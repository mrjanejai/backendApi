﻿namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreateDate { get; set; }
    public string UpdateBy { get; set; }
    public DateTime UpdateDate { get; set; }
}

