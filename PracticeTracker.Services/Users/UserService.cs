using System.Security.Cryptography;
using System.Text;
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

    public Response GetUserDomainByLoginAndPassword(string login, string password)
    {
        Response response = new Response();
        string passwordHash = GetPasswordHash(password);
        UserDB userDb = _userRepository.GetUserDbByLoginAndPasswordHash(login, passwordHash);

        if (userDb is null)
        {
            response = Response.Failed("Пользователь не найден");
        }
        else
        {//TODO: add Role and Group service/repository
            UserDomain userDomain = UserConverter.ConvertUserDbToUserDomainWithoutRoles(userDb, null, null);
            response = Response.Success(userDomain);
        }

        return response;
    }

    private string GetPasswordHash(string password)
    {
        Byte[] bytes = Encoding.Unicode.GetBytes(password);
        MD5CryptoServiceProvider cryptoService = new MD5CryptoServiceProvider();
        Byte[] byteHash = cryptoService.ComputeHash(bytes);
        String hash = String.Empty;

        foreach (Byte b in byteHash)
            hash += String.Format("{0:x2}", b);

        return hash;
    }
}