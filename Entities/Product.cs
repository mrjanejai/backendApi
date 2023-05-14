namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public string createby { get; set; }
    public DateTime createdate { get; set; }
    public string updateby { get; set; }
    public DateTime updatedate { get; set; }
}

