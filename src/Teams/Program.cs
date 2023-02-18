using cbb_learn.src.Teams.Services;

namespace cbb_learn.src.Teams;

public class Program
{
    public static async Task<int> Main()
    {
        TeamsService teamsService = new TeamsService();
        await teamsService.GetAllTeams();

        return 0;
    }    
}
