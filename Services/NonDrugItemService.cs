using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface INonDrugItemSyncService
    {
        Task SyncAsync();
    }

    public class NonDrugItemSyncService : INonDrugItemSyncService
    {
        private readonly DataContext _dataContext;
        private readonly HisContext _hisContext;

        public NonDrugItemSyncService(DataContext dataContext, HisContext hisContext)
        {
            _dataContext = dataContext;
            _hisContext = hisContext;
        }

        public async Task SyncAsync()
        {
            var sourceNonDrugItems = await _hisContext.nondrugitems.AsNoTracking().ToListAsync();
            var targetNonDrugItems = await _dataContext.nondrugitems.AsNoTracking().ToListAsync();

            foreach (var sourceNonDrugItem in sourceNonDrugItems)
            {
                var targetNonDrugItem = targetNonDrugItems.FirstOrDefault(i => i.icode == sourceNonDrugItem.icode);

                if (targetNonDrugItem == null)
                {
                    var newNonDrugItem = new nondrugitem
                    {
                        icode = sourceNonDrugItem.icode,
                        name = sourceNonDrugItem.name,
                        price = sourceNonDrugItem.price,
                        income = sourceNonDrugItem.income,
                        xrayfilm = sourceNonDrugItem.xrayfilm,
                        icd9cm = sourceNonDrugItem.icd9cm,
                        iflag = sourceNonDrugItem.iflag,
                        vorder = sourceNonDrugItem.vorder,
                        note = sourceNonDrugItem.note,
                        use_right = sourceNonDrugItem.use_right,
                        i_type = sourceNonDrugItem.i_type,
                        must_paid = sourceNonDrugItem.must_paid,
                        paidst = sourceNonDrugItem.paidst,
                        ipd_price = sourceNonDrugItem.ipd_price,
                        unitcost = sourceNonDrugItem.unitcost,
                      organ_code = sourceNonDrugItem.organ_code,
                      displaycolor = sourceNonDrugItem.displaycolor,
                      istatus = sourceNonDrugItem.istatus,
                      price3 = sourceNonDrugItem.price3,
                      price2 = sourceNonDrugItem.price2,
                      ipd_price2 = sourceNonDrugItem.ipd_price2,
                      ipd_price3 = sourceNonDrugItem.ipd_price3,
                      price_lock = sourceNonDrugItem.price_lock,
                      unit = sourceNonDrugItem.unit,
                      icode_guid = sourceNonDrugItem.icode_guid,
                      billcode = sourceNonDrugItem.billcode,
                      billnumber = sourceNonDrugItem.billnumber,
                      detail = sourceNonDrugItem.detail,
                      oldcode = sourceNonDrugItem.oldcode,
                      ext_icode = sourceNonDrugItem.ext_icode,
                      charge_paidst = sourceNonDrugItem.charge_paidst,
                      lockprint = sourceNonDrugItem.lockprint,
                      rx_unique = sourceNonDrugItem.rx_unique,
                      item_is_df = sourceNonDrugItem.item_is_df,
                      df_type_id = sourceNonDrugItem.df_type_id,
                      item_subtype_id = sourceNonDrugItem.item_subtype_id,
                      ename = sourceNonDrugItem.ename,
                      no_remed = sourceNonDrugItem.no_remed,
                      remove_when_admit = sourceNonDrugItem.remove_when_admit,
                      df_percent = sourceNonDrugItem.df_percent,
                      max_price = sourceNonDrugItem.max_price,
                      drugusage = sourceNonDrugItem.drugusage,
                      no_ipd_transfer = sourceNonDrugItem.no_ipd_transfer,
                      no_discount = sourceNonDrugItem.no_discount,
                      df_search_code = sourceNonDrugItem.df_search_code,
                        print_sticker_header = sourceNonDrugItem.print_sticker_header,
                      no_substock = sourceNonDrugItem.no_substock,
                      ipd_default_pay = sourceNonDrugItem.ipd_default_pay,
                      hospital_highcost_code = sourceNonDrugItem.hospital_highcost_code,
                      lockprint_ipd = sourceNonDrugItem.lockprint_ipd,
                      enable_sks_opd = sourceNonDrugItem.enable_sks_opd,
                      enable_sks_ipd = sourceNonDrugItem.enable_sks_ipd,
                      hos_guid = sourceNonDrugItem.hos_guid,
                      show_notify = sourceNonDrugItem.show_notify,
                      show_notify_text = sourceNonDrugItem.show_notify_text,
                      sks_coverage_price = sourceNonDrugItem.sks_coverage_price,
                      sks_product_category_id = sourceNonDrugItem.sks_product_category_id,
                      hos_guid_ext = sourceNonDrugItem.hos_guid_ext,
                      nhso_adp_type_id = sourceNonDrugItem.nhso_adp_type_id,
                      nhso_adp_code = sourceNonDrugItem.nhso_adp_code,
                      extra_unitcost = sourceNonDrugItem.extra_unitcost,
                      property_text = sourceNonDrugItem.property_text,
                      objctive_text = sourceNonDrugItem.objctive_text,
                      vat_percent = sourceNonDrugItem.vat_percent,
                      use_paidst = sourceNonDrugItem.use_paidst,
                      inv_map_update = sourceNonDrugItem.inv_map_update,
                      fwf_item_id = sourceNonDrugItem.fwf_item_id,
                      limit_pttype = sourceNonDrugItem.limit_pttype,
                      sub_income = sourceNonDrugItem.sub_income,
                      nondrugitems_type_id = sourceNonDrugItem.nondrugitems_type_id,
                      ucef_code = sourceNonDrugItem.ucef_code,
                      lockprice = sourceNonDrugItem.lockprice,
                      is_accm = sourceNonDrugItem.is_accm,
                      is_food = sourceNonDrugItem.is_food,
                      displaycolor_focus = sourceNonDrugItem.displaycolor_focus,
                      last_update = sourceNonDrugItem.last_update,
                      charge_service_opd = sourceNonDrugItem.charge_service_opd,
                      charge_service_ipd = sourceNonDrugItem.charge_service_ipd,
                      state_item_id = sourceNonDrugItem.state_item_id,
                      lock_pttype = sourceNonDrugItem.lock_pttype,
                      lock_pttype_code = sourceNonDrugItem.lock_pttype_code,
                      multiply_charge_service = sourceNonDrugItem.multiply_charge_service,
                      csmbs_claim_cat = sourceNonDrugItem.csmbs_claim_cat,
                      simb_2005 = sourceNonDrugItem.simb_2005,
                      default_qty = sourceNonDrugItem.default_qty,
                      max_qty = sourceNonDrugItem.max_qty,
                      sks_rev_date = sourceNonDrugItem.sks_rev_date,
                      default_qty_ipd = sourceNonDrugItem.default_qty_ipd,
                      max_qty_ipd = sourceNonDrugItem.max_qty_ipd,
                      sks_claim_category_type_id = sourceNonDrugItem.sks_claim_category_type_id
                        // Copy all other properties from sourceNonDrugItem to newNonDrugItem
                    };

                    _dataContext.nondrugitems.Add(newNonDrugItem);
                }
                else
                {
                    targetNonDrugItem.name = sourceNonDrugItem.name;
                    targetNonDrugItem.price = sourceNonDrugItem.price;
                    targetNonDrugItem.income = sourceNonDrugItem.income;
                    targetNonDrugItem.xrayfilm = sourceNonDrugItem.xrayfilm;
                    targetNonDrugItem.icd9cm = sourceNonDrugItem.icd9cm;
                    targetNonDrugItem.iflag = sourceNonDrugItem.iflag;
                    targetNonDrugItem.vorder = sourceNonDrugItem.vorder;
                    targetNonDrugItem.note = sourceNonDrugItem.note;
                    targetNonDrugItem.use_right = sourceNonDrugItem.use_right;
                    targetNonDrugItem.i_type = sourceNonDrugItem.i_type;
                    targetNonDrugItem.must_paid = sourceNonDrugItem.must_paid;
                    targetNonDrugItem.paidst = sourceNonDrugItem.paidst;
                    targetNonDrugItem.ipd_price = sourceNonDrugItem.ipd_price;
                    targetNonDrugItem.unitcost = sourceNonDrugItem.unitcost;
                    targetNonDrugItem.organ_code = sourceNonDrugItem.organ_code;
                    targetNonDrugItem.displaycolor = sourceNonDrugItem.displaycolor;
                    targetNonDrugItem.istatus = sourceNonDrugItem.istatus;
                    targetNonDrugItem.price3 = sourceNonDrugItem.price3;
                    targetNonDrugItem.price2 = sourceNonDrugItem.price2;
                    targetNonDrugItem.ipd_price2 = sourceNonDrugItem.ipd_price2;
                    targetNonDrugItem.ipd_price3 = sourceNonDrugItem.ipd_price3;
                    targetNonDrugItem.price_lock = sourceNonDrugItem.price_lock;
                    targetNonDrugItem.unit = sourceNonDrugItem.unit;
                    targetNonDrugItem.icode_guid = sourceNonDrugItem.icode_guid;
                    targetNonDrugItem.billcode = sourceNonDrugItem.billcode;
                    targetNonDrugItem.billnumber = sourceNonDrugItem.billnumber;
                    targetNonDrugItem.detail = sourceNonDrugItem.detail;
                    targetNonDrugItem.oldcode = sourceNonDrugItem.oldcode;
                    targetNonDrugItem.ext_icode = sourceNonDrugItem.ext_icode;
                    targetNonDrugItem.charge_paidst = sourceNonDrugItem.charge_paidst;
                    targetNonDrugItem.lockprint = sourceNonDrugItem.lockprint;
                    targetNonDrugItem.rx_unique = sourceNonDrugItem.rx_unique;
                    targetNonDrugItem.item_is_df = sourceNonDrugItem.item_is_df;
                    targetNonDrugItem.df_type_id = sourceNonDrugItem.df_type_id;
                    targetNonDrugItem.item_subtype_id = sourceNonDrugItem.item_subtype_id;
                    targetNonDrugItem.ename = sourceNonDrugItem.ename;
                    targetNonDrugItem.no_remed = sourceNonDrugItem.no_remed;
                    targetNonDrugItem.remove_when_admit = sourceNonDrugItem.remove_when_admit;
                    targetNonDrugItem.df_percent = sourceNonDrugItem.df_percent;
                    targetNonDrugItem.max_price = sourceNonDrugItem.max_price;
                    targetNonDrugItem.drugusage = sourceNonDrugItem.drugusage;
                    targetNonDrugItem.no_ipd_transfer = sourceNonDrugItem.no_ipd_transfer;
                    targetNonDrugItem.no_discount = sourceNonDrugItem.no_discount;
                    targetNonDrugItem.df_search_code = sourceNonDrugItem.df_search_code;
                    targetNonDrugItem.print_sticker_header = sourceNonDrugItem.print_sticker_header;
                    targetNonDrugItem.no_substock = sourceNonDrugItem.no_substock;
                    targetNonDrugItem.ipd_default_pay = sourceNonDrugItem.ipd_default_pay;
                    targetNonDrugItem.hospital_highcost_code = sourceNonDrugItem.hospital_highcost_code;
                    targetNonDrugItem.lockprint_ipd = sourceNonDrugItem.lockprint_ipd;
                    targetNonDrugItem.enable_sks_opd = sourceNonDrugItem.enable_sks_opd;
                    targetNonDrugItem.enable_sks_ipd = sourceNonDrugItem.enable_sks_ipd;
                    targetNonDrugItem.hos_guid = sourceNonDrugItem.hos_guid;
                    targetNonDrugItem.show_notify = sourceNonDrugItem.show_notify;
                    targetNonDrugItem.show_notify_text = sourceNonDrugItem.show_notify_text;
                    targetNonDrugItem.sks_coverage_price = sourceNonDrugItem.sks_coverage_price;
                    targetNonDrugItem.sks_product_category_id = sourceNonDrugItem.sks_product_category_id;
                    targetNonDrugItem.hos_guid_ext = sourceNonDrugItem.hos_guid_ext;
                    targetNonDrugItem.nhso_adp_type_id = sourceNonDrugItem.nhso_adp_type_id;
                    targetNonDrugItem.nhso_adp_code = sourceNonDrugItem.nhso_adp_code;
                    targetNonDrugItem.extra_unitcost = sourceNonDrugItem.extra_unitcost;
                    targetNonDrugItem.property_text = sourceNonDrugItem.property_text;
                    targetNonDrugItem.objctive_text = sourceNonDrugItem.objctive_text;
                    targetNonDrugItem.vat_percent = sourceNonDrugItem.vat_percent;
                    targetNonDrugItem.use_paidst = sourceNonDrugItem.use_paidst;
                    targetNonDrugItem.inv_map_update = sourceNonDrugItem.inv_map_update;
                    targetNonDrugItem.fwf_item_id = sourceNonDrugItem.fwf_item_id;
                    targetNonDrugItem.limit_pttype = sourceNonDrugItem.limit_pttype;
                    targetNonDrugItem.sub_income = sourceNonDrugItem.sub_income;
                    targetNonDrugItem.nondrugitems_type_id = sourceNonDrugItem.nondrugitems_type_id;
                    targetNonDrugItem.ucef_code = sourceNonDrugItem.ucef_code;
                    targetNonDrugItem.lockprice = sourceNonDrugItem.lockprice;
                    targetNonDrugItem.is_accm = sourceNonDrugItem.is_accm;
                    targetNonDrugItem.is_food = sourceNonDrugItem.is_food;
                    targetNonDrugItem.displaycolor_focus = sourceNonDrugItem.displaycolor_focus;
                    targetNonDrugItem.last_update = sourceNonDrugItem.last_update;
                    targetNonDrugItem.charge_service_opd = sourceNonDrugItem.charge_service_opd;
                    targetNonDrugItem.charge_service_ipd = sourceNonDrugItem.charge_service_ipd;
                    targetNonDrugItem.state_item_id = sourceNonDrugItem.state_item_id;
                    targetNonDrugItem.lock_pttype = sourceNonDrugItem.lock_pttype;
                    targetNonDrugItem.lock_pttype_code = sourceNonDrugItem.lock_pttype_code;
                    targetNonDrugItem.multiply_charge_service = sourceNonDrugItem.multiply_charge_service;
                    targetNonDrugItem.csmbs_claim_cat = sourceNonDrugItem.csmbs_claim_cat;
                    targetNonDrugItem.simb_2005 = sourceNonDrugItem.simb_2005;
                    targetNonDrugItem.default_qty = sourceNonDrugItem.default_qty;
                    targetNonDrugItem.max_qty = sourceNonDrugItem.max_qty;
                    targetNonDrugItem.sks_rev_date = sourceNonDrugItem.sks_rev_date;
                    targetNonDrugItem.default_qty_ipd = sourceNonDrugItem.default_qty_ipd;
                    targetNonDrugItem.max_qty_ipd = sourceNonDrugItem.max_qty_ipd;
                    targetNonDrugItem.sks_claim_category_type_id = sourceNonDrugItem.sks_claim_category_type_id;
                    // Update all other properties from sourceNonDrugItem to targetNonDrugItem
                    _dataContext.nondrugitems.Update(targetNonDrugItem);
                }
            }

            await _dataContext.SaveChangesAsync();
        }
    }
}
