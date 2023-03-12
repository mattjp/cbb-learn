using CsvHelper.Configuration.Attributes;

namespace AwayScoreModel.ConsoleApp
{
    public class GameStatsDocument
    {
        [Name(@"home")]
        public float Home { get; set; }

        [Name(@"away")]
        public float Away { get; set; }

        [Name(@"homePoints")]
        public float HomePoints { get; set; }

        [Name(@"awayPoints")]
        public float AwayPoints { get; set; }

        [Name(@"homeBlocks")]
        public float HomeBlocks { get; set; }

        [Name(@"homeDefensiveRebounds")]
        public float HomeDefensiveRebounds { get; set; }

        [Name(@"homeSteals")]
        public float HomeSteals { get; set; }

        [Name(@"homeTurnoverPoints")]
        public float HomeTurnoverPoints { get; set; }

        [Name(@"homeDisqualifications")]
        public float HomeDisqualifications { get; set; }

        [Name(@"homeFlagrantFouls")]
        public float HomeFlagrantFouls { get; set; }

        [Name(@"homeFouls")]
        public float HomeFouls { get; set; }

        [Name(@"homeEjections")]
        public float HomeEjections { get; set; }

        [Name(@"homeTechnicalFouls")]
        public float HomeTechnicalFouls { get; set; }

        [Name(@"homeRebounds")]
        public float HomeRebounds { get; set; }

        [Name(@"homeAssistTurnoverRatio")]
        public float HomeAssistTurnoverRatio { get; set; }

        [Name(@"homeStealFoulRatio")]
        public float HomeStealFoulRatio { get; set; }

        [Name(@"homeBlockFoulRatio")]
        public float HomeBlockFoulRatio { get; set; }

        [Name(@"homeTeamAssistTurnoverRatio")]
        public float HomeTeamAssistTurnoverRatio { get; set; }

        [Name(@"homeStealTurnoverRatio")]
        public float HomeStealTurnoverRatio { get; set; }

        [Name(@"homeGamesPlayed")]
        public float HomeGamesPlayed { get; set; }

        [Name(@"homeGamesStarted")]
        public float HomeGamesStarted { get; set; }

        [Name(@"homeDoubleDouble")]
        public float HomeDoubleDouble { get; set; }

        [Name(@"homeTripleDouble")]
        public float HomeTripleDouble { get; set; }

        [Name(@"homeAssists")]
        public float HomeAssists { get; set; }

        [Name(@"homeFieldGoals")]
        public float HomeFieldGoals { get; set; }

        [Name(@"homeFieldGoalsAttempted")]
        public float HomeFieldGoalsAttempted { get; set; }

        [Name(@"homeFieldGoalsMade")]
        public float HomeFieldGoalsMade { get; set; }

        [Name(@"homeFieldGoalPct")]
        public float HomeFieldGoalPct { get; set; }

        [Name(@"homeFreeThrows")]
        public float HomeFreeThrows { get; set; }

        [Name(@"homeFreeThrowPct")]
        public float HomeFreeThrowPct { get; set; }

        [Name(@"homeFreeThrowsAttempted")]
        public float HomeFreeThrowsAttempted { get; set; }

        [Name(@"homeFreeThrowsMade")]
        public float HomeFreeThrowsMade { get; set; }

        [Name(@"homeOffensiveRebounds")]
        public float HomeOffensiveRebounds { get; set; }

        [Name(@"homeTurnovers")]
        public float HomeTurnovers { get; set; }

        [Name(@"homeThreePointFieldGoalsAttempted")]
        public float HomeThreePointFieldGoalsAttempted { get; set; }

        [Name(@"homeThreePointFieldGoalsMade")]
        public float HomeThreePointFieldGoalsMade { get; set; }

        [Name(@"homeTeamTurnovers")]
        public float HomeTeamTurnovers { get; set; }

        [Name(@"homePointsInPaint")]
        public float HomePointsInPaint { get; set; }

        [Name(@"homeFastBreakPoints")]
        public float HomeFastBreakPoints { get; set; }

        [Name(@"homeOffensiveReboundPct")]
        public float HomeOffensiveReboundPct { get; set; }

        [Name(@"homeEstimatedPossessions")]
        public float HomeEstimatedPossessions { get; set; }

        [Name(@"homePointsPerEstimatedPossessions")]
        public float HomePointsPerEstimatedPossessions { get; set; }

        [Name(@"homeThreePointFieldGoalPct")]
        public float HomeThreePointFieldGoalPct { get; set; }

        [Name(@"homeTwoPointFieldGoalsMade")]
        public float HomeTwoPointFieldGoalsMade { get; set; }

        [Name(@"homeTwoPointFieldGoalsAttempted")]
        public float HomeTwoPointFieldGoalsAttempted { get; set; }

        [Name(@"homeTwoPointFieldGoalPct")]
        public float HomeTwoPointFieldGoalPct { get; set; }

        [Name(@"homeShootingEfficiency")]
        public float HomeShootingEfficiency { get; set; }

        [Name(@"homeScoringEfficiency")]
        public float HomeScoringEfficiency { get; set; }

        [Name(@"homeLargestLead")]
        public float HomeLargestLead { get; set; }

        [Name(@"awayBlocks")]
        public float AwayBlocks { get; set; }

        [Name(@"awayDefensiveRebounds")]
        public float AwayDefensiveRebounds { get; set; }

        [Name(@"awaySteals")]
        public float AwaySteals { get; set; }

        [Name(@"awayTurnoverPoints")]
        public float AwayTurnoverPoints { get; set; }

        [Name(@"awayDisqualifications")]
        public float AwayDisqualifications { get; set; }

        [Name(@"awayFlagrantFouls")]
        public float AwayFlagrantFouls { get; set; }

        [Name(@"awayFouls")]
        public float AwayFouls { get; set; }

        [Name(@"awayEjections")]
        public float AwayEjections { get; set; }

        [Name(@"awayTechnicalFouls")]
        public float AwayTechnicalFouls { get; set; }

        [Name(@"awayRebounds")]
        public float AwayRebounds { get; set; }

        [Name(@"awayAssistTurnoverRatio")]
        public float AwayAssistTurnoverRatio { get; set; }

        [Name(@"awayStealFoulRatio")]
        public float AwayStealFoulRatio { get; set; }

        [Name(@"awayBlockFoulRatio")]
        public float AwayBlockFoulRatio { get; set; }

        [Name(@"awayTeamAssistTurnoverRatio")]
        public float AwayTeamAssistTurnoverRatio { get; set; }

        [Name(@"awayStealTurnoverRatio")]
        public float AwayStealTurnoverRatio { get; set; }

        [Name(@"awayGamesPlayed")]
        public float AwayGamesPlayed { get; set; }

        [Name(@"awayGamesStarted")]
        public float AwayGamesStarted { get; set; }

        [Name(@"awayDoubleDouble")]
        public float AwayDoubleDouble { get; set; }

        [Name(@"awayTripleDouble")]
        public float AwayTripleDouble { get; set; }

        [Name(@"awayAssists")]
        public float AwayAssists { get; set; }

        [Name(@"awayFieldGoals")]
        public float AwayFieldGoals { get; set; }

        [Name(@"awayFieldGoalsAttempted")]
        public float AwayFieldGoalsAttempted { get; set; }

        [Name(@"awayFieldGoalsMade")]
        public float AwayFieldGoalsMade { get; set; }

        [Name(@"awayFieldGoalPct")]
        public float AwayFieldGoalPct { get; set; }

        [Name(@"awayFreeThrows")]
        public float AwayFreeThrows { get; set; }

        [Name(@"awayFreeThrowPct")]
        public float AwayFreeThrowPct { get; set; }

        [Name(@"awayFreeThrowsAttempted")]
        public float AwayFreeThrowsAttempted { get; set; }

        [Name(@"awayFreeThrowsMade")]
        public float AwayFreeThrowsMade { get; set; }

        [Name(@"awayOffensiveRebounds")]
        public float AwayOffensiveRebounds { get; set; }

        [Name(@"awayTurnovers")]
        public float AwayTurnovers { get; set; }

        [Name(@"awayThreePointFieldGoalsAttempted")]
        public float AwayThreePointFieldGoalsAttempted { get; set; }

        [Name(@"awayThreePointFieldGoalsMade")]
        public float AwayThreePointFieldGoalsMade { get; set; }

        [Name(@"awayTeamTurnovers")]
        public float AwayTeamTurnovers { get; set; }

        [Name(@"awayPointsInPaint")]
        public float AwayPointsInPaint { get; set; }

        [Name(@"awayFastBreakPoints")]
        public float AwayFastBreakPoints { get; set; }

        [Name(@"awayOffensiveReboundPct")]
        public float AwayOffensiveReboundPct { get; set; }

        [Name(@"awayEstimatedPossessions")]
        public float AwayEstimatedPossessions { get; set; }

        [Name(@"awayPointsPerEstimatedPossessions")]
        public float AwayPointsPerEstimatedPossessions { get; set; }

        [Name(@"awayThreePointFieldGoalPct")]
        public float AwayThreePointFieldGoalPct { get; set; }

        [Name(@"awayTwoPointFieldGoalsMade")]
        public float AwayTwoPointFieldGoalsMade { get; set; }

        [Name(@"awayTwoPointFieldGoalsAttempted")]
        public float AwayTwoPointFieldGoalsAttempted { get; set; }

        [Name(@"awayTwoPointFieldGoalPct")]
        public float AwayTwoPointFieldGoalPct { get; set; }

        [Name(@"awayShootingEfficiency")]
        public float AwayShootingEfficiency { get; set; }

        [Name(@"awayScoringEfficiency")]
        public float AwayScoringEfficiency { get; set; }

        [Name(@"awayLargestLead")]
        public float AwayLargestLead { get; set; }
    }
}
