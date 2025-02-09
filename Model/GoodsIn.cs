using System;
using System.Collections.Generic;
namespace Model
{
    public class GoodsIn
    {
        public string GoodsInCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductBarcode { get; set; }
        public decimal ProductCost { get; set; }
        public string ProductBatch { get; set; }
        public int ProductQuantity { get; set; }
        public string SupplierCode { get; set; }
        public decimal Total { get; set; }
        public string Date { get; set; }
    }
}
