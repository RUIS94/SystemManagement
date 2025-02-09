using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class InventoryChangeService
    {
        private readonly IInventoryChangeRepository _inventoryChangeRepository;

        public InventoryChangeService(IInventoryChangeRepository inventoryChangeRepository)
        {
            _inventoryChangeRepository = inventoryChangeRepository;
        }

        public async Task<List<InventoryChange>> GetAllInventoryChangeAsync()
        {
            return await _inventoryChangeRepository.GetAllInventoryChangeAsync();
        }

        public async Task<List<InventoryChange>> GetAllByIDAsync(string id)
        {
            return await _inventoryChangeRepository.GetAllByIDAsync(id);
        }
        public async Task<bool> AddInventoryChangeAsync(InventoryChange invtChange)
        {
            return await _inventoryChangeRepository.AddInventoryChangeAsync(invtChange);
        }
    }
}
