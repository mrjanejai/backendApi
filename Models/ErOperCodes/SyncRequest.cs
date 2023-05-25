using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
namespace WebApi.Models.ErOperCodes;

    public class SyncRequest
    {
    public int ErOperCode { get; set; }
    public string Name { get; set; }
    public string Icode { get; set; }
    public string Icd9cm { get; set; }
    public double Price { get; set; }
    public double Price2 { get; set; }
    public double Price3 { get; set; }
    public string ErOperCodeGuid { get; set; }
    public string ActiveStatus { get; set; }
    public string HasAreaCode { get; set; }
    public string Icd10tm { get; set; }
    public string ExportProced { get; set; }
    public string HosGuid { get; set; }
    public TimeSpan DurationMinute { get; set; }
    public int ErOperCodeTypeId { get; set; }
    public string SearchKeyword { get; set; }
    public string UseOpiPrice { get; set; }
    public string IsInvestigation { get; set; }
    }

