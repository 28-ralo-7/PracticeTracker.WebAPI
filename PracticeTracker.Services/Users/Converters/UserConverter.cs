using PracticeTracker.Domain.Group;
using PracticeTracker.Domain.Role;
using PracticeTracker.Domain.User;
using PracticeTracker.Services.Role.Models;
using PracticeTracker.Services.Users.Models;

namespace PracticeTracker.Services.Users.Converters;

public abstract class UserConverter
{
    public static UserDomain ConvertUserDbToUserDomainWithoutRoles(UserDB userDb, GroupDomain groupDomain, RoleDomain roleDomain)
    {
        return new UserDomain(userDb.Id, userDb.Login, userDb.PasswordHash, userDb.Surname, userDb.Name, userDb.Patronomic, groupDomain, roleDomain);
    }
}