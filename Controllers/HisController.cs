using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using AutoMapper;
using WebApi.Authorization;
using Microsoft.AspNetCore.Http;
using WebApi.Entities;
using WebApi.Entities.HIS;
using System;
using System.Threading.Tasks;
using WebApi.Helpers;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HisController : ControllerBase
    {
        private readonly IHisService _hisService;
        private readonly IOpitemreceService _opitemreceService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly DataContext _dataContext;
        private readonly HisContext _hisContext;

        public HisController(IHisService hisService
            , IOpitemreceService opitemreceService
            , IHttpContextAccessor httpContextAccessor
            , IMapper mapper, IUserService userService
            , DataContext dataContext
            , HisContext hisContext)
        {
            _hisService = hisService;
            _opitemreceService = opitemreceService;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _userService = userService;
            _dataContext = dataContext;
            _hisContext = hisContext;
        }

        // POST: /his/hisSync?startDate=2023-05-01&endDate=2023-05-01&pRoom=001
        [HttpPost("hisSync")]
        public async Task<IActionResult> OvstSync([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, [FromQuery] string pRoom)
        {
            try
            {
                // Set the command timeout to a larger value (e.g., 180 seconds)
                //_hisContext.Database.SetCommandTimeout(300);

                await _hisService.SyncHisData(startDate, endDate, pRoom);
                return Ok();
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate response
                return StatusCode(500, "An error occurred during synchronization.");
            }
        }




    }
}
