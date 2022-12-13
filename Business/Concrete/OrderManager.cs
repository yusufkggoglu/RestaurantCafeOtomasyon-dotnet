using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace Business.Concrete
{
    public class OrderManager:IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderdal)
        {
            _orderDal = orderdal;
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public Order Get(int id)
        {
            return _orderDal.Get(p => p.OrderID.Equals(id));
        }
        
        public List<Order> GetAll(int id)
        {
            return _orderDal.GetAll(p=>p.TableID.Equals(id));
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
