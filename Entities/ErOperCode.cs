using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities;

    public class ErOperCodeE
    {
    [Key]
    [Column("er_oper_code")]
    public int? ErOperCode { get; set; }

    public string Name { get; set; }
    public string Icode { get; set; }
    public string Icd9cm { get; set; }
    public double? Price { get; set; }
    public double? Price2 { get; set; }
    public double? Price3 { get; set; }

    [Column("er_oper_code_guid")]
    public string ErOperCodeGuid { get; set; }

    [Column("active_status")]
    public string ActiveStatus { get; set; }

    [Column("has_area_code")]
    public string HasAreaCode { get; set; }
    public string Icd10tm { get; set; }

    [Column("export_proced")]
    public string ExportProced { get; set; }

    [Column("hos_guid")]
    public string HosGuid { get; set; }

    [Column("duration_minute")]
    public TimeSpan? DurationMinute { get; set; }

    [Column("er_oper_code_type_id")]
    public int? ErOperCodeTypeId { get; set; }

    [Column("search_keyword")]
    public string SearchKeyword { get; set; }

    [Column("use_opi_price")]
    public string UseOpiPrice { get; set; }

    [Column("is_investigation")]
    public string IsInvestigation { get; set; }
}

