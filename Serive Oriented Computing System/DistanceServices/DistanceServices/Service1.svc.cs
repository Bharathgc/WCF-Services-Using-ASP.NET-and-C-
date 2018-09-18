using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.Web;
using System.Xml;
using System.IO;
using System.Web.Script.Serialization;

namespace DistanceServices
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
        public string[] GetDistance(double lat1, double lon1, double lat2, double lon2)
        {
            string[] distancevalues = new string[3];
            //converting first latitude to radians
            double rlat1 = Math.PI * lat1 / 180;
            //converting first latitude to radians
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI * theta / 180;
            //using a standard formula to calulate distance between geo cordinates
            double dist = Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) * Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;
            //kilometers
            distancevalues[0] = (dist * 1.609344).ToString();
            //nautical miles
            distancevalues[1] = (dist * 0.8684).ToString();
            //miles
            distancevalues[2] = dist.ToString();
            return distancevalues;
        }
    }
}
