using cbb_learn.src.Stats.Services;

namespace cbb_learn.src.Stats;

public class Program
{
    public static async Task<int> Main()
    {
        StatsService statsService = new StatsService();
        await statsService.GetAllStats("src/Data/games.csv");

        return 0;
    }
}
