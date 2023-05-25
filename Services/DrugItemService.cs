namespace WebApi.Services
{
    using WebApi.Entities;
    using WebApi.Helpers;
    using WebApi.Models.DrugItems;
    using WebApi.Authorization;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IDrugItemSyncService
    {
        Task SyncAsync();
    }

    public class DrugItemSyncService : IDrugItemSyncService
    {
        private readonly DataContext _dataContext;
        private readonly HisContext _hisContext;

        public DrugItemSyncService(DataContext dataContext, HisContext hisContext)
        {
            _dataContext = dataContext;
            _hisContext = hisContext;
        }

        public async Task SyncAsync()
        {
            var sourceDrugItems = await _hisContext.drugitems.AsNoTracking().ToListAsync();
            var targetDrugItems = await _dataContext.drugitems.AsNoTracking().ToListAsync();

            foreach (var sourceDrugItem in sourceDrugItems)
            {
                var targetDrugItem = targetDrugItems.FirstOrDefault(i => i.icode == sourceDrugItem.icode);

                if (targetDrugItem == null)
                {
                    var newDrugItem = new drugitems
                    {
                        // Map all properties of sourceDrugItem to newDrugItem
                        // For instance: 
                        icode = sourceDrugItem.icode,
                        name = sourceDrugItem.name,
                        strength = sourceDrugItem.strength,
                        units = sourceDrugItem.units,
                        unitprice = sourceDrugItem.unitprice,
                        dosageform = sourceDrugItem.dosageform,
                        criticalpriority = sourceDrugItem.criticalpriority,
                        drugaccount = sourceDrugItem.drugaccount,
                        drugcategory = sourceDrugItem.drugcategory,
                        drugnote = sourceDrugItem.drugnote,
                        hintcode = sourceDrugItem.hintcode,
                        istatus = sourceDrugItem.istatus,
                        lastupdatestdprice = sourceDrugItem.lastupdatestdprice,
                        lockprice = sourceDrugItem.lockprice,
                        lockprint = sourceDrugItem.lockprint,
                        maxlevel = sourceDrugItem.maxlevel,
                        minlevel = sourceDrugItem.minlevel,
                        maxunitperdose = sourceDrugItem.maxunitperdose,
                        packqty = sourceDrugItem.packqty,
                        reorderqty = sourceDrugItem.reorderqty,
                        stdprice = sourceDrugItem.stdprice,
                        stdtaken = sourceDrugItem.stdtaken,
                        therapeutic = sourceDrugItem.therapeutic,
                        therapeuticgroup = sourceDrugItem.therapeuticgroup,
                        default_qty = sourceDrugItem.default_qty,
                        gpo_code = sourceDrugItem.gpo_code,
                        use_right = sourceDrugItem.use_right,
                        i_type = sourceDrugItem.i_type,
                        drugusage = sourceDrugItem.drugusage,
                        high_cost = sourceDrugItem.high_cost,
                        must_paid = sourceDrugItem.must_paid,
                        alert_level = sourceDrugItem.alert_level,
                        access_level = sourceDrugItem.access_level,
                        sticker_short_name = sourceDrugItem.sticker_short_name,
                        paidst = sourceDrugItem.paidst,
                        antibiotic = sourceDrugItem.antibiotic,
                        displaycolor = sourceDrugItem.displaycolor,
                        empty = sourceDrugItem.empty,
                        empty_text = sourceDrugItem.empty_text,
                        unitcost = sourceDrugItem.unitcost,
                        gfmiscode = sourceDrugItem.gfmiscode,
                        ipd_price = sourceDrugItem.ipd_price,
                        oldcode = sourceDrugItem.oldcode,
                        habit_forming = sourceDrugItem.habit_forming,
                        did = sourceDrugItem.did,
                        stock_type = sourceDrugItem.stock_type,
                        price2 = sourceDrugItem.price2,
                        price3 = sourceDrugItem.price3,
                        ipd_price2 = sourceDrugItem.ipd_price2,
                        ipd_price3 = sourceDrugItem.ipd_price3,
                        price_lock = sourceDrugItem.price_lock,
                        pregnancy = sourceDrugItem.pregnancy,
                        pharmacology_group1 = sourceDrugItem.pharmacology_group1,
                        pharmacology_group2 = sourceDrugItem.pharmacology_group2,
                        pharmacology_group3 = sourceDrugItem.pharmacology_group3,
                        generic_name = sourceDrugItem.generic_name,
                        show_pregnancy_alert = sourceDrugItem.show_pregnancy_alert,
                        icode_guid = sourceDrugItem.icode_guid,
                        na = sourceDrugItem.na,
                        invcode = sourceDrugItem.invcode,
                        check_user_group = sourceDrugItem.check_user_group,
                        check_user_name = sourceDrugItem.check_user_name,
                        show_notify = sourceDrugItem.show_notify,
                        show_notify_text = sourceDrugItem.show_notify_text,
                        income = sourceDrugItem.income,
                        print_sticker_pq = sourceDrugItem.print_sticker_pq,
                        charge_service_opd = sourceDrugItem.charge_service_opd,
                        charge_service_ipd = sourceDrugItem.charge_service_ipd,
                        ename = sourceDrugItem.ename,
                        dose_type = sourceDrugItem.dose_type,
                        habit_forming_type = sourceDrugItem.habit_forming_type,
                        no_discount = sourceDrugItem.no_discount,
                        therapeutic_eng = sourceDrugItem.therapeutic_eng,
                        hintcode_eng = sourceDrugItem.hintcode_eng,
                        limit_drugusage = sourceDrugItem.limit_drugusage,
                        print_sticker_header = sourceDrugItem.print_sticker_header,
                        calc_idr_qty = sourceDrugItem.calc_idr_qty,
                        item_in_hospital = sourceDrugItem.item_in_hospital,
                        no_substock = sourceDrugItem.no_substock,
                        volume_cc = sourceDrugItem.volume_cc,
                        usage_code = sourceDrugItem.usage_code,
                        frequency_code = sourceDrugItem.frequency_code,
                        time_code = sourceDrugItem.time_code,
                        dispense_dose = sourceDrugItem.dispense_dose,
                        usage_unit_code = sourceDrugItem.usage_unit_code,
                        dose_per_units = sourceDrugItem.dose_per_units,
                        ipd_default_pay = sourceDrugItem.ipd_default_pay,
                        billcode = sourceDrugItem.billcode,
                        billnumber = sourceDrugItem.billnumber,
                        lockprint_ipd = sourceDrugItem.lockprint_ipd,
                        pregnancy_notify_text = sourceDrugItem.pregnancy_notify_text,
                        show_breast_feeding_alert = sourceDrugItem.show_breast_feeding_alert,
                        breast_feeding_alert_text = sourceDrugItem.breast_feeding_alert_text,
                        show_child_notify = sourceDrugItem.show_child_notify,
                        child_notify_text = sourceDrugItem.child_notify_text,
                        child_notify_min_age = sourceDrugItem.child_notify_min_age,
                        child_notify_max_age = sourceDrugItem.child_notify_max_age,
                        continuous = sourceDrugItem.continuous,
                        substitute_icode = sourceDrugItem.substitute_icode,
                        trade_name = sourceDrugItem.trade_name,
                        use_right_allow = sourceDrugItem.use_right_allow,
                        medication_machine_id = sourceDrugItem.medication_machine_id,
                        ipd_medication_machine_id = sourceDrugItem.ipd_medication_machine_id,
                        check_remed_qty = sourceDrugItem.check_remed_qty,
                        addict = sourceDrugItem.addict,
                        addict_type_id = sourceDrugItem.addict_type_id,
                        medication_machine_opd_no = sourceDrugItem.medication_machine_opd_no,
                        medication_machine_ipd_no = sourceDrugItem.medication_machine_ipd_no,
                        fp_drug = sourceDrugItem.fp_drug,
                        usage_code_ipd = sourceDrugItem.usage_code_ipd,
                        dispense_dose_ipd = sourceDrugItem.dispense_dose_ipd,
                        usage_unit_code_ipd = sourceDrugItem.usage_unit_code_ipd,
                        frequency_code_ipd = sourceDrugItem.frequency_code_ipd,
                        time_code_ipd = sourceDrugItem.time_code_ipd,
                        print_ipd_injection_sticker = sourceDrugItem.print_ipd_injection_sticker,
                        provis_medication_unit_code = sourceDrugItem.provis_medication_unit_code,
                        hos_guid = sourceDrugItem.hos_guid,
                        sks_product_category_id = sourceDrugItem.sks_product_category_id,
                        sks_clain_control_type_id = sourceDrugItem.sks_clain_control_type_id,
                        sks_drug_code = sourceDrugItem.sks_drug_code,
                        sks_dfs_code = sourceDrugItem.sks_dfs_code,
                        sks_dfs_text = sourceDrugItem.sks_dfs_text,
                        sks_reimb_price = sourceDrugItem.sks_reimb_price,
                        hos_guid_ext = sourceDrugItem.hos_guid_ext,
                        check_druginteraction_history = sourceDrugItem.check_druginteraction_history,
                        check_druginteraction_history_day = sourceDrugItem.check_druginteraction_history_day,
                        nhso_adp_type_id = sourceDrugItem.nhso_adp_type_id,
                        nhso_adp_code = sourceDrugItem.nhso_adp_code,
                        sks_claim_control_type_id = sourceDrugItem.sks_claim_control_type_id,
                        begin_date = sourceDrugItem.begin_date,
                        finish_date = sourceDrugItem.finish_date,
                        name_pr = sourceDrugItem.name_pr,
                        name_eng = sourceDrugItem.name_eng,
                        capacity_name = sourceDrugItem.capacity_name,
                        finish_reason = sourceDrugItem.finish_reason,
                        extra_unitcost = sourceDrugItem.extra_unitcost,
                        drug_control_type_id = sourceDrugItem.drug_control_type_id,
                        name_print = sourceDrugItem.name_print,
                        active_ingredient_mg = sourceDrugItem.active_ingredient_mg,
                        no_order_g6pd = sourceDrugItem.no_order_g6pd,
                        gender_check = sourceDrugItem.gender_check,
                        no_order_gender = sourceDrugItem.no_order_gender,
                        max_qty = sourceDrugItem.max_qty,
                        prefer_opd_usage_code = sourceDrugItem.prefer_opd_usage_code,
                        capacity_qty = sourceDrugItem.capacity_qty,
                        need_order_reason = sourceDrugItem.need_order_reason,
                        drugitems_due_type_id = sourceDrugItem.drugitems_due_type_id,
                        drugeval_head_id = sourceDrugItem.drugeval_head_id,
                        light_protect = sourceDrugItem.light_protect,
                        tpu_code_list = sourceDrugItem.tpu_code_list,
                        inv_map_update = sourceDrugItem.inv_map_update,
                        special_advice_text = sourceDrugItem.special_advice_text,
                        precaution_advice_text = sourceDrugItem.precaution_advice_text,
                        contra_advice_text = sourceDrugItem.contra_advice_text,
                        storage_advice_text = sourceDrugItem.storage_advice_text,
                        qr_code_url = sourceDrugItem.qr_code_url,
                        vat_percent = sourceDrugItem.vat_percent,
                        acc_regist = sourceDrugItem.acc_regist,
                        use_paidst = sourceDrugItem.use_paidst,
                        thai_name = sourceDrugItem.thai_name,
                        fwf_item_id = sourceDrugItem.fwf_item_id,
                        drugitems_em1_id = sourceDrugItem.drugitems_em1_id,
                        drugitems_em2_id = sourceDrugItem.drugitems_em2_id,
                        drugitems_em3_id = sourceDrugItem.drugitems_em3_id,
                        drugitems_em4_id = sourceDrugItem.drugitems_em4_id,
                        tmt_tp_code = sourceDrugItem.tmt_tp_code,
                        tmt_gp_code = sourceDrugItem.tmt_gp_code,
                        limit_pttype = sourceDrugItem.limit_pttype,
                        noshow_narcotic = sourceDrugItem.noshow_narcotic,
                        medication_machine_flag = sourceDrugItem.medication_machine_flag,
                        sks_price = sourceDrugItem.sks_price,
                        print_sticker_by_frequency = sourceDrugItem.print_sticker_by_frequency,
                        print_sticker_pq_ipd = sourceDrugItem.print_sticker_pq_ipd,
                        sub_income = sourceDrugItem.sub_income,
                        prefer_ipd_usage_code = sourceDrugItem.prefer_ipd_usage_code,
                        default_qty_ipd = sourceDrugItem.default_qty_ipd,
                        max_qty_ipd = sourceDrugItem.max_qty_ipd,
                        drugusage_ipd = sourceDrugItem.drugusage_ipd,
                        no_popup_ipd_reason = sourceDrugItem.no_popup_ipd_reason,
                        specprep = sourceDrugItem.specprep,
                        med_dose_calc_type_id = sourceDrugItem.med_dose_calc_type_id,
                        send_line_notify = sourceDrugItem.send_line_notify,
                        show_qrcode_trade = sourceDrugItem.show_qrcode_trade,
                        warn_g6pd = sourceDrugItem.warn_g6pd,
                        ipd_rx_freq_day = sourceDrugItem.ipd_rx_freq_day,
                        displaycolor_focus = sourceDrugItem.displaycolor_focus,
                        last_update = sourceDrugItem.last_update,
                        no_remed = sourceDrugItem.no_remed,
                        force_round_qty = sourceDrugItem.force_round_qty,
                        atc_code = sourceDrugItem.atc_code,
                        state_item_id = sourceDrugItem.state_item_id,
                        multiply_charge_service = sourceDrugItem.multiply_charge_service,
                        csmbs_claim_cat = sourceDrugItem.csmbs_claim_cat,
                        simb_2005 = sourceDrugItem.simb_2005,
                        sks_rev_date = sourceDrugItem.sks_rev_date,
                        sct_unit_code = sourceDrugItem.sct_unit_code,
                        print_label = sourceDrugItem.print_label,
                        // ...
                        // continue for all properties
                    };
                    _dataContext.drugitems.Add(newDrugItem);
                }
                else
                {
                    // Update all the properties here...
                    targetDrugItem.name = sourceDrugItem.name;
                    targetDrugItem.strength = sourceDrugItem.strength;
                    targetDrugItem.units = sourceDrugItem.units;
                    targetDrugItem.unitprice = sourceDrugItem.unitprice;
                    targetDrugItem.dosageform = sourceDrugItem.dosageform;
                    targetDrugItem.criticalpriority = sourceDrugItem.criticalpriority;
                    targetDrugItem.drugaccount = sourceDrugItem.drugaccount;
                    targetDrugItem.drugcategory = sourceDrugItem.drugcategory;
                    targetDrugItem.drugnote = sourceDrugItem.drugnote;
                    targetDrugItem.hintcode = sourceDrugItem.hintcode;
                    targetDrugItem.istatus = sourceDrugItem.istatus;
                    targetDrugItem.lastupdatestdprice = sourceDrugItem.lastupdatestdprice;
                    targetDrugItem.lockprice = sourceDrugItem.lockprice;
                    targetDrugItem.lockprint = sourceDrugItem.lockprint;
                    targetDrugItem.maxlevel = sourceDrugItem.maxlevel;
                    targetDrugItem.minlevel = sourceDrugItem.minlevel;
                    targetDrugItem.maxunitperdose = sourceDrugItem.maxunitperdose;
                    targetDrugItem.packqty = sourceDrugItem.packqty;
                    targetDrugItem.reorderqty = sourceDrugItem.reorderqty;
                    targetDrugItem.stdprice = sourceDrugItem.stdprice;
                    targetDrugItem.stdtaken = sourceDrugItem.stdtaken;
                    targetDrugItem.therapeutic = sourceDrugItem.therapeutic;
                    targetDrugItem.therapeuticgroup = sourceDrugItem.therapeuticgroup;
                    targetDrugItem.default_qty = sourceDrugItem.default_qty;
                    targetDrugItem.gpo_code = sourceDrugItem.gpo_code;
                    targetDrugItem.use_right = sourceDrugItem.use_right;
                    targetDrugItem.i_type = sourceDrugItem.i_type;
                    targetDrugItem.drugusage = sourceDrugItem.drugusage;
                    targetDrugItem.high_cost = sourceDrugItem.high_cost;
                    targetDrugItem.must_paid = sourceDrugItem.must_paid;
                    targetDrugItem.alert_level = sourceDrugItem.alert_level;
                    targetDrugItem.access_level = sourceDrugItem.access_level;
                    targetDrugItem.sticker_short_name = sourceDrugItem.sticker_short_name;
                    targetDrugItem.paidst = sourceDrugItem.paidst;
                    targetDrugItem.antibiotic = sourceDrugItem.antibiotic;
                    targetDrugItem.displaycolor = sourceDrugItem.displaycolor;
                    targetDrugItem.empty = sourceDrugItem.empty;
                    targetDrugItem.empty_text = sourceDrugItem.empty_text;
                    targetDrugItem.unitcost = sourceDrugItem.unitcost;
                    targetDrugItem.gfmiscode = sourceDrugItem.gfmiscode;
                    targetDrugItem.ipd_price = sourceDrugItem.ipd_price;
                    targetDrugItem.oldcode = sourceDrugItem.oldcode;
                    targetDrugItem.habit_forming = sourceDrugItem.habit_forming;
                    targetDrugItem.did = sourceDrugItem.did;
                    targetDrugItem.stock_type = sourceDrugItem.stock_type;
                    targetDrugItem.price2 = sourceDrugItem.price2;
                    targetDrugItem.price3 = sourceDrugItem.price3;
                    targetDrugItem.ipd_price2 = sourceDrugItem.ipd_price2;
                    targetDrugItem.ipd_price3 = sourceDrugItem.ipd_price3;
                    targetDrugItem.price_lock = sourceDrugItem.price_lock;
                    targetDrugItem.pregnancy = sourceDrugItem.pregnancy;
                    targetDrugItem.pharmacology_group1 = sourceDrugItem.pharmacology_group1;
                    targetDrugItem.pharmacology_group2 = sourceDrugItem.pharmacology_group2;
                    targetDrugItem.pharmacology_group3 = sourceDrugItem.pharmacology_group3;
                    targetDrugItem.generic_name = sourceDrugItem.generic_name;
                    targetDrugItem.show_pregnancy_alert = sourceDrugItem.show_pregnancy_alert;
                    targetDrugItem.icode_guid = sourceDrugItem.icode_guid;
                    targetDrugItem.na = sourceDrugItem.na;
                    targetDrugItem.invcode = sourceDrugItem.invcode;
                    targetDrugItem.check_user_group = sourceDrugItem.check_user_group;
                    targetDrugItem.check_user_name = sourceDrugItem.check_user_name;
                    targetDrugItem.show_notify = sourceDrugItem.show_notify;
                    targetDrugItem.show_notify_text = sourceDrugItem.show_notify_text;
                    targetDrugItem.income = sourceDrugItem.income;
                    targetDrugItem.print_sticker_pq = sourceDrugItem.print_sticker_pq;
                    targetDrugItem.charge_service_opd = sourceDrugItem.charge_service_opd;
                    targetDrugItem.charge_service_ipd = sourceDrugItem.charge_service_ipd;
                    targetDrugItem.ename = sourceDrugItem.ename;
                    targetDrugItem.dose_type = sourceDrugItem.dose_type;
                    targetDrugItem.habit_forming_type = sourceDrugItem.habit_forming_type;
                    targetDrugItem.no_discount = sourceDrugItem.no_discount;
                    targetDrugItem.therapeutic_eng = sourceDrugItem.therapeutic_eng;
                    targetDrugItem.hintcode_eng = sourceDrugItem.hintcode_eng;
                    targetDrugItem.limit_drugusage = sourceDrugItem.limit_drugusage;
                    targetDrugItem.print_sticker_header = sourceDrugItem.print_sticker_header;
                    targetDrugItem.calc_idr_qty = sourceDrugItem.calc_idr_qty;
                    targetDrugItem.item_in_hospital = sourceDrugItem.item_in_hospital;
                    targetDrugItem.no_substock = sourceDrugItem.no_substock;
                    targetDrugItem.volume_cc = sourceDrugItem.volume_cc;
                    targetDrugItem.usage_code = sourceDrugItem.usage_code;
                    targetDrugItem.frequency_code = sourceDrugItem.frequency_code;
                    targetDrugItem.time_code = sourceDrugItem.time_code;
                    targetDrugItem.dispense_dose = sourceDrugItem.dispense_dose;
                    targetDrugItem.usage_unit_code = sourceDrugItem.usage_unit_code;
                    targetDrugItem.dose_per_units = sourceDrugItem.dose_per_units;
                    targetDrugItem.ipd_default_pay = sourceDrugItem.ipd_default_pay;
                    targetDrugItem.billcode = sourceDrugItem.billcode;
                    targetDrugItem.billnumber = sourceDrugItem.billnumber;
                    targetDrugItem.lockprint_ipd = sourceDrugItem.lockprint_ipd;
                    targetDrugItem.pregnancy_notify_text = sourceDrugItem.pregnancy_notify_text;
                    targetDrugItem.show_breast_feeding_alert = sourceDrugItem.show_breast_feeding_alert;
                    targetDrugItem.breast_feeding_alert_text = sourceDrugItem.breast_feeding_alert_text;
                    targetDrugItem.show_child_notify = sourceDrugItem.show_child_notify;
                    targetDrugItem.child_notify_text = sourceDrugItem.child_notify_text;
                    targetDrugItem.child_notify_min_age = sourceDrugItem.child_notify_min_age;
                    targetDrugItem.child_notify_max_age = sourceDrugItem.child_notify_max_age;
                    targetDrugItem.continuous = sourceDrugItem.continuous;
                    targetDrugItem.substitute_icode = sourceDrugItem.substitute_icode;
                    targetDrugItem.trade_name = sourceDrugItem.trade_name;
                    targetDrugItem.use_right_allow = sourceDrugItem.use_right_allow;
                    targetDrugItem.medication_machine_id = sourceDrugItem.medication_machine_id;
                    targetDrugItem.ipd_medication_machine_id = sourceDrugItem.ipd_medication_machine_id;
                    targetDrugItem.check_remed_qty = sourceDrugItem.check_remed_qty;
                    targetDrugItem.addict = sourceDrugItem.addict;
                    targetDrugItem.addict_type_id = sourceDrugItem.addict_type_id;
                    targetDrugItem.medication_machine_opd_no = sourceDrugItem.medication_machine_opd_no;
                    targetDrugItem.medication_machine_ipd_no = sourceDrugItem.medication_machine_ipd_no;
                    targetDrugItem.fp_drug = sourceDrugItem.fp_drug;
                    targetDrugItem.usage_code_ipd = sourceDrugItem.usage_code_ipd;
                    targetDrugItem.dispense_dose_ipd = sourceDrugItem.dispense_dose_ipd;
                    targetDrugItem.usage_unit_code_ipd = sourceDrugItem.usage_unit_code_ipd;
                    targetDrugItem.frequency_code_ipd = sourceDrugItem.frequency_code_ipd;
                    targetDrugItem.time_code_ipd = sourceDrugItem.time_code_ipd;
                    targetDrugItem.print_ipd_injection_sticker = sourceDrugItem.print_ipd_injection_sticker;
                    targetDrugItem.provis_medication_unit_code = sourceDrugItem.provis_medication_unit_code;
                    targetDrugItem.hos_guid = sourceDrugItem.hos_guid;
                    targetDrugItem.sks_product_category_id = sourceDrugItem.sks_product_category_id;
                    targetDrugItem.sks_claim_control_type_id = sourceDrugItem.sks_claim_control_type_id;
                    targetDrugItem.sks_drug_code = sourceDrugItem.sks_drug_code;
                    targetDrugItem.sks_dfs_code = sourceDrugItem.sks_dfs_code;
                    targetDrugItem.sks_dfs_text = sourceDrugItem.sks_dfs_text;
                    targetDrugItem.sks_reimb_price = sourceDrugItem.sks_reimb_price;
                    targetDrugItem.hos_guid_ext = sourceDrugItem.hos_guid_ext;
                    targetDrugItem.check_druginteraction_history = sourceDrugItem.check_druginteraction_history;
                    targetDrugItem.check_druginteraction_history_day = sourceDrugItem.check_druginteraction_history_day;
                    targetDrugItem.nhso_adp_type_id = sourceDrugItem.nhso_adp_type_id;
                    targetDrugItem.nhso_adp_code = sourceDrugItem.nhso_adp_code;
                    targetDrugItem.sks_claim_control_type_id = sourceDrugItem.sks_claim_control_type_id;
                    targetDrugItem.begin_date = sourceDrugItem.begin_date;
                    targetDrugItem.finish_date = sourceDrugItem.finish_date;
                    targetDrugItem.name_pr = sourceDrugItem.name_pr;
                    targetDrugItem.name_eng = sourceDrugItem.name_eng;
                    targetDrugItem.capacity_name = sourceDrugItem.capacity_name;
                    targetDrugItem.finish_reason = sourceDrugItem.finish_reason;
                    targetDrugItem.extra_unitcost = sourceDrugItem.extra_unitcost;
                    targetDrugItem.drug_control_type_id = sourceDrugItem.drug_control_type_id;
                    targetDrugItem.name_print = sourceDrugItem.name_print;
                    targetDrugItem.active_ingredient_mg = sourceDrugItem.active_ingredient_mg;
                    targetDrugItem.no_order_g6pd = sourceDrugItem.no_order_g6pd;
                    targetDrugItem.gender_check = sourceDrugItem.gender_check;
                    targetDrugItem.no_order_gender = sourceDrugItem.no_order_gender;
                    targetDrugItem.max_qty = sourceDrugItem.max_qty;
                    targetDrugItem.prefer_opd_usage_code = sourceDrugItem.prefer_opd_usage_code;
                    targetDrugItem.capacity_qty = sourceDrugItem.capacity_qty;
                    targetDrugItem.need_order_reason = sourceDrugItem.need_order_reason;
                    targetDrugItem.drugitems_due_type_id = sourceDrugItem.drugitems_due_type_id;
                    targetDrugItem.drugeval_head_id = sourceDrugItem.drugeval_head_id;
                    targetDrugItem.light_protect = sourceDrugItem.light_protect;
                    targetDrugItem.tpu_code_list = sourceDrugItem.tpu_code_list;
                    targetDrugItem.inv_map_update = sourceDrugItem.inv_map_update;
                    targetDrugItem.special_advice_text = sourceDrugItem.special_advice_text;
                    targetDrugItem.precaution_advice_text = sourceDrugItem.precaution_advice_text;
                    targetDrugItem.contra_advice_text = sourceDrugItem.contra_advice_text;
                    targetDrugItem.storage_advice_text = sourceDrugItem.storage_advice_text;
                    targetDrugItem.qr_code_url = sourceDrugItem.qr_code_url;
                    targetDrugItem.vat_percent = sourceDrugItem.vat_percent;
                    targetDrugItem.acc_regist = sourceDrugItem.acc_regist;
                    targetDrugItem.use_paidst = sourceDrugItem.use_paidst;
                    targetDrugItem.thai_name = sourceDrugItem.thai_name;
                    targetDrugItem.fwf_item_id = sourceDrugItem.fwf_item_id;
                    targetDrugItem.drugitems_em1_id = sourceDrugItem.drugitems_em1_id;
                    targetDrugItem.drugitems_em2_id = sourceDrugItem.drugitems_em2_id;
                    targetDrugItem.drugitems_em3_id = sourceDrugItem.drugitems_em3_id;
                    targetDrugItem.drugitems_em4_id = sourceDrugItem.drugitems_em4_id;
                    targetDrugItem.tmt_tp_code = sourceDrugItem.tmt_tp_code;
                    targetDrugItem.tmt_gp_code = sourceDrugItem.tmt_gp_code;
                    targetDrugItem.limit_pttype = sourceDrugItem.limit_pttype;
                    targetDrugItem.noshow_narcotic = sourceDrugItem.noshow_narcotic;
                    targetDrugItem.medication_machine_flag = sourceDrugItem.medication_machine_flag;
                    targetDrugItem.sks_price = sourceDrugItem.sks_price;
                    targetDrugItem.print_sticker_by_frequency = sourceDrugItem.print_sticker_by_frequency;
                    targetDrugItem.print_sticker_pq_ipd = sourceDrugItem.print_sticker_pq_ipd;
                    targetDrugItem.sub_income = sourceDrugItem.sub_income;
                    targetDrugItem.prefer_ipd_usage_code = sourceDrugItem.prefer_ipd_usage_code;
                    targetDrugItem.default_qty_ipd = sourceDrugItem.default_qty_ipd;
                    targetDrugItem.max_qty_ipd = sourceDrugItem.max_qty_ipd;
                    targetDrugItem.drugusage_ipd = sourceDrugItem.drugusage_ipd;
                    targetDrugItem.no_popup_ipd_reason = sourceDrugItem.no_popup_ipd_reason;
                    targetDrugItem.specprep = sourceDrugItem.specprep;
                    targetDrugItem.med_dose_calc_type_id = sourceDrugItem.med_dose_calc_type_id;
                    targetDrugItem.send_line_notify = sourceDrugItem.send_line_notify;
                    targetDrugItem.show_qrcode_trade = sourceDrugItem.show_qrcode_trade;
                    targetDrugItem.warn_g6pd = sourceDrugItem.warn_g6pd;
                    targetDrugItem.ipd_rx_freq_day = sourceDrugItem.ipd_rx_freq_day;
                    targetDrugItem.displaycolor_focus = sourceDrugItem.displaycolor_focus;
                    targetDrugItem.last_update = sourceDrugItem.last_update;
                    targetDrugItem.no_remed = sourceDrugItem.no_remed;
                    targetDrugItem.force_round_qty = sourceDrugItem.force_round_qty;
                    targetDrugItem.atc_code = sourceDrugItem.atc_code;
                    targetDrugItem.state_item_id = sourceDrugItem.state_item_id;
                    targetDrugItem.multiply_charge_service = sourceDrugItem.multiply_charge_service;
                    targetDrugItem.csmbs_claim_cat = sourceDrugItem.csmbs_claim_cat;
                    targetDrugItem.simb_2005 = sourceDrugItem.simb_2005;
                    targetDrugItem.sks_rev_date = sourceDrugItem.sks_rev_date;
                    targetDrugItem.sct_unit_code = sourceDrugItem.sct_unit_code;
                    targetDrugItem.print_label = sourceDrugItem.print_label;

                    _dataContext.drugitems.Update(targetDrugItem);
                }

            }

            await _dataContext.SaveChangesAsync();
        }
    }
}
