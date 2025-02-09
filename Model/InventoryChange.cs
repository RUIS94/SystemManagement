using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InventoryChange
    {
        public string ID { get; set; }
        public string ProductCode { get; set; }
        public string Date { get; set; }
        public string Qty { get; set; }
        public string Reason { get; set; }
    }
}
