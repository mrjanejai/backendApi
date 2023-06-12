namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using System.Data;
using WebApi.Entities;
using WebApi.Entities.eclaim;
using WebApi.Entities.HIS;
using WebApi.Models.Products;

public class DataContext : DbContext
{

    private readonly IConfiguration _configuration;

    public DataContext() { 
    
    }

    public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    // program master table
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Icd101> Icd101 { get; set; }
    public DbSet<ErOperCodeE> er_oper_code { get; set; }
    public DbSet<nondrugitem> nondrugitems { get; set; }
    public DbSet<drugitems> drugitems { get; set; }
    public DbSet<pttype> pttype { get; set; }
    public DbSet<IptOperCodeE> ipt_oper_code { get; set; }
    public DbSet<kskdepartment> kskdepartment { get; set; }
    public DbSet<Funds> Funds { get; set; }

    //program transecsion table
    public DbSet<ovst> ovst { get; set; }
    public DbSet<visit_pttype> visit_pttype { get; set; }
    public DbSet<opitemrece> opitemrece { get; set; }
    public DbSet<doctor_operation> doctor_operation { get; set; }
    public DbSet<ovstdiag> ovstdiag { get; set; }
    public DbSet<ovst_doctor_diag> ovst_doctor_diag { get; set; }
    public DbSet<ipt> ipt { get; set; }
    public DbSet<ipt_nurse_oper> ipt_nurse_oper { get; set; }
    public DbSet<ipt_doctor_diag> ipt_Doctor_diag { get; set; }
    public DbSet<patient> patient { get; set; }
    public DbSet<eclaim> eclaim { get; set; }


    public async Task OpenDatabaseAsync()
    {
        await Database.OpenConnectionAsync();
    }

    public async Task CloseDatabaseAsync()
    {
        await Database.CloseConnectionAsync();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = _configuration.GetConnectionString("WebApiDatabase");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }


}

public class HisContext : DbContext
{
    private readonly IConfiguration _configuration;

    public HisContext() { 
    
    }

    public HisContext(DbContextOptions<HisContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    //His Master table
    public DbSet<Icd101> icd101 { get; set; }
    public DbSet<ErOperCodeE> er_oper_code { get; set;}
    public DbSet<nondrugitem> nondrugitems { get; set; }
    public DbSet<drugitems> drugitems { get; set; }
    public DbSet<pttype> pttype { get; set; }
    public DbSet<IptOperCodeE> ipt_oper_code { get; set; }
    public DbSet<kskdepartment> kskdepartment { get; set; }

    //HIS transecsion table
    public DbSet<ovst> ovst { get; set; }
    public DbSet<visit_pttype> visit_pttype { get; set; }
    public DbSet<opitemrece> opitemrece { get; set; }
    public DbSet<doctor_operation> doctor_operation { get; set; }
    public DbSet<ovstdiag> ovstdiag { get; set; }
    public DbSet<ovst_doctor_diag> ovst_doctor_diag { get; set; }
    public DbSet<ipt> ipt { get; set; }
    public DbSet<ipt_nurse_oper> ipt_nurse_oper { get; set; }
    public DbSet<ipt_doctor_diag> ipt_Doctor_diag { get; set; }
    public DbSet<patient> patient { get; set; }
    public DbSet<eclaim> eclaim { get; set; }

    public async Task OpenDatabaseAsync()
    {
        await Database.OpenConnectionAsync();
    }

    public async Task CloseDatabaseAsync()
    {
        await Database.CloseConnectionAsync();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = _configuration.GetConnectionString("HISDatabase");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }


}