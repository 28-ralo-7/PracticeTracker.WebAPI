namespace PracticeTracker.Domain.Role;

public class RoleDomain
{
    public byte[] Id { get; }
    public string Type { get; }

    public RoleDomain(){}
    public RoleDomain(byte[] id, string type)
    {
        Id = id;
        Type = type;
    }
}