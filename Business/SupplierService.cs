using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class SupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<List<Supplier>> GetAllSuppliersAsync()
        {
            return await _supplierRepository.GetAllSuppliersAsync();
        }

        public async Task<Supplier> GetSupplierByTermAsync(string searchTerm)
        {
            return await _supplierRepository.GetSupplierByTermAsync(searchTerm);
        }

        public async Task<bool> AddSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.AddSupplierAsync(supplier);
        }

        public async Task<bool> UpdateSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.UpdateSupplierAsync(supplier);
        }

        public async Task<bool> DeleteSupplierAsync(string supplierId)
        {
            return await _supplierRepository.DeleteSupplierAsync(supplierId); 
        }
    }
}