using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using WebApi.Models.Funds;
using AutoMapper;
using WebApi.Authorization;
using Microsoft.AspNetCore.Http;
using WebApi.Entities;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class FundsController : ControllerBase
    {
        private IFundService _fundService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private IMapper _mapper;
        private IUserService _userService;

        public FundsController(IFundService fundService, IHttpContextAccessor httpContextAccessor, IMapper mapper, IUserService userService)
        {
            _fundService = fundService;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _userService = userService;
        }

        // GET: funds
        [HttpGet]
        public IActionResult GetAll()
        {
            var funds = _fundService.GetAll();
            return Ok(funds);
        }

        // GET: funds/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _fundService.GetById(id);
            return Ok(product);
        }

        // POST: funds
        [HttpPost]
        public IActionResult Create([FromBody] CreateRequest model)
        {
            // create funds
            //var user = (User)_httpContextAccessor.HttpContext.Items["User"];
            //var userId = user.Id.ToString();
            //model.CreateBy = userId;

            _fundService.Create(model);
            return Ok(new { message = "funds created successfully" });
        }

        // PUT: funds/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateRequest model)
        {
            // update funds
            //var user = (User)_httpContextAccessor.HttpContext.Items["User"];
            //var userId = user.Id.ToString();
            //model.UpdateBy = userId;

            _fundService.Update(id, model);
            return Ok(new { message = "funds updated successfully" });
        }

        // DELETE: funds/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // delete funds
            _fundService.Delete(id);
            return Ok(new { message = "funds deleted successfully" });
        }

    }
}
