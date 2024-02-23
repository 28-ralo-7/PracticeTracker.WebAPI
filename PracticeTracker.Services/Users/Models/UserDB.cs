namespace PracticeTracker.Services.Users.Models;

public class UserDB
{
    public Byte[] ID { get; }
    public string Login { get; }
    public string PasswordHash { get; }
    public string Surname { get; }
    public string Name { get; }
    public string Patronomic { get; }
    public Byte[] RoleID { get; }
    public bool IsRemoved { get; }
}