using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Abstract
{
    public interface ITableService
    {
        int GetByID(Table table);
        List<Table> GetAll();
        void Update(Table table);


    }
}
