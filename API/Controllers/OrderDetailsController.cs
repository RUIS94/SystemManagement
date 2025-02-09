using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly OrderDetailService _orderDetailsService;

        public OrderDetailsController(OrderDetailService orderDetailsService)
        {
            _orderDetailsService = orderDetailsService;
        }
        [HttpGet]
        public async Task<ActionResult<List<OrderDetail>>> GetOrderDetails()
        {
            var orderDetails = await _orderDetailsService.GetAllOrderDetailsAsync();
            return Ok(orderDetails);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<OrderDetail>>> SearchOrderDetails(string id)
        {
            var orderDetails = await _orderDetailsService.GetOrderDetailsByOrderIdAsync(id);
            if (orderDetails == null)
            {
                return NotFound();
            }
            return Ok(orderDetails);
        }
        [HttpPost]
        public async Task<ActionResult> AddOrderDetail([FromBody] OrderDetail orderDetail)
        {
            await _orderDetailsService.AddOrderDetailAsync(orderDetail);
            return CreatedAtAction(nameof(GetOrderDetails), new { id = orderDetail.OrderDetailID }, orderDetail);
        }
    }
}

