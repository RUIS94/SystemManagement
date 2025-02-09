namespace Model
{
    public class Order
    {
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public string OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
