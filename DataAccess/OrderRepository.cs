using System.Data;
using Model;

namespace DataAccess
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository() : base()
        {
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            string query = "SELECT * FROM Orders";
            DataTable table = GetData(query);
            List<Order> orders = new List<Order>();

            foreach (DataRow row in table.Rows)
            {
                Order order = new Order();
                var properties = typeof(Order).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(order, row[i]);
                    }
                }
                orders.Add(order);
            }

            return orders;
        }

        public async Task<List<Order>> GetOrderByIdAsync(string id)
        {
            string query = $"SELECT * FROM Orders WHERE CustomerID = '{id}'";
            DataTable table = GetData(query);
            List<Order> orders = new List<Order>();
            foreach (DataRow row in table.Rows)
            {
                Order order = new Order();
                var properties = typeof(Order).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(order, row[i]);
                    }
                }
                orders.Add(order);
            }
            return orders;
        }

        public async Task<bool> AddOrderAsync(Order order)
        {
            if (CheckExists("Orders", "OrderID", order.OrderID))
            {
                throw new Exception("Invalid OrderID.");
            }
            var parameters = new Dictionary<string, object>
            {
                { "OrderID", order.OrderID },
                { "CustomerID", order.CustomerID },
                { "OrderDate", order.OrderDate },
                { "TotalAmount", order.TotalAmount },
                { "Status", order.Status },
                { "Operator", order.Operator}
            };

            Insert("Orders", parameters); 
            return true;
        }

        public async Task<bool> UpdateOrderAsync(Order order)
        {
            var parameters = new Dictionary<string, object>
            {
                { "CustomerID", order.CustomerID },
                { "OrderDate", order.OrderDate },
                { "TotalAmount", order.TotalAmount },
                { "Status", order.Status }
            };
            string condition = $"OrderID = '{order.OrderID}'";
            Update("Orders", parameters, condition);
            return true;
        }

        public async Task<bool> DeleteOrderAsync(string orderId)
        {
            string condition = $"OrderID = '{orderId}'";
            Delete("Orders", condition); 
            return true; 
        }

        public async Task<List<Order>> GetOrdersByCustomerIdAsync(string customerId)
        {
            string query = $"SELECT * FROM Orders WHERE CustomerID = '{customerId}'";
            DataTable table = GetData(query);
            List<Order> orders = new List<Order>();

            foreach (DataRow row in table.Rows)
            {
                Order order = new Order();
                var properties = typeof(Order).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(order, row[i]);
                    }
                }
                orders.Add(order);
            }
            return orders;
        }
    }
}
