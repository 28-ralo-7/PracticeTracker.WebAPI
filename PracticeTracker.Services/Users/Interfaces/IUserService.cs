using PracticeTracker.Domain.User;
using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Users.Interfaces;

public interface IUserService
{
    public Response GetUserByLoginAndPassword(string login, string passwordHash);

}