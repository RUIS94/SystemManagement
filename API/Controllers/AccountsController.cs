using API.Controllers;
using Business;
using Microsoft.AspNetCore.Mvc;
using Model;
using static Model.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : Controller
    {
        private readonly AccountService _accountService;
        public AccountsController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Account>>> GetAccounts()
        {
            var accounts = await _accountService.GetAllAccountsAsync();
            return Ok(accounts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Account>>> GetAccountByID(string id)
        {
            var account = await _accountService.GetAccountByIDAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }
        [HttpGet("getbalance")]
        public async Task<ActionResult<decimal>> GetBalance(string customerID)
        {
            var balance = await _accountService.GetBalanceAsync(customerID);
            return Ok(balance);
        }
        [HttpPost]
        public async Task<ActionResult> AddAccount([FromBody] Account account)
        {
            await _accountService.AddAccountAsync(account);
            return CreatedAtAction(nameof(GetAccounts), new { id = account.CustomerID }, account);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAccount([FromBody] Account account)
        {
            await _accountService.UpdateAccountAsync(account);
            return NoContent();
        }

        [HttpPut("{password}")]
        public async Task<ActionResult> UpdateBalance(string customerID, decimal balance)
        {
            await _accountService.UpdateAccountBalanceAsync(customerID, balance);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAccount(string id)
        {
            await _accountService.DeleteAccountAsync(id);
            return NoContent();
        }

        [HttpPut("updatebalance")]
        public async Task<ActionResult> UpdateInventory([FromBody] BalanceUpdate updatebala)
        {
            await _accountService.UpdateAccountBalanceAsync(updatebala.CustomerID, updatebala.AccountBalance);
            return Ok();
        }
    }
}