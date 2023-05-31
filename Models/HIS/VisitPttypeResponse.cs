namespace WebApi.Models.HIS
{
    public class VisitPttypeResponse
    {
        public string vn { get; set; }
        public string pttype { get; set; }
        public string staff { get; set; }
        public double rcpt_amount { get; set; }
        public double debt_amount { get; set; }
        public double discount_amount { get; set; }
        public DateTime begin_date { get; set; }
        public DateTime expire_date { get; set; }
        public string hospmain { get; set; }
        public string hospsub { get; set; }
        public string pttypeno { get; set; }
        public int pttype_number { get; set; }
        public int pttype_order { get; set; }
        public double discount_percent { get; set; }
        public int company_id { get; set; }
        public int contract_id { get; set; }
        public double max_debt_amount { get; set; }
        public double paid_amount { get; set; }
        public string claim_code { get; set; }
        public string hos_guid { get; set; }
        public int limit_hour { get; set; }
        public string check_limit_hour { get; set; }
        public string finance_clear_ok { get; set; }
        public string hos_guid_ext { get; set; }
        public DateTime confirm_and_locked_datetime { get; set; }
        public string confirm_and_locked { get; set; }
        public string confirm_and_locked_staff { get; set; }
        public string nhso_govcode { get; set; }
        public string nhso_govname { get; set; }
        public string nhso_docno { get; set; }
        public string nhso_ownright_pid { get; set; }
        public string nhso_ownright_name { get; set; }
        public DateTime update_datetime { get; set; }
        public string emp_privilege { get; set; }
        public int emp_id { get; set; }
        public string pttype_service_charge { get; set; }
        public string pttype_note { get; set; }
        public string auth_code { get; set; }
        public string rcpno_list { get; set; }
        public string project_code { get; set; }
        public string depcode_service_charge { get; set; }

        public VisitPttypeResponse()
        {
        }

        public VisitPttypeResponse(string vn, string pttype, string staff, double rcpt_amount, double debt_amount, double discount_amount, DateTime begin_date, DateTime expire_date, string hospmain, string hospsub, string pttypeno, int pttype_number, int pttype_order, double discount_percent, int company_id, int contract_id, double max_debt_amount, double paid_amount, string claim_code, string hos_guid, int limit_hour, string check_limit_hour, string finance_clear_ok, string hos_guid_ext, DateTime confirm_and_locked_datetime, string confirm_and_locked, string confirm_and_locked_staff, string nhso_govcode, string nhso_govname, string nhso_docno, string nhso_ownright_pid, string nhso_ownright_name, DateTime update_datetime, string emp_privilege, int emp_id, string pttype_service_charge, string pttype_note, string auth_code, string rcpno_list, string project_code, string depcode_service_charge)
        {
            this.vn = vn;
            this.pttype = pttype;
            this.staff = staff;
            this.rcpt_amount = rcpt_amount;
            this.debt_amount = debt_amount;
            this.discount_amount = discount_amount;
            this.begin_date = begin_date;
            this.expire_date = expire_date;
            this.hospmain = hospmain;
            this.hospsub = hospsub;
            this.pttypeno = pttypeno;
            this.pttype_number = pttype_number;
            this.pttype_order = pttype_order;
            this.discount_percent = discount_percent;
            this.company_id = company_id;
            this.contract_id = contract_id;
            this.max_debt_amount = max_debt_amount;
            this.paid_amount = paid_amount;
            this.claim_code = claim_code;
            this.hos_guid = hos_guid;
            this.limit_hour = limit_hour;
            this.check_limit_hour = check_limit_hour;
            this.finance_clear_ok = finance_clear_ok;
            this.hos_guid_ext = hos_guid_ext;
            this.confirm_and_locked_datetime = confirm_and_locked_datetime;
            this.confirm_and_locked = confirm_and_locked;
            this.confirm_and_locked_staff = confirm_and_locked_staff;
            this.nhso_govcode = nhso_govcode;
            this.nhso_govname = nhso_govname;
            this.nhso_docno = nhso_docno;
            this.nhso_ownright_pid = nhso_ownright_pid;
            this.nhso_ownright_name = nhso_ownright_name;
            this.update_datetime = update_datetime;
            this.emp_privilege = emp_privilege;
            this.emp_id = emp_id;
            this.pttype_service_charge = pttype_service_charge;
            this.pttype_note = pttype_note;
            this.auth_code = auth_code;
            this.rcpno_list = rcpno_list;
            this.project_code = project_code;
            this.depcode_service_charge = depcode_service_charge;
        }
    }
}
