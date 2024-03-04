using PracticeTracker.Domain.Group;
using PracticeTracker.Domain.Role;
using PracticeTracker.Domain.User;
using PracticeTracker.Services.Role.Models;
using PracticeTracker.Services.Users.Models;

namespace PracticeTracker.Services.Users.Converters;

public static class UserConverter
{
    public static UserDomain ConvertUserDbToUserDomainWithoutRoles(this UserDB userDb, GroupDomain groupDomain, RoleDomain roleDomain)
    {
        return new UserDomain(userDb.Id, userDb.Login, userDb.PasswordHash, userDb.Surname, userDb.Name, userDb.Patronomic, groupDomain, roleDomain);
    }
}