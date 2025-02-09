using Model;
using Newtonsoft.Json;
using System.Text;
using static Model.DTO;

namespace UI.Services
{
    public class ApiService
    {
        #region Generic
        private readonly HttpClient _httpClient;
        //private const string baseUrl = "http://localhost:5000/api";
        private const string baseUrl = "https://localhost:7207/api";//For Development Envir
        //private const string baseUrl = "";//add another later
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        private async Task<T> GetAsync<T>(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            if (typeof(T) == typeof(string))
            {
                return (T)(object)content;
            }
            return JsonConvert.DeserializeObject<T>(content);
        }
        private async Task<bool> PostAsync<T>(string url, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);
            return response.IsSuccessStatusCode;
        }
        private async Task<bool> PutAsync<T>(string url, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(url, content);
            return response.IsSuccessStatusCode;
        }
        private async Task<bool> DeleteAsync(string url)
        {
            var response = await _httpClient.DeleteAsync(url);
            return response.IsSuccessStatusCode;
        }
        #endregion

        #region UserApi
        /// <summary>
        /// User operation
        /// </summary>
        public async Task<bool> PasswordMatch(string username, string password)
        {
            string condition = $"UserName = '{username}'";
            var url = $"{baseUrl}/Validation/value-matches?tableName=Users&columnName=UserPassword&valueToMatch={password}&condition={condition}";

            return await GetAsync<bool>(url);
        }

        public async Task<string> GetRoleAsync(string username, string password)
        {
            var url = $"{baseUrl}/Users/role?username={username}&password={password}";
            return await GetAsync<string>(url);
        }

        public async Task<List<User>> SearchUsersAsync(string searchTerm)
        {
            var url = string.IsNullOrEmpty(searchTerm) ? $"{baseUrl}/Users" : $"{baseUrl}/Users/{searchTerm}";
            return await GetAsync<List<User>>(url);
        }

        public async Task<bool> InsertUserAsync(User user)
        {
            return await PostAsync($"{baseUrl}/Users", user);
        }
        public async Task<bool> UpdateUserAsync(User user)
        {
            return await PutAsync($"{baseUrl}/Users", user);
        }
        public async Task<bool> DeleteUserAsync(string id)
        {
            return await DeleteAsync($"{baseUrl}/Users/{id}");
        }
        //public async Task<string> GenerateNewUserIDAsync()
        //{
        //    var url = $"{baseUrl}/NumberGeneration/userID";
        //    return await GetAsync<string>(url);
        //}

        //public async Task<bool> UpdateUserPasswordAsync(string username, string password)
        //{
        //    var userData = new { username, password };
        //    return await PostAsync($"{baseUrl}/Products/updatePassword", userData);
        //}

        //public async Task<bool> UpdateUserPhoneAsync(string username, string phone)
        //{
        //    var userData = new { username, phone };
        //    return await PostAsync($"{baseUrl}/Products/updatePhone", userData);
        //}

        //public async Task<bool> UpdateUserRoleAsync(string username, string role)
        //{
        //    var userData = new { username, role };
        //    return await PostAsync($"{baseUrl}/Products/updateRole", userData);
        //}
        #endregion

        #region CustomerApi
        /// <summary>
        /// Customer operation
        /// </summary>
        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await GetAsync<List<Customer>>($"{baseUrl}/Customers");
        }

        public async Task<bool> InsertCustomerAsync(Customer customer)
        {
            return await PostAsync($"{baseUrl}/Customers", customer);
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            return await PutAsync($"{baseUrl}/Customers", customer);
        }

        public async Task<List<Customer>> SearchCustomersAsync(string searchTerm)
        {
            var url = string.IsNullOrEmpty(searchTerm) ? $"{baseUrl}/Customers" : $"{baseUrl}/Customers/{searchTerm}";
            return await GetAsync<List<Customer>>(url);
        }

        public async Task<bool> DeleteCustomerAsync(string customerId)
        {
            return await DeleteAsync($"{baseUrl}/Customers/{customerId}");
        }
        public async Task<bool> UpdateNotesAsync(NotesForCust notes)
        {
            return await PutAsync($"{baseUrl}/Customers/updateNotes", notes);
        }
        #endregion

        #region ProductApi
        /// <summary>
        /// Product operation
        /// </summary>
        public async Task<List<Product>> GetProductsAsync()
        {
            return await GetAsync<List<Product>>($"{baseUrl}/Products");
        }

        public async Task<bool> InsertProductAsync(Product product)
        {
            return await PostAsync($"{baseUrl}/Products", product);
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            return await PutAsync($"{baseUrl}/Products", product);
        }

        public async Task<string> GetProductCodeAsync(string barcode)
        {
            var url = $"{baseUrl}/Products/getCode?barcode={barcode}";
            return await GetAsync<string>(url);
        }

        public async Task<List<Product>> SearchProductsAsync(string searchTerm)
        {
            var url = $"{baseUrl}/Products/{searchTerm}";
            return await GetAsync<List<Product>>(url);
        }

        public async Task<string> GenerateNewProductCodeAsync()
        {
            var url = $"{baseUrl}/NumberGeneration/productCode";
            return await GetAsync<string>(url);
        }

        public async Task<bool> DeleteProductAsync(string productId)
        {
            return await DeleteAsync($"{baseUrl}/Products/{productId}");
        }
        public async Task<bool> UpdateInventoryAsync(InventoryUpdate updateinvt)
        {
            return await PutAsync($"{baseUrl}/Products/updateInventory", updateinvt);
        }

        #endregion

        #region OrderApi
        /// <summary>
        /// Order operation
        /// </summary>
        public async Task<List<Order>> GetOrdersAsync()
        {
            return await GetAsync<List<Order>>($"{baseUrl}/Orders");
        }

        public async Task<bool> InsertOrderAsync(Order order)
        {
            return await PostAsync($"{baseUrl}/Orders", order);
        }

        public async Task<List<Order>> SearchOrderAsync(string customerId)
        {
            var url = $"{baseUrl}/Orders/{customerId}";
            return await GetAsync<List<Order>>(url);
        }
        #endregion

        #region OrderDetailApi
        /// <summary>
        /// OrderDetail operation
        /// </summary>
        public async Task<List<OrderDetail>> GetOrderDetailsAsync()
        {
            return await GetAsync<List<OrderDetail>>($"{baseUrl}/OrderDetails");
        }

        public async Task<bool> InsertOrderDetailAsync(OrderDetail orderDetail)
        {
            return await PostAsync($"{baseUrl}/OrderDetails", orderDetail);
        }

        public async Task<List<OrderDetail>> SearchOrderDetailsAsync(string orderId)
        {
            var url = $"{baseUrl}/OrderDetails/{orderId}";
            return await GetAsync<List<OrderDetail>>(url);
        }
        #endregion

        #region AccountApi
        /// <summary>
        /// Account operation
        /// </summary>
        public async Task<List<Account>> GetAccountsAsync()
        {
            return await GetAsync<List<Account>>($"{baseUrl}/Accounts");
        }

        public async Task<bool> InsertAccountAsync(Account account)
        {
            return await PostAsync($"{baseUrl}/Accounts", account);
        }
        public async Task<List<Account>> SearchAccountAsync(string id)
        {
            var url = $"{baseUrl}/Accounts/{id}";
            return await GetAsync<List<Account>>(url);
        }
        public async Task<bool> UpdateAccount(Account account)
        {
            return await PutAsync($"{baseUrl}/Accounts", account);
        }
        public async Task<bool> UpdateAccountBalance(BalanceUpdate updatebala)
        {
            return await PutAsync($"{baseUrl}/Accounts/updatebalance", updatebala);
        }

        public async Task<double> GetBalanceAsync(string customerID)
        {
            var url = $"{baseUrl}/Accounts/getbalance?customerID={customerID}";
            return await GetAsync<double>(url);
        }
        public async Task<bool> DeleteAccountAsync(string customerId)
        {
            return await DeleteAsync($"{baseUrl}/Accounts/{customerId}");
        }
        #endregion

        #region ValidationApi
        /// <summary>
        /// Validation operation
        /// </summary>
        public async Task<bool> CheckExistsAsync(string tableName, string columnName, string value)
        {
            var url = $"{baseUrl}/Validation/exists?tableName={tableName}&columnName={columnName}&value={value}";
            return await GetAsync<bool>(url);
        }
        #endregion

        #region SupplierApi
        /// <summary>
        /// Supplier operation
        /// </summary>
        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            return await GetAsync<List<Supplier>>($"{baseUrl}/Suppliers");
        }

        public async Task<bool> InsertSupplierAsync(Supplier supplier)
        {
            return await PostAsync($"{baseUrl}/Suppliers", supplier);
        }

        public async Task<List<Supplier>> SearchSuppliersAsync(string searchTerm)
        {
            var url = string.IsNullOrEmpty(searchTerm) ? $"{baseUrl}/Suppliers" : $"{baseUrl}/Suppliers/{searchTerm}";
            return await GetAsync<List<Supplier>>(url);
        }

        public async Task<bool> UpdateSupplierAsync(Supplier supplier)
        {
            return await PutAsync($"{baseUrl}/Suppliers", supplier);
        }

        #endregion

        #region GoodsInApi
        /// <summary>
        /// GoodsIn operation
        /// </summary>
        public async Task<List<GoodsIn>> GetGoodsInAsync()
        {
            return await GetAsync<List<GoodsIn>>($"{baseUrl}/GoodsIn");
        }

        public async Task<bool> InsertGoodsInAsync(GoodsIn goodsIn)
        {
            return await PostAsync($"{baseUrl}/GoodsIn", goodsIn);
        }

        public async Task<List<GoodsIn>> SearchGoodsInAsync(string supplierCode)
        {
            var url = $"{baseUrl}/GoodsIn/search?supplierCode={supplierCode}";
            return await GetAsync<List<GoodsIn>>(url);
        }
        #endregion

        #region RecodeApi
        public async Task<List<InventoryChange>> GetAllInventoryChangesAsync()
        {
            var url = $"{baseUrl}/InventoryChange";
            return await GetAsync<List<InventoryChange>>(url);
        }
        public async Task<List<InventoryChange>> GetAllByIDAsync(string id)
        {
            var url = $"{baseUrl}/InventoryChange/{id}";
            return await GetAsync<List<InventoryChange>>(url);
        }
        public async Task<bool> InsertInventoryChangeAsync(InventoryChange invtChange)
        {
            return await PostAsync($"{baseUrl}/InventoryChange", invtChange);
        }
        #endregion

        #region MethodApi
        public async Task<int> GenerateNewIdAsync(string tableName, string idColumn)
        {
            var url = $"{baseUrl}/NumberGeneration/generate-id?tableName={tableName}&idColumn={idColumn}";
            var response = await GetAsync<int>(url);
            return response;
        }
        #endregion

        #region HelpDocsApi
        public async Task<List<HelpDocs>> GetAllHelpDocs()
        {
            return await GetAsync<List<HelpDocs>> ($"{baseUrl}/HelpDocs");
        }
        public async Task<List<HelpDocs>> GetHelpDocsByTerm(string term)
        {
            return await GetAsync<List<HelpDocs>>($"{baseUrl}/HelpDocs/{term}");
        }
        #endregion

        #region EventsApi
        public async Task<List<Events>> GetAllEventsAsync()
        {
            return await GetAsync<List<Events>>($"{baseUrl}/Events");
        }
        public async Task<List<Events>> GetEventsByDateAsync(string date)
        {
            string encodeddate = Uri.EscapeDataString(date);
            var url = string.IsNullOrEmpty(date) ? $"{baseUrl}/Events" : $"{baseUrl}/Events/{encodeddate}";
            return await GetAsync<List<Events>>(url);
        }
        public async Task<bool> InsertEventsAsync(Events even)
        {
            return await PostAsync($"{baseUrl}/Events", even);
        }
        public async Task<bool> UpdateEventAsync(Events even)
        {           
            return await PutAsync($"{baseUrl}/Events", even);
        }
        public async Task<bool> DeleteEventAsync(string id)
        {
            return await DeleteAsync($"{baseUrl}/Events/{id}");
        }
        public async Task<bool> UpdateNotes(EventNotes eventnotes)
        {
            return await PutAsync($"{baseUrl}/Events/updateNotes", eventnotes);
        }     
        #endregion
    }
}