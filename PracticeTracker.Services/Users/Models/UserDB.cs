namespace PracticeTracker.Services.Users.Models;

public class UserDB
{
    public Byte[] Id { get; }
    public string Login { get; }
    public string PasswordHash { get; }
    public string Surname { get; }
    public string Name { get; }
    public string Patronomic { get; }
    public Byte[] GroupId { get; }
    public bool IsRemoved { get; }
}