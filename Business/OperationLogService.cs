using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;
using static Model.DTO;

namespace Business
{
    public class OperationLogService
    {
        private readonly IOperationLogRepository _operationLogRepository;
        public OperationLogService(IOperationLogRepository operationLogRepository)
        {
            _operationLogRepository = operationLogRepository;
        }

        public async Task<List<OperationLog>> GetALlLogsAsync()
        {
            return await _operationLogRepository.GetAllLogs();
        }

        public async Task<bool> InsertLogAsync(ActionLog log)
        {
            return await _operationLogRepository.InsertLog(log);
        }
    }
}
