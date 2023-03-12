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
    class Program
    {
        public static async Task Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please pass in exactly 2 teamIds.");
                return;
            }

            string teamA = args[0];
            string teamB = args[1];

            SeasonStatsService seasonStatsService = new SeasonStatsService();
            var seasonStats = await seasonStatsService.GetSeasonStats(teamA, teamB);

            var modelInputA = seasonStatsService.GetModelInput(seasonStats["B"], seasonStats["A"]);
            var modelInputB = seasonStatsService.GetModelInput(seasonStats["A"], seasonStats["B"]);

            Console.WriteLine($"Predicting away points for both teams.\n");

            // Console.WriteLine($"{JsonConvert.SerializeObject(modelInputA, Formatting.Indented)}");

            var predA = AwayScoreModel.Predict(modelInputA);
            var predB = AwayScoreModel.Predict(modelInputB);

            var scoreA = predA.Score;
            var scoreB = predB.Score;
            var scoreDiff = Math.Abs(scoreA - scoreB);

            Console.WriteLine($"=> Points:\n\t{teamA}: {Math.Round(scoreA)}\n\t{teamB}: {Math.Round(scoreB)}\n");
            Console.WriteLine($"=> Point difference: {scoreDiff}\n");
            Console.WriteLine($"=> Winner: {(scoreA > scoreB ? teamA : teamB)}\n");
            Console.WriteLine($"=> Spread: {Math.Round(scoreDiff * 2, MidpointRounding.AwayFromZero) / 2}\n");
            Console.WriteLine("=============== End of process ===============");
        }
    }
}
