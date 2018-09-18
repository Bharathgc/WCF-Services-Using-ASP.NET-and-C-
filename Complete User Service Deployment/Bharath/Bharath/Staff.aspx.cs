using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Bharath
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_type"] == null || Session["user_type"].ToString() != "Staff")
            {
                Response.Redirect("~/Default.aspx");
            }
            username.Text = Request.QueryString["username"];
            try
            {
                StringBuilder sb = new StringBuilder("");
                XmlWriterSettings xSet = new XmlWriterSettings();
                xSet.ConformanceLevel = ConformanceLevel.Auto;
                XmlWriter writer = XmlWriter.Create(sb, xSet);
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/staff.xsl"));
                transform.Transform(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/Pagemembers.xml"), writer);
                string res = sb.ToString();
                userdiv.InnerHtml = res;
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
                status.Visible = true;
            }


        }
        protected void Logout(object sender, EventArgs e)
        {
            Session["user_type"] = null;
            Response.Redirect("~/Default.aspx");
        }
    }
}