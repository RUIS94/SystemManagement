using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Business
{
    public class NumberGenerationService
    {
        private readonly INumberGenerationRepository _numberGenerationRepository;

        public NumberGenerationService(INumberGenerationRepository numberGenerationRepository)
        {
            _numberGenerationRepository = numberGenerationRepository;
        }
        public int GenerateNewId(string tableName, string idColumn)
        {
            return _numberGenerationRepository.GenerateNewId(tableName, idColumn);
        }
    }
}
