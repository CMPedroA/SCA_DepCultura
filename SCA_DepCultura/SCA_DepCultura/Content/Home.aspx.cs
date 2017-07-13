using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCA_DepCultura.Content
{
    public partial class homee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ValidatePageAccess())
            {

            }
            else
            {
                Response.Redirect("~/Content/Home2.aspx");
                Response.ClearContent();
                Response.StatusCode = 401;
                Response.End();
            }
        }
        public bool ValidatePageAccess()
        {
            string pageAccessCode = "SCAH1";
            
             return ((General)Master).ValidatePageAccess(pageAccessCode);
            //return ((MasterPage)Master).ValidatePageAccess(pageAccessCode);
        }
    }
}