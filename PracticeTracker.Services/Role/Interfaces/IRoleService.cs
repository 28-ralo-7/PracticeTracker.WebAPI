using PracticeTracker.Tools.Types;

namespace PracticeTracker.Services.Role.Interfaces;

public interface IRoleService
{
    public Response GetRoleById(byte[] id);
}