using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsInController : ControllerBase
    {
        private readonly GoodsInService _goodsInService;

        public GoodsInController(GoodsInService goodsInService)
        {
            _goodsInService = goodsInService;
        }

        [HttpGet]
        public async Task<ActionResult<List<GoodsIn>>> GetGoodsIn()
        {
            var goodsIn = await _goodsInService.GetAllGoodsInAsync();
            return Ok(goodsIn);
        }

        [HttpPost]
        public async Task<ActionResult> AddGoodsIn([FromBody] GoodsIn goodsIn)
        {
            await _goodsInService.AddGoodsInAsync(goodsIn);
            return CreatedAtAction(nameof(GetGoodsIn), new { id = goodsIn.GoodsInCode }, goodsIn);
        }
    }
}
