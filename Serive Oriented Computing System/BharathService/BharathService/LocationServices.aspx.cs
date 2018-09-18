using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BharathService
{
    public partial class LocationServices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Getlocationdetails(object sender, EventArgs e)
        {
            LocationServicesReference.Service1Client locationobject = new LocationServicesReference.Service1Client();
            string locationdetails = locationobject.GetlocationdetailsAPI(locationtextbox.Text);
            string[] details = locationdetails.Split(',');
            longitudelabel.Text = details[1];
            latitudelabel.Text = details[0];
            zipcodelabel.Text = details[2];
            return;
        }

    }
}