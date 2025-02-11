using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using static Model.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationLogController : ControllerBase
    {
        private readonly OperationLogService _operationLogService;
        public OperationLogController(OperationLogService operationLogService)
        {
            _operationLogService = operationLogService;
        }

        [HttpGet]
        public async Task<ActionResult<List<OperationLog>>> GetAllLogsAsync()
        {
            var logs = await _operationLogService.GetALlLogsAsync();
            return Ok(logs);
        }
        [HttpPost]
        public async Task<ActionResult> InsertLogAsync([FromBody] ActionLog log)
        {
            await _operationLogService.InsertLogAsync(log);
            return Ok();
        }
    }
}
