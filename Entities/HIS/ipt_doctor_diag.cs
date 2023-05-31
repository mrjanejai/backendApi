using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class ipt_doctor_diag
    {
        [Key]
        public int ipt_doctor_diag_id { get; set; }
        public string an { get; set; }
        public string doctor_code { get; set; }
        public string? diag_text { get; set; }
        public DateTime? diag_datetime { get; set; }
        public int? ovst_doctor_diag_st_id { get; set; }
        public string? diagtype { get; set; }
        public string? final_diag { get; set; }
        public string? audit_ok { get; set; }
        public DateTime? audit_datetime { get; set; }
        public string? audit_doctor_code { get; set; }
        public string? audit_diag_text { get; set; }
        public string? audit_diagtype { get; set; }
        public string? inspect_doctor_code { get; set; }
    }
}
