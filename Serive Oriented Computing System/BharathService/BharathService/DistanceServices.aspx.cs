using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BharathService
{
    public partial class DistanceServices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Getdistance(object sender, EventArgs e)
        {

            LocationServicesReference.Service1Client locationobject = new LocationServicesReference.Service1Client();
            string origindetails = locationobject.GetlocationdetailsAPI(origintextbox.Text);
            string[] details = origindetails.Split(',');
            double lat1 = Convert.ToDouble(details[0]);
            double long1 = Convert.ToDouble(details[1]);
            string destinationdetails = locationobject.GetlocationdetailsAPI(destinationtextbox.Text);
            string[] details2 = destinationdetails.Split(',');
            double lat2 = Convert.ToDouble(details2[0]);
            double long2 = Convert.ToDouble(details2[1]);
            Distances.Service1Client distanceobject = new Distances.Service1Client();
            string[] Distance = distanceobject.GetDistance(lat1,long1,lat2,long2);
            distancelabel.Text = "Distance Between " + origintextbox.Text + " and " + destinationtextbox.Text + " is " + Distance[0] + " Kilometers  or<br>" + Distance[2] + " Miles";
            return;
        }
    }
}