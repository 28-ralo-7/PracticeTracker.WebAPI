using Microsoft.AspNetCore.Mvc;
using PracticeTracker.Services.Authorization.Interfaces;
using PracticeTracker.Tools.Types;

namespace PracticeTracker.WebAPI.Controllers.Authorization;

[ApiController]
[Route("[controller]")]
public class AuthorizationController : ControllerBase
{
    private IAuthorizationService _authorizationService;
    //private CurrentUser _currentUser;
    public AuthorizationController(IAuthorizationService authorizationService)
    {
        _authorizationService = authorizationService;
    }

    [HttpPost(Name = "Authorization")]
    public Response Login(string login, string password)
    {
        return _authorizationService.Authorization(login, password);
    }

    [HttpGet(Name = "GetPermissions")]
    public Response GetPermissions()
    {
        return _authorizationService.GetPermissions(/*_currentUser.Id*/);
    }
}