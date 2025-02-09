using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class ValidationRepository : BaseRepository, IValidationRepository
    {
        private readonly string _connectionString;
        public ValidationRepository() : base()
        {
        }
        public bool CheckExists(string tableName, string columnName, string value)
        {
            return base.CheckExists(tableName, columnName, value);
        }

        public bool ValueMatches(string tableName, string columnName, string valueToMatch, string condition)
        {
            return base.ValueMatchs(tableName, columnName, valueToMatch, condition);
        }
    }
}
