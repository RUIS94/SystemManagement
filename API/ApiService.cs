using Model;
using Newtonsoft.Json;
using System.Text;

namespace API
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private const string baseUrl = "https://localhost:7211/api";
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        #region UserApi
        /// <summary>
        /// User operation
        /// </summary>
        public async Task<bool> PasswordMatch(string username, string password)
        {
            var url = $"{baseUrl}/Users/match?username={username}&password={password}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<bool>(content);
        }

        public async Task<string> GetRoleAsync(string username, string password)
        {
            var url = $"{baseUrl}/Users/role?username={username}&password={password}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            string role = content.ToString();
            return role;
        }
        public async Task<List<User>> SearchUsersAsync(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                var response = await _httpClient.GetAsync($"{baseUrl}/Users/search");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<List<User>>(content);
                return users;
            }
            else
            {
                var response = await _httpClient.GetAsync($"{baseUrl}/Users/search?searchTerm={searchTerm}");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<List<User>>(content);
                return users;
            }
        }
        public async Task<bool> InsertUserAsync(User user)
        {
            var userJson = JsonConvert.SerializeObject(user);
            var content = new StringContent(userJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{baseUrl}/Users", content);
            return response.IsSuccessStatusCode;
        }
        public async Task<string> GenerateNewUserIDAsync()
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/NumberGeneration/userID");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception("Unable to generate new UserID.");
            }
        }
        public async Task<bool> UpdateUserPasswordAsync(string username, string password)
        {
            var url = $"{baseUrl}/Products/updatePassword?username={username}&password={password}";
            var userData = new
            {
                usernmae = username,
                password = password
            };
            var userJson = JsonConvert.SerializeObject(userData);
            var content = new StringContent(userJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateUserPhoneAsync(string username, string phone)
        {
            var url = $"{baseUrl}/Products/updatePhone?username={username}&phone={phone}";
            var userData = new
            {
                usernmae = username,
                phone = phone
            };
            var userJson = JsonConvert.SerializeObject(userData);
            var content = new StringContent(userJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateUserRoleAsync(string username, string role)
        {
            var url = $"{baseUrl}/Products/updateRole?username={username}&role={role}";
            var userData = new
            {
                usernmae = username,
                role = role
            };
            var userJson = JsonConvert.SerializeObject(userData);
            var content = new StringContent(userJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);
            return response.IsSuccessStatusCode;
        }
        #endregion

        #region CustomerApi
        /// <summary>
        /// Customer operation
        /// </summary>
        public async Task<List<Customer>> GetCustomersAsync()
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/Customers");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var customers = JsonConvert.DeserializeObject<List<Customer>>(content);
            return customers;
        }
        public async Task<bool> InsertCustomerAsync(Customer customer)
        {
            var customerJson = JsonConvert.SerializeObject(customer);
            var content = new StringContent(customerJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{baseUrl}/Customers", content);

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            var customerJson = JsonConvert.SerializeObject(customer);
            var content = new StringContent(customerJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{baseUrl}/Customers/updateCustomer", content);
            return response.IsSuccessStatusCode;
        }
        public async Task<List<Customer>> SearchCustomersAsync(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                var response = await _httpClient.GetAsync($"{baseUrl}/Customers/search");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var customers = JsonConvert.DeserializeObject<List<Customer>>(content);
                return customers;
            }
            else
            {
                var response = await _httpClient.GetAsync($"{baseUrl}/Customers/search?searchTerm={searchTerm}");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var customers = JsonConvert.DeserializeObject<List<Customer>>(content);
                return customers;
            }
        }
        public async Task<bool> DeleteCustomerAsync(string customerId)
        {
            var url = $"{baseUrl}/Customers/delete?customerID={customerId}";
            var response = await _httpClient.DeleteAsync(url);
            return response.IsSuccessStatusCode;
        }
        #endregion

        #region ProductApi
        /// <summary>
        /// Product operation
        /// </summary>
        public async Task<List<Product>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/Products");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(content);
            return products;
        }
        public async Task<bool> InsertProductAsync(Product product)
        {
            var productJson = JsonConvert.SerializeObject(product);
            var content = new StringContent(productJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{baseUrl}/Products", content);

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateProductInventoryAsync(string productCode, string inventory)
        {
            var url = $"{baseUrl}/Products/updateInventory?productCode={productCode}&inventory={inventory}";

            var productData = new
            {
                productCode = productCode,
                inventory = inventory
            };

            var productJson = JsonConvert.SerializeObject(productData);
            var content = new StringContent(productJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateProductAsync(Product product)
        {
            var productJson = JsonConvert.SerializeObject(product);
            var content = new StringContent(productJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{baseUrl}/Products/updateProduct", content);

            return response.IsSuccessStatusCode;
        }
        public async Task<string> GetProductCodeAsync(string barcode)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/Products/getCode?barcode={barcode}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            string productCode = content.ToString();
            return productCode;
        }
        public async Task<List<Product>> SearchProductsAsync(string searchTerm)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/Products/search?searchTerm={searchTerm}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(content);
            return products;
        }
        public async Task<string> GenerateNewProductCodeAsync()
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/NumberGeneration/productCode");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception("Unable to generate new ProductCode.");
            }
        }
        #endregion

        #region OrderApi
        /// <summary>
        /// Order operation
        /// </summary>
        public async Task<List<Order>> GetOrdersAsync()
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/Orders");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var orders = JsonConvert.DeserializeObject<List<Order>>(content);
            return orders;
        }
        public async Task<bool> InsertOrderAsync(Order order)
        {
            var orderJson = JsonConvert.SerializeObject(order);
            var content = new StringContent(orderJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{baseUrl}/Orders", content);

            return response.IsSuccessStatusCode;
        }
        public async Task<List<Order>> SearchOrderAsync(string customerId)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/Orders/search?customerID={customerId}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var orders = JsonConvert.DeserializeObject<List<Order>>(content);
            return orders;
        }
        #endregion

        #region OrderDetailApi
        /// <summary>
        /// OrderDetail operation
        /// </summary>
        public async Task<List<OrderDetail>> GetOrderDetailsAsync()
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/OrderDetails");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var orderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(content);
            return orderDetails;
        }
        public async Task<bool> InsertOrderDetailAsync(OrderDetail orderDetail)
        {
            var orderJson = JsonConvert.SerializeObject(orderDetail);
            var content = new StringContent(orderJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{baseUrl}/OrderDetails", content);

            return response.IsSuccessStatusCode;
        }
        public async Task<List<OrderDetail>> SearchOrderDetailsAsync(string orderId)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/OrderDetails/search?orderId={orderId}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var orderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(content);
            return orderDetails;
        }
        #endregion

        #region AccountApi
        /// <summary>
        /// Account operation
        /// </summary>
        public async Task<List<Account>> GetAccountsAsync()
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/Accounts");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var accounts = JsonConvert.DeserializeObject<List<Account>>(content);
            return accounts;
        }
        public async Task<bool> InsertAccountAsync(string customerID)
        {
            var url = $"{baseUrl}/Accounts";
            //var accountJson = JsonConvert.SerializeObject(account);
            var content = new StringContent($"{{\"CustomerID\":\"{customerID}\", \"AccountPassword\":\"123456\", \"Balance\":0}}", Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }
        public async Task<List<Account>> SearchAccountAsync(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                var response = await _httpClient.GetAsync($"{baseUrl}/Accounts/search");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var accounts = JsonConvert.DeserializeObject<List<Account>>(content);
                return accounts;
            }
            else
            {
                var response = await _httpClient.GetAsync($"{baseUrl}/Accounts/search?searchTerm={searchTerm}");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var accounts = JsonConvert.DeserializeObject<List<Account>>(content);
                return accounts;
            }
        }
        public async Task<bool> UpdateAccountPassword(string customerID, string password)
        {
            var url = $"{baseUrl}/Accounts/update?customerID={customerID}&password={password}";

            var accountData = new
            {
                customerID = customerID,
                password = password
            };

            var accountJson = JsonConvert.SerializeObject(accountData);
            var content = new StringContent(accountJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateAccountBalance(string customerID, double balance)
        {
            var url = $"{baseUrl}/Accounts/deposit?customerID={customerID}&balance={balance}";

            var accountData = new
            {
                customerID = customerID,
                balance = balance
            };

            var accountJson = JsonConvert.SerializeObject(accountData);
            var content = new StringContent(accountJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }
        public async Task<double> GetBalanceAsync(string customerID)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/Accounts/getbalance?customerID={customerID}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            double balance = Convert.ToDouble(content);
            return balance;
        }
        #endregion

        #region ValidationApi
        /// <summary>
        /// Validation operation
        /// </summary>
        public async Task<bool> CheckExistsAsync(string tableName, string columnName, string value)
        {
            var url = $"{baseUrl}/Validate?tableName={tableName}&columnName={columnName}&value={value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<bool>(content);
        }
        #endregion

        #region SupplierApi
        /// <summary>
        /// Supplier operation
        /// </summary>
        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/Suppliers");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(content);
            return suppliers;
        }
        public async Task<bool> InsertSupplierAsync(Supplier supplier)
        {
            var supplierJson = JsonConvert.SerializeObject(supplier);
            var content = new StringContent(supplierJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{baseUrl}/Suppliers", content);

            return response.IsSuccessStatusCode;
        }
        public async Task<List<Supplier>> SearchSuppliersAsync(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                var response = await _httpClient.GetAsync($"{baseUrl}/Suppliers/search");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(content);
                return suppliers;
            }
            else
            {
                var response = await _httpClient.GetAsync($"{baseUrl}/Suppliers/search?searchTerm={searchTerm}");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(content);
                return suppliers;
            }
        }
        #endregion

        #region GoodsInApi
        /// <summary>
        /// GoodsIn operation
        /// </summary>
        public async Task<List<GoodsIn>> GetGoodsInAsync()
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/GoodsIn");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var goodsIn = JsonConvert.DeserializeObject<List<GoodsIn>>(content);
            return goodsIn;
        }
        public async Task<bool> InsertGoodsInAsync(GoodsIn goodsIn)
        {
            var goodsInJson = JsonConvert.SerializeObject(goodsIn);
            var content = new StringContent(goodsInJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{baseUrl}/GoodsIn", content);

            return response.IsSuccessStatusCode;
        }
        public async Task<List<GoodsIn>> SearchGoodsInAsync(string supplierCode)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/GoodsIn/search?supplierCode={supplierCode}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var goodsIn = JsonConvert.DeserializeObject<List<GoodsIn>>(content);
            return goodsIn;
        }
        #endregion
    }
}