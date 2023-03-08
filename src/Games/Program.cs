using cbb_learn.src.Games.Services;

namespace cbb_learn.src.Games;

public class Program
{
    public static async Task<int> Main()
    {
        GamesService gamesService = new GamesService();
        await gamesService.GetAllGames("src/Data/teams.csv");

        return 0;
    }
}
