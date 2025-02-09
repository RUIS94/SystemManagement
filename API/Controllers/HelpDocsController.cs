using API.Controllers;
using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpDocsController : ControllerBase
    {
        private readonly HelpDocsService _helpDocsService;
        public HelpDocsController(HelpDocsService helpDocsService)
        {
            _helpDocsService = helpDocsService;
        }
        [HttpGet]
        public async Task<ActionResult<List<HelpDocs>>> GetAllHelpDocs()
        {
            var docs = await _helpDocsService.GetAllHelpDocsAsync();
            return Ok(docs);
        }
        [HttpGet("{term}")]
        public async Task<ActionResult<List<HelpDocs>>> GetHelpResultByTerm(string term)
        {
            var docs = await _helpDocsService.GetHelpDocsByTermAsync(term);
            return Ok(docs);    
        }
    }
}
