using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using WebApi.Models.Products;
using AutoMapper;
using WebApi.Authorization;
using Microsoft.AspNetCore.Http;
using WebApi.Entities;


namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;  
        private readonly IHttpContextAccessor _httpContextAccessor;
        private IMapper _mapper;
        private IUserService _userService;

        public ProductsController(IProductService productService, IHttpContextAccessor httpContextAccessor, IMapper mapper, IUserService userService)
        {
            _productService = productService;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _userService = userService;
        }

        // GET: Products
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        // GET: Products/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
            return Ok(product);
        }

        // POST: Products
        [HttpPost]
        public IActionResult Create([FromBody] CreateRequest model)
        {
            // create product
            var user = (User)_httpContextAccessor.HttpContext.Items["User"];
            var userId = user.Id.ToString();
            model.CreateBy=userId;

            _productService.Create(model);
            return Ok(new { message = "Product created successfully" });
        }

        // PUT: Products/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateRequest model)
        {
            // update product
            var user = (User)_httpContextAccessor.HttpContext.Items["User"];
            var userId = user.Id.ToString();
            model.UpdateBy = userId;

            _productService.Update(id,model);
            return Ok(new { message = "Product updated successfully" });
        }

        // DELETE: Products/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // delete product
            _productService.Delete(id);
            return Ok(new { message = "Product deleted successfully" });
        }
    }
}
