using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class ovstdiag
    {
        [Key]
        public int ovst_diag_id { get; set; }
        public string? vn { get; set; }
        public string? icd10 { get; set; }
        public string? hn { get; set; }
        public DateTime? vstdate { get; set; }
        public TimeSpan? vsttime { get; set; }
        public string? diagtype { get; set; }
        public string? icd103 { get; set; }
        public string? hcode { get; set; }
        public string? doctor { get; set; }
        public byte? episode { get; set; }
        public string? ext_code { get; set; }
        public string? hos_guid { get; set; }
        public string? dep_flag { get; set; }
        public int? ovst_oper_type { get; set; }
        public string? staff { get; set; }
        public string? dx_guid { get; set; }
        public string? lock_dx { get; set; }
        public string? dx_code_note { get; set; }
        public int? ovstdiag_severe_type_id { get; set; }
        public int? diag_no { get; set; }
        public DateTime? update_datetime { get; set; }
        public string? confirm { get; set; }
        public string? confirm_staff { get; set; }
        public string? opi_guid { get; set; }
        public string? sct_id { get; set; }
    }
}
