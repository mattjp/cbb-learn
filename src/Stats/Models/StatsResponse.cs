using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace cbb_learn.src.Stats.Models;

public class StatsResponse
{
    public Splits Splits { get; set; } = new Splits();
}

public class Splits
{
    public string Name { get; set; } = string.Empty;
    public List<Category> Categories  { get; set; } = new List<Category>();
}

public class Category
{
    public string Name { get; set; } = string.Empty;
    public List<Stat> Stats { get; set; } = new List<Stat>();
}

public class Stat
{
    public string Name { get; set; } = string.Empty;
    public double Value { get; set; } = 0;
}
