using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int  UserID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

    }
}
