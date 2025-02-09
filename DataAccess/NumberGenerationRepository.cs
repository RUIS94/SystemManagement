using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccess
{
    public class NumberGenerationRepository : BaseRepository, INumberGenerationRepository
    {
        private readonly string _connectionString;
        public NumberGenerationRepository() : base()
        {
        }
        public int GenerateNewId(string tableName, string idColumn)
        {
            return base.GenerateNewId(tableName, idColumn); 
        }
    }
        
}