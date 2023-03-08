using CsvHelper.Configuration.Attributes;

namespace cbb_learn.src.Teams.Models;

public class TeamDocument
{
    [Name("id")]
    public string Id { get; set; } = string.Empty;

    public TeamDocument(string id)
    {
        Id = id;
    }
}
