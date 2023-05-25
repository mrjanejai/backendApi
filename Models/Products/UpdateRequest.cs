namespace WebApi.Models.Products;

public class UpdateRequest
{
    public string Name { get; set; }
    public string UpdateBy { get; set; }
    public DateTime UpdateDate { get; set; }
}
