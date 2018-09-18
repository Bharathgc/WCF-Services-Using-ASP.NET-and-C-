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
using System.Web.Script.Serialization;

namespace WindIntensity
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
        public string GetWindIntensity(string place)
        {
            // API Key is given here.
            string key = "1aefa5d5aa3ee3f7117215aae09a4154";
            string weatherstring = "";
            // From the url
            var request = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q="+ place+ "&appid=" + key);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)request.GetResponse();

            // Read through the response
            using (var streamreaderobject = new StreamReader(response.GetResponseStream()))
            {
                // Define a serializer to read your response
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                // Get your results
                dynamic result = serializer.DeserializeObject(streamreaderobject.ReadToEnd());
                weatherstring += result["visibility"] + ",";
                weatherstring += result["wind"]["speed"] + ",";
                weatherstring += result["wind"]["deg"];
                // Read the distance property from the JSON request
                //Console.Write(result.elements.duration.text);
                
            }
            return weatherstring;

        }
    }
}
