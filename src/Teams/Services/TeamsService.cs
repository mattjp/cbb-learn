
using cbb_learn.src.Teams.Models;
using Newtonsoft.Json;
using CsvHelper;
using System.Globalization;

namespace cbb_learn.src.Teams.Services;

public class TeamsService
{
    private static readonly HttpClient client = new HttpClient();

    public TeamsService() { }

    public async Task GetAllTeams()
    {
        Console.WriteLine("Fetching TeamIds...");

        string url = "http://sports.core.api.espn.com/v2/sports/basketball/leagues/mens-college-basketball/seasons/2022/types/2/groups/50/teams?lang=en&region=us&limit=400";

        JsonSerializerSettings settings = new JsonSerializerSettings();
        settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;

        string response = await client.GetStringAsync(url);

        var teams = JsonConvert.DeserializeObject<TeamsResponse>(response, settings);

        if (teams == null)
        {
            Console.WriteLine("ESPN API response was null.");
            return;
        }

        if (teams.Items == null)
        {
            Console.WriteLine("ESPN response contained null Items.");
            return;
        }

        var teamDocuments = teams.Items.Select(item => 
        {
            int i = item.Ref.LastIndexOf("/") + 1;
            int l = item.Ref.LastIndexOf("?") - i;
            return new TeamDocument(item.Ref.Substring(i, l));
        });
        
        using (var writer = new StreamWriter("../Data/teams.csv"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(teamDocuments);
        }
    }
}
