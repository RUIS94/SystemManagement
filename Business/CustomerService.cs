using DataAccess;
using Model;

namespace Business
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _customerRepository.GetAllCustomersAsync();
        }
        public async Task<List<Customer>> GetCustomerByTermAsync(string searchTerm)
        {
            return await _customerRepository.GetCustomerByTermAsync(searchTerm);
        }

        public async Task<bool> AddCustomerAsync(Customer customer)
        {
            return await _customerRepository.AddCustomerAsync(customer);
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            return await _customerRepository.UpdateCustomerAsync(customer);
        }

        public async Task<bool> DeleteCustomerAsync(string customerId)
        {
            return await _customerRepository.DeleteCustomerAsync(customerId);
        }
        public async Task<bool> UpdateNotesAsync(string custID, string notes)
        {
            return await _customerRepository.UpdateNotesAsync(custID, notes);
        }
    }
}