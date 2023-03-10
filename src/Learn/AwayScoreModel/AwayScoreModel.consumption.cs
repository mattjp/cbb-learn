// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace AwayScoreModel.ConsoleApp
{
    public partial class AwayScoreModel
    {
        /// <summary>
        /// model input class for AwayScoreModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"home")]
            public float Home { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"away")]
            public float Away { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"homePoints")]
            public float HomePoints { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"awayPoints")]
            public float AwayPoints { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"homeBlocks")]
            public float HomeBlocks { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"homeDefensiveRebounds")]
            public float HomeDefensiveRebounds { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"homeSteals")]
            public float HomeSteals { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"homeTurnoverPoints")]
            public float HomeTurnoverPoints { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"homeDisqualifications")]
            public float HomeDisqualifications { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"homeFlagrantFouls")]
            public float HomeFlagrantFouls { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"homeFouls")]
            public float HomeFouls { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"homeEjections")]
            public float HomeEjections { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"homeTechnicalFouls")]
            public float HomeTechnicalFouls { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"homeRebounds")]
            public float HomeRebounds { get; set; }

            [LoadColumn(14)]
            [ColumnName(@"homeAssistTurnoverRatio")]
            public float HomeAssistTurnoverRatio { get; set; }

            [LoadColumn(15)]
            [ColumnName(@"homeStealFoulRatio")]
            public float HomeStealFoulRatio { get; set; }

            [LoadColumn(16)]
            [ColumnName(@"homeBlockFoulRatio")]
            public float HomeBlockFoulRatio { get; set; }

            [LoadColumn(17)]
            [ColumnName(@"homeTeamAssistTurnoverRatio")]
            public float HomeTeamAssistTurnoverRatio { get; set; }

            [LoadColumn(18)]
            [ColumnName(@"homeStealTurnoverRatio")]
            public float HomeStealTurnoverRatio { get; set; }

            [LoadColumn(19)]
            [ColumnName(@"homeGamesPlayed")]
            public float HomeGamesPlayed { get; set; }

            [LoadColumn(20)]
            [ColumnName(@"homeGamesStarted")]
            public float HomeGamesStarted { get; set; }

            [LoadColumn(21)]
            [ColumnName(@"homeDoubleDouble")]
            public float HomeDoubleDouble { get; set; }

            [LoadColumn(22)]
            [ColumnName(@"homeTripleDouble")]
            public float HomeTripleDouble { get; set; }

            [LoadColumn(23)]
            [ColumnName(@"homeAssists")]
            public float HomeAssists { get; set; }

            [LoadColumn(24)]
            [ColumnName(@"homeFieldGoals")]
            public float HomeFieldGoals { get; set; }

            [LoadColumn(25)]
            [ColumnName(@"homeFieldGoalsAttempted")]
            public float HomeFieldGoalsAttempted { get; set; }

            [LoadColumn(26)]
            [ColumnName(@"homeFieldGoalsMade")]
            public float HomeFieldGoalsMade { get; set; }

            [LoadColumn(27)]
            [ColumnName(@"homeFieldGoalPct")]
            public float HomeFieldGoalPct { get; set; }

            [LoadColumn(28)]
            [ColumnName(@"homeFreeThrows")]
            public float HomeFreeThrows { get; set; }

            [LoadColumn(29)]
            [ColumnName(@"homeFreeThrowPct")]
            public float HomeFreeThrowPct { get; set; }

            [LoadColumn(30)]
            [ColumnName(@"homeFreeThrowsAttempted")]
            public float HomeFreeThrowsAttempted { get; set; }

            [LoadColumn(31)]
            [ColumnName(@"homeFreeThrowsMade")]
            public float HomeFreeThrowsMade { get; set; }

            [LoadColumn(32)]
            [ColumnName(@"homeOffensiveRebounds")]
            public float HomeOffensiveRebounds { get; set; }

            [LoadColumn(33)]
            [ColumnName(@"homeTurnovers")]
            public float HomeTurnovers { get; set; }

            [LoadColumn(34)]
            [ColumnName(@"homeThreePointFieldGoalsAttempted")]
            public float HomeThreePointFieldGoalsAttempted { get; set; }

            [LoadColumn(35)]
            [ColumnName(@"homeThreePointFieldGoalsMade")]
            public float HomeThreePointFieldGoalsMade { get; set; }

            [LoadColumn(36)]
            [ColumnName(@"homeTeamTurnovers")]
            public float HomeTeamTurnovers { get; set; }

            [LoadColumn(37)]
            [ColumnName(@"homePointsInPaint")]
            public float HomePointsInPaint { get; set; }

            [LoadColumn(38)]
            [ColumnName(@"homeFastBreakPoints")]
            public float HomeFastBreakPoints { get; set; }

            [LoadColumn(39)]
            [ColumnName(@"homeOffensiveReboundPct")]
            public float HomeOffensiveReboundPct { get; set; }

            [LoadColumn(40)]
            [ColumnName(@"homeEstimatedPossessions")]
            public float HomeEstimatedPossessions { get; set; }

            [LoadColumn(41)]
            [ColumnName(@"homePointsPerEstimatedPossessions")]
            public float HomePointsPerEstimatedPossessions { get; set; }

            [LoadColumn(42)]
            [ColumnName(@"homeThreePointFieldGoalPct")]
            public float HomeThreePointFieldGoalPct { get; set; }

            [LoadColumn(43)]
            [ColumnName(@"homeTwoPointFieldGoalsMade")]
            public float HomeTwoPointFieldGoalsMade { get; set; }

            [LoadColumn(44)]
            [ColumnName(@"homeTwoPointFieldGoalsAttempted")]
            public float HomeTwoPointFieldGoalsAttempted { get; set; }

            [LoadColumn(45)]
            [ColumnName(@"homeTwoPointFieldGoalPct")]
            public float HomeTwoPointFieldGoalPct { get; set; }

            [LoadColumn(46)]
            [ColumnName(@"homeShootingEfficiency")]
            public float HomeShootingEfficiency { get; set; }

            [LoadColumn(47)]
            [ColumnName(@"homeScoringEfficiency")]
            public float HomeScoringEfficiency { get; set; }

            [LoadColumn(48)]
            [ColumnName(@"homeLargestLead")]
            public float HomeLargestLead { get; set; }

            [LoadColumn(49)]
            [ColumnName(@"awayBlocks")]
            public float AwayBlocks { get; set; }

            [LoadColumn(50)]
            [ColumnName(@"awayDefensiveRebounds")]
            public float AwayDefensiveRebounds { get; set; }

            [LoadColumn(51)]
            [ColumnName(@"awaySteals")]
            public float AwaySteals { get; set; }

            [LoadColumn(52)]
            [ColumnName(@"awayTurnoverPoints")]
            public float AwayTurnoverPoints { get; set; }

            [LoadColumn(53)]
            [ColumnName(@"awayDisqualifications")]
            public float AwayDisqualifications { get; set; }

            [LoadColumn(54)]
            [ColumnName(@"awayFlagrantFouls")]
            public float AwayFlagrantFouls { get; set; }

            [LoadColumn(55)]
            [ColumnName(@"awayFouls")]
            public float AwayFouls { get; set; }

            [LoadColumn(56)]
            [ColumnName(@"awayEjections")]
            public float AwayEjections { get; set; }

            [LoadColumn(57)]
            [ColumnName(@"awayTechnicalFouls")]
            public float AwayTechnicalFouls { get; set; }

            [LoadColumn(58)]
            [ColumnName(@"awayRebounds")]
            public float AwayRebounds { get; set; }

            [LoadColumn(59)]
            [ColumnName(@"awayAssistTurnoverRatio")]
            public float AwayAssistTurnoverRatio { get; set; }

            [LoadColumn(60)]
            [ColumnName(@"awayStealFoulRatio")]
            public float AwayStealFoulRatio { get; set; }

            [LoadColumn(61)]
            [ColumnName(@"awayBlockFoulRatio")]
            public float AwayBlockFoulRatio { get; set; }

            [LoadColumn(62)]
            [ColumnName(@"awayTeamAssistTurnoverRatio")]
            public float AwayTeamAssistTurnoverRatio { get; set; }

            [LoadColumn(63)]
            [ColumnName(@"awayStealTurnoverRatio")]
            public float AwayStealTurnoverRatio { get; set; }

            [LoadColumn(64)]
            [ColumnName(@"awayGamesPlayed")]
            public float AwayGamesPlayed { get; set; }

            [LoadColumn(65)]
            [ColumnName(@"awayGamesStarted")]
            public float AwayGamesStarted { get; set; }

            [LoadColumn(66)]
            [ColumnName(@"awayDoubleDouble")]
            public float AwayDoubleDouble { get; set; }

            [LoadColumn(67)]
            [ColumnName(@"awayTripleDouble")]
            public float AwayTripleDouble { get; set; }

            [LoadColumn(68)]
            [ColumnName(@"awayAssists")]
            public float AwayAssists { get; set; }

            [LoadColumn(69)]
            [ColumnName(@"awayFieldGoals")]
            public float AwayFieldGoals { get; set; }

            [LoadColumn(70)]
            [ColumnName(@"awayFieldGoalsAttempted")]
            public float AwayFieldGoalsAttempted { get; set; }

            [LoadColumn(71)]
            [ColumnName(@"awayFieldGoalsMade")]
            public float AwayFieldGoalsMade { get; set; }

            [LoadColumn(72)]
            [ColumnName(@"awayFieldGoalPct")]
            public float AwayFieldGoalPct { get; set; }

            [LoadColumn(73)]
            [ColumnName(@"awayFreeThrows")]
            public float AwayFreeThrows { get; set; }

            [LoadColumn(74)]
            [ColumnName(@"awayFreeThrowPct")]
            public float AwayFreeThrowPct { get; set; }

            [LoadColumn(75)]
            [ColumnName(@"awayFreeThrowsAttempted")]
            public float AwayFreeThrowsAttempted { get; set; }

            [LoadColumn(76)]
            [ColumnName(@"awayFreeThrowsMade")]
            public float AwayFreeThrowsMade { get; set; }

            [LoadColumn(77)]
            [ColumnName(@"awayOffensiveRebounds")]
            public float AwayOffensiveRebounds { get; set; }

            [LoadColumn(78)]
            [ColumnName(@"awayTurnovers")]
            public float AwayTurnovers { get; set; }

            [LoadColumn(79)]
            [ColumnName(@"awayThreePointFieldGoalsAttempted")]
            public float AwayThreePointFieldGoalsAttempted { get; set; }

            [LoadColumn(80)]
            [ColumnName(@"awayThreePointFieldGoalsMade")]
            public float AwayThreePointFieldGoalsMade { get; set; }

            [LoadColumn(81)]
            [ColumnName(@"awayTeamTurnovers")]
            public float AwayTeamTurnovers { get; set; }

            [LoadColumn(82)]
            [ColumnName(@"awayPointsInPaint")]
            public float AwayPointsInPaint { get; set; }

            [LoadColumn(83)]
            [ColumnName(@"awayFastBreakPoints")]
            public float AwayFastBreakPoints { get; set; }

            [LoadColumn(84)]
            [ColumnName(@"awayOffensiveReboundPct")]
            public float AwayOffensiveReboundPct { get; set; }

            [LoadColumn(85)]
            [ColumnName(@"awayEstimatedPossessions")]
            public float AwayEstimatedPossessions { get; set; }

            [LoadColumn(86)]
            [ColumnName(@"awayPointsPerEstimatedPossessions")]
            public float AwayPointsPerEstimatedPossessions { get; set; }

            [LoadColumn(87)]
            [ColumnName(@"awayThreePointFieldGoalPct")]
            public float AwayThreePointFieldGoalPct { get; set; }

            [LoadColumn(88)]
            [ColumnName(@"awayTwoPointFieldGoalsMade")]
            public float AwayTwoPointFieldGoalsMade { get; set; }

            [LoadColumn(89)]
            [ColumnName(@"awayTwoPointFieldGoalsAttempted")]
            public float AwayTwoPointFieldGoalsAttempted { get; set; }

            [LoadColumn(90)]
            [ColumnName(@"awayTwoPointFieldGoalPct")]
            public float AwayTwoPointFieldGoalPct { get; set; }

            [LoadColumn(91)]
            [ColumnName(@"awayShootingEfficiency")]
            public float AwayShootingEfficiency { get; set; }

            [LoadColumn(92)]
            [ColumnName(@"awayScoringEfficiency")]
            public float AwayScoringEfficiency { get; set; }

            [LoadColumn(93)]
            [ColumnName(@"awayLargestLead")]
            public float AwayLargestLead { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for AwayScoreModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"home")]
            public float Home { get; set; }

            [ColumnName(@"away")]
            public float Away { get; set; }

            [ColumnName(@"homePoints")]
            public float HomePoints { get; set; }

            [ColumnName(@"awayPoints")]
            public float AwayPoints { get; set; }

            [ColumnName(@"homeBlocks")]
            public float HomeBlocks { get; set; }

            [ColumnName(@"homeDefensiveRebounds")]
            public float HomeDefensiveRebounds { get; set; }

            [ColumnName(@"homeSteals")]
            public float HomeSteals { get; set; }

            [ColumnName(@"homeTurnoverPoints")]
            public float HomeTurnoverPoints { get; set; }

            [ColumnName(@"homeDisqualifications")]
            public float HomeDisqualifications { get; set; }

            [ColumnName(@"homeFlagrantFouls")]
            public float HomeFlagrantFouls { get; set; }

            [ColumnName(@"homeFouls")]
            public float HomeFouls { get; set; }

            [ColumnName(@"homeEjections")]
            public float HomeEjections { get; set; }

            [ColumnName(@"homeTechnicalFouls")]
            public float HomeTechnicalFouls { get; set; }

            [ColumnName(@"homeRebounds")]
            public float HomeRebounds { get; set; }

            [ColumnName(@"homeAssistTurnoverRatio")]
            public float HomeAssistTurnoverRatio { get; set; }

            [ColumnName(@"homeStealFoulRatio")]
            public float HomeStealFoulRatio { get; set; }

            [ColumnName(@"homeBlockFoulRatio")]
            public float HomeBlockFoulRatio { get; set; }

            [ColumnName(@"homeTeamAssistTurnoverRatio")]
            public float HomeTeamAssistTurnoverRatio { get; set; }

            [ColumnName(@"homeStealTurnoverRatio")]
            public float HomeStealTurnoverRatio { get; set; }

            [ColumnName(@"homeGamesPlayed")]
            public float HomeGamesPlayed { get; set; }

            [ColumnName(@"homeGamesStarted")]
            public float HomeGamesStarted { get; set; }

            [ColumnName(@"homeDoubleDouble")]
            public float HomeDoubleDouble { get; set; }

            [ColumnName(@"homeTripleDouble")]
            public float HomeTripleDouble { get; set; }

            [ColumnName(@"homeAssists")]
            public float HomeAssists { get; set; }

            [ColumnName(@"homeFieldGoals")]
            public float HomeFieldGoals { get; set; }

            [ColumnName(@"homeFieldGoalsAttempted")]
            public float HomeFieldGoalsAttempted { get; set; }

            [ColumnName(@"homeFieldGoalsMade")]
            public float HomeFieldGoalsMade { get; set; }

            [ColumnName(@"homeFieldGoalPct")]
            public float HomeFieldGoalPct { get; set; }

            [ColumnName(@"homeFreeThrows")]
            public float HomeFreeThrows { get; set; }

            [ColumnName(@"homeFreeThrowPct")]
            public float HomeFreeThrowPct { get; set; }

            [ColumnName(@"homeFreeThrowsAttempted")]
            public float HomeFreeThrowsAttempted { get; set; }

            [ColumnName(@"homeFreeThrowsMade")]
            public float HomeFreeThrowsMade { get; set; }

            [ColumnName(@"homeOffensiveRebounds")]
            public float HomeOffensiveRebounds { get; set; }

            [ColumnName(@"homeTurnovers")]
            public float HomeTurnovers { get; set; }

            [ColumnName(@"homeThreePointFieldGoalsAttempted")]
            public float HomeThreePointFieldGoalsAttempted { get; set; }

            [ColumnName(@"homeThreePointFieldGoalsMade")]
            public float HomeThreePointFieldGoalsMade { get; set; }

            [ColumnName(@"homeTeamTurnovers")]
            public float HomeTeamTurnovers { get; set; }

            [ColumnName(@"homePointsInPaint")]
            public float HomePointsInPaint { get; set; }

            [ColumnName(@"homeFastBreakPoints")]
            public float HomeFastBreakPoints { get; set; }

            [ColumnName(@"homeOffensiveReboundPct")]
            public float HomeOffensiveReboundPct { get; set; }

            [ColumnName(@"homeEstimatedPossessions")]
            public float HomeEstimatedPossessions { get; set; }

            [ColumnName(@"homePointsPerEstimatedPossessions")]
            public float HomePointsPerEstimatedPossessions { get; set; }

            [ColumnName(@"homeThreePointFieldGoalPct")]
            public float HomeThreePointFieldGoalPct { get; set; }

            [ColumnName(@"homeTwoPointFieldGoalsMade")]
            public float HomeTwoPointFieldGoalsMade { get; set; }

            [ColumnName(@"homeTwoPointFieldGoalsAttempted")]
            public float HomeTwoPointFieldGoalsAttempted { get; set; }

            [ColumnName(@"homeTwoPointFieldGoalPct")]
            public float HomeTwoPointFieldGoalPct { get; set; }

            [ColumnName(@"homeShootingEfficiency")]
            public float HomeShootingEfficiency { get; set; }

            [ColumnName(@"homeScoringEfficiency")]
            public float HomeScoringEfficiency { get; set; }

            [ColumnName(@"homeLargestLead")]
            public float HomeLargestLead { get; set; }

            [ColumnName(@"awayBlocks")]
            public float AwayBlocks { get; set; }

            [ColumnName(@"awayDefensiveRebounds")]
            public float AwayDefensiveRebounds { get; set; }

            [ColumnName(@"awaySteals")]
            public float AwaySteals { get; set; }

            [ColumnName(@"awayTurnoverPoints")]
            public float AwayTurnoverPoints { get; set; }

            [ColumnName(@"awayDisqualifications")]
            public float AwayDisqualifications { get; set; }

            [ColumnName(@"awayFlagrantFouls")]
            public float AwayFlagrantFouls { get; set; }

            [ColumnName(@"awayFouls")]
            public float AwayFouls { get; set; }

            [ColumnName(@"awayEjections")]
            public float AwayEjections { get; set; }

            [ColumnName(@"awayTechnicalFouls")]
            public float AwayTechnicalFouls { get; set; }

            [ColumnName(@"awayRebounds")]
            public float AwayRebounds { get; set; }

            [ColumnName(@"awayAssistTurnoverRatio")]
            public float AwayAssistTurnoverRatio { get; set; }

            [ColumnName(@"awayStealFoulRatio")]
            public float AwayStealFoulRatio { get; set; }

            [ColumnName(@"awayBlockFoulRatio")]
            public float AwayBlockFoulRatio { get; set; }

            [ColumnName(@"awayTeamAssistTurnoverRatio")]
            public float AwayTeamAssistTurnoverRatio { get; set; }

            [ColumnName(@"awayStealTurnoverRatio")]
            public float AwayStealTurnoverRatio { get; set; }

            [ColumnName(@"awayGamesPlayed")]
            public float AwayGamesPlayed { get; set; }

            [ColumnName(@"awayGamesStarted")]
            public float AwayGamesStarted { get; set; }

            [ColumnName(@"awayDoubleDouble")]
            public float AwayDoubleDouble { get; set; }

            [ColumnName(@"awayTripleDouble")]
            public float AwayTripleDouble { get; set; }

            [ColumnName(@"awayAssists")]
            public float AwayAssists { get; set; }

            [ColumnName(@"awayFieldGoals")]
            public float AwayFieldGoals { get; set; }

            [ColumnName(@"awayFieldGoalsAttempted")]
            public float AwayFieldGoalsAttempted { get; set; }

            [ColumnName(@"awayFieldGoalsMade")]
            public float AwayFieldGoalsMade { get; set; }

            [ColumnName(@"awayFieldGoalPct")]
            public float AwayFieldGoalPct { get; set; }

            [ColumnName(@"awayFreeThrows")]
            public float AwayFreeThrows { get; set; }

            [ColumnName(@"awayFreeThrowPct")]
            public float AwayFreeThrowPct { get; set; }

            [ColumnName(@"awayFreeThrowsAttempted")]
            public float AwayFreeThrowsAttempted { get; set; }

            [ColumnName(@"awayFreeThrowsMade")]
            public float AwayFreeThrowsMade { get; set; }

            [ColumnName(@"awayOffensiveRebounds")]
            public float AwayOffensiveRebounds { get; set; }

            [ColumnName(@"awayTurnovers")]
            public float AwayTurnovers { get; set; }

            [ColumnName(@"awayThreePointFieldGoalsAttempted")]
            public float AwayThreePointFieldGoalsAttempted { get; set; }

            [ColumnName(@"awayThreePointFieldGoalsMade")]
            public float AwayThreePointFieldGoalsMade { get; set; }

            [ColumnName(@"awayTeamTurnovers")]
            public float AwayTeamTurnovers { get; set; }

            [ColumnName(@"awayPointsInPaint")]
            public float AwayPointsInPaint { get; set; }

            [ColumnName(@"awayFastBreakPoints")]
            public float AwayFastBreakPoints { get; set; }

            [ColumnName(@"awayOffensiveReboundPct")]
            public float AwayOffensiveReboundPct { get; set; }

            [ColumnName(@"awayEstimatedPossessions")]
            public float AwayEstimatedPossessions { get; set; }

            [ColumnName(@"awayPointsPerEstimatedPossessions")]
            public float AwayPointsPerEstimatedPossessions { get; set; }

            [ColumnName(@"awayThreePointFieldGoalPct")]
            public float AwayThreePointFieldGoalPct { get; set; }

            [ColumnName(@"awayTwoPointFieldGoalsMade")]
            public float AwayTwoPointFieldGoalsMade { get; set; }

            [ColumnName(@"awayTwoPointFieldGoalsAttempted")]
            public float AwayTwoPointFieldGoalsAttempted { get; set; }

            [ColumnName(@"awayTwoPointFieldGoalPct")]
            public float AwayTwoPointFieldGoalPct { get; set; }

            [ColumnName(@"awayShootingEfficiency")]
            public float AwayShootingEfficiency { get; set; }

            [ColumnName(@"awayScoringEfficiency")]
            public float AwayScoringEfficiency { get; set; }

            [ColumnName(@"awayLargestLead")]
            public float AwayLargestLead { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("src/Learn/AwayScoreModel/AwayScoreModel.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

    }
}
