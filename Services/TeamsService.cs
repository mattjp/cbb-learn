namespace cbb_learn.Services;

public class TeamsService
{
    private readonly ILogger<TeamsService> _logger;

    private static readonly HttpClient client = new HttpClient();

    public TeamsService(ILogger<TeamsService> logger)
    {
        _logger = logger;
    }

    public async Task<IEnumerable<int>> GetAllTeams()
    {

        Console.WriteLine("I am getting the teams now");



        return new List<int>();
    }


}
