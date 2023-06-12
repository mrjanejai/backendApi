using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadsController : ControllerBase
    {
        private readonly IEclaimService _eclaimService;

        public UploadsController(IEclaimService eclaimService)
        {
            _eclaimService = eclaimService;
        }

        [HttpPost("eclaim")]
        public async Task<IActionResult> UploadEclaim([FromForm] IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return BadRequest("No file is selected or the file is empty.");
                }

                var claims = await _eclaimService.UploadExcel(file);

                return Ok(claims);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an appropriate response
                return StatusCode(500, "An error occurred during file upload.");
            }
        }
    }
}
