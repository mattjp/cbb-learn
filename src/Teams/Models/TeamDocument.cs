namespace cbb_learn.src.Teams.Models;

public class TeamDocument
{
    public string Id { get; set; } = string.Empty;

    public TeamDocument(string id)
    {
        Id = id;
    }
}
