using PracticeTracker.Services.Authorization.Interfaces;
using PracticeTracker.Services.Authorization.Validate;
using PracticeTracker.Services.Role.Interfaces;
using PracticeTracker.Services.Users.Interfaces;
using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Authorization;

public class AuthorizationService : IAuthorizationService
{
    private readonly VAuthorizationService _validator;
    private readonly IUserService _userService;
    private readonly IRoleService _roleService;

    public AuthorizationService(VAuthorizationService validator, IUserService userService, IRoleService roleService)
    {
        _validator = validator;
        _userService = userService;
        _roleService = roleService;
    }

    public Response Authorization(string login, string password)
    {
        Response response = _userService.GetUserDomainByLoginAndPassword(login, password);

        if (response.IsSuccess)
        {
            
        }
        else
        {
            
        } //TODO: learn and add authorization with save

        return response;
    }

    public Response GetPermissions(/*ID id*/)
    {
        Response response = _roleService.GetRolesByUserId(/*id*/); //TODO: add roles and class id

        return response;
    }
}