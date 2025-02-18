using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using static Model.DTO;

namespace DataAccess
{
    public interface IOperationLogRepository
    {
        Task<List<OperationLog>> GetAllLogs();
        Task<bool> InsertLog(ActionLog log);
    }
}
