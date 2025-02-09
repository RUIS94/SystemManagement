using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface IAccountRepository
    {
        Task<List<Account>> GetAllAccountsAsync(); 
        Task<List<Account>> GetAccountByIDAsync(string id); 
        Task<bool> AddAccountAsync(Account account); 
        Task<bool> UpdateAccountAsync(Account account);
        Task<bool> DeleteAccountAsync(string accountNumber); 
        Task<decimal> GetBalanceAsync(string customerId); 
        Task<bool> UpdateAccountBalanceAsync(string id, decimal newBalance);
        Task<bool> UpdateAccountPasswordAsync(string accountNumber, string newPassword);
        Task<string> GenerateNewAccountNumberAsync();
    }
}
