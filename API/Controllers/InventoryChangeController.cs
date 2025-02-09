using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryChangeController : ControllerBase
    {
        private readonly InventoryChangeService _inventoryChangeService;

        public InventoryChangeController(InventoryChangeService inventoryChangeService)
        {
            _inventoryChangeService = inventoryChangeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<InventoryChange>>> GetAllInventoryChanges()
        {
            var changes = await _inventoryChangeService.GetAllInventoryChangeAsync();
            return Ok(changes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<InventoryChange>>> GetAllByID(string id)
        {
            var changes = await _inventoryChangeService.GetAllByIDAsync(id);
            if (changes == null)
            {
                return NotFound();
            }
            return Ok(changes);
        }
        [HttpPost]
        public async Task<ActionResult> AddInventoryChange([FromBody] InventoryChange invtChange)
        {
            await _inventoryChangeService.AddInventoryChangeAsync(invtChange);
            return CreatedAtAction(nameof(GetAllInventoryChanges), new { id = invtChange.ID }, invtChange);
        }
    }
}
