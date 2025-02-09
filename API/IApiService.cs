using Model;

namespace API
{
    public interface IApiService
    {
        // UserApi Methods
        Task<bool> PasswordMatch(string username, string password);
        Task<string> GetRoleAsync(string username, string password);
        Task<List<User>> SearchUsersAsync(string searchTerm);
        Task<bool> InsertUserAsync(User user);
        Task<string> GenerateNewUserIDAsync();
        Task<bool> UpdateUserPasswordAsync(string username, string password);
        Task<bool> UpdateUserPhoneAsync(string username, string phone);
        Task<bool> UpdateUserRoleAsync(string username, string role);

        // CustomerApi Methods
        Task<List<Customer>> GetCustomersAsync();
        Task<bool> InsertCustomerAsync(Customer customer);
        Task<bool> UpdateCustomerAsync(Customer customer);
        Task<List<Customer>> SearchCustomersAsync(string searchTerm);
        Task<bool> DeleteCustomerAsync(string customerId);

        // ProductApi Methods
        Task<List<Product>> GetProductsAsync();
        Task<bool> InsertProductAsync(Product product);
        Task<bool> UpdateProductInventoryAsync(string productCode, string inventory);
        Task<bool> UpdateProductAsync(Product product);
        Task<string> GetProductCodeAsync(string barcode);
        Task<List<Product>> SearchProductsAsync(string searchTerm);
        Task<string> GenerateNewProductCodeAsync();

        // OrderApi Methods
        Task<List<Order>> GetOrdersAsync();
        Task<bool> InsertOrderAsync(Order order);
        Task<List<Order>> SearchOrderAsync(string customerId);

        // OrderDetailApi Methods
        Task<List<OrderDetail>> GetOrderDetailsAsync();
        Task<bool> InsertOrderDetailAsync(OrderDetail orderDetail);
        Task<List<OrderDetail>> SearchOrderDetailsAsync(string orderId);

        // AccountApi Methods
        Task<List<Account>> GetAccountsAsync();
        Task<bool> InsertAccountAsync(string customerID);
        Task<List<Account>> SearchAccountAsync(string searchTerm);
        Task<bool> UpdateAccountPassword(string customerID, string password);
        Task<bool> UpdateAccountBalance(string customerID, double balance);
        Task<double> GetBalanceAsync(string customerID);

        // ValidationApi Methods
        Task<bool> CheckExistsAsync(string tableName, string columnName, string value);

        // SupplierApi Methods
        Task<List<Supplier>> GetSuppliersAsync();
        Task<bool> InsertSupplierAsync(Supplier supplier);
        Task<List<Supplier>> SearchSuppliersAsync(string searchTerm);

        // GoodsInApi Methods
        Task<List<GoodsIn>> GetGoodsInAsync();
        Task<bool> InsertGoodsInAsync(GoodsIn goodsIn);
        Task<List<GoodsIn>> SearchGoodsInAsync(string supplierCode);
    }
}
