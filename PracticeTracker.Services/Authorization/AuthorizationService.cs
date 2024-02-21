using PracticeTracker.Services.Authorization.Interfaces;
using PracticeTracker.Services.Authorization.Validate;
using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Authorization;

public class AuthorizationService : IAuthorizationService
{
    private VAuthorizationService _validator;

    public AuthorizationService(VAuthorizationService validator)
    {
        _validator = validator;
    }
    public Response Authorization(string login, string password)
    {
        Response response = new Response();
        List<Error> errors = _validator.ValidateLoginAndPassword(login, password);

        if (errors.Count != 0)
        {
            response.AddError(errors);
        }

        return null;
        //UserDB userDb = _userRepository
    }
}