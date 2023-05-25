using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
namespace WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class Icd101sController : ControllerBase
{
    private readonly IIcdSyncService _icdSyncService;

    public Icd101sController(IIcdSyncService icdSyncService)
    {
        _icdSyncService = icdSyncService;
    }

    [HttpPost("icds")]
    public async Task<IActionResult> SyncIcds()
    {
        await _icdSyncService.SyncAsync();
        return Ok();
    }
}
