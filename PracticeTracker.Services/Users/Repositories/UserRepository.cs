using PracticeTracker.Services.Users.Models;
using PracticeTracker.Services.Users.Repositories.Interfaces;
using PracticeTracker.Tools.Utils;

namespace PracticeTracker.Services.Users.Repositories;

public class UserRepository : NpgSqlRepository, IUserRepository
{
    public UserDB GetUserDbByLoginAndPasswordHash(string login, string passwordHash)
    {
        string command = $"SELECT * FROM us_users WHERE login = '{login}' AND passwordHash = '{passwordHash}'";
        UserDB userDb = Get<UserDB>(command);

        return userDb;
    }
}