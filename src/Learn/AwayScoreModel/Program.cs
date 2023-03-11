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
            SeasonStatsService seasonStatsService = new SeasonStatsService();
            var seasonStats = await seasonStatsService.GetSeasonStats("2", "5");

            var modelInputA = seasonStatsService.GetModelInput(seasonStats["B"], seasonStats["A"]);
            var modelInputB = seasonStatsService.GetModelInput(seasonStats["A"], seasonStats["B"]);

            Console.WriteLine($"Predicting away points for teamId=2 against teamId=201\n");

            var predictionResultA = AwayScoreModel.Predict(modelInputA);

            Console.WriteLine($"Predicted AwayPoints for teamId=2: {predictionResultA.Score}\n");

            Console.WriteLine($"Predicting away points for teamId=201 against teamId=2\n");

            var predictionResultB = AwayScoreModel.Predict(modelInputB);

            Console.WriteLine($"Predicted AwayPoints for teamId=201: {predictionResultB.Score}\n");

            Console.WriteLine("=============== End of process ===============");
        }
    }
}
