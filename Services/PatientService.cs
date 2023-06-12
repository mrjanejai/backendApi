using Microsoft.EntityFrameworkCore;
using WebApi.Entities;
using WebApi.Entities.HIS;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface IPatientService
    {
        Task SyncAsync();
    }
    public class PatientService : IPatientService
    {
        private readonly DataContext _dataContext;
        private readonly HisContext _hisContext;

        public PatientService(DataContext dataContext, HisContext hisContext)
        {
            _dataContext = dataContext;
            _hisContext = hisContext;
        }

        public async Task SyncAsync()
        {
            var sourceIcds = await _hisContext.patient.AsNoTracking().ToListAsync();
            var targetIcds = await _dataContext.patient.AsNoTracking().ToListAsync();

            foreach (var sourceIcd in sourceIcds)
            {
                var targetIcd = targetIcds.FirstOrDefault(i => i.hos_guid == sourceIcd.hos_guid);

                if (targetIcd == null)
                {
                    var newIcd = new patient
                    {
                        hos_guid = sourceIcd.hos_guid,
                        hn = sourceIcd.hn,
                        pname = sourceIcd.pname,
                        fname = sourceIcd.fname,
                        lname = sourceIcd.lname,
                        occupation = sourceIcd.occupation,
                        citizenship = sourceIcd.citizenship,
                        birthday = sourceIcd.birthday,
                        addrpart = sourceIcd.addrpart,
                        moopart = sourceIcd.moopart,
                        tmbpart = sourceIcd.tmbpart,
                        amppart = sourceIcd.amppart,
                        chwpart = sourceIcd.chwpart,
                        bloodgrp = sourceIcd.bloodgrp,
                        clinic = sourceIcd.clinic,
                        deathday = sourceIcd.deathday,
                        drugallergy = sourceIcd.drugallergy,
                        familyno = sourceIcd.familyno,
                        fathername = sourceIcd.fathername,
                        firstday = sourceIcd.firstday,
                        hometel = sourceIcd.hometel,
                        informaddr = sourceIcd.informaddr,
                        informname = sourceIcd.informname,
                        informrelation = sourceIcd.informrelation,
                        informtel = sourceIcd.informtel,
                        marrystatus = sourceIcd.marrystatus,
                        mathername = sourceIcd.mathername,
                        hn_int = sourceIcd.hn_int,
                        nationality = sourceIcd.nationality,
                        opdlocation = sourceIcd.opdlocation,
                        pttype = sourceIcd.pttype,
                        religion = sourceIcd.religion,
                        sex = sourceIcd.sex,
                        spsname = sourceIcd.spsname,
                        truebirthday = sourceIcd.truebirthday,
                        workaddr = sourceIcd.workaddr,
                        worktel = sourceIcd.worktel,
                        hcode = sourceIcd.hcode,
                        cid = sourceIcd.cid,
                        hid = sourceIcd.hid,
                        educate = sourceIcd.educate,
                        family_status = sourceIcd.family_status,
                        labor_type = sourceIcd.labor_type,
                        last_update = sourceIcd.last_update,
                        type_area = sourceIcd.type_area,
                        road = sourceIcd.road,
                        father_cid = sourceIcd.father_cid,
                        mother_cid = sourceIcd.mother_cid,
                        couple_cid = sourceIcd.couple_cid,
                        person_type = sourceIcd.person_type,
                        private_doctor_name = sourceIcd.private_doctor_name,
                        legal_action = sourceIcd.legal_action,
                        death_code504 = sourceIcd.death_code504,
                        death_diag = sourceIcd.death_diag,
                        node_id = sourceIcd.node_id,
                        admit = sourceIcd.admit,
                        midname = sourceIcd.midname,
                        po_code = sourceIcd.po_code,
                        fatherlname = sourceIcd.fatherlname,
                        motherlname = sourceIcd.motherlname,
                        spslname = sourceIcd.spslname,
                        country = sourceIcd.country,
                        email = sourceIcd.email,
                        birthtime = sourceIcd.birthtime,
                        mother_hn = sourceIcd.mother_hn,
                        last_visit = sourceIcd.last_visit,
                        death = sourceIcd.death,
                        height = sourceIcd.height,
                        inregion = sourceIcd.inregion,
                        reg_time = sourceIcd.reg_time,
                        oldcode = sourceIcd.oldcode,
                        lang = sourceIcd.lang,
                        gov_chronic_id = sourceIcd.gov_chronic_id,
                        in_cups = sourceIcd.in_cups,
                        patient_type_id = sourceIcd.patient_type_id,
                        addr_soi = sourceIcd.addr_soi,
                        work_addr = sourceIcd.work_addr,
                        father_hn = sourceIcd.father_hn,
                        alias_name = sourceIcd.alias_name,
                        destroyed = sourceIcd.destroyed,
                        old_addr = sourceIcd.old_addr,
                        fname_soundex = sourceIcd.fname_soundex,
                        lname_soundex = sourceIcd.lname_soundex,
                        bloodgroup_rh = sourceIcd.bloodgroup_rh,
                        passport_no = sourceIcd.passport_no,
                        addressid = sourceIcd.addressid,
                        mobile_phone_number = sourceIcd.mobile_phone_number,
                        anonymous_person = sourceIcd.anonymous_person,
                        hospital_department_id = sourceIcd.hospital_department_id,
                        membercard_no = sourceIcd.membercard_no,
                        ec_fname = sourceIcd.ec_fname,
                        ec_lname = sourceIcd.ec_lname,
                        ec_relation_type_id = sourceIcd.ec_relation_type_id,
                        patient_color_id = sourceIcd.patient_color_id,
                        number_of_relatives = sourceIcd.number_of_relatives,
                        birth_order = sourceIcd.birth_order,
                        person_labor_type_id = sourceIcd.person_labor_type_id,
                        is_card_destroy = sourceIcd.is_card_destroy,
                        card_destroy_date = sourceIcd.card_destroy_date,
                        g6pd = sourceIcd.g6pd
                        // Copy all the properties here...
                    };
                    _dataContext.patient.Add(newIcd);
                }
                else
                {
                    targetIcd.hos_guid = sourceIcd.hos_guid;
                    targetIcd.hn = sourceIcd.hn;
                    targetIcd.pname = sourceIcd.pname;
                    targetIcd.fname = sourceIcd.fname;
                    targetIcd.lname = sourceIcd.lname;
                    targetIcd.occupation = sourceIcd.occupation;
                    targetIcd.citizenship = sourceIcd.citizenship;
                    targetIcd.birthday = sourceIcd.birthday;
                    targetIcd.addrpart = sourceIcd.addrpart;
                    targetIcd.moopart = sourceIcd.moopart;
                    targetIcd.tmbpart = sourceIcd.tmbpart;
                    targetIcd.amppart = sourceIcd.amppart;
                    targetIcd.chwpart = sourceIcd.chwpart;
                    targetIcd.bloodgrp = sourceIcd.bloodgrp;
                    targetIcd.clinic = sourceIcd.clinic;
                    targetIcd.deathday = sourceIcd.deathday;
                    targetIcd.drugallergy = sourceIcd.drugallergy;
                    targetIcd.familyno = sourceIcd.familyno;
                    targetIcd.fathername = sourceIcd.fathername;
                    targetIcd.firstday = sourceIcd.firstday;
                    targetIcd.hometel = sourceIcd.hometel;
                    targetIcd.informaddr = sourceIcd.informaddr;
                    targetIcd.informname = sourceIcd.informname;
                    targetIcd.informrelation = sourceIcd.informrelation;
                    targetIcd.informtel = sourceIcd.informtel;
                    targetIcd.marrystatus = sourceIcd.marrystatus;
                    targetIcd.mathername = sourceIcd.mathername;
                    targetIcd.hn_int = sourceIcd.hn_int;
                    targetIcd.nationality = sourceIcd.nationality;
                    targetIcd.opdlocation = sourceIcd.opdlocation;
                    targetIcd.pttype = sourceIcd.pttype;
                    targetIcd.religion = sourceIcd.religion;
                    targetIcd.sex = sourceIcd.sex;
                    targetIcd.spsname = sourceIcd.spsname;
                    targetIcd.truebirthday = sourceIcd.truebirthday;
                    targetIcd.workaddr = sourceIcd.workaddr;
                    targetIcd.worktel = sourceIcd.worktel;
                    targetIcd.hcode = sourceIcd.hcode;
                    targetIcd.cid = sourceIcd.cid;
                    targetIcd.hid = sourceIcd.hid;
                    targetIcd.educate = sourceIcd.educate;
                    targetIcd.family_status = sourceIcd.family_status;
                    targetIcd.labor_type = sourceIcd.labor_type;
                    targetIcd.last_update = sourceIcd.last_update;
                    targetIcd.type_area = sourceIcd.type_area;
                    targetIcd.road = sourceIcd.road;
                    targetIcd.father_cid = sourceIcd.father_cid;
                    targetIcd.mother_cid = sourceIcd.mother_cid;
                    targetIcd.couple_cid = sourceIcd.couple_cid;
                    targetIcd.person_type = sourceIcd.person_type;
                    targetIcd.private_doctor_name = sourceIcd.private_doctor_name;
                    targetIcd.legal_action = sourceIcd.legal_action;
                    targetIcd.death_code504 = sourceIcd.death_code504;
                    targetIcd.death_diag = sourceIcd.death_diag;
                    targetIcd.node_id = sourceIcd.node_id;
                    targetIcd.admit = sourceIcd.admit;
                    targetIcd.midname = sourceIcd.midname;
                    targetIcd.po_code = sourceIcd.po_code;
                    targetIcd.fatherlname = sourceIcd.fatherlname;
                    targetIcd.motherlname = sourceIcd.motherlname;
                    targetIcd.spslname = sourceIcd.spslname;
                    targetIcd.country = sourceIcd.country;
                    targetIcd.email = sourceIcd.email;
                    targetIcd.birthtime = sourceIcd.birthtime;
                    targetIcd.mother_hn = sourceIcd.mother_hn;
                    targetIcd.last_visit = sourceIcd.last_visit;
                    targetIcd.death = sourceIcd.death;
                    targetIcd.height = sourceIcd.height;
                    targetIcd.inregion = sourceIcd.inregion;
                    targetIcd.reg_time = sourceIcd.reg_time;
                    targetIcd.oldcode = sourceIcd.oldcode;
                    targetIcd.lang = sourceIcd.lang;
                    targetIcd.gov_chronic_id = sourceIcd.gov_chronic_id;
                    targetIcd.in_cups = sourceIcd.in_cups;
                    targetIcd.patient_type_id = sourceIcd.patient_type_id;
                    targetIcd.addr_soi = sourceIcd.addr_soi;
                    targetIcd.work_addr = sourceIcd.work_addr;
                    targetIcd.father_hn = sourceIcd.father_hn;
                    targetIcd.alias_name = sourceIcd.alias_name;
                    targetIcd.destroyed = sourceIcd.destroyed;
                    targetIcd.old_addr = sourceIcd.old_addr;
                    targetIcd.fname_soundex = sourceIcd.fname_soundex;
                    targetIcd.lname_soundex = sourceIcd.lname_soundex;
                    targetIcd.bloodgroup_rh = sourceIcd.bloodgroup_rh;
                    targetIcd.passport_no = sourceIcd.passport_no;
                    targetIcd.addressid = sourceIcd.addressid;
                    targetIcd.mobile_phone_number = sourceIcd.mobile_phone_number;
                    targetIcd.anonymous_person = sourceIcd.anonymous_person;
                    targetIcd.hospital_department_id = sourceIcd.hospital_department_id;
                    targetIcd.membercard_no = sourceIcd.membercard_no;
                    targetIcd.ec_fname = sourceIcd.ec_fname;
                    targetIcd.ec_lname = sourceIcd.ec_lname;
                    targetIcd.ec_relation_type_id = sourceIcd.ec_relation_type_id;
                    targetIcd.patient_color_id = sourceIcd.patient_color_id;
                    targetIcd.number_of_relatives = sourceIcd.number_of_relatives;
                    targetIcd.birth_order = sourceIcd.birth_order;
                    targetIcd.person_labor_type_id = sourceIcd.person_labor_type_id;
                    targetIcd.is_card_destroy = sourceIcd.is_card_destroy;
                    targetIcd.card_destroy_date = sourceIcd.card_destroy_date;
                    targetIcd.g6pd = sourceIcd.g6pd;

                    // Update all the properties here...
                    _dataContext.patient.Update(targetIcd);
                }
            }

            await _dataContext.SaveChangesAsync();
        }


    }
}
