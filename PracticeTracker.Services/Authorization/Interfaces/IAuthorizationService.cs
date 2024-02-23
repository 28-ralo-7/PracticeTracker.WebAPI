using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Authorization.Interfaces;

public interface IAuthorizationService
{
    public Response Authorization(string login, string password);
    public Response GetPermissions(/*ID id*/);
}