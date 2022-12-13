using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace Business.Concrete
{
    public class TableManager : ITableService
    {
        private ITableDal _tableDal;

        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }

        public int GetByID(Table table)
        {
            using (RestaurantContext context = new RestaurantContext())
            {

                return Convert.ToInt32(table.TableID);
            }
        }
        public List<Table> GetAll()
        {
            return _tableDal.GetAll();
        }

        public void Update(Table table)
        {
            _tableDal.Update(table);
        }
    }
}
