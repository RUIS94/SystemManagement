using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductByCodeAsync(string productCode);
        Task<List<Product>> GetProductByTermAsync(string term);
        //int GetNewProductId();
        Task<bool> AddProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(string productCode);
        Task<bool> UpdateProductInventoryAsync(string productCode, int newInventory);
        Task<string> GetProductCodeAsync(string barcode);
        Task<string> GenerateNewProductCodeAsync();
    }
}
