using cbb_learn.src.Stats.Models;
using Newtonsoft.Json;
using CsvHelper;
using System.Globalization;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayScoreModel.ConsoleApp
{
    public class SeasonStatsService
    {
        private static readonly HttpClient client = new HttpClient();
        private const float HomePointsAdvantage = 1.85F;

        public SeasonStatsService() { }

        public async Task<Dictionary<string, Dictionary<string, float>>> GetSeasonStats(string teamA, string teamB)
        {
            Console.WriteLine($"Fetching season stats for teamA={teamA}, teamB={teamB}...\n");

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;

            var result = new Dictionary<string, Dictionary<string, float>>();

            foreach (var teamId in new List<string> { teamA, teamB })
            {
                try
                {
                    string url = $"http://sports.core.api.espn.com/v2/sports/basketball/leagues/mens-college-basketball/seasons/2022/types/0/teams/{teamId}/statistics?lang=en&region=us";
                    string response = await client.GetStringAsync(url);

                    var statsResponse = JsonConvert.DeserializeObject<StatsResponse>(response, settings);

                    var statsDict = new Dictionary<string, float>();

                    foreach (var cat in statsResponse.Splits.Categories)
                    {
                        foreach (var s in cat.Stats.Where(c =>
                            !c.Name.StartsWith("avg")
                            && !c.Name.StartsWith("total")
                            && c.Name != "largestLead"
                            && c.Name != "turnoverPoints"
                            && c.Name != "pointsInPaint"
                            && c.Name != "fastBreakPoints"
                            && c.Name != "fantasyRating"))
                        {
                            string k = string.Concat(s.Name[0].ToString().ToUpper(), s.Name.AsSpan(1));
                            float v = (float)s.Value;

                            statsDict.Add(k, v);
                        }
                    }

                    // Aggregate season stats not present in the API response.
                    var stats = new List<GameStatsDocument>();

                    using (var reader = new StreamReader("src/Data/stats_v2.csv"))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        stats = csv.GetRecords<GameStatsDocument>().ToList();
                    }

                    // Turnover points
                    float homeTurnoverPoints = stats
                        .Where(doc => doc.Home.ToString() == teamId)
                        .Aggregate(0F, (count, doc) => count + doc.HomeTurnoverPoints);
                    float totalTurnoverPoints = stats
                        .Where(doc => doc.Away.ToString() == teamId)
                        .Aggregate(homeTurnoverPoints, (count, doc) => count + doc.AwayTurnoverPoints);
                    statsDict.Add("TurnoverPoints", totalTurnoverPoints);

                    // Points in paint
                    float homePointsInPaint = stats
                        .Where(doc => doc.Home.ToString() == teamId)
                        .Aggregate(0F, (count, doc) => count + doc.HomePointsInPaint);
                    float totalPointsInPaint = stats
                        .Where(doc => doc.Away.ToString() == teamId)
                        .Aggregate(homePointsInPaint, (count, doc) => count + doc.AwayPointsInPaint);
                    statsDict.Add("PointsInPaint", totalPointsInPaint);

                    // Fast break points
                    float homeFastBreakPoints = stats
                        .Where(doc => doc.Home.ToString() == teamId)
                        .Aggregate(0F, (count, doc) => count + doc.HomeFastBreakPoints);
                    float totalFastBreakPoints = stats
                        .Where(doc => doc.Away.ToString() == teamId)
                        .Aggregate(homeFastBreakPoints, (count, doc) => count + doc.AwayFastBreakPoints);
                    statsDict.Add("FastBreakPoints", totalFastBreakPoints);

                    // Largest lead
                    float homeLargestLead = stats
                        .Where(doc => doc.Home.ToString() == teamId)
                        .Aggregate(0F, (count, doc) => count + doc.HomeLargestLead);
                    float totalLargestLead = stats
                        .Where(doc => doc.Away.ToString() == teamId)
                        .Aggregate(homeLargestLead, (count, doc) => count + doc.AwayLargestLead);
                    statsDict.Add("LargestLead", totalLargestLead);

                    string key = teamId == teamA ? "A" : "B";
                    result.Add(key, statsDict);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Encountered exception={ex.Message}");
                    throw;
                }
            }

            return result;
        }

        public AwayScoreModel.ModelInput GetModelInput(Dictionary<string, float> homeStats, Dictionary<string, float> awayStats)
        {
            float homeGamesPlayed = homeStats["GamesPlayed"];
            float awayGamesPlayed = awayStats["GamesPlayed"];

            return new AwayScoreModel.ModelInput()
            {
                HomePoints = (homeStats["Points"] / homeGamesPlayed) + HomePointsAdvantage,
                HomeBlocks = homeStats["Blocks"] / homeGamesPlayed,
                HomeDefensiveRebounds = homeStats["DefensiveRebounds"] / homeGamesPlayed,
                HomeSteals = homeStats["Steals"] / homeGamesPlayed,
                HomeTurnoverPoints = homeStats["TurnoverPoints"] / homeGamesPlayed,
                HomeDisqualifications = homeStats["Disqualifications"] / homeGamesPlayed,
                HomeFlagrantFouls = homeStats["FlagrantFouls"] / homeGamesPlayed,
                HomeFouls = homeStats["Fouls"] / homeGamesPlayed,
                HomeEjections = homeStats["Ejections"] / homeGamesPlayed,
                HomeTechnicalFouls = homeStats["TechnicalFouls"] / homeGamesPlayed,
                HomeRebounds = homeStats["Rebounds"] / homeGamesPlayed,
                HomeAssistTurnoverRatio = homeStats["AssistTurnoverRatio"],
                HomeStealFoulRatio = homeStats["StealFoulRatio"],
                HomeBlockFoulRatio = homeStats["BlockFoulRatio"],
                HomeTeamAssistTurnoverRatio = homeStats["TeamAssistTurnoverRatio"],
                HomeStealTurnoverRatio = homeStats["StealTurnoverRatio"],
                HomeGamesPlayed = 1F,
                HomeGamesStarted = 0F,
                HomeDoubleDouble = homeStats["DoubleDouble"] / homeGamesPlayed,
                HomeTripleDouble = homeStats["TripleDouble"] / homeGamesPlayed,
                HomeAssists = homeStats["Assists"] / homeGamesPlayed,
                HomeFieldGoals = homeStats["FieldGoals"],
                HomeFieldGoalsAttempted = homeStats["FieldGoalsAttempted"] / homeGamesPlayed,
                HomeFieldGoalsMade = homeStats["FieldGoalsMade"] / homeGamesPlayed,
                HomeFieldGoalPct = homeStats["FieldGoalPct"],
                HomeFreeThrows = homeStats["FreeThrows"],
                HomeFreeThrowPct = homeStats["FreeThrowPct"],
                HomeFreeThrowsAttempted = homeStats["FreeThrowsAttempted"] / homeGamesPlayed,
                HomeFreeThrowsMade = homeStats["FreeThrowsMade"] / homeGamesPlayed,
                HomeOffensiveRebounds = homeStats["OffensiveRebounds"] / homeGamesPlayed,
                HomeTurnovers = homeStats["Turnovers"] / homeGamesPlayed,
                HomeThreePointFieldGoalsAttempted = homeStats["ThreePointFieldGoalsAttempted"] / homeGamesPlayed,
                HomeThreePointFieldGoalsMade = homeStats["ThreePointFieldGoalsMade"] / homeGamesPlayed,
                HomeTeamTurnovers = homeStats["TeamTurnovers"] / homeGamesPlayed,
                HomePointsInPaint = homeStats["PointsInPaint"] / homeGamesPlayed,
                HomeFastBreakPoints = homeStats["FastBreakPoints"] / homeGamesPlayed,
                HomeOffensiveReboundPct = homeStats["OffensiveReboundPct"],
                HomeEstimatedPossessions = homeStats["EstimatedPossessions"] / homeGamesPlayed,
                HomePointsPerEstimatedPossessions = homeStats["PointsPerEstimatedPossessions"],
                HomeThreePointFieldGoalPct = homeStats["ThreePointFieldGoalPct"],
                HomeTwoPointFieldGoalsMade = homeStats["TwoPointFieldGoalsMade"] / homeGamesPlayed,
                HomeTwoPointFieldGoalsAttempted = homeStats["TwoPointFieldGoalsAttempted"] / homeGamesPlayed,
                HomeTwoPointFieldGoalPct = homeStats["TwoPointFieldGoalPct"],
                HomeShootingEfficiency = homeStats["ShootingEfficiency"],
                HomeScoringEfficiency = homeStats["ScoringEfficiency"],
                AwayBlocks = awayStats["Blocks"] / awayGamesPlayed,
                AwayDefensiveRebounds = awayStats["DefensiveRebounds"] / awayGamesPlayed,
                AwaySteals = awayStats["Steals"] / awayGamesPlayed,
                AwayTurnoverPoints = awayStats["TurnoverPoints"] / awayGamesPlayed,
                AwayDisqualifications = awayStats["Disqualifications"] / awayGamesPlayed,
                AwayFlagrantFouls = awayStats["FlagrantFouls"] / awayGamesPlayed,
                AwayFouls = awayStats["Fouls"] / awayGamesPlayed,
                AwayEjections = awayStats["Ejections"] / awayGamesPlayed,
                AwayTechnicalFouls = awayStats["TechnicalFouls"] / awayGamesPlayed,
                AwayRebounds = awayStats["Rebounds"] / awayGamesPlayed,
                AwayAssistTurnoverRatio = awayStats["AssistTurnoverRatio"],
                AwayStealFoulRatio = awayStats["StealFoulRatio"],
                AwayBlockFoulRatio = awayStats["BlockFoulRatio"],
                AwayTeamAssistTurnoverRatio = awayStats["TeamAssistTurnoverRatio"],
                AwayStealTurnoverRatio = awayStats["StealTurnoverRatio"],
                AwayGamesPlayed = 1F,
                AwayGamesStarted = 0F,
                AwayDoubleDouble = awayStats["DoubleDouble"] / awayGamesPlayed,
                AwayTripleDouble = awayStats["TripleDouble"] / awayGamesPlayed,
                AwayAssists = awayStats["Assists"] / awayGamesPlayed,
                AwayFieldGoals = awayStats["FieldGoals"],
                AwayFieldGoalsAttempted = awayStats["FieldGoalsAttempted"] / awayGamesPlayed,
                AwayFieldGoalsMade = awayStats["FieldGoalsMade"] / awayGamesPlayed,
                AwayFieldGoalPct = awayStats["FieldGoalPct"],
                AwayFreeThrows = awayStats["FreeThrows"],
                AwayFreeThrowPct = awayStats["FreeThrowPct"],
                AwayFreeThrowsAttempted = awayStats["FreeThrowsAttempted"] / awayGamesPlayed,
                AwayFreeThrowsMade = awayStats["FreeThrowsMade"] / awayGamesPlayed,
                AwayOffensiveRebounds = awayStats["OffensiveRebounds"] / awayGamesPlayed,
                AwayTurnovers = awayStats["Turnovers"] / awayGamesPlayed,
                AwayThreePointFieldGoalsAttempted = awayStats["ThreePointFieldGoalsAttempted"] / awayGamesPlayed,
                AwayThreePointFieldGoalsMade = awayStats["ThreePointFieldGoalsMade"] / awayGamesPlayed,
                AwayTeamTurnovers = awayStats["TeamTurnovers"] / awayGamesPlayed,
                AwayPointsInPaint = awayStats["PointsInPaint"] / awayGamesPlayed,
                AwayFastBreakPoints = awayStats["FastBreakPoints"] / awayGamesPlayed,
                AwayOffensiveReboundPct = awayStats["OffensiveReboundPct"],
                AwayEstimatedPossessions = awayStats["EstimatedPossessions"] / awayGamesPlayed,
                AwayPointsPerEstimatedPossessions = awayStats["PointsPerEstimatedPossessions"],
                AwayThreePointFieldGoalPct = awayStats["ThreePointFieldGoalPct"],
                AwayTwoPointFieldGoalsMade = awayStats["TwoPointFieldGoalsMade"] / awayGamesPlayed,
                AwayTwoPointFieldGoalsAttempted = awayStats["TwoPointFieldGoalsAttempted"] / awayGamesPlayed,
                AwayTwoPointFieldGoalPct = awayStats["TwoPointFieldGoalPct"],
                AwayShootingEfficiency = awayStats["ShootingEfficiency"],
                AwayScoringEfficiency = awayStats["ScoringEfficiency"],
            };
        }
    }
}
