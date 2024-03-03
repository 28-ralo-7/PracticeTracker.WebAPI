namespace PracticeTracker.Domain.Group;

public class GroupDomain
{
    public string Id { get; }
    public string Name { get; }

    public GroupDomain(string id, string name)
    {
        Id = id;
        Name = name;
    }
}