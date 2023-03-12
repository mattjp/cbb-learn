using CsvHelper.Configuration.Attributes;

namespace cbb_learn.src.Stats.Models;

public class StatsDocument
{
    [Name("id")]
    public string Id { get; set; } = string.Empty;
    [Name("home")]
    public string Home { get; set; } = string.Empty;
    [Name("away")]
    public string Away { get; set; } = string.Empty;

    public Dictionary<string, double> Stats { get; set; } = new Dictionary<string, double>();

    public static List<string> GetColumns()
    {
        return new List<string>
        {
            "homePoints",
            "awayPoints",
            "homeBlocks",
            "homeDefensiveRebounds",
            "homeSteals",
            "homeTurnoverPoints",
            "homeDisqualifications",
            "homeFlagrantFouls",
            "homeFouls",
            "homeEjections",
            "homeTechnicalFouls",
            "homeRebounds",
            "homeAssistTurnoverRatio",
            "homeStealFoulRatio",
            "homeBlockFoulRatio",
            "homeTeamAssistTurnoverRatio",
            "homeStealTurnoverRatio",
            "homeGamesPlayed",
            "homeGamesStarted",
            "homeDoubleDouble",
            "homeTripleDouble",
            "homeAssists",
            "homeFieldGoals",
            "homeFieldGoalsAttempted",
            "homeFieldGoalsMade",
            "homeFieldGoalPct",
            "homeFreeThrows",
            "homeFreeThrowPct",
            "homeFreeThrowsAttempted",
            "homeFreeThrowsMade",
            "homeOffensiveRebounds",
            "homeTurnovers",
            "homeThreePointFieldGoalsAttempted",
            "homeThreePointFieldGoalsMade",
            "homeTeamTurnovers",
            "homePointsInPaint",
            "homeFastBreakPoints",
            "homeOffensiveReboundPct",
            "homeEstimatedPossessions",
            "homePointsPerEstimatedPossessions",
            "homeThreePointFieldGoalPct",
            "homeTwoPointFieldGoalsMade",
            "homeTwoPointFieldGoalsAttempted",
            "homeTwoPointFieldGoalPct",
            "homeShootingEfficiency",
            "homeScoringEfficiency",
            "homeLargestLead",
            "awayBlocks",
            "awayDefensiveRebounds",
            "awaySteals",
            "awayTurnoverPoints",
            "awayDisqualifications",
            "awayFlagrantFouls",
            "awayFouls",
            "awayEjections",
            "awayTechnicalFouls",
            "awayRebounds",
            "awayAssistTurnoverRatio",
            "awayStealFoulRatio",
            "awayBlockFoulRatio",
            "awayTeamAssistTurnoverRatio",
            "awayStealTurnoverRatio",
            "awayGamesPlayed",
            "awayGamesStarted",
            "awayDoubleDouble",
            "awayTripleDouble",
            "awayAssists",
            "awayFieldGoals",
            "awayFieldGoalsAttempted",
            "awayFieldGoalsMade",
            "awayFieldGoalPct",
            "awayFreeThrows",
            "awayFreeThrowPct",
            "awayFreeThrowsAttempted",
            "awayFreeThrowsMade",
            "awayOffensiveRebounds",
            "awayTurnovers",
            "awayThreePointFieldGoalsAttempted",
            "awayThreePointFieldGoalsMade",
            "awayTeamTurnovers",
            "awayPointsInPaint",
            "awayFastBreakPoints",
            "awayOffensiveReboundPct",
            "awayEstimatedPossessions",
            "awayPointsPerEstimatedPossessions",
            "awayThreePointFieldGoalPct",
            "awayTwoPointFieldGoalsMade",
            "awayTwoPointFieldGoalsAttempted",
            "awayTwoPointFieldGoalPct",
            "awayShootingEfficiency",
            "awayScoringEfficiency",
            "awayLargestLead"
        };
    }

    public StatsDocument(string id, string home, string away)
    {
        Id = id;
        Home = home;
        Away = away;
    }
}
