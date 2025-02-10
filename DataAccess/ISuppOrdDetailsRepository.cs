using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface ISuppOrdDetailsRepository
    {
        public Task<List<SuppOrdDetails>> GetAllDetails();
        public Task<List<SuppOrdDetails>> GetDetailsByTerm(string term);
        public Task<bool> InsertOrderDetail(SuppOrdDetails suppOrdDetails);
    }
}
