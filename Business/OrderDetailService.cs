using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class OrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<List<OrderDetail>> GetAllOrderDetailsAsync()
        {
            return await _orderDetailRepository.GetAllOrderDetailsAsync();
        }

        public async Task<bool> AddOrderDetailAsync(OrderDetail orderDetail)
        {
            return await _orderDetailRepository.AddOrderDetailAsync(orderDetail);
        }

        public async Task<bool> UpdateOrderDetailAsync(OrderDetail orderDetail)
        {
            return await _orderDetailRepository.UpdateOrderDetailAsync(orderDetail);
        }

        public async Task<bool> DeleteOrderDetailAsync(string orderDetailId)
        {
            return await _orderDetailRepository.DeleteOrderDetailAsync(orderDetailId);
        }

        public async Task<List<OrderDetail>> GetOrderDetailsByOrderIdAsync(string orderId)
        {
            return await _orderDetailRepository.GetOrderDetailsByOrderIdAsync(orderId);
        }
    }
}