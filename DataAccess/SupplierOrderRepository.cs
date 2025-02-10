using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class SupplierOrderRepository : BaseRepository, ISupplierOrderRepository
    {
        public SupplierOrderRepository() : base()  { }

        //private async Task<List<SupplierOrder>> GetAllData(string query)
        //{
        //    DataTable dt = GetData(query);
        //    List<SupplierOrder> orders = new List<SupplierOrder>();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        SupplierOrder order = new SupplierOrder();
        //        var properties = typeof(SupplierOrder).GetProperties();
        //        for (int i = 0; i < properties.Length; i++)
        //        {
        //            if (row[i] != DBNull.Value)
        //            {
        //                properties[i].SetValue(order, row[i]);
        //            }
        //        }
        //        orders.Add(order);
        //    }
        //    return orders;
        //}
        private SupplierOrder DataRowToOrder(DataRow row)
        {
            SupplierOrder order = new SupplierOrder();
            var properties = typeof(SupplierOrder).GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                if (row[i] != DBNull.Value)
                {
                    properties[i].SetValue(order, row[i]);
                }
            }
            return order;

        }
        public Task<List<SupplierOrder>> GetAllSuppOrder()
        {
            string query = "SELECT * FROM SupplierOrder";
            DataTable dt = GetData(query);
            List<SupplierOrder> orders = new List<SupplierOrder>();
            foreach (DataRow row in dt.Rows)
            {
                orders.Add(DataRowToOrder(row));
            }
            return Task.FromResult(orders);
        }
        public Task<List<SupplierOrder>> GetSuppOrderByTerm(string term)
        {
            string query = $"SELECT * FROM SupplierOrder WHERE SupplierCode = {term}" +
                $"OR Date LIKE '%{term}%'";
            DataTable dt = GetData(query);
            List<SupplierOrder> orders = new List<SupplierOrder>();
            foreach (DataRow row in dt.Rows)
            {
                orders.Add(DataRowToOrder(row));
            }
            return Task.FromResult(orders);

        }
        public Task<bool> InsertSuppOrder(SupplierOrder suppord)
        {
            if (CheckExists("SupplierOrder", "SupplierOrderID", suppord.SupplierOrderID))
            {
                throw new Exception("ID exists");
            }
            var parameters = new Dictionary<string, object?>
            {
                {"SupplierOrderID", suppord.SupplierOrderID},
                {"SupplierCode", suppord.SupplierCode },
                {"Date", suppord.Date },
                {"Total", suppord.Total }
            };
            Insert("SupplierOrder", parameters);
            return Task.FromResult(true);
        }
    }
}
