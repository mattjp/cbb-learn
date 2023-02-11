
namespace cbb_learn.src.Teams.Services;

public class TeamsService
{
    // private readonly ILogger<TeamsService> _logger;

    private static readonly HttpClient client = new HttpClient();

    public TeamsService()
    {
        // _logger = logger;
    }

    // public TeamsService()
    // {
    // }

    public async Task<IEnumerable<int>> GetAllTeams()
    {

        Console.WriteLine("I am getting the teams now");



        return new List<int>();
    }


}
