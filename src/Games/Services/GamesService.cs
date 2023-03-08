using cbb_learn.src.Teams.Models;
using cbb_learn.src.Games.Models;
using Newtonsoft.Json;
using CsvHelper;
using System.Globalization;

namespace cbb_learn.src.Games.Services;

public class GamesService
{
    private static readonly HttpClient _client = new HttpClient();

    public GamesService() { }

    public async Task GetAllGames(string teamsCsvFilePath)
    {
        Console.WriteLine("Fetching GameIds...");

        JsonSerializerSettings settings = new JsonSerializerSettings();
        settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;

        var teams = new List<TeamDocument>();

        using (var reader = new StreamReader(teamsCsvFilePath))
        using (var teamsCsv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            teams = teamsCsv.GetRecords<TeamDocument>().ToList();
        }

        List<GameDocument> gameDocuments = new List<GameDocument>();

        foreach (var team in teams)
        {
            Console.WriteLine($"Collecting gameIds for Team={team.Id}");

            string url = $"https://sports.core.api.espn.com/v2/sports/basketball/leagues/mens-college-basketball/seasons/2022/teams/{team.Id}/events";

            string response = "";
            try
            {
                response = await _client.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Encountered exception: {ex.Message}.\nSleeping for 10 seconds then retrying...");
                System.Threading.Thread.Sleep(10000);
                response = await _client.GetStringAsync(url);
            }

            GamesResponse? games = JsonConvert.DeserializeObject<GamesResponse>(response, settings);

            if (games == null)
            {
                Console.WriteLine("ESPN API response was null.");
                return;
            }

            if (games.Items == null)
            {
                Console.WriteLine("ESPN response contained null Items.");
                return;
            }

            var gameIds = games.Items.Select(item =>
            {
                int i = item.Ref.LastIndexOf("/") + 1;
                int l = item.Ref.LastIndexOf("?") - i;
                return item.Ref.Substring(i, l);
            });

            await Parallel.ForEachAsync(gameIds, async (gameId, token) =>
            {
                string gameUrl = $"http://sports.core.api.espn.com/v2/sports/basketball/leagues/mens-college-basketball/events/{gameId}?lang=en&region=us";

                string gameResponse = "";
                
                try
                {
                    gameResponse = await _client.GetStringAsync(gameUrl);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Encountered exception: {ex.Message}.\nSleeping for 10 seconds then retrying...");
                    System.Threading.Thread.Sleep(10000);
                    gameResponse = await _client.GetStringAsync(gameUrl);
                }
                
                GameResponse? game = JsonConvert.DeserializeObject<GameResponse>(gameResponse, settings);

                if (game == null)
                {
                    Console.WriteLine("ESPN API response was null.");
                    return;
                }

                gameDocuments.AddRange(game.Competitions.Select(competition => {
                    var doc = new GameDocument(gameId);

                    foreach (var competitor in competition.Competitors)
                    {
                        if (competitor.HomeAway == "home")
                        {
                            doc.Home = competitor.Id;
                        }
                        else
                        {
                            doc.Away = competitor.Id;
                        }
                    }

                    return doc;
                }));
            });

            Console.WriteLine("Waiting for 5 seconds...");
            System.Threading.Thread.Sleep(5000);
        }

        Console.WriteLine($"Retreived {gameDocuments.Count} games.");

        Console.WriteLine($"Removing null game documents...");

        var gameDocumentsNoNulls = gameDocuments.FindAll(doc => doc != null);

        Console.WriteLine($"Deduplicating {gameDocumentsNoNulls.Count} gameIds...");

        var uniqueGameDocuments = gameDocumentsNoNulls.DistinctBy(doc => doc.Id);

        using (var writer = new StreamWriter("src/Data/games.csv"))
        using (var gamesCsv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            gamesCsv.WriteRecords(uniqueGameDocuments);
        }
    }
}
