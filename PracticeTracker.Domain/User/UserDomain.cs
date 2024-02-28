namespace PracticeTracker.Domain.User;

public class UserDomain
{
    public string Id { get; }
    public string Login { get; }
    public string PasswordHash { get; }
    public string Surname { get; }
    public string Name { get; }
    public string Patronomic { get; }
    public string GroupId { get; }
    public string[] RoleIds { get; }

    public UserDomain(byte[] id, string login, string passwordHash, string surname, string name, string patronomic, byte[] groupId, byte[][] roleIds)
    {
        Id = System.Text.Encoding.UTF8.GetString(id);
        Login = login;
        PasswordHash = passwordHash;
        Surname = surname;
        Name = name;
        Patronomic = patronomic;
        GroupId = System.Text.Encoding.UTF8.GetString(groupId);
        RoleIds = roleIds is not null 
            ? roleIds.Select(roleId => System.Text.Encoding.UTF8.GetString(roleId)).ToArray() 
            : new string[]{};
    }
}