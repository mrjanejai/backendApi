using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SyncsController : ControllerBase
    {
        private readonly IIcdSyncService _icdSyncService;
        private readonly IErOperCodeService _erOperCodeService;
        private readonly INonDrugItemSyncService _nonDrugItemSyncService; // new service
        private readonly IDrugItemSyncService _drugItemSyncService;
        private readonly IPttypeService _pttypeService;
        private readonly IIptOperCodeService _iptopCodeService;

        public SyncsController(IIcdSyncService icdSyncService, IErOperCodeService erOperCodeService, INonDrugItemSyncService nonDrugItemSyncService
        ,IDrugItemSyncService drugItemSyncService, IPttypeService pttypeService, IIptOperCodeService iptopCodeService) // new service in constructor
        {
            _icdSyncService = icdSyncService;
            _erOperCodeService = erOperCodeService;
            _nonDrugItemSyncService = nonDrugItemSyncService; // assign to field
            _drugItemSyncService = drugItemSyncService;
            _pttypeService = pttypeService;
            _iptopCodeService = iptopCodeService;
        }

        [HttpPost("icds")]
        public async Task<IActionResult> SyncIcds()
        {
            await _icdSyncService.SyncAsync();
            return Ok();
        }

        [HttpPost("er_oper_code")]
        public async Task<IActionResult> SyncErOperCode()
        {
            await _erOperCodeService.SyncAsync();
            return Ok();
        }

        // New method to sync non-drug items
        [HttpPost("non_drug_items")]
        public async Task<IActionResult> SyncNonDrugItems()
        {
            await _nonDrugItemSyncService.SyncAsync();
            return Ok();
        }

        [HttpPost("drug_items")]
        public async Task<IActionResult> SyncDrugItems() 
        {
            await _drugItemSyncService.SyncAsync();
            return Ok();
        }

        [HttpPost("pttype")]
        public async Task<IActionResult> SyncPttype()
        {
            await _pttypeService.SyncAsync();
            return Ok();
        }

        [HttpPost("ipt_oper_code")]
        public async Task<IActionResult> SyncIptOperCode()
        {
            await _iptopCodeService.SyncAsync();
            return Ok();
        }

    }
}
