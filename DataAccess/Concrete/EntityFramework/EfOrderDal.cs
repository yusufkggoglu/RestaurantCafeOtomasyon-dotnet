using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfOrderDal:EfEntityRepositoryBase<Order,RestaurantContext>,IOrderDal
    {
    }
}
