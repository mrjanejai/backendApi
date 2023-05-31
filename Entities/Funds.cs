using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Funds
    {
        [Key]
        public int Id { get; set; }
        public string? FundName { get; set; }
        public string? FundCode { get; set; }
        public string? FundType { get; set; }
        public string? FundPatientType { get; set; }
        public string? ActiveStatus { get; set; }
        public string? FundCodeMap { get; set; }
    }
}
