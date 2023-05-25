using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Icd101
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Spclty { get; set; }
        public string Tname { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public int? Sex { get; set; }

        [Column("ipd_valid")]
        public string IpdValid { get; set; }

        public string Icd10compat { get; set; }
        public string Icd10tmcompat { get; set; }

        [Column("active_status")]
        public string ActiveStatus { get; set; }

        [Column("hos_guid")]
        public string HosGuid { get; set; }

        [Column("hos_guid_ext")]
        public string HosGuidExt { get; set; }
    }
}
