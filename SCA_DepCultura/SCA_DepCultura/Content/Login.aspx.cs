using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using BussinessLogicLayer;
using DataAccessLayer;
using System.Collections;

namespace SCA_DepCultura.Content
{
    public partial class Login : System.Web.UI.Page
    {
        #region BLL
        LoginBLL loginBLL = new LoginBLL();

        #endregion
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }
        protected void btEnter_Click(object sender, EventArgs e)
        {
            try
            {
               
               User dataUser = new User();
               dataUser = loginBLL.checkUsers(txtUser.Text, txtPassword.Text);
               Session["Name"] = dataUser.name.ToString() + " " + dataUser.firstSurname.ToString();
               Session["UserName"] = dataUser.userName;
               Session["Profile"] = dataUser.Roles.Name;
               Hashtable has = new Hashtable();
                has=new AccessBLL().getAccesUser(Session["Profile"].ToString());
                Session["access"] = has;
                

               
                if (Session["UserName"] != null)
                {
                    Response.Redirect("~/Content/Home.aspx");
                }
                else
                {

                }
            }
            catch { 
            
            }


        }
        #endregion
        #region Methods
        
        #endregion
    }
}