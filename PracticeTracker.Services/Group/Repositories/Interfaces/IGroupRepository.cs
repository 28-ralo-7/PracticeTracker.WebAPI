using PracticeTracker.Services.Group.Models;

namespace PracticeTracker.Services.Group.Repositories.Interfaces;

public interface IGroupRepository
{
    GroupDB GetGroupById(byte[] id);
}