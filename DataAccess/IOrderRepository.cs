using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrdersAsync(); 
        Task<List<Order>> GetOrderByIdAsync(string id); 
        Task<bool> AddOrderAsync(Order order);
        Task<bool> UpdateOrderAsync(Order order); 
        Task<bool> DeleteOrderAsync(string orderId); 
        Task<List<Order>> GetOrdersByCustomerIdAsync(string customerId);
    }
}
