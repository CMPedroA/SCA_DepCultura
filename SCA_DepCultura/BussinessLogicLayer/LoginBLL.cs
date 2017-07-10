using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BussinessLogicLayer
{
   public class LoginBLL
    {
       public string CheckUser(string user, string password)
       {
           LoginDAL DAL = new LoginDAL();
           return DAL.CheckUser(user,password);
       }
    }
}
