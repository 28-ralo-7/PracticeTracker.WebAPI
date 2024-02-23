using PracticeTracker.Services.Users.Models;

namespace PracticeTracker.Services.Users.Repositories.Interfaces;

public interface IUserRepository
{
    public UserDB GetUserDbByLoginAndPasswordHash(string login, string passwordHash);
}