namespace PracticeTracker.Domain.Role;

public class RoleDomain
{
    public string Id { get; }
    public string Type { get; }

    public RoleDomain(){}
    public RoleDomain(string id, string type)
    {
        Id = id;
        Type = type;
    }
}