using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class LoginDAL
    {
        SCA_DepCulturaEntities Context;
        public LoginDAL() {
            Context = new SCA_DepCulturaEntities();      
        }
       
        public User checkUsers(string user, string pass) {
            var check = from TUser in Context.User
                        where TUser.userName == user
                        where TUser.password == pass
                        select TUser;
            return check.FirstOrDefault();
        }
    }
}
