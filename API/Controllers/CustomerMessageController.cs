using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerMessageController : ControllerBase
    {
        private static List<string> messages = new List<string>();

        [HttpPost]
        public IActionResult SendMessage([FromBody] string message)
        {
            messages.Add(message);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetMessages()
        {
            return Ok(messages);
        }
    }
}
