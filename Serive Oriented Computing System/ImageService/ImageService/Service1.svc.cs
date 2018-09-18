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

namespace ImageService
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
        public string[] GetImages(string Place)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://pixabay.com/api/?key=9314153-00ca87e144ffd1f9d627a1168&q="+ Place+"&pretty=true" );
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            dynamic parsed_JSON = JsonConvert.DeserializeObject<dynamic>(new StreamReader(response.GetResponseStream()).ReadToEnd());
            
            int numberofhits = parsed_JSON["totalHits"];
            string[] images = new string[20];
            int count = 0;
            while (count < 20 && count < numberofhits)
            {

                images[count] = parsed_JSON["hits"][count]["webformatURL"];
                count++;
            }

            return images;
            //return parsed_JSON["hits"][0]["webformatURL"];
        }
    }
}
