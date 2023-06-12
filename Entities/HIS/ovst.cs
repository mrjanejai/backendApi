using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class ovst
    {
        [Key]
        public string hos_guid { get; set; }
        public string? vn { get; set; }
        public string? hn { get; set; }
        public string? an { get; set; }
        public DateTime? vstdate { get; set; }
        public TimeSpan? vsttime { get; set; }
        public string? doctor { get; set; }
        public string? hospmain { get; set; }
        public string? hospsub { get; set; }
        public int? oqueue { get; set; }
        public string? ovstist { get; set; }
        public string? ovstost { get; set; }
        public string? pttype { get; set; }
        public string? pttypeno { get; set; }
        public string? rfrics { get; set; }
        public string? rfrilct { get; set; }
        public string? rfrocs { get; set; }
        public string? rfrolct { get; set; }
        public string? spclty { get; set; }
        public string? rcpt_disease { get; set; }
        public string? hcode { get; set; }
        public string? cur_dep { get; set; }
        public string? cur_dep_busy { get; set; }
        public string? last_dep { get; set; }
        public TimeSpan? cur_dep_time { get; set; }
        public int? rx_queue { get; set; }
        public string? diag_text { get; set; }
        public byte? pt_subtype { get; set; }
        public string? main_dep { get; set; }
        public int? main_dep_queue { get; set; }
        public DateTime? finance_summary_date { get; set; }
        public string? visit_type { get; set; }
        public string? node_id { get; set; }
        public int? contract_id { get; set; }
        public string? waiting { get; set; }
        public string? rfri_icd10 { get; set; }
        public int? o_refer_number { get; set; }
        public string? has_insurance { get; set; }
        public string? i_refer_number { get; set; }
        public string? refer_type { get; set; }
        public string? o_refer_dep { get; set; }
        public string? staff { get; set; }
        public string? command_doctor { get; set; }
        public string? send_person { get; set; }
        public int? pt_priority { get; set; }
        public string? finance_lock { get; set; }
        public string? oldcode { get; set; }
        public string? sign_doctor { get; set; }
        public string? anonymous_visit { get; set; }
        public string? anonymous_vn { get; set; }
        public int? pt_capability_type_id { get; set; }
        public string? at_hospital { get; set; }
        public string? ovst_key { get; set; }

        public Dictionary<string, object> ToInsertFieldValues()
        {
            return new Dictionary<string, object>()
            {
                { "hos_guid", hos_guid },
                { "vn", vn },
                { "hn", hn },
                { "an", an },
                { "vstdate", vstdate },
                { "vsttime", vsttime },
                { "doctor", doctor },
                { "hospmain", hospmain },
                { "hospsub", hospsub },
                { "oqueue", oqueue },
                { "ovstist", ovstist },
                { "ovstost", ovstost },
                { "pttype", pttype },
                { "pttypeno", pttypeno },
                { "rfrics", rfrics },
                { "rfrilct", rfrilct },
                { "rfrocs", rfrocs },
                { "rfrolct", rfrolct },
                { "spclty", spclty },
                { "rcpt_disease", rcpt_disease },
                { "hcode", hcode },
                { "cur_dep", cur_dep },
                { "cur_dep_busy", cur_dep_busy },
                { "last_dep", last_dep },
                { "cur_dep_time", cur_dep_time },
                { "rx_queue", rx_queue },
                { "diag_text", diag_text },
                { "pt_subtype", pt_subtype },
                { "main_dep", main_dep },
                { "main_dep_queue", main_dep_queue },
                { "finance_summary_date", finance_summary_date },
                { "visit_type", visit_type },
                { "node_id", node_id },
                { "contract_id", contract_id },
                { "waiting", waiting },
                { "rfri_icd10", rfri_icd10 },
                { "o_refer_number", o_refer_number },
                { "has_insurance", has_insurance },
                { "i_refer_number", i_refer_number },
                { "refer_type", refer_type },
                { "o_refer_dep", o_refer_dep },
                { "staff", staff },
                { "command_doctor", command_doctor },
                { "send_person", send_person },
                { "pt_priority", pt_priority },
                { "finance_lock", finance_lock },
                { "oldcode", oldcode },
                { "sign_doctor", sign_doctor },
                { "anonymous_visit", anonymous_visit },
                { "anonymous_vn", anonymous_vn },
                { "pt_capability_type_id", pt_capability_type_id },
                { "at_hospital", at_hospital },
                { "ovst_key", ovst_key }
            };
        }

        public Dictionary<string, object> ToUpdateKeyValues()
        {
            return new Dictionary<string, object>()
            {
                { "hos_guid", hos_guid }
            };
        }
    }
}
