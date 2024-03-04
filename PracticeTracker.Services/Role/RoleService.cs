using PracticeTracker.Domain.Role;
using PracticeTracker.Services.Role.Converters;
using PracticeTracker.Services.Role.Interfaces;
using PracticeTracker.Services.Role.Models;
using PracticeTracker.Services.Role.Repositories.Interfaces;
using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Role;

public class RoleService : IRoleService
{
    private readonly IRoleRepository _roleRepository;

    public RoleService(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public Response GetRoleById(byte[] id)
    {
        Response response = new Response();
        RoleDB roleDb = _roleRepository.GetRoleById(id);

        if (roleDb is null)
        {
            response.AddError("Данный пользователь не имеет роли");
        }
        else
        {
            RoleDomain roleDomains = roleDb.ConvertToRoleDomain();
            response = Response.Success(roleDomains);
        }

        return response;
    }
}