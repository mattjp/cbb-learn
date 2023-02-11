using Newtonsoft.Json;

namespace cbb_learn.Models;

public class Teams
{
    public int Count { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int PageCount { get; set; }
    public List<Item>? Items { get; set; }
}

public class Item
{
    [JsonProperty(PropertyName = "$ref")]
    public string? Ref { get; set; }
}
