using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Verification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GetVerification(object sender, EventArgs e)
        {
            services.Service1Client verificationobject = new services.Service1Client();
            string verificationresults = verificationobject.verification(xmlfiletextbox.Text, schmeafiletextbox.Text);
            resultlabel.Text = verificationresults;
            return;
        }
    }
}