using CsvHelper.Configuration.Attributes;

namespace cbb_learn.src.Games.Models;

public class GameDocument
{
    [Name("id")]
    public string Id { get; set; } = string.Empty;
    [Name("home")]
    public string Home { get; set; } = string.Empty;
    [Name("away")]
    public string Away { get; set; } = string.Empty;

    public GameDocument(string id)
    {
        Id = id;
    }
}
