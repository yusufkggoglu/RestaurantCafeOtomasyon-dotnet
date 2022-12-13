using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        public int PaymentID { get; set; }
        public decimal Price { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime DateTime { get; set; }
    }
}
