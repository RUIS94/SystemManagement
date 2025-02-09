using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Model;

namespace DataAccess
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        public AccountRepository() : base()//string connectionString) : base(connectionString)
        {
        }

        public async Task<List<Account>> GetAllAccountsAsync()
        {
            string query = "SELECT * FROM Accounts";
            DataTable table = GetData(query);
            List<Account> accounts = new List<Account>();

            foreach (DataRow row in table.Rows)
            {
                Account account = new Account();
                var properties = typeof(Account).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(account, row[i]);
                    }
                }
                accounts.Add(account);
            }

            return accounts;
        }

        public async Task<List<Account>> GetAccountByIDAsync(string id)
        {
            string query = $"SELECT * FROM Accounts WHERE CustomerID = '{id}'";
            DataTable table = GetData(query);
            List<Account> accounts = new List<Account>();
            foreach (DataRow row in table.Rows)
            {
                Account account = new Account();
                var properties = typeof(Account).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(account, row[i]);
                    }
                }
                accounts.Add(account);
            }
            return accounts;
        }

        public async Task<bool> AddAccountAsync(Account account)
        {
            var parameters = new Dictionary<string, object>
            {
                { "AccountNumber", account.AccountNumber },
                { "AccountPassword", account.AccountPassword },
                { "CustomerID", account.CustomerID },
                { "AccountBalance", account.AccountBalance }
            };

            Insert("Accounts", parameters);
            return true;
        }

        public async Task<bool> UpdateAccountAsync(Account account)
        {
            var parameters = new Dictionary<string, object>
            {
                { "AccountPassword", account.AccountPassword },
                { "AccountBalance", account.AccountBalance }
            };
            string condition = $"AccountNumber = '{account.AccountNumber}'";
            Update("Accounts", parameters, condition);
            return true;
        }

        public async Task<bool> DeleteAccountAsync(string customerId)
        {
            string condition = $"CustomerID = '{customerId}'";
            Delete("Accounts", condition); 
            return true; 
        }

        public async Task<decimal> GetBalanceAsync(string customerId)
        {
            string query = $"SELECT AccountBalance FROM Accounts WHERE CustomerID = '{customerId}'";
            string balanceString = GetValue("Accounts", "AccountBalance", $"CustomerID = '{customerId}'");
            return decimal.TryParse(balanceString, out decimal balance) ? balance : 0;
        }

        public async Task<bool> UpdateAccountBalanceAsync(string customerID, decimal newBalance)
        {
            var parameters = new Dictionary<string, object>
            {
                { "AccountBalance", newBalance }
            };
            string condition = $"CustomerID = '{customerID}'";
            Update("Accounts", parameters, condition); 
            return true;
        }

        public async Task<bool> UpdateAccountPasswordAsync(string accountNumber, string newPassword)
        {
            var parameters = new Dictionary<string, object>
            {
                { "AccountPassword", newPassword }
            };
            string condition = $"AccountNumber = '{accountNumber}'";
            Update("Accounts", parameters, condition); 
            return true; 
        }

        public async Task<string> GenerateNewAccountNumberAsync()
        {
            string query = "SELECT MAX(CAST(AccountNumber AS INT)) FROM Accounts";
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
