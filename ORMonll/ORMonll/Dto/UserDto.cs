using ORMonll.Enum;

namespace ORMonll.Dto;

public class UserDto
{
    public long Id { get; set; }
    public string name{ get; set; }
    public string surname{ get; set; }
    public string displayName{ get; set; }
    public string email{ get; set; }
    public string password{ get; set; }
    public int age{ get; set; }
    public Gender gender{ get; set; }
    public DateTime insDate{ get; set; }
    public Boolean isRegistered{ get; set; }
}