namespace WebApi.Models.HIS
{
    public class IptDoctorDiagResponse
    {
        public int ipt_doctor_diag_id { get; set; }
        public string an { get; set; }
        public string doctor_code { get; set; }
        public string diag_text { get; set; }
        public DateTime diag_datetime { get; set; }
        public int ovst_doctor_diag_st_id { get; set; }
        public string diagtype { get; set; }
        public string final_diag { get; set; }
        public string audit_ok { get; set; }
        public DateTime audit_datetime { get; set; }
        public string audit_doctor_code { get; set; }
        public string audit_diag_text { get; set; }
        public string audit_diagtype { get; set; }
        public string inspect_doctor_code { get; set; }

        public IptDoctorDiagResponse() { }

        public IptDoctorDiagResponse(int ipt_doctor_diag_id, string an, string doctor_code, string diag_text, DateTime diag_datetime, int ovst_doctor_diag_st_id, string diagtype, string final_diag, string audit_ok, DateTime audit_datetime, string audit_doctor_code, string audit_diag_text, string audit_diagtype, string inspect_doctor_code)
        {
            this.ipt_doctor_diag_id = ipt_doctor_diag_id;
            this.an = an;
            this.doctor_code = doctor_code;
            this.diag_text = diag_text;
            this.diag_datetime = diag_datetime;
            this.ovst_doctor_diag_st_id = ovst_doctor_diag_st_id;
            this.diagtype = diagtype;
            this.final_diag = final_diag;
            this.audit_ok = audit_ok;
            this.audit_datetime = audit_datetime;
            this.audit_doctor_code = audit_doctor_code;
            this.audit_diag_text = audit_diag_text;
            this.audit_diagtype = audit_diagtype;
            this.inspect_doctor_code = inspect_doctor_code;
        }
    }
}
