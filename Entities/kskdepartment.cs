namespace WebApi.Entities;
using System.ComponentModel.DataAnnotations;

public class kskdepartment
{
    [Key]
    public string depcode { get; set; }
    public string? department { get; set; }
    public string? roomno { get; set; }
    public string? doctor_code { get; set; }
    public DateTime? online_time { get; set; }
    public string? on_desk { get; set; }
    public string? spclty { get; set; }
    public string? depcode_active { get; set; }
    public string? department_active { get; set; }
}

