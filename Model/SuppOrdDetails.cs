using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SuppOrdDetails
    {
        public required string ID { get; set; }
        public string? SupplierOrderID { get; set;}
        public string? ProductCode { get; set; }
        public decimal? Price { get; set; }
        public int? Qty { get; set; }
        public decimal? Total {  get; set; }
    }
}
