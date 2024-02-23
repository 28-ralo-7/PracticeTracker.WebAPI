using PracticeTracker.Services.Role.Converters;
using PracticeTracker.Services.Role.Interfaces;
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

    public Response GetRolesByUserId(/*ID id*/)
    {
        Response response = new Response();
        var roleDbs = _roleRepository.GetRolesByUserId( /*id*/);//TODO: add roles

        if (roleDbs is null)
        {
            response.AddError("Данный пользователь не имеет ролей");
        }
        else
        {
            var roleDomains = RoleConverter.ConvertRoleDbsToRoleDomains(roleDbs); //TODO: add role
            response = Response.Success(roleDomains);
        }

        return response;
    }
}