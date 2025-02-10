using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface ISupplierOrderRepository
    {
        Task<List<SupplierOrder>> GetAllSuppOrder();
        Task<List<SupplierOrder>> GetSuppOrderByTerm(string term);
        Task<bool> InsertSuppOrder(SupplierOrder suppord);
    }
}
