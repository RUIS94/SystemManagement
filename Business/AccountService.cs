using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class AccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<List<Account>> GetAllAccountsAsync()
        {
            return await _accountRepository.GetAllAccountsAsync();
        }

        public async Task<List<Account>> GetAccountByIDAsync(string id)
        {
            return await _accountRepository.GetAccountByIDAsync(id);
        }

        public async Task<bool> AddAccountAsync(Account account)
        {
            return await _accountRepository.AddAccountAsync(account);
        }

        public async Task<bool> UpdateAccountAsync(Account account)
        {
            return await _accountRepository.UpdateAccountAsync(account);
        }

        public async Task<bool> DeleteAccountAsync(string customerID)
        {
            return await _accountRepository.DeleteAccountAsync(customerID);
        }

        public async Task<decimal> GetBalanceAsync(string customerId)
        {
            return await _accountRepository.GetBalanceAsync(customerId);
        }

        public async Task<bool> UpdateAccountBalanceAsync(string id, decimal newBalance)
        {
            return await _accountRepository.UpdateAccountBalanceAsync(id, newBalance);
        }

        public async Task<bool> UpdateAccountPasswordAsync(string accountNumber, string newPassword)
        {
            return await _accountRepository.UpdateAccountPasswordAsync(accountNumber, newPassword);
        }
    }
}
