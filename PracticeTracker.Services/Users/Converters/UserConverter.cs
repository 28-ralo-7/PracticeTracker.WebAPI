using PracticeTracker.Domain.User;
using PracticeTracker.Services.Users.Models;

namespace PracticeTracker.Services.Users.Converters;

public abstract class UserConverter
{
    public static UserDomain ConvertUserDbToUserDomain(UserDB userDb)
    {
        return new UserDomain();
    }
}