using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class SupplierOrderService
    {
        private readonly ISupplierOrderRepository _supplierOrderRepository;
        public SupplierOrderService(ISupplierOrderRepository supplierOrderRepository)
        {
            _supplierOrderRepository = supplierOrderRepository;
        }

        public async Task<List<SupplierOrder>> GetAllOrdersAsync()
        {
            return await _supplierOrderRepository.GetAllSuppOrder();
        }
        public async Task<List<SupplierOrder>> GetOrdersByTermAsync(string term)
        {
            return await _supplierOrderRepository.GetSuppOrderByTerm(term);
        }
        public async Task<bool> InsertSupplierOrder(SupplierOrder order)
        {
            return await _supplierOrderRepository.InsertSuppOrder(order);
        }
    }
}
