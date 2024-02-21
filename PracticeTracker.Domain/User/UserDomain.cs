namespace PracticeTracker.Domain.User;

public class UserDomain
{
    public byte[] Id { get; set; }
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Patronomic { get; set; }
    public byte[] GroupId { get; set; }
    public byte[][] RoleIds { get; set; }
    
}