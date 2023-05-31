namespace WebApi.Models.Funds
{
    public class CreateRequest
    {
        public string FundName { get; set; }
        public string FundCode { get; set; }
        public string FundType { get; set; }
        public string FundPatientType { get; set; }
        public string ActiveStatus { get; set; }
        public string FundCodeMap { get; set; }
    }
}
