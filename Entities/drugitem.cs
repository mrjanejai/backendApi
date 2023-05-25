﻿namespace WebApi.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class drugitems
    {
        [Key]
        public string icode { get; set; }
        public string? name { get; set; }
        public string? strength { get; set; }
        public string? units { get; set; }
        public double? unitprice { get; set; }
        public string? dosageform { get; set; }
        public int? criticalpriority { get; set; }
        public string? drugaccount { get; set; }
        public string? drugcategory { get; set; }
        public string? drugnote { get; set; }
        public string? hintcode { get; set; }
        public string? istatus { get; set; }
        public DateTime? lastupdatestdprice { get; set; }
        public string? lockprice { get; set; }
        public string? lockprint { get; set; }
        public int? maxlevel { get; set; }
        public int? minlevel { get; set; }
        public int? maxunitperdose { get; set; }
        public int? packqty { get; set; }
        public int? reorderqty { get; set; }
        public double? stdprice { get; set; }
        public string? stdtaken { get; set; }
        public string? therapeutic { get; set; }
        public string? therapeuticgroup { get; set; }
        public int? default_qty { get; set; }
        public string? gpo_code { get; set; }
        public string? use_right { get; set; }
        public string? i_type { get; set; }
        public string? drugusage { get; set; }
        public string? high_cost { get; set; }
        public string? must_paid { get; set; }
        public byte? alert_level { get; set; }
        public byte? access_level { get; set; }
        public string? sticker_short_name { get; set; }
        public string? paidst { get; set; }
        public string? antibiotic { get; set; }
        public int? displaycolor { get; set; }
        public string? empty { get; set; }
        public string? empty_text { get; set; }
        public double? unitcost { get; set; }
        public string? gfmiscode { get; set; }
        public double? ipd_price { get; set; }
        public string? oldcode { get; set; }
        public string? habit_forming { get; set; }
        public string? did { get; set; }
        public string? stock_type { get; set; }
        public double? price2 { get; set; }
        public double? price3 { get; set; }
        public double? ipd_price2 { get; set; }
        public double? ipd_price3 { get; set; }
        public string? price_lock { get; set; }
        public string? pregnancy { get; set; }
        public int? pharmacology_group1 { get; set; }
        public int? pharmacology_group2 { get; set; }
        public int? pharmacology_group3 { get; set; }
        public string? generic_name { get; set; }
        public string? show_pregnancy_alert { get; set; }
        public string? icode_guid { get; set; }
        public string? na { get; set; }
        public string? invcode { get; set; }
        public string? check_user_group { get; set; }
        public string? check_user_name { get; set; }
        public string? show_notify { get; set; }
        public string? show_notify_text { get; set; }
        public string? income { get; set; }
        public string? print_sticker_pq { get; set; }
        public string? charge_service_opd { get; set; }
        public string? charge_service_ipd { get; set; }
        public string? ename { get; set; }
        public string? dose_type { get; set; }
        public int? habit_forming_type { get; set; }
        public string? no_discount { get; set; }
        public string? therapeutic_eng { get; set; }
        public string? hintcode_eng { get; set; }
        public string? limit_drugusage { get; set; }
        public string? print_sticker_header { get; set; }
        public string? calc_idr_qty { get; set; }
        public string? item_in_hospital { get; set; }
        public string? no_substock { get; set; }
        public int? volume_cc { get; set; }
        public string? usage_code { get; set; }
        public string? frequency_code { get; set; }
        public string? time_code { get; set; }
        public double? dispense_dose { get; set; }
        public string? usage_unit_code { get; set; }
        public double? dose_per_units { get; set; }
        public int? ipd_default_pay { get; set; }
        public string? billcode { get; set; }
        public string? billnumber { get; set; }
        public string? lockprint_ipd { get; set; }
        public string? pregnancy_notify_text { get; set; }
        public string? show_breast_feeding_alert { get; set; }
        public string? breast_feeding_alert_text { get; set; }
        public string? show_child_notify { get; set; }
        public string? child_notify_text { get; set; }
        public int? child_notify_min_age { get; set; }
        public int? child_notify_max_age { get; set; }
        public string? continuous { get; set; }
        public string? substitute_icode { get; set; }
        public string? trade_name { get; set; }
        public string? use_right_allow { get; set; }
        public int? medication_machine_id { get; set; }
        public int? ipd_medication_machine_id { get; set; }
        public string? check_remed_qty { get; set; }
        public string? addict { get; set; }
        public int? addict_type_id { get; set; }
        public int? medication_machine_opd_no { get; set; }
        public int? medication_machine_ipd_no { get; set; }
        public string? fp_drug { get; set; }
        public string? usage_code_ipd { get; set; }
        public double? dispense_dose_ipd { get; set; }
        public string? usage_unit_code_ipd { get; set; }
        public string? frequency_code_ipd { get; set; }
        public string? time_code_ipd { get; set; }
        public string? print_ipd_injection_sticker { get; set; }
        public string? provis_medication_unit_code { get; set; }
        public string? hos_guid { get; set; }
        public int? sks_product_category_id { get; set; }
        public int? sks_clain_control_type_id { get; set; }
        public string? sks_drug_code { get; set; }
        public string? sks_dfs_code { get; set; }
        public string? sks_dfs_text { get; set; }
        public double? sks_reimb_price { get; set; }
        public string? hos_guid_ext { get; set; }
        public string? check_druginteraction_history { get; set; }
        public int? check_druginteraction_history_day { get; set; }
        public int? nhso_adp_type_id { get; set; }
        public string? nhso_adp_code { get; set; }
        public int? sks_claim_control_type_id { get; set; }
        public DateTime? begin_date { get; set; }
        public DateTime? finish_date { get; set; }
        public string? name_pr { get; set; }
        public string? name_eng { get; set; }
        public string? capacity_name { get; set; }
        public string? finish_reason { get; set; }
        public double? extra_unitcost { get; set; }
        public int? drug_control_type_id { get; set; }
        public string? name_print { get; set; }
        public double? active_ingredient_mg { get; set; }
        public string? no_order_g6pd { get; set; }
        public string? gender_check { get; set; }
        public string? no_order_gender { get; set; }
        public int? max_qty { get; set; }
        public string? prefer_opd_usage_code { get; set; }
        public double? capacity_qty { get; set; }
        public string? need_order_reason { get; set; }
        public int? drugitems_due_type_id { get; set; }
        public int? drugeval_head_id { get; set; }
        public string? light_protect { get; set; }
        public string? tpu_code_list { get; set; }
        public string? inv_map_update { get; set; }
        public string? special_advice_text { get; set; }
        public string? precaution_advice_text { get; set; }
        public string? contra_advice_text { get; set; }
        public string? storage_advice_text { get; set; }
        public string? qr_code_url { get; set; }
        public double? vat_percent { get; set; }
        public string? acc_regist { get; set; }
        public string? use_paidst { get; set; }
        public string? thai_name { get; set; }
        public int? fwf_item_id { get; set; }
        public int? drugitems_em1_id { get; set; }
        public int? drugitems_em2_id { get; set; }
        public int? drugitems_em3_id { get; set; }
        public int? drugitems_em4_id { get; set; }
        public string? tmt_tp_code { get; set; }
        public string? tmt_gp_code { get; set; }
        public string? limit_pttype { get; set; }
        public string? noshow_narcotic { get; set; }
        public string? medication_machine_flag { get; set; }
        public double? sks_price { get; set; }
        public string? print_sticker_by_frequency { get; set; }
        public string? print_sticker_pq_ipd { get; set; }
        public string? sub_income { get; set; }
        public string? prefer_ipd_usage_code { get; set; }
        public int? default_qty_ipd { get; set; }
        public int? max_qty_ipd { get; set; }
        public string? drugusage_ipd { get; set; }
        public string? no_popup_ipd_reason { get; set; }
        public string? specprep { get; set; }
        public int? med_dose_calc_type_id { get; set; }
        public string? send_line_notify { get; set; }
        public string? show_qrcode_trade { get; set; }
        public string? warn_g6pd { get; set; }
        public int? ipd_rx_freq_day { get; set; }
        public int? displaycolor_focus { get; set; }
        public DateTime? last_update { get; set; }
        public string? no_remed { get; set; }
        public string? force_round_qty { get; set; }
        public string? atc_code { get; set; }
        public int? state_item_id { get; set; }
        public string? multiply_charge_service { get; set; }
        public string? csmbs_claim_cat { get; set; }
        public string? simb_2005 { get; set; }
        public DateTime? sks_rev_date { get; set; }
        public string? sct_unit_code { get; set; }
        public string? print_label { get; set; }
    }
}
