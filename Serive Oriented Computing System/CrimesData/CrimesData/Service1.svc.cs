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

namespace CrimesData
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
        public string GetCrimeData(double latitude, double longitude)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/Bharathgc/CrimesJson/master/new_crimes.json");
            
           
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string crime_rate = "";
            
            // Read through the response
            using (var streamreaderobject = new StreamReader(response.GetResponseStream()))
            {
                
                dynamic result = JsonConvert.DeserializeObject(streamreaderobject.ReadToEnd());
                foreach(var row in result)
                {
                    if (((int)row["Latitude"]) == (int)latitude)
                    {
                        if (((int)row["Longitude"]) == (int)longitude)
                        {
                            crime_rate += row["Voilent Crimes"] + ",";
                            crime_rate += row["Property Crimes"];
                        }
                    }
                  
                }
            }
            return crime_rate;
        }
    }
}
