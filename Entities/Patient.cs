namespace WebApi.Entities;
using System.Text.Json.Serialization;

public class patient
{
    private string _hos_guid;
    public string hos_guid
    {
        get { return _hos_guid; }
        set { _hos_guid = value; }
    }

    private string _hn;
    public string hn
    {
        get { return _hn; }
        set { _hn = value; }
    }

    private string? _pname;
    public string? pname
    {
        get { return _pname; }
        set { _pname = value; }
    }

    private string? _fname;
    public string? fname
    {
        get { return _fname; }
        set { _fname = value; }
    }

    private string? _lname;
    public string? lname
    {
        get { return _lname; }
        set { _lname = value; }
    }

    private string? _occupation;
    public string? occupation
    {
        get { return _occupation; }
        set { _occupation = value; }
    }

    private string? _citizenship;
    public string? citizenship
    {
        get { return _citizenship; }
        set { _citizenship = value; }
    }

    private DateTime? _birthday;
    public DateTime? birthday
    {
        get { return _birthday; }
        set { _birthday = value; }
    }

    private string? _addrpart;
    public string? addrpart
    {
        get { return _addrpart; }
        set { _addrpart = value; }
    }

    private string? _moopart;
    public string? moopart
    {
        get { return _moopart; }
        set { _moopart = value; }
    }

    private string? _tmbpart;
    public string? tmbpart
    {
        get { return _tmbpart; }
        set { _tmbpart = value; }
    }

    private string? _amppart;
    public string? amppart
    {
        get { return _amppart; }
        set { _amppart = value; }
    }

    private string? _chwpart;
    public string? chwpart
    {
        get { return _chwpart; }
        set { _chwpart = value; }
    }

    private string? _bloodgrp;
    public string? bloodgrp
    {
        get { return _bloodgrp; }
        set { _bloodgrp = value; }
    }

    private string? _clinic;
    public string? clinic
    {
        get { return _clinic; }
        set { _clinic = value; }
    }

    private DateTime? _deathday;
    public DateTime? deathday
    {
        get { return _deathday; }
        set { _deathday = value; }
    }

    private string? _drugallergy;
    public string? drugallergy
    {
        get { return _drugallergy; }
        set { _drugallergy = value; }
    }

    private int? _familyno;
    public int? familyno
    {
        get { return _familyno; }
        set { _familyno = value; }
    }

    private string? _fathername;
    public string? fathername
    {
        get { return _fathername; }
        set { _fathername = value; }
    }

    private DateTime? _firstday;
    public DateTime? firstday
    {
        get { return _firstday; }
        set { _firstday = value; }
    }

    private string? _hometel;
    public string? hometel
    {
        get { return _hometel; }
        set { _hometel = value; }
    }

    private string? _informaddr;
    public string? informaddr
    {
        get { return _informaddr; }
        set { _informaddr = value; }
    }

    private string? _informname;
    public string? informname
    {
        get { return _informname; }
        set { _informname = value; }
    }

    private string? _informrelation;
    public string? informrelation
    {
        get { return _informrelation; }
        set { _informrelation = value; }
    }

    private string? _informtel;
    public string? informtel
    {
        get { return _informtel; }
        set { _informtel = value; }
    }

    private string? _marrystatus;
    public string? marrystatus
    {
        get { return _marrystatus; }
        set { _marrystatus = value; }
    }

    private string? _mathername;
    public string? mathername
    {
        get { return _mathername; }
        set { _mathername = value; }
    }

    private int? _hn_int;
    public int? hn_int
    {
        get { return _hn_int; }
        set { _hn_int = value; }
    }

    private string? _nationality;
    public string? nationality
    {
        get { return _nationality; }
        set { _nationality = value; }
    }

    private string? _opdlocation;
    public string? opdlocation
    {
        get { return _opdlocation; }
        set { _opdlocation = value; }
    }

    private string? _pttype;
    public string? pttype
    {
        get { return _pttype; }
        set { _pttype = value; }
    }

    private string? _religion;
    public string? religion
    {
        get { return _religion; }
        set { _religion = value; }
    }

    private string? _sex;
    public string? sex
    {
        get { return _sex; }
        set { _sex = value; }
    }

    private string? _spsname;
    public string? spsname
    {
        get { return _spsname; }
        set { _spsname = value; }
    }

    private string? _truebirthday;
    public string? truebirthday
    {
        get { return _truebirthday; }
        set { _truebirthday = value; }
    }

    private string? _workaddr;
    public string? workaddr
    {
        get { return _workaddr; }
        set { _workaddr = value; }
    }

    private string? _worktel;
    public string? worktel
    {
        get { return _worktel; }
        set { _worktel = value; }
    }

    private string? _hcode;
    public string? hcode
    {
        get { return _hcode; }
        set { _hcode = value; }
    }

    private string? _cid;
    public string? cid
    {
        get { return _cid; }
        set { _cid = value; }
    }

    private int? _hid;
    public int? hid
    {
        get { return _hid; }
        set { _hid = value; }
    }

    private string? _educate;
    public string? educate
    {
        get { return _educate; }
        set { _educate = value; }
    }

    private string? _family_status;
    public string? family_status
    {
        get { return _family_status; }
        set { _family_status = value; }
    }

    private string? _labor_type;
    public string? labor_type
    {
        get { return _labor_type; }
        set { _labor_type = value; }
    }

    private DateTime? _last_update;
    public DateTime? last_update
    {
        get { return _last_update; }
        set { _last_update = value; }
    }

    private string? _type_area;
    public string? type_area
    {
        get { return _type_area; }
        set { _type_area = value; }
    }

    private string? _road;
    public string? road
    {
        get { return _road; }
        set { _road = value; }
    }

    private string? _father_cid;
    public string? father_cid
    {
        get { return _father_cid; }
        set { _father_cid = value; }
    }

    private string? _mother_cid;
    public string? mother_cid
    {
        get { return _mother_cid; }
        set { _mother_cid = value; }
    }

    private string? _couple_cid;
    public string? couple_cid
    {
        get { return _couple_cid; }
        set { _couple_cid = value; }
    }

    private string? _person_type;
    public string? person_type
    {
        get { return _person_type; }
        set { _person_type = value; }
    }

    private string? _private_doctor_name;
    public string? private_doctor_name
    {
        get { return _private_doctor_name; }
        set { _private_doctor_name = value; }
    }

    private string? _legal_action;
    public string? legal_action
    {
        get { return _legal_action; }
        set { _legal_action = value; }
    }

    private string? _death_code504;
    public string? death_code504
    {
        get { return _death_code504; }
        set { _death_code504 = value; }
    }

    private string? _death_diag;
    public string? death_diag
    {
        get { return _death_diag; }
        set { _death_diag = value; }
    }

    private string? _node_id;
    public string? node_id
    {
        get { return _node_id; }
        set { _node_id = value; }
    }

    private string? _admit;
    public string? admit
    {
        get { return _admit; }
        set { _admit = value; }
    }

    private string? _midname;
    public string? midname
    {
        get { return _midname; }
        set { _midname = value; }
    }

    private string? _po_code;
    public string? po_code
    {
        get { return _po_code; }
        set { _po_code = value; }
    }

    private string? _fatherlname;
    public string? fatherlname
    {
        get { return _fatherlname; }
        set { _fatherlname = value; }
    }

    private string? _motherlname;
    public string? motherlname
    {
        get { return _motherlname; }
        set { _motherlname = value; }
    }

    private string? _spslname;
    public string? spslname
    {
        get { return _spslname; }
        set { _spslname = value; }
    }

    private string? _country;
    public string? country
    {
        get { return _country; }
        set { _country = value; }
    }

    private string? _email;
    public string? email
    {
        get { return _email; }
        set { _email = value; }
    }

    private TimeSpan? _birthtime;
    public TimeSpan? birthtime
    {
        get { return _birthtime; }
        set { _birthtime = value; }
    }

    private string? _mother_hn;
    public string? mother_hn
    {
        get { return _mother_hn; }
        set { _mother_hn = value; }
    }

    private DateTime? _last_visit;
    public DateTime? last_visit
    {
        get { return _last_visit; }
        set { _last_visit = value; }
    }

    private string? _death;
    public string? death
    {
        get { return _death; }
        set { _death = value; }
    }

    private int? _height;
    public int? height
    {
        get { return _height; }
        set { _height = value; }
    }

    private string? _inregion;
    public string? inregion
    {
        get { return _inregion; }
        set { _inregion = value; }
    }

    private TimeSpan? _reg_time;
    public TimeSpan? reg_time
    {
        get { return _reg_time; }
        set { _reg_time = value; }
    }

    private string? _oldcode;
    public string? oldcode
    {
        get { return _oldcode; }
        set { _oldcode = value; }
    }

    private string? _lang;
    public string? lang
    {
        get { return _lang; }
        set { _lang = value; }
    }

    private string? _gov_chronic_id;
    public string? gov_chronic_id
    {
        get { return _gov_chronic_id; }
        set { _gov_chronic_id = value; }
    }

    private string? _in_cups;
    public string? in_cups
    {
        get { return _in_cups; }
        set { _in_cups = value; }
    }

    private byte? _patient_type_id;
    public byte? patient_type_id
    {
        get { return _patient_type_id; }
        set { _patient_type_id = value; }
    }

    private string? _addr_soi;
    public string? addr_soi
    {
        get { return _addr_soi; }
        set { _addr_soi = value; }
    }

    private string? _work_addr;
    public string? work_addr
    {
        get { return _work_addr; }
        set { _work_addr = value; }
    }

    private string? _father_hn;
    public string? father_hn
    {
        get { return _father_hn; }
        set { _father_hn = value; }
    }

    private string? _alias_name;
    public string? alias_name
    {
        get { return _alias_name; }
        set { _alias_name = value; }
    }

    private string? _destroyed;
    public string? destroyed
    {
        get { return _destroyed; }
        set { _destroyed = value; }
    }

    private string? _old_addr;
    public string? old_addr
    {
        get { return _old_addr; }
        set { _old_addr = value; }
    }

    private string? _fname_soundex;
    public string? fname_soundex
    {
        get { return _fname_soundex; }
        set { _fname_soundex = value; }
    }

    private string? _lname_soundex;
    public string? lname_soundex
    {
        get { return _lname_soundex; }
        set { _lname_soundex = value; }
    }

    private string? _bloodgroup_rh;
    public string? bloodgroup_rh
    {
        get { return _bloodgroup_rh; }
        set { _bloodgroup_rh = value; }
    }

    private string? _passport_no;
    public string? passport_no
    {
        get { return _passport_no; }
        set { _passport_no = value; }
    }

    private string? _addressid;
    public string? addressid
    {
        get { return _addressid; }
        set { _addressid = value; }
    }

    private string? _mobile_phone_number;
    public string? mobile_phone_number
    {
        get { return _mobile_phone_number; }
        set { _mobile_phone_number = value; }
    }

    private string? _anonymous_person;
    public string? anonymous_person
    {
        get { return _anonymous_person; }
        set { _anonymous_person = value; }
    }

    private int? _hospital_department_id;
    public int? hospital_department_id
    {
        get { return _hospital_department_id; }
        set { _hospital_department_id = value; }
    }

    private string? _membercard_no;
    public string? membercard_no
    {
        get { return _membercard_no; }
        set { _membercard_no = value; }
    }

    private string? _ec_fname;
    public string? ec_fname
    {
        get { return _ec_fname; }
        set { _ec_fname = value; }
    }

    private string? _ec_lname;
    public string? ec_lname
    {
        get { return _ec_lname; }
        set { _ec_lname = value; }
    }

    private int? _ec_relation_type_id;
    public int? ec_relation_type_id
    {
        get { return _ec_relation_type_id; }
        set { _ec_relation_type_id = value; }
    }

    private int? _patient_color_id;
    public int? patient_color_id
    {
        get { return _patient_color_id; }
        set { _patient_color_id = value; }
    }

    private int? _number_of_relatives;
    public int? number_of_relatives
    {
        get { return _number_of_relatives; }
        set { _number_of_relatives = value; }
    }

    private int? _birth_order;
    public int? birth_order
    {
        get { return _birth_order; }
        set { _birth_order = value; }
    }

    private int? _person_labor_type_id;
    public int? person_labor_type_id
    {
        get { return _person_labor_type_id; }
        set { _person_labor_type_id = value; }
    }

    private string? _is_card_destroy;
    public string? is_card_destroy
    {
        get { return _is_card_destroy; }
        set { _is_card_destroy = value; }
    }

    private DateTime? _card_destroy_date;
    public DateTime? card_destroy_date
    {
        get { return _card_destroy_date; }
        set { _card_destroy_date = value; }
    }

    private string? _g6pd;
    public string? g6pd
    {
        get { return _g6pd; }
        set { _g6pd = value; }
    }


    public patient(string hos_guid_, string hn_, string? pname_, string? fname_, string? lname_, string? occupation_, string? citizenship_, DateTime? birthday_, string? addrpart_, string? moopart_, string? tmbpart_, string? amppart_, string? chwpart_, string? bloodgrp_, string? clinic_, DateTime? deathday_, string? drugallergy_, int? familyno_, string? fathername_, DateTime? firstday_, string? hometel_, string? informaddr_, string? informname_, string? informrelation_, string? informtel_, string? marrystatus_, string? mathername_, int? hn_int_, string? nationality_, string? opdlocation_, string? pttype_, string? religion_, string? sex_, string? spsname_, string? truebirthday_, string? workaddr_, string? worktel_, string? hcode_, string? cid_, int? hid_, string? educate_, string? family_status_, string? labor_type_, DateTime? last_update_, string? type_area_, string? road_, string? father_cid_, string? mother_cid_, string? couple_cid_, string? person_type_, string? private_doctor_name_, string? legal_action_, string? death_code504_, string? death_diag_, string? node_id_, string? admit_, string? midname_, string? po_code_, string? fatherlname_, string? motherlname_, string? spslname_, string? country_, string? email_, TimeSpan? birthtime_, string? mother_hn_, DateTime? last_visit_, string? death_, int? height_, string? inregion_, TimeSpan? reg_time_, string? oldcode_, string? lang_, string? gov_chronic_id_, string? in_cups_, byte? patient_type_id_, string? addr_soi_, string? work_addr_, string? father_hn_, string? alias_name_, string? destroyed_, string? old_addr_, string? fname_soundex_, string? lname_soundex_, string? bloodgroup_rh_, string? passport_no_, string? addressid_, string? mobile_phone_number_, string? anonymous_person_, int? hospital_department_id_, string? membercard_no_, string? ec_fname_, string? ec_lname_, int? ec_relation_type_id_, int? patient_color_id_, int? number_of_relatives_, int? birth_order_, int? person_labor_type_id_, string? is_card_destroy_, DateTime? card_destroy_date_, string? g6pd_)
    {
        this.hos_guid = hos_guid_;
        this.hn = hn_;
        this.pname = pname_;
        this.fname = fname_;
        this.lname = lname_;
        this.occupation = occupation_;
        this.citizenship = citizenship_;
        this.birthday = birthday_;
        this.addrpart = addrpart_;
        this.moopart = moopart_;
        this.tmbpart = tmbpart_;
        this.amppart = amppart_;
        this.chwpart = chwpart_;
        this.bloodgrp = bloodgrp_;
        this.clinic = clinic_;
        this.deathday = deathday_;
        this.drugallergy = drugallergy_;
        this.familyno = familyno_;
        this.fathername = fathername_;
        this.firstday = firstday_;
        this.hometel = hometel_;
        this.informaddr = informaddr_;
        this.informname = informname_;
        this.informrelation = informrelation_;
        this.informtel = informtel_;
        this.marrystatus = marrystatus_;
        this.mathername = mathername_;
        this.hn_int = hn_int_;
        this.nationality = nationality_;
        this.opdlocation = opdlocation_;
        this.pttype = pttype_;
        this.religion = religion_;
        this.sex = sex_;
        this.spsname = spsname_;
        this.truebirthday = truebirthday_;
        this.workaddr = workaddr_;
        this.worktel = worktel_;
        this.hcode = hcode_;
        this.cid = cid_;
        this.hid = hid_;
        this.educate = educate_;
        this.family_status = family_status_;
        this.labor_type = labor_type_;
        this.last_update = last_update_;
        this.type_area = type_area_;
        this.road = road_;
        this.father_cid = father_cid_;
        this.mother_cid = mother_cid_;
        this.couple_cid = couple_cid_;
        this.person_type = person_type_;
        this.private_doctor_name = private_doctor_name_;
        this.legal_action = legal_action_;
        this.death_code504 = death_code504_;
        this.death_diag = death_diag_;
        this.node_id = node_id_;
        this.admit = admit_;
        this.midname = midname_;
        this.po_code = po_code_;
        this.fatherlname = fatherlname_;
        this.motherlname = motherlname_;
        this.spslname = spslname_;
        this.country = country_;
        this.email = email_;
        this.birthtime = birthtime_;
        this.mother_hn = mother_hn_;
        this.last_visit = last_visit_;
        this.death = death_;
        this.height = height_;
        this.inregion = inregion_;
        this.reg_time = reg_time_;
        this.oldcode = oldcode_;
        this.lang = lang_;
        this.gov_chronic_id = gov_chronic_id_;
        this.in_cups = in_cups_;
        this.patient_type_id = patient_type_id_;
        this.addr_soi = addr_soi_;
        this.work_addr = work_addr_;
        this.father_hn = father_hn_;
        this.alias_name = alias_name_;
        this.destroyed = destroyed_;
        this.old_addr = old_addr_;
        this.fname_soundex = fname_soundex_;
        this.lname_soundex = lname_soundex_;
        this.bloodgroup_rh = bloodgroup_rh_;
        this.passport_no = passport_no_;
        this.addressid = addressid_;
        this.mobile_phone_number = mobile_phone_number_;
        this.anonymous_person = anonymous_person_;
        this.hospital_department_id = hospital_department_id_;
        this.membercard_no = membercard_no_;
        this.ec_fname = ec_fname_;
        this.ec_lname = ec_lname_;
        this.ec_relation_type_id = ec_relation_type_id_;
        this.patient_color_id = patient_color_id_;
        this.number_of_relatives = number_of_relatives_;
        this.birth_order = birth_order_;
        this.person_labor_type_id = person_labor_type_id_;
        this.is_card_destroy = is_card_destroy_;
        this.card_destroy_date = card_destroy_date_;
        this.g6pd = g6pd_;
    }
}
