using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LatitudeLongitutdeZipcodeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetlocationdetailsAPI(string Place)
        {   
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://maps.googleapis.com/maps/api/geocode/json?address=" + Place);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            dynamic parsed_JSON = JsonConvert.DeserializeObject<dynamic>(new StreamReader(response.GetResponseStream()).ReadToEnd());
            string latitude = ((double)(parsed_JSON.results[0].geometry.location["lat"])).ToString();
            string longitude = ((double)(parsed_JSON.results[0].geometry.location["lng"])).ToString();
            request = (HttpWebRequest)WebRequest.Create("https://maps.googleapis.com/maps/api/geocode/json?latlng=" + (latitude.ToString()) + ", " + (longitude.ToString()));
            response = (HttpWebResponse)request.GetResponse();
            parsed_JSON = JsonConvert.DeserializeObject<dynamic>(new StreamReader(response.GetResponseStream()).ReadToEnd());
            string zipcode = (parsed_JSON.results[0].address_components[parsed_JSON.results[0].address_components.Count - 1].long_name).ToString();
            string locationString = latitude + ", " + longitude + ", " + zipcode;
            return locationString;
        }

    }
}
