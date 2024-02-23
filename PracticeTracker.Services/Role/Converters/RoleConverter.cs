using PracticeTracker.Domain.Role;
using PracticeTracker.Services.Role.Models;

namespace PracticeTracker.Services.Role.Converters;

public abstract class RoleConverter
{
    public static RoleDomain[] ConvertRoleDbsToRoleDomains(RoleDB[] roleDbs)
    {
        List<RoleDomain> roleDomains = new List<RoleDomain>();

        foreach (var roleDb in roleDbs)
        {
            RoleDomain roleDomain = ConvertRoleDbToRoleDomain(roleDb);
            roleDomains.Add(roleDomain);
        }

        return roleDomains.ToArray();

    }

    public static RoleDomain ConvertRoleDbToRoleDomain(RoleDB roleDb)
    {
        return new RoleDomain(); //TODO: add role
    }
}