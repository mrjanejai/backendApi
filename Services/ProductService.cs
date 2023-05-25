namespace WebApi.Services;


using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Products;
using WebApi.Authorization;
using AutoMapper;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    Product GetById(int id);
    void Create(CreateRequest model);
    void Update(int id, UpdateRequest model);
    void Delete(int id);
}

public class ProductService : IProductService
{
    private DataContext _context;
    private IJwtUtils _jwtUtils;
    private readonly AppSettings _appSettings;
    private readonly IMapper _mapper;

    public ProductService(
        DataContext context,
        IJwtUtils jwtUtils, IMapper mapper)
    {
        _context = context;
        _jwtUtils = jwtUtils;
        _mapper = mapper;
    }

    public IEnumerable<ProductResponse> GetAll()
    {
        return (IEnumerable<ProductResponse>)_context.Products;
    }

    public Product GetById(int id)
    {
        return getProduct(id);
    }

    public void Create(CreateRequest model)
    {
           
        // validation
        if (string.IsNullOrWhiteSpace(model.Name))
            throw new AppException("Name is required");

        if (_context.Products.Any(x => x.Name == model.Name))
            throw new AppException("Name \"" + model.Name + "\" is already taken");

        // map model to new user object
        var product = _mapper.Map<Product>(model);

        _context.Products.Add(product);
        _context.SaveChanges();

        //return new ProductResponse(product.Id, product.Name, product.CreateBy, product.CreateDate, product.UpdateBy, product.UpdateDate);
    }

    public void Update(int id,UpdateRequest model)
    {
        //var product = _context.Products.Find(model.Id);

        var product = getProduct(id);
        if (string.IsNullOrEmpty(product.Name))
        {
            model.Name = product.Name;
        }


        if (product == null)
            throw new AppException("Product not found");


        // update product properties
        product.Name = model.Name;
        product.UpdateBy = model.UpdateBy;
        product.UpdateDate = DateTime.UtcNow;

        _context.Products.Update(product);
        _context.SaveChanges();

        //return new ProductResponse(product.Id, product.Name, product.CreateBy, product.CreateDate, product.UpdateBy, product.UpdateDate);
    }

    public void Delete(int id)
    {

        var product = _context.Products.Find(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }

    IEnumerable<Product> IProductService.GetAll()
    {
        return (IEnumerable<Product>)_context.Products;
    }

    Product IProductService.GetById(int id)
    {
        return getProduct(id);
    }


    private Product getProduct(int id)
    {
        var product = _context.Products.Find(id);
        if (product == null) throw new KeyNotFoundException("Product not found");
        return product;
    }
}
