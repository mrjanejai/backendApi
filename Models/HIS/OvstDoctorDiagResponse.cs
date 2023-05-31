namespace WebApi.Models.HIS
{
    public class OvstDoctorDiagResponse
    {
        public int ovst_doctor_diag_id { get; set; }
        public string vn { get; set; }
        public string doctor_code { get; set; }
        public string diag_text { get; set; }
        public DateTime diag_datetime { get; set; }
        public int ovst_doctor_diag_st_id { get; set; }
        public string sct_id { get; set; }
        public int hl7_condition_clinical_status_id { get; set; }
        public string body_structure_sct_id { get; set; }
        public string body_structure_sct_name { get; set; }
        public string severity_sct_id { get; set; }
        public string severity_sct_name { get; set; }

        public OvstDoctorDiagResponse() { }

        public OvstDoctorDiagResponse(int ovst_doctor_diag_id, string vn, string doctor_code, string diag_text, DateTime diag_datetime, int ovst_doctor_diag_st_id, string sct_id, int hl7_condition_clinical_status_id, string body_structure_sct_id, string body_structure_sct_name, string severity_sct_id, string severity_sct_name)
        {
            this.ovst_doctor_diag_id = ovst_doctor_diag_id;
            this.vn = vn;
            this.doctor_code = doctor_code;
            this.diag_text = diag_text;
            this.diag_datetime = diag_datetime;
            this.ovst_doctor_diag_st_id = ovst_doctor_diag_st_id;
            this.sct_id = sct_id;
            this.hl7_condition_clinical_status_id = hl7_condition_clinical_status_id;
            this.body_structure_sct_id = body_structure_sct_id;
            this.body_structure_sct_name = body_structure_sct_name;
            this.severity_sct_id = severity_sct_id;
            this.severity_sct_name = severity_sct_name;
        }
    }
}
