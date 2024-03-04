using PracticeTracker.Domain.Role;
using PracticeTracker.Services.Role.Models;

namespace PracticeTracker.Services.Role.Converters;

public static class RoleConverter
{
    public static RoleDomain ConvertToRoleDomain(this RoleDB roleDb)
    {
        return new RoleDomain(roleDb.Id, roleDb.Type); //TODO: add role
    }
}