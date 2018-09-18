using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace WcfService1
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

        public string verification(string xmlUrl, string xsdUrl)
        {
            string result = "No Errors"; 
            string xmlstring;
            var set = new XmlSchemaSet();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (var wc = new WebClient())
            {                
                xmlstring = wc.DownloadString(xmlUrl); 
                var xd = new XmlDocument(); 
                xd.Load(xmlUrl);
                var xdoc = XDocument.Load(new XmlNodeReader(xd));
                set.Add(null, xsdUrl); 
                xdoc.Validate(set, (o, e) => 
                {
                    result = e.Message;
                });
            }
            return result;
        }
        public string GetHTML(string urlXML, string urlXSL)
        {
            StringBuilder sb = new StringBuilder("");
            XmlWriterSettings xSet = new XmlWriterSettings();
            xSet.ConformanceLevel = ConformanceLevel.Auto;
            XmlWriter writer = XmlWriter.Create(sb, xSet);
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(urlXSL);
            transform.Transform(urlXML, writer);
            string res = sb.ToString();
            string path = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Persons.html");
            File.WriteAllText(path, string.Empty);
            File.WriteAllText(path, res);
            return res;
        }


    }
}
