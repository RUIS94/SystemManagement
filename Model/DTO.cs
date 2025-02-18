using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DTO
    {
        public class BalanceUpdate
        {
            public string? CustomerID { get; set; }
            public decimal AccountBalance { get; set; }
        }
        public class InventoryUpdate
        {
            public string? ProductCode { get; set; }
            public int Inventory { get; set; }
        }
        public class  NotesForCust
        {
            public string? CustomerID { get; set; }
            public string? Notes { get; set; }  
        }

        public class EventNotes
        {
            public string? ID { get; set; }
            public string? Notes { get; set; }
        }

        public class GetUsername
        {
            public string?  UserName { get; set; }
        }
        public class ActionLog
        {
            public string? Action { get; set; }
        }
    }
}
