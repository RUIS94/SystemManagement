using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class GoodsInRepository : BaseRepository, IGoodsInRepository
    {
        public GoodsInRepository() : base()
        {
        }

        public async Task<List<GoodsIn>> GetAllGoodsInAsync()
        {
            string query = "SELECT * FROM GoodsIn";
            DataTable table = GetData(query);
            List<GoodsIn> goods = new List<GoodsIn>();
            foreach (DataRow row in table.Rows)
            {
                GoodsIn good = new GoodsIn();
                var properties = typeof(GoodsIn).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(good, row[i]);
                    }
                }
                goods.Add(good);
            }
            return goods;
        }

        public async Task<GoodsIn> GetGoodsInByIdAsync(string goodsInId)
        {
            string query = $"SELECT * FROM GoodsIn WHERE GoodsInID = '{goodsInId}'";
            DataTable table = GetData(query);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                GoodsIn goodsIn = new GoodsIn
                {
                    GoodsInCode = row["GoodsInID"].ToString(),
                    ProductCode = row["ProductCode"].ToString(),
                    ProductName = row["ProductName"].ToString(),
                    ProductBarcode = row["ProductBarcode"].ToString(),
                    ProductCost = Convert.ToDecimal(row["ProductCost"]),
                    ProductBatch = row["ProductBatch"].ToString(),
                    ProductQuantity = Convert.ToInt32(row["ProductQuantity"]),
                    SupplierCode = row["SupplierCode"].ToString(),
                    Total = Convert.ToDecimal(row["Total"]),
                    Date = row["Date"].ToString()
                };
                return goodsIn;
            }
            return null;
        }

        public async Task<bool> AddGoodsInAsync(GoodsIn goodsIn)
        {
            var parameters = new Dictionary<string, object>
            {
                {"GoodsInCode", goodsIn.GoodsInCode},
                {"ProductCode", goodsIn.ProductCode},
                {"ProductName", goodsIn.ProductName},
                {"ProductBarcode", goodsIn.ProductCode},
                {"ProductCost", goodsIn.ProductCost},
                {"ProductBatch", goodsIn.ProductBatch},
                {"ProductQuantity", goodsIn.ProductQuantity},
                {"SupplierCode", goodsIn.SupplierCode},
                {"Total", goodsIn.Total},
                {"Date", goodsIn.Date}
            };

            Insert("GoodsIn", parameters);
            return true; 
        }

        public async Task<bool> UpdateGoodsInAsync(GoodsIn goodsIn)
        {
            var parameters = new Dictionary<string, object>
            {
                {"GoodsInID", goodsIn.GoodsInCode},
                {"ProductCode", goodsIn.ProductCode},
                {"ProductName", goodsIn.ProductName},
                {"ProductBarcode", goodsIn.ProductCode},
                {"ProductCost", goodsIn.ProductCost},
                {"ProductBatch", goodsIn.ProductBatch},
                {"ProductQuantity", goodsIn.ProductQuantity},
                {"SupplierCode", goodsIn.SupplierCode},
                {"Total", goodsIn.Total},
                {"Date", goodsIn.Date}
            };
            string condition = $"GoodsInID = '{goodsIn.GoodsInCode}'";
            Update("GoodsIn", parameters, condition);
            return true;
        }

        public async Task<bool> DeleteGoodsInAsync(string goodsInId)
        {
            string condition = $"GoodsInID = '{goodsInId}'";
            Delete("GoodsIn", condition);
            return true;
        }
    }
}
