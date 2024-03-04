using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeTracker.Services.Group.Models;

[Table("gr_group")]
public class GroupDB
{
    public byte[] Id { get; set; }
    public string Code { get; set; }
    public string Specialization { get; set; }
    public Boolean IsRemoved { get; set; }
}