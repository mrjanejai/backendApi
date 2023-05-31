namespace WebApi.Models.Funds;
using System.Text.Json.Serialization;
using WebApi.Entities;

public class FundResponse
    {
    public int Id { get; set; }
    public string FundName { get; set; }
    public string FundCode { get; set; }
    public string FundType { get; set; }
    public string FundPatientType { get; set; }
    public string ActiveStatus { get; set; }
    public string FundCodeMap { get; set; }

    public FundResponse(int id,string fundName,string fundCode,string fundType,string fundPatientType,string activeStatus,string fundCodeMap)
    { 
        Id = id;
        FundName = fundName;
        FundCode = fundCode;
        FundType = fundType;
        FundPatientType = fundPatientType;
        ActiveStatus = activeStatus;
        FundCodeMap = fundCodeMap;
    }
}

