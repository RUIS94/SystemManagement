using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OperationLog
    {
        public int ID { get; set; }
        public DateTime Timestamp { get; set; }
        public string Action { get; set; }
    }
}
