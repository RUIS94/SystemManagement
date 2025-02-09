using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberGenerationController : ControllerBase
    {
        private readonly NumberGenerationService _numberGenerationService;

        public NumberGenerationController(NumberGenerationService numberGenerationService)
        {
            _numberGenerationService = numberGenerationService;
        }
        [HttpGet("generate-id")]
        public ActionResult<int> GenerateNewId(string tableName, string idColumn)
        {
            int newId = _numberGenerationService.GenerateNewId(tableName, idColumn);
            return Ok(newId); 
        }
    }
}
