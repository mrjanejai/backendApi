namespace WebApi.Services;
using Microsoft.Extensions.Options;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Funds;
using WebApi.Authorization;
using System.Security.Cryptography;
using System.Text;
using AutoMapper;

public interface IFundService
{
    IEnumerable<Funds> GetAll();
    Funds GetById(int id);
    void Create(CreateRequest model);
    void Update(int id, UpdateRequest model);
    void Delete(int id);
}

public class FundService : IFundService
{
    private DataContext _context;
    private IJwtUtils _jwtUtils;
    private readonly AppSettings _appSettings;
    private readonly IMapper _mapper;

    public FundService(
        DataContext context,
        IJwtUtils jwtUtils,
        IOptions<AppSettings> appSettings,
        IMapper mapper)
    {
        _context = context;
        _jwtUtils = jwtUtils;
        _appSettings = appSettings.Value;
        _mapper = mapper;
    }

    public IEnumerable<Funds> GetAll()
    {
        return _context.Funds;
    }

    public Funds GetById(int id)
    {
        var fund = _context.Funds.Find(id);
        if (fund == null) throw new KeyNotFoundException("Funds not found");
        return fund;
    }

    public void Create(CreateRequest model)
    {
        // validate
        if (_context.Funds.Any(x => x.FundName == model.FundName))
            throw new AppException("Funds with the Fund Name '" + model.FundName + "' already exists");

        // map model to new user object
        var fund = _mapper.Map<Funds>(model);

        // hash password
        //fund.PasswordHash = MD5Hash(model.Password); //BCrypt.HashPassword(model.Password);

        // save user
        _context.Funds.Add(fund);
        _context.SaveChanges();
    }

    public void Update(int id, UpdateRequest model)
    {
        var fund = GetById(id);

        // Validate
        if (!string.IsNullOrEmpty(fund.FundName) && _context.Funds.Any(x => x.FundName == fund.FundName && x.Id != id))
        {
            throw new AppException("Fund with the Fund Name '" + fund.FundName + "' already exists");
        }

        //// Hash password if it was entered
        //if (!string.IsNullOrEmpty(model.Password))
        //{
        //    fund.PasswordHash = MD5Hash(model.Password);
        //}
        //if (string.IsNullOrEmpty(model.Email))
        //{
        //    //user.Email = model.Email;
        //    model.Email = user.Email;
        //}
        //if (string.IsNullOrEmpty(model.Title))
        //{
        //    //user.Title = model.Title;
        //    model.Title = user.Title;
        //}

        // Copy model to user
        _mapper.Map(model, fund);


        // Save
        _context.Funds.Update(fund);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var fund = GetById(id);
        _context.Funds.Remove(fund);
        _context.SaveChanges();
    }
}

