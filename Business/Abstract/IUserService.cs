using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        bool UserProvider(string name, string password);
        void Add(User user);

    }
}
