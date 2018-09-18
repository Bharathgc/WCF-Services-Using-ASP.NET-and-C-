using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bharath
{
    public partial class Images : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GetImagesOfthePlace(object sender, EventArgs e)
        {
            Image.Service1Client imageservicesobject = new Image.Service1Client();
            string[] imageslist = imageservicesobject.GetImages(placenametextbox.Text);
            RepeaterImages.DataSource = imageslist;
            RepeaterImages.DataBind();

            return;

        }
    }
}