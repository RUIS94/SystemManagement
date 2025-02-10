using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class SuppOrdDetailsService
    {
        private readonly ISuppOrdDetailsRepository _suppOrdDetailsRepository;
        public SuppOrdDetailsService(ISuppOrdDetailsRepository suppOrdDetailsRepository)
        {
            _suppOrdDetailsRepository = suppOrdDetailsRepository;
        }
        public async Task<List<SuppOrdDetails>> GetAllDetailsAsync()
        {
            return await _suppOrdDetailsRepository.GetAllDetails();
        }
        public async Task<List<SuppOrdDetails>> GetDetailByTermAsync(string term)
        {
            return await _suppOrdDetailsRepository.GetDetailsByTerm(term);
        }
        public async Task<bool> InsertOrderDetail(SuppOrdDetails suppOrdDetails)
        {
            return await _suppOrdDetailsRepository.InsertOrderDetail(suppOrdDetails);
        }
    }
}
