using Newtonsoft.Json;

namespace cbb_learn.src.Games.Models;

public class GamesResponse
{
    public int Count { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int PageCount { get; set; }
    
    [JsonProperty(PropertyName="Items")]
    public List<Item>? Items { get; set; }
}

public class Item
{
    [JsonProperty(PropertyName = "$ref")]
    public string Ref { get; set; } = string.Empty;
}
