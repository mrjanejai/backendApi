﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class ipt
    {
        [Key]
        public string an { get; set; }
        public string? admdoctor { get; set; }
        public DateTime? dchdate { get; set; }
        public string? dchstts { get; set; }
        public TimeSpan? dchtime { get; set; }
        public string? dchtype { get; set; }
        public string? dthdiagdct { get; set; }
        public string? hn { get; set; }
        public string? ivstist { get; set; }
        public string? ivstost { get; set; }
        public byte? lockdx { get; set; }
        public string? prediag { get; set; }
        public string? pttype { get; set; }
        public DateTime? regdate { get; set; }
        public TimeSpan? regtime { get; set; }
        public string? rfrics { get; set; }
        public string? rfrilct { get; set; }
        public string? rfrocs { get; set; }
        public string? rfrolct { get; set; }
        public string? spclty { get; set; }
        public string? vn { get; set; }
        public string? ward { get; set; }
        public string? rcpt_disease { get; set; }
        public string? dch_doctor { get; set; }
        public byte? ipt_type { get; set; }
        public string? iref_type { get; set; }
        public int? ipacc { get; set; }
        public double? act_money_limit { get; set; }
        public string? drg { get; set; }
        public string? mdc { get; set; }
        public double? rw { get; set; }
        public double? wtlos { get; set; }
        public int? ot { get; set; }
        public string? result { get; set; }
        public byte? gravidity { get; set; }
        public byte? parity { get; set; }
        public byte? living_children { get; set; }
        public string? rxdoctor { get; set; }
        public string? staff { get; set; }
        public int? bw { get; set; }
        public string? first_ward { get; set; }
        public string? refer_out_number { get; set; }
        public string? incharge_doctor { get; set; }
        public string? an_guid { get; set; }
        public string? an_lock { get; set; }
        public string? ergent { get; set; }
        public string? chart_state { get; set; }
        public DateTime? receive_chart_date_time { get; set; }
        public string? receive_chart_staff { get; set; }
        public string? receive_chart_note { get; set; }
        public double? adjrw { get; set; }
        public string? ipt_spclty { get; set; }
        public string? finance_lock { get; set; }
        public DateTime? last_check_autoincome { get; set; }
        public string? admit_fee_guid { get; set; }
        public int? leave_home_day { get; set; }
        public string? operation_status { get; set; }
        public DateTime? finance_summary_date { get; set; }
        public DateTime? estimate_discharge_date { get; set; }
        public string? old_cause_revisit { get; set; }
        public string? finance_transfer { get; set; }
        public string? provision_dx { get; set; }
        public int? dw_hhc_list_id { get; set; }
        public string? hos_guid { get; set; }
        public string? hos_guid_ext { get; set; }
        public int? body_height { get; set; }
        public DateTime? update_datetime { get; set; }
        public string? cur_dep_code { get; set; }
        public int? finance_status_flag { get; set; }
        public int? ipt_admit_type_id { get; set; }
        public string? no_visit { get; set; }
        public string? no_food { get; set; }
        public string? confirm_discharge { get; set; }
        public string? lab_status { get; set; }
        public string? xray_status { get; set; }
        public string? grouper_version { get; set; }
        public int? grouper_err { get; set; }
        public int? grouper_warn { get; set; }
        public int? grouper_actlos { get; set; }
        public double? auto_charge_amount { get; set; }
        public string? provision_dx_icd { get; set; }
        public int? ipt_cause_type_id { get; set; }
        public int? ipt_severe_type_id { get; set; }
        public string? ipt_cause_type_note { get; set; }
        public string? followup { get; set; }
        public int? dch_severe_type_id { get; set; }
        public double? opd_finance_wait_tr { get; set; }
        public string? home_leave_status { get; set; }
        public double? grouper_adjrw_price { get; set; }
        public double? reimburse_price { get; set; }
        public string? oldcode { get; set; }
        public string? data_ok { get; set; }
        public DateTime? data_exp_date { get; set; }
        public int? ipt_summary_status_id { get; set; }
        public string? no_charge_room { get; set; }
        public string? rx_home_med { get; set; }
        public string? hhc_hospcode { get; set; }
        public int? operation_status_id { get; set; }
        public string? ipd_nurse_eval_range_code { get; set; }
    }
}