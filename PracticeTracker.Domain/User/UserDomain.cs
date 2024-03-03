using PracticeTracker.Domain.Group;
using PracticeTracker.Domain.Role;

namespace PracticeTracker.Domain.User;

public class UserDomain
{
    public string Id { get; }
    public string Login { get; }
    public string PasswordHash { get; }
    public string Surname { get; }
    public string Name { get; }
    public string Patronomic { get; }
    public GroupDomain Group { get; }
    public RoleDomain Role { get; }

    public UserDomain(byte[] id, string login, string passwordHash, string surname, string name, string patronomic, GroupDomain group, RoleDomain role)
    {
        Id = System.Text.Encoding.UTF8.GetString(id);
        Login = login;
        PasswordHash = passwordHash;
        Surname = surname;
        Name = name;
        Patronomic = patronomic;
        Group = group;
        Role = role;
    }
}