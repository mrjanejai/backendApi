namespace WebApi.Models.Funds
{
    public class UpdateRequest
    {
        public string FundName { get; set; }
        public string FundCode { get; set; }
        public string FundType { get; set; }
        public string FundPatientType { get; set; }
        public string ActiveStatus { get; set; }
        public string FundCodeMap { get; set; }
    }
}
