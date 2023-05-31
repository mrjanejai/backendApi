using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class visit_pttype
    {
        [Key]
        public string vn { get; set; }
        public string pttype { get; set; }
        public string? staff { get; set; }
        public double? rcpt_amount { get; set; }
        public double? debt_amount { get; set; }
        public double? discount_amount { get; set; }
        public DateTime? begin_date { get; set; }
        public DateTime? expire_date { get; set; }
        public string? hospmain { get; set; }
        public string? hospsub { get; set; }
        public string? pttypeno { get; set; }
        public int? pttype_number { get; set; }
        public int? pttype_order { get; set; }
        public double? discount_percent { get; set; }
        public int? company_id { get; set; }
        public int? contract_id { get; set; }
        public double? max_debt_amount { get; set; }
        public double? paid_amount { get; set; }
        public string? claim_code { get; set; }
        public string? hos_guid { get; set; }
        public int? limit_hour { get; set; }
        public string? check_limit_hour { get; set; }
        public string? finance_clear_ok { get; set; }
        public string? hos_guid_ext { get; set; }
        public DateTime? confirm_and_locked_datetime { get; set; }
        public string? confirm_and_locked { get; set; }
        public string? confirm_and_locked_staff { get; set; }
        public string? nhso_govcode { get; set; }
        public string? nhso_govname { get; set; }
        public string? nhso_docno { get; set; }
        public string? nhso_ownright_pid { get; set; }
        public string? nhso_ownright_name { get; set; }
        public DateTime? update_datetime { get; set; }
        public string? emp_privilege { get; set; }
        public int? emp_id { get; set; }
        public string? pttype_service_charge { get; set; }
        public string? pttype_note { get; set; }
        public string? auth_code { get; set; }
        public string? rcpno_list { get; set; }
        public string? project_code { get; set; }
        public string? depcode_service_charge { get; set; }
    }
}
