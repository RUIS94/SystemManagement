using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierOrderController : ControllerBase
    {
        private readonly SupplierOrderService _supplierOrderService;
        public SupplierOrderController(SupplierOrderService supplierOrderService)
        {
            _supplierOrderService = supplierOrderService;
        }
        [HttpGet]
        public async Task<ActionResult<List<SupplierOrder>>> GetAllOrdersAsync()
        {
            var orders = await _supplierOrderService.GetAllOrdersAsync();
            return Ok(orders);
        }
        [HttpGet("{term}")]
        public async Task<ActionResult<List<SupplierOrder>>> GetOrdersByTermAsync(string term)
        {
            var orders = await _supplierOrderService.GetOrdersByTermAsync(term);
            return Ok(orders);
        }
        [HttpPost]
        public async Task<ActionResult> InsertSupplierOrder([FromBody] SupplierOrder order)
        {
            await _supplierOrderService.InsertSupplierOrder(order);
            return CreatedAtAction(nameof(GetAllOrdersAsync), new { id = order.SupplierOrderID }, order);
        }
    }
}
