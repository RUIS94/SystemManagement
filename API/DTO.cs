namespace API
{
    public class DTO
    {
        public class AccountDeposit
        {
            public string CustomerID { get; set; }
            public decimal AccountBalance { get; set; }
        }
        public class  InventoryUpdate
        {
            public string ProductCode { get; set; }
            public int Inventory { get; set; }
        }
    }
}
