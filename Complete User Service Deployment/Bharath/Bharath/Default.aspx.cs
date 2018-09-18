using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bharath
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if(Session["user_type"] == "User")
				Response.Redirect("~/Users.aspx");
			else if(Session["user_type"] == "Staff")
				Response.Redirect("~/Staff.aspx");
			else if(Session["user_type"] == "Manager")
				Response.Redirect("~/Manager.aspx");
        }
    }
}