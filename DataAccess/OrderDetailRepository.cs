using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class OrderDetailRepository : BaseRepository, IOrderDetailRepository
    {
        public OrderDetailRepository() : base()
        {
        }

        public async Task<List<OrderDetail>> GetAllOrderDetailsAsync()
        {
            string query = "SELECT * FROM OrderDetails";
            DataTable table = GetData(query);
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            foreach (DataRow row in table.Rows)
            {
                OrderDetail orderDetail = new OrderDetail();
                var properties = typeof(OrderDetail).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(orderDetail, row[i]);
                    }
                }
                orderDetails.Add(orderDetail);
            }

            return orderDetails;
        }

        public async Task<bool> AddOrderDetailAsync(OrderDetail orderDetail)
        {
            var parameters = new Dictionary<string, object>
            {
                { "OrderDetailID", orderDetail.OrderDetailID },
                { "OrderID", orderDetail.OrderID },
                { "ProductCode", orderDetail.ProductCode },
                { "Quantity", orderDetail.Quantity },
                { "UnitPrice", orderDetail.UnitPrice },
                { "Discount", orderDetail.Discount },
                { "Total", orderDetail.Total }
            };

            Insert("OrderDetails", parameters); 
            return true;
        }

        public async Task<bool> UpdateOrderDetailAsync(OrderDetail orderDetail)
        {
            var parameters = new Dictionary<string, object>
            {
                { "Quantity", orderDetail.Quantity },
                { "UnitPrice", orderDetail.UnitPrice },
                { "Discount", orderDetail.Discount },
                { "Total", orderDetail.Total }
            };
            string condition = $"OrderDetailID = '{orderDetail.OrderDetailID}'";
            Update("OrderDetails", parameters, condition);
            return true; 
        }

        public async Task<bool> DeleteOrderDetailAsync(string orderDetailId)
        {
            string condition = $"OrderDetailID = '{orderDetailId}'";
            Delete("OrderDetails", condition);
            return true;
        }

        public async Task<List<OrderDetail>> GetOrderDetailsByOrderIdAsync(string orderId)
        {
            string query = $"SELECT * FROM OrderDetails WHERE OrderID = '{orderId}'";
            DataTable table = GetData(query);
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            foreach (DataRow row in table.Rows)
            {
                OrderDetail orderDetail = new OrderDetail();
                var properties = typeof(OrderDetail).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(orderDetail, row[i]);
                    }
                }
                orderDetails.Add(orderDetail);
            }

            return orderDetails;
        }
    }
}
