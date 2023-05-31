namespace WebApi.Models.HIS
{
    public class OvstResponse
    {
        public string hos_guid { get; set; }
        public string vn { get; set; }
        public string hn { get; set; }
        public string an { get; set; }
        public DateTime vstdate { get; set; }
        public TimeSpan vsttime { get; set; }
        public string doctor { get; set; }
        public string hospmain { get; set; }
        public string hospsub { get; set; }
        public int oqueue { get; set; }
        public string ovstist { get; set; }
        public string ovstost { get; set; }
        public string pttype { get; set; }
        public string pttypeno { get; set; }
        public string rfrics { get; set; }
        public string rfrilct { get; set; }
        public string rfrocs { get; set; }
        public string rfrolct { get; set; }
        public string spclty { get; set; }
        public string rcpt_disease { get; set; }
        public string hcode { get; set; }
        public string cur_dep { get; set; }
        public string cur_dep_busy { get; set; }
        public string last_dep { get; set; }
        public TimeSpan cur_dep_time { get; set; }
        public int rx_queue { get; set; }
        public string diag_text { get; set; }
        public byte pt_subtype { get; set; }
        public string main_dep { get; set; }
        public int main_dep_queue { get; set; }
        public DateTime finance_summary_date { get; set; }
        public string visit_type { get; set; }
        public string node_id { get; set; }
        public int contract_id { get; set; }
        public string waiting { get; set; }
        public string rfri_icd10 { get; set; }
        public int o_refer_number { get; set; }
        public string has_insurance { get; set; }
        public string i_refer_number { get; set; }
        public string refer_type { get; set; }
        public string o_refer_dep { get; set; }
        public string staff { get; set; }
        public string command_doctor { get; set; }
        public string send_person { get; set; }
        public int pt_priority { get; set; }
        public string finance_lock { get; set; }
        public string oldcode { get; set; }
        public string sign_doctor { get; set; }
        public string anonymous_visit { get; set; }
        public string anonymous_vn { get; set; }
        public int pt_capability_type_id { get; set; }
        public string at_hospital { get; set; }
        public string ovst_key { get; set; }

        public OvstResponse(string hos_guid,string vn, string hn, string an, DateTime vstdate, TimeSpan vsttime, string doctor, string hospmain, string hospsub, int oqueue, string ovstist, string ovstost, string pttype, string pttypeno, string rfrics, string rfrilct, string rfrocs, string rfrolct, string spclty, string rcpt_disease, string hcode, string cur_dep, string cur_dep_busy, string last_dep, TimeSpan cur_dep_time, int rx_queue, string diag_text, byte pt_subtype, string main_dep, int main_dep_queue, DateTime finance_summary_date, string visit_type, string node_id, int contract_id, string waiting, string rfri_icd10, int o_refer_number, string has_insurance, string i_refer_number, string refer_type, string o_refer_dep, string staff, string command_doctor, string send_person, int pt_priority, string finance_lock, string oldcode, string sign_doctor, string anonymous_visit, string anonymous_vn, int pt_capability_type_id, string at_hospital, string ovst_key)
        {
            this.hos_guid = hos_guid;
            this.vn = vn;
            this.hn = hn;
            this.an = an;
            this.vstdate = vstdate;
            this.vsttime = vsttime;
            this.doctor = doctor;
            this.hospmain = hospmain;
            this.hospsub = hospsub;
            this.oqueue = oqueue;
            this.ovstist = ovstist;
            this.ovstost = ovstost;
            this.pttype = pttype;
            this.pttypeno = pttypeno;
            this.rfrics = rfrics;
            this.rfrilct = rfrilct;
            this.rfrocs = rfrocs;
            this.rfrolct = rfrolct;
            this.spclty = spclty;
            this.rcpt_disease = rcpt_disease;
            this.hcode = hcode;
            this.cur_dep = cur_dep;
            this.cur_dep_busy = cur_dep_busy;
            this.last_dep = last_dep;
            this.cur_dep_time = cur_dep_time;
            this.rx_queue = rx_queue;
            this.diag_text = diag_text;
            this.pt_subtype = pt_subtype;
            this.main_dep = main_dep;
            this.main_dep_queue = main_dep_queue;
            this.finance_summary_date = finance_summary_date;
            this.visit_type = visit_type;
            this.node_id = node_id;
            this.contract_id = contract_id;
            this.waiting = waiting;
            this.rfri_icd10 = rfri_icd10;
            this.o_refer_number = o_refer_number;
            this.has_insurance = has_insurance;
            this.i_refer_number = i_refer_number;
            this.refer_type = refer_type;
            this.o_refer_dep = o_refer_dep;
            this.staff = staff;
            this.command_doctor = command_doctor;
            this.send_person = send_person;
            this.pt_priority = pt_priority;
            this.finance_lock = finance_lock;
            this.oldcode = oldcode;
            this.sign_doctor = sign_doctor;
            this.anonymous_visit = anonymous_visit;
            this.anonymous_vn = anonymous_vn;
            this.pt_capability_type_id = pt_capability_type_id;
            this.at_hospital = at_hospital;
            this.ovst_key = ovst_key;
        }
    }
}
