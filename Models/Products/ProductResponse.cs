namespace WebApi.Models.Products;

using System.Text.Json.Serialization;
using WebApi.Entities;

public class ProductResponse
{
    public int id { get; set; }
    public string name { get; set; }
    public string createby { get; set; }
    public DateTime createdate { get; set; }
    public string updateby { get; set; }
    public DateTime updatedate { get; set; }

    public ProductResponse(int id_, string name_, string createby_, DateTime createdate_, string updateby_, DateTime updatedate_)
    {
        this.id = id_;
        this.name = name_;
        this.createby = createby_;
        this.createdate = createdate_;
        this.updateby = updateby_;
        this.updatedate = updatedate_;
    }
}

