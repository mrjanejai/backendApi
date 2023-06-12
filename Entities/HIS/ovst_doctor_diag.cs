using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class ovst_doctor_diag
    {
        [Key]
        public int ovst_doctor_diag_id { get; set; }
        public string vn { get; set; }
        public string doctor_code { get; set; }
        public string? diag_text { get; set; }
        public DateTime? diag_datetime { get; set; }
        public int? ovst_doctor_diag_st_id { get; set; }
        public string? sct_id { get; set; }
        public int? hl7_condition_clinical_status_id { get; set; }
        public string? body_structure_sct_id { get; set; }
        public string? body_structure_sct_name { get; set; }
        public string? severity_sct_id { get; set; }
        public string? severity_sct_name { get; set; }
    }
}
