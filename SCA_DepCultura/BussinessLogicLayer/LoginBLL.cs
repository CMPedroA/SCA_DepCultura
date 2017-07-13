using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BussinessLogicLayer
{
   public class LoginBLL
    {
       
       public User checkUsers(string user, string pass) {

           LoginDAL DAl = new LoginDAL();
           return DAl.checkUsers(user,pass);
       }
    }
}
