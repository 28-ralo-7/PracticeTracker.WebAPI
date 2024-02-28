namespace PracticeTracker.Services.Users.Models;

public class UserDB
{
    public Byte[] Id { get; set; }
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Patronomic { get; set; }
    public Byte[] GroupId { get; set; }
    public bool IsRemoved { get; set; }
}