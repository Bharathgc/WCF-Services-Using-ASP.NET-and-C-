using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bharath
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_type"] == null || Session["user_type"].ToString() != "User")
            {
                Response.Redirect("~/Default.aspx");
            }
            username.Text = Request.QueryString["username"];
        }
        protected void Logout(object sender, EventArgs e)
        {
            Session["user_type"] = null;
            Response.Redirect("~/Default.aspx");
        }
    }
}