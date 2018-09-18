using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Transformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GetTransformation(object sender, EventArgs e)
        {
            services.Service1Client Transformationobject = new services.Service1Client();
            string verificationresults = Transformationobject.GetHTML(xmlfiletextbox.Text, xslfiletextbox.Text);
            resultlabel.Text = Server.HtmlDecode(verificationresults); 
            return;
        }
    }
}