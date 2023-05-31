using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class doctor_operation
    {
        [Key]
        public int doctor_operation_id { get; set; }
        public string? vn { get; set; }
        public int? er_oper_code { get; set; }
        public string? doctor { get; set; }
        public DateTime? begin_date_time { get; set; }
        public DateTime? end_date_time { get; set; }
        public string? icd9 { get; set; }
        public double? price { get; set; }
        public string? sflag { get; set; }
        public string opi_guid { get; set; }
        public int? ovst_diag_id { get; set; }
        public string? depcode { get; set; }
        public int? er_oper_code_area_id { get; set; }
        public string? hos_guid { get; set; }
        public string? staff { get; set; }
        public DateTime? update_datetime { get; set; }
        public string? order_doctor_code { get; set; }
        public string? operation_detail_text { get; set; }
        public int? doctor_investigation_report_id { get; set; }
        public string? hos_guid_ext { get; set; }
    }
}
