using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using StackExchange.Redis;

namespace DataAccess
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        RedisHelper redis = new RedisHelper();
        public CustomerRepository() : base()
        {
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            string customerCacheKey = "AllCustomers";
            var allcustomers = await redis.GetAsync<List<Customer>>(customerCacheKey);
            if (allcustomers != null)
            {
                return allcustomers;
            }
            string query = "SELECT * FROM Customers";
            DataTable table = GetData(query); 
            List<Customer> customers = new List<Customer>();

            foreach (DataRow row in table.Rows)
            {
                Customer customer = new Customer();
                var properties = typeof(Customer).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(customer, row[i]);
                    }
                }
                customers.Add(customer);
            }
            await redis.SetAsync(customerCacheKey, customers, TimeSpan.FromMinutes(1));
            return customers;
        }

        public async Task<List<Customer>> GetCustomerByTermAsync(string searchTerm)
        {
            string query = $"SELECT * FROM Customers WHERE CustomerID LIKE '%{searchTerm}%'" +
                           $"OR ContactName LIKE '%{searchTerm}%' " +
                           $"OR Phone LIKE '%{searchTerm}%' " +
                           $"OR Address1 LIKE '%{searchTerm}%'" +
                           $"OR Address2 LIKE '%{searchTerm}%'";
            DataTable table = GetData(query);
            List<Customer> customers = new List<Customer>();
            foreach (DataRow row in table.Rows)
            {
                Customer customer = new Customer();
                var properties = typeof(Customer).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(customer, row[i]);
                    }
                }
                customers.Add(customer);
            }
            return customers;
        }

        //public int GetNewCustomerId()
        //{
        //    return GenerateNewId("Customers", "CustomerID");
        //}

        public async Task<bool> AddCustomerAsync(Customer customer)
        {
            if (CheckExists("Customers", "CustomerID", customer.CustomerID))
            {
                throw new Exception("Customer ID already exists."); 
            }
            var parameters = new Dictionary<string, object>
            {
                { "CustomerID", customer.CustomerID },
                { "ContactName", customer.ContactName },
                { "Phone", customer.Phone },
                { "Email", customer.Email },
                { "Address1", customer.Address1 },
                { "Address2", customer.Address2 },
                { "Notes", customer.Notes }
            };

            Insert("Customers", parameters); 
            return true;
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            var parameters = new Dictionary<string, object>
            {
                { "ContactName", customer.ContactName },
                { "Phone", customer.Phone },
                { "Email", customer.Email },
                { "Address1", customer.Address1 },
                { "Address2", customer.Address2 },
                {"Notes", customer.Notes }
            };
            string condition = $"CustomerID = '{customer.CustomerID}'";
            Update("Customers", parameters, condition); 
            return true;
        }
        public async Task<bool> DeleteCustomerAsync(string customerId)
        {
            string condition = $"CustomerID = '{customerId}'";
            Delete("Customers", condition);
            return true;
        }
        public async Task<bool> UpdateNotesAsync(string custId, string notes)
        {
            var parameters = new Dictionary<string, object>
            {
                { "Notes", notes }
            };
            string condition = $"CustomerID = '{custId}'";
            Update("Customers", parameters, condition);
            return true;
        }
    }
}
