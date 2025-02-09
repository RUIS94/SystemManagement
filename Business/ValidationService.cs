using DataAccess;
using Model;

namespace Business
{
    public class ValidationService
    {
        private readonly IValidationRepository _validationRepository;

        public ValidationService(IValidationRepository validationRepository)
        {
            _validationRepository = validationRepository;
        }
        public bool CheckExists(string tableName, string columnName, string value)
        {
            return _validationRepository.CheckExists(tableName, columnName, value);
        }

        public bool ValueMatches(string tableName, string columnName, string valueToMatch, string condition)
        {
            return _validationRepository.ValueMatches(tableName, columnName, valueToMatch, condition);
        }
    }    
}
