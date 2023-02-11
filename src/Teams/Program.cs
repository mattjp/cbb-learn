// using cbb_learn.Models;
// using cbb_learn.Services;
// using Microsoft.Extensions.Logging;
// using Newtonsoft.Json;

using cbb_learn.src.Teams.Services;

namespace cbb_learn.src.Teams;

public class Program
{

    // private readonly ILogger<Program> _logger;
    private static readonly HttpClient client = new HttpClient();

    // public Program(ILogger<Program> logger)
    // {
    //     _logger = logger;
    // }

    public static void Main()
    {
        TeamsService teamsService = new TeamsService();
        var teams = teamsService.GetAllTeams();
        // teamsService.WriteAllTeams();

        // string url = "http://sports.core.api.espn.com/" +
        //             "v2/sports/basketball/leagues/mens-college-basketball/seasons/2022/types/2/groups/50/teams" +
        //             "?lang=en&region=us&limit=400";

        // JsonSerializerSettings settings = new JsonSerializerSettings();
        // settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;

        // string response = await client.GetStringAsync(url);
        // var teams = JsonConvert.DeserializeObject<TeamsResponse>(response, settings);

        // if (teams == null)
        // {
        //     _logger.LogError("ESPN response was null.");
        //     return;
        //     // return new List<int>();
        // }

        // Console.WriteLine("Hello, World!");
    }    
}
