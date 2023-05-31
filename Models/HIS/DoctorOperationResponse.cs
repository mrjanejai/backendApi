namespace WebApi.Models.HIS
{
    public class DoctorOperationResponse
    {
        public int doctor_operation_id { get; set; }
        public string vn { get; set; }
        public int er_oper_code { get; set; }
        public string doctor { get; set; }
        public DateTime begin_date_time { get; set; }
        public DateTime end_date_time { get; set; }
        public string icd9 { get; set; }
        public double price { get; set; }
        public string sflag { get; set; }
        public string opi_guid { get; set; }
        public int ovst_diag_id { get; set; }
        public string depcode { get; set; }
        public int er_oper_code_area_id { get; set; }
        public string hos_guid { get; set; }
        public string staff { get; set; }
        public DateTime update_datetime { get; set; }
        public string order_doctor_code { get; set; }
        public string operation_detail_text { get; set; }
        public int doctor_investigation_report_id { get; set; }
        public string hos_guid_ext { get; set; }

        public DoctorOperationResponse() { }

        public DoctorOperationResponse(int doctor_operation_id, string vn, int er_oper_code, string doctor, DateTime begin_date_time, DateTime end_date_time, string icd9, double price, string sflag, string opi_guid, int ovst_diag_id, string depcode, int er_oper_code_area_id, string hos_guid, string staff, DateTime update_datetime, string order_doctor_code, string operation_detail_text, int doctor_investigation_report_id, string hos_guid_ext)
        {
            this.doctor_operation_id = doctor_operation_id;
            this.vn = vn;
            this.er_oper_code = er_oper_code;
            this.doctor = doctor;
            this.begin_date_time = begin_date_time;
            this.end_date_time = end_date_time;
            this.icd9 = icd9;
            this.price = price;
            this.sflag = sflag;
            this.opi_guid = opi_guid;
            this.ovst_diag_id = ovst_diag_id;
            this.depcode = depcode;
            this.er_oper_code_area_id = er_oper_code_area_id;
            this.hos_guid = hos_guid;
            this.staff = staff;
            this.update_datetime = update_datetime;
            this.order_doctor_code = order_doctor_code;
            this.operation_detail_text = operation_detail_text;
            this.doctor_investigation_report_id = doctor_investigation_report_id;
            this.hos_guid_ext = hos_guid_ext;
        }
    }
}
