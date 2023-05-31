namespace WebApi.Models.HIS
{
    public class IptNurseOperResponse
    {
        public int nurse_oper_id { get; set; }
        public string an { get; set; }
        public int ipt_oper_code { get; set; }
        public string doctor { get; set; }
        public DateTime begin_date_time { get; set; }
        public DateTime end_date_time { get; set; }
        public int oper_qty { get; set; }
        public double oper_price { get; set; }
        public DateTime ref_date { get; set; }
        public string hos_guid { get; set; }
        public string opi_guid { get; set; }
        public string charge_opitemrece { get; set; }
        public DateTime entry_datetime { get; set; }
        public DateTime modify_datetime { get; set; }
        public string staff { get; set; }
        public int ref_date_int { get; set; }
        public double total_price { get; set; }
        public string oper_note { get; set; }
        public int doctor_investigation_report_id { get; set; }
        public int icd9_priority { get; set; }
        public int ipd_nurse_shift_id { get; set; }
        public DateTime oper_date { get; set; }
        public int ipd_nurse_note_time_id { get; set; }
        public int oper_date_unix { get; set; }

        public IptNurseOperResponse() { }

        public IptNurseOperResponse(int nurse_oper_id, string an, int ipt_oper_code, string doctor, DateTime begin_date_time, DateTime end_date_time, int oper_qty, double oper_price, DateTime ref_date, string hos_guid, string opi_guid, string charge_opitemrece, DateTime entry_datetime, DateTime modify_datetime, string staff, int ref_date_int, double total_price, string oper_note, int doctor_investigation_report_id, int icd9_priority, int ipd_nurse_shift_id, DateTime oper_date, int ipd_nurse_note_time_id, int oper_date_unix)
        {
            this.nurse_oper_id = nurse_oper_id;
            this.an = an;
            this.ipt_oper_code = ipt_oper_code;
            this.doctor = doctor;
            this.begin_date_time = begin_date_time;
            this.end_date_time = end_date_time;
            this.oper_qty = oper_qty;
            this.oper_price = oper_price;
            this.ref_date = ref_date;
            this.hos_guid = hos_guid;
            this.opi_guid = opi_guid;
            this.charge_opitemrece = charge_opitemrece;
            this.entry_datetime = entry_datetime;
            this.modify_datetime = modify_datetime;
            this.staff = staff;
            this.ref_date_int = ref_date_int;
            this.total_price = total_price;
            this.oper_note = oper_note;
            this.doctor_investigation_report_id = doctor_investigation_report_id;
            this.icd9_priority = icd9_priority;
            this.ipd_nurse_shift_id = ipd_nurse_shift_id;
            this.oper_date = oper_date;
            this.ipd_nurse_note_time_id = ipd_nurse_note_time_id;
            this.oper_date_unix = oper_date_unix;
        }
    }
}
