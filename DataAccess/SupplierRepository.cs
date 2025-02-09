using System.Data;
using Model;

namespace DataAccess
{
    public class SupplierRepository : BaseRepository, ISupplierRepository
    {
        public SupplierRepository() : base()
        {
        }

        public async Task<List<Supplier>> GetAllSuppliersAsync()
        {
            string query = "SELECT * FROM Suppliers";
            DataTable table = GetData(query);
            List<Supplier> suppliers = new List<Supplier>();

            foreach (DataRow row in table.Rows)
            {
                Supplier supplier = new Supplier();
                var properties = typeof(Supplier).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(supplier, row[i]);
                    }
                }
                suppliers.Add(supplier);
            }

            return suppliers;
        }

        public async Task<Supplier> GetSupplierByTermAsync(string searchTerm)
        {
            string query = $"SELECT * FROM Suppliers WHERE SupplierCode LIKE '%{searchTerm}%'" +
                           $"OR SupplierName LIKE '%{searchTerm}%' " +
                           $"OR SupplierPhone LIKE '%{searchTerm}%' " +
                           $"OR SupplierAddress1 LIKE '%{searchTerm}%'" +
                           $"OR SupplierAddress2 LIKE '%{searchTerm}%'";
            DataTable table = GetData(query);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                Supplier supplier = new Supplier();
                var properties = typeof(Supplier).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(supplier, row[i]);
                    }
                }
                return supplier;
            }
            return null;
        }

        public async Task<bool> AddSupplierAsync(Supplier supplier)
        {
            var parameters = new Dictionary<string, object>
            {
                {"SupplierCode", supplier.SupplierCode},
                {"SupplierName", supplier.SupplierName},
                {"SupplierPhone", supplier.SupplierPhone},
                {"SupplierEmail", supplier.SupplierEmail},
                {"SupplierAddress1", supplier.SupplierAddress1},
                {"SupplierAddress2", supplier.SupplierAddress2 }
            };

            Insert("Suppliers", parameters);
            return true;
        }

        public async Task<bool> UpdateSupplierAsync(Supplier supplier)
        {
            var parameters = new Dictionary<string, object>
            {
                {"SupplierCode", supplier.SupplierCode},
                {"SupplierName", supplier.SupplierName},
                {"SupplierPhone", supplier.SupplierPhone},
                {"SupplierEmail", supplier.SupplierEmail},
                {"SupplierAddress1", supplier.SupplierAddress1},
                {"SupplierAddress2", supplier.SupplierAddress2 }
            };
            string condition = $"SupplierID = '{supplier.SupplierCode}'";
            Update("Suppliers", parameters, condition);
            return true;
        }

        public async Task<bool> DeleteSupplierAsync(string supplierId)
        {
            string condition = $"SupplierID = '{supplierId}'";
            Delete("Suppliers", condition);
            return true;
        }
    }
}
