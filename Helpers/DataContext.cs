namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using WebApi.Entities;
using WebApi.Models.Products;

public class DataContext : DbContext
{

    private readonly IConfiguration Configuration;
    private DbSet<Icd101> icd101s;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // in memory database used for simplicity, change to a real db for production applications
        //options.UseInMemoryDatabase("TestDb");
        var connectionString = Configuration.GetConnectionString("WebApiDatabase");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Icd101> Icd101 { get; set; }
    public DbSet<ErOperCodeE> er_oper_code { get; set; }
    public DbSet<nondrugitem> nondrugitems { get; set;}
    public DbSet<drugitems> drugitems { get; set; }
    public DbSet<pttype> pttype { get; set; }

}

public class HisContext : DbContext
{
    private IConfiguration Configuration;
    public HisContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //base.OnConfiguring(optionsBuilder);
        var connectionString = Configuration.GetConnectionString("HISDatabase");
        optionsBuilder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
    }
    public DbSet<Icd101> icd101 { get; set; }
    public DbSet<ErOperCodeE> er_oper_code { get; set;}
    public DbSet<nondrugitem> nondrugitems { get; set; }
    public DbSet<drugitems> drugitems { get; set; }

    public DbSet<pttype> pttype { get; set; }
}