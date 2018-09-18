using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Bharath
{
    public partial class Register : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void clearform()
        {
            registerusernametextbox.Text = string.Empty;
            registerpasswordtextbox.Text = string.Empty;
            registerfirstnametextbox.Text = string.Empty;
            registerlastnametextbox.Text = string.Empty;
            registerretypepasswordtextbox.Text = string.Empty;
            registeremailtextbox.Text = string.Empty;
            captchatextbox.Text = string.Empty;
        }
        protected void printerrormessage(string message)
        {
            registerstatus.Text = message;
            registerstatus.ForeColor = Color.Red;
            registerstatus.Font.Bold = true;
        }
        protected void RegisterUser(object sender, EventArgs e)
        {
            // Get the registration details from the webpage
            string username = registerusernametextbox.Text;
            string password = registerpasswordtextbox.Text;
            string password2 = registerretypepasswordtextbox.Text;
            string emailid = registeremailtextbox.Text;
            string fname = registerfirstnametextbox.Text;
            string lname = registerlastnametextbox.Text;
            if(username == string.Empty || password == string.Empty || password2 == string.Empty || emailid == string.Empty || fname == string.Empty || lname == string.Empty)
            {
                printerrormessage("Please fill all the fields");
            }
            try
            {
                // Read the xml file to check the user
                XmlDocument document = new XmlDocument();
                document.Load(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/Pagemembers.xml"));

                // Loop over the elements to check for user
                foreach (XmlElement element in document.LastChild.ChildNodes)
                {
                    if (element["Username"].InnerText == username || element["Emailid"].InnerText == emailid)
                    {
                        printerrormessage("The User already exists. Please Login");
                        clearform();
                        return;
                    }
                }

                // Check if the password and retypepasswords match
                if (password != password2)
                {
                    printerrormessage("Passwords don't match!");
                    clearform();
                    return;
                }

                // Check the captcha
                if (!captcha_image.Validate(captchatextbox.Text))
                {
                    printerrormessage("You entered the captcha incorrectly. Please try again");
                    clearform();
                    return;
                }
                //encrypt the password
                string encodedpassword;
                encodedpassword = DllFile.Class1.EncryptIt(password);
                
                // Enter the user details into the xml file
                //create each element and enter the details
                XmlNode memberelement = document.CreateElement("member");
                XmlNode nameelement = document.CreateElement("Name");
                XmlNode firstnameelement = document.CreateElement("FirstName");
                firstnameelement.InnerText = fname;
                XmlNode lastnameelement = document.CreateElement("LastName");
                lastnameelement.InnerText = lname;
                XmlNode emailidelement = document.CreateElement("Emailid");
                emailidelement.InnerText = emailid;
                XmlNode usernameelement = document.CreateElement("Username");
                usernameelement.InnerText = username;
                XmlNode passwordelement = document.CreateElement("Password");
                passwordelement.InnerText = encodedpassword;
                XmlNode designationelement = document.CreateElement("Desgination");
                designationelement.InnerText = "User";
                //append all the elements to the member element
                nameelement.AppendChild(firstnameelement);
                nameelement.AppendChild(lastnameelement);
                memberelement.AppendChild(nameelement);
                memberelement.AppendChild(emailidelement);
                memberelement.AppendChild(usernameelement);                
                memberelement.AppendChild(passwordelement);
                memberelement.AppendChild(designationelement);
                //append  the member element to the xml file
                document.DocumentElement.AppendChild(memberelement);
                document.Save(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/Pagemembers.xml"));

                // Registration Successfull
                registerstatus.Text = "User regsitered successfully!";
                registerstatus.ForeColor = Color.Green;
                registerstatus.Font.Bold = true;
                //clear the form
                clearform();

            }
            catch (Exception exception)
            {
                registerstatus.Text = exception.Message;
            }
        }
    }
}