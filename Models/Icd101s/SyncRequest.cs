using System.Runtime.CompilerServices;
namespace WebApi.Models.Icd101;

    public class SyncRequest
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Spclty { get; set; }
        public string Tname { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public int Sex { get; set; }
        public string IpdValid { get; set; } 
        public string Icd10compat { get; set; }
        public string Icd10tmcompat { get; set; }
        public string ActiveStatus { get; set; }
        public string HosGuid { get; set; }
        public string HosGuidExt { get; set; }
    }

