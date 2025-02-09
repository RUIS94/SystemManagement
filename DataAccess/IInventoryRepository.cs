using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface IInventoryChangeRepository
    {
        Task<List<InventoryChange>> GetAllInventoryChangeAsync();
        Task<List<InventoryChange>> GetAllByIDAsync(string id);
        Task<bool> AddInventoryChangeAsync(InventoryChange invtChange);
    }
}
