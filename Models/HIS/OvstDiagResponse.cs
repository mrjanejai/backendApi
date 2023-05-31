namespace WebApi.Models.HIS
{
    public class OvstDiagResponse
    {
        public int ovst_diag_id { get; set; }
        public string vn { get; set; }
        public string icd10 { get; set; }
        public string hn { get; set; }
        public DateTime vstdate { get; set; }
        public TimeSpan vsttime { get; set; }
        public string diagtype { get; set; }
        public string icd103 { get; set; }
        public string hcode { get; set; }
        public string doctor { get; set; }
        public byte episode { get; set; }
        public string ext_code { get; set; }
        public string hos_guid { get; set; }
        public string dep_flag { get; set; }
        public int ovst_oper_type { get; set; }
        public string staff { get; set; }
        public string dx_guid { get; set; }
        public string lock_dx { get; set; }
        public string dx_code_note { get; set; }
        public int ovstdiag_severe_type_id { get; set; }
        public int diag_no { get; set; }
        public DateTime update_datetime { get; set; }
        public string confirm { get; set; }
        public string confirm_staff { get; set; }
        public string opi_guid { get; set; }
        public string sct_id { get; set; }

        public OvstDiagResponse()
        {
        }

        public OvstDiagResponse(int ovst_diag_id, string vn, string icd10, string hn, DateTime vstdate, TimeSpan vsttime, string diagtype, string icd103, string hcode, string doctor, byte episode, string ext_code, string hos_guid, string dep_flag, int ovst_oper_type, string staff, string dx_guid, string lock_dx, string dx_code_note, int ovstdiag_severe_type_id, int diag_no, DateTime update_datetime, string confirm, string confirm_staff, string opi_guid, string sct_id)
        {
            this.ovst_diag_id = ovst_diag_id;
            this.vn = vn;
            this.icd10 = icd10;
            this.hn = hn;
            this.vstdate = vstdate;
            this.vsttime = vsttime;
            this.diagtype = diagtype;
            this.icd103 = icd103;
            this.hcode = hcode;
            this.doctor = doctor;
            this.episode = episode;
            this.ext_code = ext_code;
            this.hos_guid = hos_guid;
            this.dep_flag = dep_flag;
            this.ovst_oper_type = ovst_oper_type;
            this.staff = staff;
            this.dx_guid = dx_guid;
            this.lock_dx = lock_dx;
            this.dx_code_note = dx_code_note;
            this.ovstdiag_severe_type_id = ovstdiag_severe_type_id;
            this.diag_no = diag_no;
            this.update_datetime = update_datetime;
            this.confirm = confirm;
            this.confirm_staff = confirm_staff;
            this.opi_guid = opi_guid;
            this.sct_id = sct_id;
        }
    }
}
