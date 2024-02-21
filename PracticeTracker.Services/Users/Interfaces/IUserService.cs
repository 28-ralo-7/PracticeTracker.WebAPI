using PracticeTracker.Domain.User;

namespace PracticeTracker.Services.Users.Interfaces;

public interface IUserService
{
    public UserDomain GetUserDomainByLoginAndPassword(string login, string password);
}