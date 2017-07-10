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
        public string CheckUser(string user, string password) {
            var CheckUser = from tUser in Context.Users
                            where tUser.userName == user
                            where tUser.password == password
                            select new
                            {
                                nameUser = tUser.name + " " + tUser.surname
                            };
            return CheckUser.First().ToString();
                        
        }
    }
}
