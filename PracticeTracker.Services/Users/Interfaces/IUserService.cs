using PracticeTracker.Domain.User;
using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Users.Interfaces;

public interface IUserService
{
    public Response GetUserDomainByLoginAndPassword(string login, string passwordHash);

}