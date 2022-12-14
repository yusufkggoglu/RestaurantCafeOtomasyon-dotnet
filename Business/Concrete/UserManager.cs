using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
   public class UserManager:IUserService
   {
       private IUserDal _userDal;

       public UserManager(IUserDal userDal)
       {
           _userDal = userDal;
       }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public bool UserProvider(string name, string password)
       {
           Boolean result=false;
           var list = _userDal.GetAll();
           foreach (var temp in list)
           {
               if (temp.Name==name)
               {
                   if (temp.Password==password)
                   {
                       result = true;
                       return result;
                   }
               }
           }
           return result;
       }
   }
}
