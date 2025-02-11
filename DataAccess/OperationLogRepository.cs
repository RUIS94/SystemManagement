using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using static Model.DTO;

namespace DataAccess
{
    public class OperationLogRepository : BaseRepository, IOperationLogRepository
    {
        public OperationLogRepository() : base() { }

        public async Task<List<OperationLog>> GetAllLogs()
        {
            string query = "SELECT * FROM OperationLog";
            DataTable dt = GetData(query);
            List<OperationLog> logs = new List<OperationLog>();
            foreach (DataRow row in dt.Rows)
            {
                OperationLog log = new OperationLog();
                var properties = typeof(OperationLog).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(log, row[i]);
                    }
                }
                logs.Add(log);
            }
            return logs;
        }
        public async Task<bool> InsertLog(ActionLog log)
        {
            var parameters = new Dictionary<string, object>
            {
                { "Action", log.Action}
            };
            Insert("OperationLog", parameters);
            return true;
        }
    }
}
