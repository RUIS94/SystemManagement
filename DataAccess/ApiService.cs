using Newtonsoft.Json;
using Model;

namespace DataAccess
{
    public class ApiService
    {
        private readonly ApiClient _apiClient;

        public ApiService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            string jsonResponse = await _apiClient.GetAsync("api/customers");
            return JsonConvert.DeserializeObject<List<Customer>>(jsonResponse); 
        }
        public async Task<Customer> GetCustomerByIdAsync(string customerId)
        {
            string jsonResponse = await _apiClient.GetAsync($"api/customers/{customerId}");
            return JsonConvert.DeserializeObject<Customer>(jsonResponse);
        }
        public async Task<bool> AddCustomerAsync(Customer customer)
        {
            return await _apiClient.PostAsync("api/customers", customer); 
        }
        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            return await _apiClient.PutAsync($"api/customers/{customer.CustomerID}", customer); 
        }
        public async Task<bool> DeleteCustomerAsync(string customerId)
        {
            return await _apiClient.DeleteAsync($"api/customers/{customerId}"); 
        }
        public async Task<List<Product>> GetProductsAsync()
        {
            string jsonResponse = await _apiClient.GetAsync("api/products");
            return JsonConvert.DeserializeObject<List<Product>>(jsonResponse);
        }
        public async Task<bool> AddProductAsync(Product product)
        {
            return await _apiClient.PostAsync("api/products", product);
        }
        public async Task<bool> UpdateProductAsync(Product product)
        {
            return await _apiClient.PutAsync($"api/products/{product.ProductCode}", product);
        }
        public async Task<bool> DeleteProductAsync(string productCode)
        {
            return await _apiClient.DeleteAsync($"api/products/{productCode}"); 
        }
        public async Task<List<Order>> GetOrdersAsync()
        {
            string jsonResponse = await _apiClient.GetAsync("api/orders");
            return JsonConvert.DeserializeObject<List<Order>>(jsonResponse); 
        }
        public async Task<bool> AddOrderAsync(Order order)
        {
            return await _apiClient.PostAsync("api/orders", order); 
        }
        public async Task<bool> UpdateOrderAsync(Order order)
        {
            return await _apiClient.PutAsync($"api/orders/{order.OrderID}", order); 
        }
        public async Task<bool> DeleteOrderAsync(string orderId)
        {
            return await _apiClient.DeleteAsync($"api/orders/{orderId}"); 
        }
    }
}
