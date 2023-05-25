using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Products;

public class CreateRequest
{
    [Required]
    public string Name { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreateDate { get; set; }
    public string UpdateBy { get; set; }
    public DateTime UpdateDate { get; set; }
}
