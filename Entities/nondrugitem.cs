﻿namespace WebApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    public class nondrugitem
    {
        [Key]
        public string icode { get; set; }
        public string? name { get; set; }
        public double? price { get; set; }
        public string? income { get; set; }
        public string? xrayfilm { get; set; }
        public string? icd9cm { get; set; }
        public string? iflag { get; set; }
        public int? vorder { get; set; }
        public string? note { get; set; }
        public string? use_right { get; set; }
        public string? i_type { get; set; }
        public string? must_paid { get; set; }
        public string? paidst { get; set; }
        public double? ipd_price { get; set; }
        public double? unitcost { get; set; }
        public string? organ_code { get; set; }
        public int? displaycolor { get; set; }
        public string? istatus { get; set; }
        public double? price3 { get; set; }
        public double? price2 { get; set; }
        public double? ipd_price2 { get; set; }
        public double? ipd_price3 { get; set; }
        public string? price_lock { get; set; }
        public string? unit { get; set; }
        public string? icode_guid { get; set; }
        public string? billcode { get; set; }
        public string? billnumber { get; set; }
        public string? detail { get; set; }
        public string? oldcode { get; set; }
        public string? ext_icode { get; set; }
        public string? charge_paidst { get; set; }
        public string? lockprint { get; set; }
        public string? rx_unique { get; set; }
        public string? item_is_df { get; set; }
        public int? df_type_id { get; set; }
        public int? item_subtype_id { get; set; }
        public string? ename { get; set; }
        public string? no_remed { get; set; }
        public string? remove_when_admit { get; set; }
        public double? df_percent { get; set; }
        public double? max_price { get; set; }
        public string? drugusage { get; set; }
        public string? no_ipd_transfer { get; set; }
        public string? no_discount { get; set; }
        public string? df_search_code { get; set; }
        public string? print_sticker_header { get; set; }
        public string? no_substock { get; set; }
        public int? ipd_default_pay { get; set; }
        public string? hospital_highcost_code { get; set; }
        public string? lockprint_ipd { get; set; }
        public string? enable_sks_opd { get; set; }
        public string? enable_sks_ipd { get; set; }
        public string? hos_guid { get; set; }
        public string? show_notify { get; set; }
        public string? show_notify_text { get; set; }
        public double? sks_coverage_price { get; set; }
        public int? sks_product_category_id { get; set; }
        public string? hos_guid_ext { get; set; }
        public int? nhso_adp_type_id { get; set; }
        public string? nhso_adp_code { get; set; }
        public double? extra_unitcost { get; set; }
        public string? property_text { get; set; }
        public string? objctive_text { get; set; }
        public double? vat_percent { get; set; }
        public string? use_paidst { get; set; }
        public string? inv_map_update { get; set; }
        public int? fwf_item_id { get; set; }
        public string? limit_pttype { get; set; }
        public string? sub_income { get; set; }
        public int? nondrugitems_type_id { get; set; }
        public string? ucef_code { get; set; }
        public string? lockprice { get; set; }
        public string? is_accm { get; set; }
        public string? is_food { get; set; }
        public int? displaycolor_focus { get; set; }
        public DateTime? last_update { get; set; }
        public string? charge_service_opd { get; set; }
        public string? charge_service_ipd { get; set; }
        public int? state_item_id { get; set; }
        public string? lock_pttype { get; set; }
        public string? lock_pttype_code { get; set; }
        public string? multiply_charge_service { get; set; }
        public string? csmbs_claim_cat { get; set; }
        public string? simb_2005 { get; set; }
        public int? default_qty { get; set; }
        public int? max_qty { get; set; }
        public DateTime? sks_rev_date { get; set; }
        public int? default_qty_ipd { get; set; }
        public int? max_qty_ipd { get; set; }
        public int? sks_claim_category_type_id { get; set; }
    }
