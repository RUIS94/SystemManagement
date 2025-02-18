using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        //public int GenerateNewProductId()
        //{
        //    return _productRepository.GetNewProductId();
        //}
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }
        public async Task<List<Product>> GetProductByTermAsync(string searchTerm)
        {
            return await _productRepository.GetProductByTermAsync(searchTerm);
        }
        public async Task<bool> AddProductAsync(Product product)
        {
            return await _productRepository.AddProductAsync(product);
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            return await _productRepository.UpdateProductAsync(product);
        }

        public async Task<bool> DeleteProductAsync(string productCode)
        {
            return await _productRepository.DeleteProductAsync(productCode);
        }
        public async Task<string> GetProductCode(string barcode)
        {
            return await _productRepository.GetProductCodeAsync(barcode);
        }
        public async Task<bool> UpdateProductInventory(string productId, int inventory)
        {
            return await _productRepository.UpdateProductInventoryAsync(productId, inventory);
        }
    }
}