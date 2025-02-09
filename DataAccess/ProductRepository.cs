using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace DataAccess
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository() : base()
        {
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            string query = "SELECT * FROM Products";
            DataTable table = GetData(query);
            List<Product> products = new List<Product>();

            foreach (DataRow row in table.Rows)
            {
                Product product = new Product();
                var properties = typeof(Product).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(product, row[i]);
                    }
                }
                products.Add(product);
            }

            return products;
        }

        public async Task<Product> GetProductByCodeAsync(string productCode)
        {
            string query = $"SELECT * FROM Products WHERE ProductCode = '{productCode}'";
            DataTable table = GetData(query); 
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                Product product = new Product();
                var properties = typeof(Product).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(product, row[i]);
                    }
                }
                return product; 
            }
            return null;
        }

        public async Task<List<Product>> GetProductByTermAsync(string searchTerm)
        {
            string query = $"SELECT * FROM Products WHERE ProductCode LIKE '%{searchTerm}%'" +
                           $"OR Name LIKE '%{searchTerm}%'";
            DataTable table = GetData(query);
            List<Product> products = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product();
                var properties = typeof(Product).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(product, row[i]);
                    }
                }
                products.Add(product);
            }
            return products;
        }

        //public int GetNewProductId()
        //{
        //    return GenerateNewId("Products", "ProductCode");
        //}
        public async Task<bool> AddProductAsync(Product product)
        {
            if (CheckExists("Products", "ProductCode", product.ProductCode))
            {
                throw new Exception("Product code already exists."); 
            }
            var parameters = new Dictionary<string, object>
            {
                { "ProductCode", product.ProductCode },
                { "Name", product.Name },
                { "Barcode", product.Barcode },
                { "Cost", product.Cost },
                { "Price", product.Price },
                { "Inventory", product.Inventory }
            };

            Insert("Products", parameters); 
            return true;
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            var parameters = new Dictionary<string, object>
            {
                { "Name", product.Name },
                { "Barcode", product.Barcode },
                { "Cost", product.Cost },
                { "Price", product.Price },
                { "Inventory", product.Inventory }
            };
            string condition = $"ProductCode = '{product.ProductCode}'";
            Update("Products", parameters, condition); 
            return true; 
        }

        public async Task<bool> DeleteProductAsync(string productCode)
        {
            string condition = $"ProductCode = '{productCode}'";
            Delete("Products", condition); 
            return true;
        }

        public async Task<bool> UpdateProductInventoryAsync(string productCode, int newInventory)
        {
            var parameters = new Dictionary<string, object>
            {
                { "Inventory", newInventory }
            };
            string condition = $"ProductCode = '{productCode}'";
            Update("Products", parameters, condition);
            return true;
        }

        public async Task<string> GetProductCodeAsync(string barcode)
        {
            string query = $"SELECT ProductCode FROM Products WHERE Barcode = '{barcode}'";
            return GetValue("Products", "ProductCode", $"Barcode = '{barcode}'"); 
        }
        public async Task<string> GenerateNewProductCodeAsync()
        {
            string query = "SELECT MAX(CAST(ProductCode AS INT)) FROM Products";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                int newCode = 1;
                if (result != DBNull.Value)
                {
                    newCode = Convert.ToInt32(result) + 1;
                }
                return newCode.ToString("D10");
            }
        }
    }
}