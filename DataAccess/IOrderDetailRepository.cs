using Model;

namespace DataAccess
{
    public interface IOrderDetailRepository
    {
        Task<List<OrderDetail>> GetAllOrderDetailsAsync();
        Task<bool> AddOrderDetailAsync(OrderDetail orderDetail);
        Task<bool> UpdateOrderDetailAsync(OrderDetail orderDetail);
        Task<bool> DeleteOrderDetailAsync(string orderDetailId); 
        Task<List<OrderDetail>> GetOrderDetailsByOrderIdAsync(string orderId); 
    }
}
