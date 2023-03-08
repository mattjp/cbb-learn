using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace cbb_learn.src.Games.Models;

public class GameResponse
{
    public List<Competition> Competitions { get; set; } = new List<Competition>();
}

public class Competition
{
    public List<Competitor> Competitors { get; set; } = new List<Competitor>();
}

public class Competitor
{
    public string Id { get; set; } = string.Empty;
    public string HomeAway { get; set; } = string.Empty;
}
