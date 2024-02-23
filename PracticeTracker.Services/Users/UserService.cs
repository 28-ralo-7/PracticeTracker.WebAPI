using PracticeTracker.Domain.User;
using PracticeTracker.Services.Users.Converters;
using PracticeTracker.Services.Users.Interfaces;
using PracticeTracker.Services.Users.Models;
using PracticeTracker.Services.Users.Repositories.Interfaces;
using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Users;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Response GetUserDomainByLoginAndPassword(string login, string passwordHash)
    {
        Response response = new Response();
        UserDB userDb = _userRepository.GetUserDbByLoginAndPasswordHash(login, passwordHash);

        if (userDb is null)
        {
            response = Response.Failed("Пользователь не найден");
        }
        else
        {
            UserDomain userDomain = UserConverter.ConvertUserDbToUserDomain(userDb);
            response = Response.Success(userDomain);
        }

        return response;
    }
    
}