using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class HelpDocsService
    {
        private readonly IHelpDocsRepository _helpdocsrRepository;

        public HelpDocsService(IHelpDocsRepository helpdocsRepository)
        {
            _helpdocsrRepository = helpdocsRepository;
        }
        public async Task<List<HelpDocs>> GetAllHelpDocsAsync()
        {
            return await _helpdocsrRepository.GetAllHelpDocsAsync();
        }

        public async Task<List<HelpDocs>> GetHelpDocsByTermAsync(string term)
        {
            return await _helpdocsrRepository.GetHelpDocsByTerm(term);
        }
    }
}
