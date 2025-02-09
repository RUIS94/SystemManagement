using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using static Model.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            var customers = await _customerService.GetAllCustomersAsync();
            return Ok(customers);
        }

        [HttpGet("{searchTerm}")]
        public async Task<ActionResult<Customer>> GetCustomerByTerm(string searchTerm)
        {
            var customer = await _customerService.GetCustomerByTermAsync(searchTerm);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult> AddCustomer([FromBody] Customer customer)
        {
            await _customerService.AddCustomerAsync(customer);
            return CreatedAtAction(nameof(GetAllCustomers), new { id = customer.CustomerID }, customer);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCustomer([FromBody] Customer customer)
        {
            await _customerService.UpdateCustomerAsync(customer);
            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCustomer(string id)
        {
            await _customerService.DeleteCustomerAsync(id);
            return NoContent();
        }

        [HttpPut("updateNotes")]
        public async Task<ActionResult> UpdateNotes([FromBody] NotesForCust notes)
        {
            await _customerService.UpdateNotesAsync(notes.CustomerID, notes.Notes);
            return Ok();
        }
    }
}