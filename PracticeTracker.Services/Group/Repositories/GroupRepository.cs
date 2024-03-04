using PracticeTracker.Services.Group.Models;
using PracticeTracker.Services.Group.Repositories.Interfaces;
using PracticeTracker.Tools.Utils;

namespace PracticeTracker.Services.Group.Repositories;

public class GroupRepository: NpgSqlRepository, IGroupRepository
{
    public GroupDB GetGroupById(byte[] id)
    {
        try
        {
            string command = $"SELECT * FROM gr_group WHERE id = '{id}'";
            GroupDB groupDB = Get<GroupDB>(command);

            return groupDB;
        }
        catch (Exception e)
        {
            Console.WriteLine(e); //TODO: add logger
            throw;
        }
    }
}