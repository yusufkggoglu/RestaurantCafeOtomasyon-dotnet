using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll(int id);
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
        Order Get(int id);
    }
}
