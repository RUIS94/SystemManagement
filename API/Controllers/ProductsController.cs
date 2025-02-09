using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using static Model.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }
        [HttpGet("{searchTerm}")]
        public async Task<ActionResult<Product>> GetProductByTerm(string searchTerm)
        {
            var product = await _productService.GetProductByTermAsync(searchTerm);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] Product product)
        {
            await _productService.AddProductAsync(product);
            return CreatedAtAction(nameof(GetAllProducts), new { id = product.ProductCode }, product);
        }
        [HttpPut]
        public async Task<ActionResult> UpdateProduct([FromBody] Product product)
        {
            await _productService.UpdateProductAsync(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return NoContent();
        }

        [HttpGet("getCode")]
        public async Task<ActionResult<string>> GetProductCodeAsync(string barcode)
        {
            if (string.IsNullOrEmpty(barcode))
            {
                return BadRequest("Product barcode is required.");
            }
            string productCode = await _productService.GetProductCode(barcode);
            if (string.IsNullOrEmpty(productCode))
            {
                return NotFound("Product not found.");
            }
            return Ok(productCode);
        }

        [HttpPut("updateInventory")]
        public async Task<ActionResult> UpdateInventory([FromBody] InventoryUpdate updateinvt)
        {
            await _productService.UpdateProductInventory(updateinvt.ProductCode, updateinvt.Inventory);
            return Ok();
        }
    }
}