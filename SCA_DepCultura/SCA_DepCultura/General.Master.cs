using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace SCA_DepCultura
{
    public partial class General : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public bool ValidatePageAccess(string accessCode)
        {
            if (((Hashtable)Session["access"]).ContainsValue(accessCode))
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}