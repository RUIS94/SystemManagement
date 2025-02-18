using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        private readonly ValidationService _validationService;

        public ValidationController(ValidationService validationService)
        {
            _validationService = validationService;
        }

        [HttpGet("exists")]
        public ActionResult<bool> CheckExists(string tableName, string columnName, string value)
        {
            bool exists = _validationService.CheckExists(tableName, columnName, value);
            return Ok(exists);
        }

        [HttpGet("value-matches")]
        public ActionResult<bool> ValueMatches(string tableName, string columnName, string valueToMatch, string condition)
        {
            bool matches = _validationService.ValueMatches(tableName, columnName, valueToMatch, condition);
            return Ok(matches);
        }
    }
}
