using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class InventoryChangeRepository : BaseRepository, IInventoryChangeRepository
    {
        public InventoryChangeRepository() : base()
        {
        }
        public async Task<List<InventoryChange>> GetAllInventoryChangeAsync()
        {
            string query = "SELECT * FROM InventoryChange";
            DataTable table = GetData(query);
            List<InventoryChange> changes = new List<InventoryChange>();
            foreach (DataRow row in table.Rows)
            {
                InventoryChange change = new InventoryChange();
                var properties = typeof(InventoryChange).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(change, row[i]);
                    }
                }
                changes.Add(change);
            }
            return changes;
        }

        public async Task<List<InventoryChange>> GetAllByIDAsync(string id)
        {
            string query = $"SELECT * FROM InventoryChange WHERE ProductCode = '{id}'";
            DataTable table = GetData(query);
            List<InventoryChange> changes = new List<InventoryChange>();
            foreach (DataRow row in table.Rows)
            {
                InventoryChange change = new InventoryChange();
                var properties = typeof(InventoryChange).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(change, row[i]);
                    }
                }
                changes.Add(change);
            }
            return changes;
        }

        public async Task<bool> AddInventoryChangeAsync(InventoryChange invtChange)
        {
            var parameters = new Dictionary<string, object>
            {
                { "ID", invtChange.ID },
                { "ProductCode", invtChange.ProductCode },
                { "Date", invtChange.Date },
                { "Qty", invtChange.Qty },
                { "Reason", invtChange.Reason }
            };
            Insert("InventoryChange", parameters);
            return true;
        }
    }
}
