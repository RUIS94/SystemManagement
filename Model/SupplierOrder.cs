using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SupplierOrder
    {
        public required string SupplierOrderID { get; set; }
        public string? SupplierCode { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Total { get; set; }
    }
}
