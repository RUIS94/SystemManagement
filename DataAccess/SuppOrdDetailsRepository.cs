using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class SuppOrdDetailsRepository : BaseRepository, ISuppOrdDetailsRepository
    {
        public SuppOrdDetailsRepository() :base() { }
        private async Task<List<SuppOrdDetails>> GetAllData(string query)
        {
            DataTable dt = GetData(query);
            List<SuppOrdDetails> details = new List<SuppOrdDetails>();
            foreach (DataRow row in dt.Rows)
            {
                SuppOrdDetails detail = new SuppOrdDetails();
                var properties = typeof(SuppOrdDetails).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(detail, row[i]);
                    }
                }
                details.Add(detail);
            }
            return details;
        }
        public Task<List<SuppOrdDetails>> GetAllDetails()
        {
            string query = "SELECT * FROM SuppOrdDetails";
            return GetAllData(query);
        }
        public Task<List<SuppOrdDetails>> GetDetailsByTerm(string term)
        {
            string query = $"SELECT * FROM SuppOrdDetails WHERE SupplierOrderID = {term}" +
                $"OR ProductCode = {term}";
            return GetAllData(query);
        }
        public Task<bool> InsertOrderDetail(SuppOrdDetails detail)
        {
            if(CheckExists("SuppOrdDetails", "ID", detail.ID))
            {
                throw new Exception("ID exists");
            }
            var parameters = new Dictionary<string, object>
            {
                { "ID", detail.ID },
                { "SupplierOrderID", detail.SupplierOrderID },
                { "ProductCode", detail.ProductCode},
                { "Price", detail.Price },
                { "Qty", detail.Qty },
                { "Total", detail.Total }
            };
            Insert("SuppOrdDetails", parameters);
            return Task.FromResult(true);
        }
    }
}
