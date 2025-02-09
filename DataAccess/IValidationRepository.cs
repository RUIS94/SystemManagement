using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IValidationRepository
    {
        bool CheckExists(string tableName, string columnName, string value);
        bool ValueMatches(string tableName, string columnName, string valueToMatch, string condition);
    }
}
