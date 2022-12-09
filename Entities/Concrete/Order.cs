using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public int TableID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
    }
}
