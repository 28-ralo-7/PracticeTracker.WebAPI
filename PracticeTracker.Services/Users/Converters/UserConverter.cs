using PracticeTracker.Domain.User;
using PracticeTracker.Services.Users.Models;

namespace PracticeTracker.Services.Users.Converters;

public abstract class UserConverter
{
    public static UserDomain ConvertUserDbToUserDomainWithoutRoles(UserDB userDb)
    {
        return new UserDomain(userDb.Id, userDb.Login, userDb.PasswordHash, userDb.Surname, userDb.Name, userDb.Patronomic, userDb.GroupId, null);
    }
}