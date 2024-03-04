using PracticeTracker.Services.Role.Models;

namespace PracticeTracker.Services.Role.Repositories.Interfaces;

public interface IRoleRepository
{
    RoleDB GetRoleById(byte[] id);//TODO: add roles
}