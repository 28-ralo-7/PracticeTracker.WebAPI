using PracticeTracker.Services.Users.Models;
using PracticeTracker.Services.Users.Repositories.Interfaces;

namespace PracticeTracker.Services.Users.Repositories;

public class UserRepository : IUserRepository
{
    public UserDB GetUserDbByLoginAndPasswordHash(string login, string passwordHash)
    {
        return new UserDB();
    }
}