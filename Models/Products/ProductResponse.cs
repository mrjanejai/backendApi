namespace WebApi.Models.Products;

using System.Text.Json.Serialization;
using WebApi.Entities;

public class ProductResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreateDate { get; set; }
    public string UpdateBy { get; set; }
    public DateTime UpdateDate { get; set; }
    public ProductResponse(int id, string name, string createBy, DateTime createDate, string updateBy, DateTime updateDate)
    {
        Id = id;
        Name = name;
        CreateBy = createBy;
        CreateDate = createDate;
        UpdateBy = updateBy;
        UpdateDate = updateDate;
    }
}
