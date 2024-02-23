using PracticeTracker.Services.Role.Models;
using PracticeTracker.Services.Role.Repositories.Interfaces;

namespace PracticeTracker.Services.Role.Repositories;

public class RoleRepository : IRoleRepository
{
    public RoleDB[] GetRolesByUserId(/*ID id*/)
    {
        return new RoleDB[]{}; //TODO: add db connection and role
    }
}