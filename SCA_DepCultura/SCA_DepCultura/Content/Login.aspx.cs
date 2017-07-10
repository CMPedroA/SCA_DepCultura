using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLogicLayer;

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
                Session["UserName"] = loginBLL.CheckUser(txtUser.Text, txtPassword.Text).ToString();

                if (Session["UserName"] != null)
                {
                    Response.Redirect("Home.aspx");
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