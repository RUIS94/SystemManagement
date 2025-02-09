using Model;

namespace DataAccess
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<List<Customer>> GetCustomerByTermAsync(string term);
        //int GetNewCustomerId();
        Task<bool> AddCustomerAsync(Customer customer);
        Task<bool> UpdateCustomerAsync(Customer customer);
        Task<bool> DeleteCustomerAsync(string customerId);
        Task<bool> UpdateNotesAsync(string custID, string notes);
    }
}
