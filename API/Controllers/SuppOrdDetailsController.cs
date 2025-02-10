using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppOrdDetailsController : ControllerBase
    {
        private readonly SuppOrdDetailsService _supplierDetailsService;
        public SuppOrdDetailsController(SuppOrdDetailsService supplierDetailsService)
        {
            _supplierDetailsService = supplierDetailsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuppOrdDetails>>> GetAllDetails() 
        {
            var details = await _supplierDetailsService.GetAllDetailsAsync();
            return Ok(details);
        }
        [HttpGet("{term}")]
        public async Task<ActionResult<List<SuppOrdDetails>>> GetDetailsByTerm(string term)
        {
            var details = await _supplierDetailsService.GetDetailByTermAsync(term);
            return Ok(details);
        }
        [HttpPost]
        public async Task<ActionResult> InsertDetail([FromBody] SuppOrdDetails details)
        {
            await _supplierDetailsService.InsertOrderDetail(details);
            return CreatedAtAction(nameof(GetAllDetails), new { id = details.ID }, details);
        }
    }
}
