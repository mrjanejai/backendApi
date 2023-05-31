using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class ipt_nurse_oper
    {
        [Key]
        public int nurse_oper_id { get; set; }
        public string? an { get; set; }
        public int? ipt_oper_code { get; set; }
        public string? doctor { get; set; }
        public DateTime? begin_date_time { get; set; }
        public DateTime? end_date_time { get; set; }
        public int? oper_qty { get; set; }
        public double? oper_price { get; set; }
        public DateTime? ref_date { get; set; }
        public string? hos_guid { get; set; }
        public string? opi_guid { get; set; }
        public string? charge_opitemrece { get; set; }
        public DateTime? entry_datetime { get; set; }
        public DateTime? modify_datetime { get; set; }
        public string? staff { get; set; }
        public int? ref_date_int { get; set; }
        public double? total_price { get; set; }
        public string? oper_note { get; set; }
        public int? doctor_investigation_report_id { get; set; }
        public int? icd9_priority { get; set; }
        public int? ipd_nurse_shift_id { get; set; }
        public DateTime? oper_date { get; set; }
        public int? ipd_nurse_note_time_id { get; set; }
        public int? oper_date_unix { get; set; }
    }
}
