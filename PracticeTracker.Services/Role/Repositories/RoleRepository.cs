using System.Text;
using PracticeTracker.Services.Role.Models;
using PracticeTracker.Services.Role.Repositories.Interfaces;
using PracticeTracker.Tools.Utils;

namespace PracticeTracker.Services.Role.Repositories;

public class RoleRepository : NpgSqlRepository, IRoleRepository
{
    public RoleDB GetRoleById(byte[] id)
    {
        try
        {
            string idString = Encoding.ASCII.GetString(id);
            string command = $"SELECT * FROM us_role WHERE id = '{idString}'";
            RoleDB roleDb = Get<RoleDB>(command);

            return roleDb;
        }
        catch (Exception e)
        {
            Console.WriteLine(e); //TODO: add logger
            throw;
        }
    }
}