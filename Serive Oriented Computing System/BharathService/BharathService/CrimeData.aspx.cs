using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BharathService
{
    public partial class CrimeData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GetCrimedataOfthePlace(object sender, EventArgs e)
        {
            CrimeDataServices.Service1Client crimedataservicesobject = new CrimeDataServices.Service1Client();
            LocationServicesReference.Service1Client locationservicesobject = new LocationServicesReference.Service1Client();
            string[] latlong = locationservicesobject.GetlocationdetailsAPI(placetextbox.Text).Split(',');
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:11098/Service1.svc/GetCrimeData?latitude="+ latlong[0]+ "&longitude="+latlong[1]);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            dynamic parsed_JSON = JsonConvert.DeserializeObject<dynamic>(new StreamReader(response.GetResponseStream()).ReadToEnd());
            string[] data = Convert.ToString(parsed_JSON).Split(',');
            voilentcrimeslabel.Text = Convert.ToString(data[0]);
            propertycrimeslabel.Text = Convert.ToString(data[1]);
            return;

        }
    }
}