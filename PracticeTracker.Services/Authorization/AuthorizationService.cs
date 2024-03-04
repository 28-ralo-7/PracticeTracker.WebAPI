using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using PracticeTracker.Domain.User;
using PracticeTracker.Services.Authorization.Interfaces;
using PracticeTracker.Services.Authorization.Validate;
using PracticeTracker.Services.Role.Interfaces;
using PracticeTracker.Services.Users.Interfaces;
using PracticeTracker.Tools.Types;
using PracticeTracker.Tools.Utils;

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
        Response authResponse;
        Response userServiceResponse = _userService.GetUserByLoginAndPassword(login, password);

        if (userServiceResponse.IsSuccess)
        {
            string token = GenerateJWT(userServiceResponse.Data);
            authResponse = Response.Success(token);
        }
        else
        {
            authResponse = Response.Failed(userServiceResponse.Errors);
        }

        return authResponse;
    }

    private string GenerateJWT(UserDomain user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Login),
            new Claim(ClaimTypes.Role, user.Role.Type),
        };
        JwtSecurityToken? jwt = new JwtSecurityToken(
            issuer: AuthOptions.ISSUER,
            audience: AuthOptions.AUDIENCE,
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
            signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
        string? encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

        return encodedJwt;
    }
}