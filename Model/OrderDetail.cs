namespace Model
{
    public class OrderDetail
    {
        public string OrderDetailID { get; set; }
        public string OrderID { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public double Discount { get; set; }
        public decimal Total { get; set; }
    }
}
