namespace WebApi.Models.HIS
{
    public class IptResponse
    {
        public string an { get; set; }
        public string admdoctor { get; set; }
        public DateTime dchdate { get; set; }
        public string dchstts { get; set; }
        public TimeSpan dchtime { get; set; }
        public string dchtype { get; set; }
        public string dthdiagdct { get; set; }
        public string hn { get; set; }
        public string ivstist { get; set; }
        public string ivstost { get; set; }
        public byte lockdx { get; set; }
        public string prediag { get; set; }
        public string pttype { get; set; }
        public DateTime regdate { get; set; }
        public TimeSpan regtime { get; set; }
        public string rfrics { get; set; }
        public string rfrilct { get; set; }
        public string rfrocs { get; set; }
        public string rfrolct { get; set; }
        public string spclty { get; set; }
        public string vn { get; set; }
        public string ward { get; set; }
        public string rcpt_disease { get; set; }
        public string dch_doctor { get; set; }
        public byte ipt_type { get; set; }
        public string iref_type { get; set; }
        public int ipacc { get; set; }
        public double act_money_limit { get; set; }
        public string drg { get; set; }
        public string mdc { get; set; }
        public double rw { get; set; }
        public double wtlos { get; set; }
        public int ot { get; set; }
        public string result { get; set; }
        public byte gravidity { get; set; }
        public byte parity { get; set; }
        public byte living_children { get; set; }
        public string rxdoctor { get; set; }
        public string staff { get; set; }
        public int bw { get; set; }
        public string first_ward { get; set; }
        public string refer_out_number { get; set; }
        public string incharge_doctor { get; set; }
        public string an_guid { get; set; }
        public string an_lock { get; set; }
        public string ergent { get; set; }
        public string chart_state { get; set; }
        public DateTime receive_chart_date_time { get; set; }
        public string receive_chart_staff { get; set; }
        public string receive_chart_note { get; set; }
        public double adjrw { get; set; }
        public string ipt_spclty { get; set; }
        public string finance_lock { get; set; }
        public DateTime last_check_autoincome { get; set; }
        public string admit_fee_guid { get; set; }
        public int leave_home_day { get; set; }
        public string operation_status { get; set; }
        public DateTime finance_summary_date { get; set; }
        public DateTime estimate_discharge_date { get; set; }
        public string old_cause_revisit { get; set; }
        public string finance_transfer { get; set; }
        public string provision_dx { get; set; }
        public int dw_hhc_list_id { get; set; }
        public string hos_guid { get; set; }
        public string hos_guid_ext { get; set; }
        public int body_height { get; set; }
        public DateTime update_datetime { get; set; }
        public string cur_dep_code { get; set; }
        public int finance_status_flag { get; set; }
        public int ipt_admit_type_id { get; set; }
        public string no_visit { get; set; }
        public string no_food { get; set; }
        public string confirm_discharge { get; set; }
        public string lab_status { get; set; }
        public string xray_status { get; set; }
        public string grouper_version { get; set; }
        public int grouper_err { get; set; }
        public int grouper_warn { get; set; }
        public int grouper_actlos { get; set; }
        public double auto_charge_amount { get; set; }
        public string provision_dx_icd { get; set; }
        public int ipt_cause_type_id { get; set; }
        public int ipt_severe_type_id { get; set; }
        public string ipt_cause_type_note { get; set; }
        public string followup { get; set; }
        public int dch_severe_type_id { get; set; }
        public double opd_finance_wait_tr { get; set; }
        public string home_leave_status { get; set; }
        public double grouper_adjrw_price { get; set; }
        public double reimburse_price { get; set; }
        public string oldcode { get; set; }
        public string data_ok { get; set; }
        public DateTime data_exp_date { get; set; }
        public int ipt_summary_status_id { get; set; }
        public string no_charge_room { get; set; }
        public string rx_home_med { get; set; }
        public string hhc_hospcode { get; set; }
        public int operation_status_id { get; set; }
        public string ipd_nurse_eval_range_code { get; set; }

        public IptResponse() { }

        public IptResponse(string an, string admdoctor, DateTime dchdate, string dchstts, TimeSpan dchtime, string dchtype, string dthdiagdct, string hn, string ivstist, string ivstost, byte lockdx, string prediag, string pttype, DateTime regdate, TimeSpan regtime, string rfrics, string rfrilct, string rfrocs, string rfrolct, string spclty, string vn, string ward, string rcpt_disease, string dch_doctor, byte ipt_type, string iref_type, int ipacc, double act_money_limit, string drg, string mdc, double rw, double wtlos, int ot, string result, byte gravidity, byte parity, byte living_children, string rxdoctor, string staff, int bw, string first_ward, string refer_out_number, string incharge_doctor, string an_guid, string an_lock, string ergent, string chart_state, DateTime receive_chart_date_time, string receive_chart_staff, string receive_chart_note, double adjrw, string ipt_spclty, string finance_lock, DateTime last_check_autoincome, string admit_fee_guid, int leave_home_day, string operation_status, DateTime finance_summary_date, DateTime estimate_discharge_date, string old_cause_revisit, string finance_transfer, string provision_dx, int dw_hhc_list_id, string hos_guid, string hos_guid_ext, int body_height, DateTime update_datetime, string cur_dep_code, int finance_status_flag, int ipt_admit_type_id, string no_visit, string no_food, string confirm_discharge, string lab_status, string xray_status, string grouper_version, int grouper_err, int grouper_warn, int grouper_actlos, double auto_charge_amount, string provision_dx_icd, int ipt_cause_type_id, int ipt_severe_type_id, string ipt_cause_type_note, string followup, int dch_severe_type_id, double opd_finance_wait_tr, string home_leave_status, double grouper_adjrw_price, double reimburse_price, string oldcode, string data_ok, DateTime data_exp_date, int ipt_summary_status_id, string no_charge_room, string rx_home_med, string hhc_hospcode, int operation_status_id, string ipd_nurse_eval_range_code)
        {
            this.an = an;
            this.admdoctor = admdoctor;
            this.dchdate = dchdate;
            this.dchstts = dchstts;
            this.dchtime = dchtime;
            this.dchtype = dchtype;
            this.dthdiagdct = dthdiagdct;
            this.hn = hn;
            this.ivstist = ivstist;
            this.ivstost = ivstost;
            this.lockdx = lockdx;
            this.prediag = prediag;
            this.pttype = pttype;
            this.regdate = regdate;
            this.regtime = regtime;
            this.rfrics = rfrics;
            this.rfrilct = rfrilct;
            this.rfrocs = rfrocs;
            this.rfrolct = rfrolct;
            this.spclty = spclty;
            this.vn = vn;
            this.ward = ward;
            this.rcpt_disease = rcpt_disease;
            this.dch_doctor = dch_doctor;
            this.ipt_type = ipt_type;
            this.iref_type = iref_type;
            this.ipacc = ipacc;
            this.act_money_limit = act_money_limit;
            this.drg = drg;
            this.mdc = mdc;
            this.rw = rw;
            this.wtlos = wtlos;
            this.ot = ot;
            this.result = result;
            this.gravidity = gravidity;
            this.parity = parity;
            this.living_children = living_children;
            this.rxdoctor = rxdoctor;
            this.staff = staff;
            this.bw = bw;
            this.first_ward = first_ward;
            this.refer_out_number = refer_out_number;
            this.incharge_doctor = incharge_doctor;
            this.an_guid = an_guid;
            this.an_lock = an_lock;
            this.ergent = ergent;
            this.chart_state = chart_state;
            this.receive_chart_date_time = receive_chart_date_time;
            this.receive_chart_staff = receive_chart_staff;
            this.receive_chart_note = receive_chart_note;
            this.adjrw = adjrw;
            this.ipt_spclty = ipt_spclty;
            this.finance_lock = finance_lock;
            this.last_check_autoincome = last_check_autoincome;
            this.admit_fee_guid = admit_fee_guid;
            this.leave_home_day = leave_home_day;
            this.operation_status = operation_status;
            this.finance_summary_date = finance_summary_date;
            this.estimate_discharge_date = estimate_discharge_date;
            this.old_cause_revisit = old_cause_revisit;
            this.finance_transfer = finance_transfer;
            this.provision_dx = provision_dx;
            this.dw_hhc_list_id = dw_hhc_list_id;
            this.hos_guid = hos_guid;
            this.hos_guid_ext = hos_guid_ext;
            this.body_height = body_height;
            this.update_datetime = update_datetime;
            this.cur_dep_code = cur_dep_code;
            this.finance_status_flag = finance_status_flag;
            this.ipt_admit_type_id = ipt_admit_type_id;
            this.no_visit = no_visit;
            this.no_food = no_food;
            this.confirm_discharge = confirm_discharge;
            this.lab_status = lab_status;
            this.xray_status = xray_status;
            this.grouper_version = grouper_version;
            this.grouper_err = grouper_err;
            this.grouper_warn = grouper_warn;
            this.grouper_actlos = grouper_actlos;
            this.auto_charge_amount = auto_charge_amount;
            this.provision_dx_icd = provision_dx_icd;
            this.ipt_cause_type_id = ipt_cause_type_id;
            this.ipt_severe_type_id = ipt_severe_type_id;
            this.ipt_cause_type_note = ipt_cause_type_note;
            this.followup = followup;
            this.dch_severe_type_id = dch_severe_type_id;
            this.opd_finance_wait_tr = opd_finance_wait_tr;
            this.home_leave_status = home_leave_status;
            this.grouper_adjrw_price = grouper_adjrw_price;
            this.reimburse_price = reimburse_price;
            this.oldcode = oldcode;
            this.data_ok = data_ok;
            this.data_exp_date = data_exp_date;
            this.ipt_summary_status_id = ipt_summary_status_id;
            this.no_charge_room = no_charge_room;
            this.rx_home_med = rx_home_med;
            this.hhc_hospcode = hhc_hospcode;
            this.operation_status_id = operation_status_id;
            this.ipd_nurse_eval_range_code = ipd_nurse_eval_range_code;
        }
    }
}
