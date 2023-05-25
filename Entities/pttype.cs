using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities;

    public class pttype
    {
    [Key]
    public string Pttype { get; set; }
    public string Name { get; set; }
    public string Editmask { get; set; }
    public string Isuse { get; set; }
    public string Pcode { get; set; }

    [Column("hipdata_code")]
    public string HipdataCode { get; set; }

    [Column("nhso_code")]
    public string NhsoCode { get; set; }
  
}

