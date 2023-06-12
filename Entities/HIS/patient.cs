﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class patient
    {
        [Key]
        public string hos_guid { get; set; }
        public string hn { get; set; }
        public string? pname { get; set; }
        public string? fname { get; set; }
        public string? lname { get; set; }
        public string? occupation { get; set; }
        public string? citizenship { get; set; }
        public DateTime? birthday { get; set; }
        public string? addrpart { get; set; }
        public string? moopart { get; set; }
        public string? tmbpart { get; set; }
        public string? amppart { get; set; }
        public string? chwpart { get; set; }
        public string? bloodgrp { get; set; }
        public string? clinic { get; set; }
        public DateTime? deathday { get; set; }
        public string? drugallergy { get; set; }
        public int? familyno { get; set; }
        public string? fathername { get; set; }
        public DateTime? firstday { get; set; }
        public string? hometel { get; set; }
        public string? informaddr { get; set; }
        public string? informname { get; set; }
        public string? informrelation { get; set; }
        public string? informtel { get; set; }
        public string? marrystatus { get; set; }
        public string? mathername { get; set; }
        public int? hn_int { get; set; }
        public string? nationality { get; set; }
        public string? opdlocation { get; set; }
        public string? pttype { get; set; }
        public string? religion { get; set; }
        public string? sex { get; set; }
        public string? spsname { get; set; }
        public string? truebirthday { get; set; }
        public string? workaddr { get; set; }
        public string? worktel { get; set; }
        public string? hcode { get; set; }
        public string? cid { get; set; }
        public int? hid { get; set; }
        public string? educate { get; set; }
        public string? family_status { get; set; }
        public string? labor_type { get; set; }
        public DateTime? last_update { get; set; }
        public string? type_area { get; set; }
        public string? road { get; set; }
        public string? father_cid { get; set; }
        public string? mother_cid { get; set; }
        public string? couple_cid { get; set; }
        public string? person_type { get; set; }
        public string? private_doctor_name { get; set; }
        public string? legal_action { get; set; }
        public string? death_code504 { get; set; }
        public string? death_diag { get; set; }
        public string? node_id { get; set; }
        public string? admit { get; set; }
        public string? midname { get; set; }
        public string? po_code { get; set; }
        public string? fatherlname { get; set; }
        public string? motherlname { get; set; }
        public string? spslname { get; set; }
        public string? country { get; set; }
        public string? email { get; set; }
        public TimeSpan? birthtime { get; set; }
        public string? mother_hn { get; set; }
        public DateTime? last_visit { get; set; }
        public string? death { get; set; }
        public int? height { get; set; }
        public string? inregion { get; set; }
        public TimeSpan? reg_time { get; set; }
        public string? oldcode { get; set; }
        public string? lang { get; set; }
        public string? gov_chronic_id { get; set; }
        public string? in_cups { get; set; }
        public byte? patient_type_id { get; set; }
        public string? addr_soi { get; set; }
        public string? work_addr { get; set; }
        public string? father_hn { get; set; }
        public string? alias_name { get; set; }
        public string? destroyed { get; set; }
        public string? old_addr { get; set; }
        public string? fname_soundex { get; set; }
        public string? lname_soundex { get; set; }
        public string? bloodgroup_rh { get; set; }
        public string? passport_no { get; set; }
        public string? addressid { get; set; }
        public string? mobile_phone_number { get; set; }
        public string? anonymous_person { get; set; }
        public int? hospital_department_id { get; set; }
        public string? membercard_no { get; set; }
        public string? ec_fname { get; set; }
        public string? ec_lname { get; set; }
        public int? ec_relation_type_id { get; set; }
        public int? patient_color_id { get; set; }
        public int? number_of_relatives { get; set; }
        public int? birth_order { get; set; }
        public int? person_labor_type_id { get; set; }
        public string? is_card_destroy { get; set; }
        public DateTime? card_destroy_date { get; set; }
        public string? g6pd { get; set; }
    }
}
