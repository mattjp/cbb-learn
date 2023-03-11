
using cbb_learn.src.Games.Models;
using cbb_learn.src.Stats.Models;
using Newtonsoft.Json;
using CsvHelper;
using System.Globalization;

namespace cbb_learn.src.Stats.Services;

public class StatsService
{
    private static readonly HttpClient client = new HttpClient();

    public StatsService() { }

    public async Task GetAllStats(string gamesCsvFilePath)
    {
        Console.WriteLine("Fetching Stats...");

        JsonSerializerSettings settings = new JsonSerializerSettings();
        settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;

        var gameDocs = new List<GameDocument>();

        // Expected column headers
        using (var writer = new StreamWriter("src/Data/stats.csv"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {

            foreach (var col in StatsDocument.GetColumns())
            {
                csv.WriteField(col);
            }

            csv.NextRecord();
        }

        using (var reader = new StreamReader(gamesCsvFilePath))
        using (var gamesCsv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            gameDocs = gamesCsv.GetRecords<GameDocument>().ToList();
        }

        int processed = 0;
        int errors = 0;

        Console.WriteLine($"Attempting to process {gameDocs.Count} games.");

        foreach (var gameDoc in gameDocs)
        {
            var statsDoc = new StatsDocument(gameDoc.Id, gameDoc.Home, gameDoc.Away);

            Console.WriteLine($"{gameDoc.Id}, {gameDoc.Home}, {gameDoc.Away}");

            try
            {
                foreach (var teamId in new List<string> { gameDoc.Home, gameDoc.Away })
                {
                    string url = $"http://sports.core.api.espn.com/v2/sports/basketball/leagues/mens-college-basketball/events/{gameDoc.Id}/competitions/{gameDoc.Id}/competitors/{teamId}/statistics?lang=en&region=us";
                    string response = await client.GetStringAsync(url);

                    var statsResponse = JsonConvert.DeserializeObject<StatsResponse>(response, settings);

                    foreach (var cat in statsResponse.Splits.Categories)
                    {
                        foreach (var s in cat.Stats.Where(c =>
                            !c.Name.StartsWith("avg")
                            && !c.Name.StartsWith("total")
                            && c.Name != "largestLead"
                            && c.Name != "fantasyRating"))
                        {
                            string prefix = teamId == gameDoc.Home ? "home" : "away";
                            string k = prefix + string.Concat(s.Name[0].ToString().ToUpper(), s.Name.AsSpan(1));
                            double v = s.Value;

                            statsDoc.Stats.Add(k, v);
                        }
                    }
                }

                using (var writer = new StreamWriter("src/Data/stats.csv", true))
                {
                    var l = new List<double>();
                    foreach (var col in StatsDocument.GetColumns())
                    {
                        if (statsDoc.Stats.ContainsKey(col))
                        {
                            l.Add(statsDoc.Stats[col]);
                        }
                        else
                        {
                            Console.WriteLine($"Could not find key={col} in docId={statsDoc.Id}");
                            l.Add(0);
                        }
                    }

                    writer.WriteLine(string.Join(',', l));
                }

                Console.WriteLine("Waiting for 1 second...");
                System.Threading.Thread.Sleep(1000);
                processed++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Encountered exception={ex.Message}");
                errors++;
            }
        }

        Console.WriteLine($"Processed {processed} games.\nEncountered {errors} errors");

    }
}
