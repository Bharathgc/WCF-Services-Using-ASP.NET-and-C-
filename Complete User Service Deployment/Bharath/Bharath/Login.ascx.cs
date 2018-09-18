using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Bharath
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Loginuser(object sender, EventArgs e)
        {
            // Get the login credentials ffrom the webpage
            string username = loginusernametextbox.Text;
            string password = loginpasswordtextbox.Text;
            string designation = null;
            string Decodedpassword = "";
            //2 boolean variables to verify the authentication
            bool auth = false;
            bool present = false;
            try
            {
                // Read the xml file to check the user
                XmlDocument document = new XmlDocument();
                document.Load(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/Pagemembers.xml"));

                // Loop over the users to check if the user exists
                foreach (XmlElement element in document.LastChild.ChildNodes)
                {
                    if (element["Username"].InnerText == username)
                    {
                        //user is present
                        present = true;
                        //decrypt the password
                        Decodedpassword = element["Password"].InnerText;
                        if (element["Desgination"].InnerText == "User")
                        {
                            string innerpass = element["Password"].InnerText;
                            Decodedpassword = DllFile.Class1.DecryptIt(innerpass);
                        }
                        if (Decodedpassword == password)
                        {  
                            //password is corret
                            auth = true;
                        }
                        designation = element["Desgination"].InnerText;
                        break;
                    }
                }

                if (!present)
                {
                    //display user does not exist
                    loginstatus.Text = "The username does not exist";
                  
                }
                else if (!auth)
                {
                    //display password is incorrect
                    loginstatus.Text = "The Username/Password is Incorrect";
                   
                }
                else
                {
                    loginstatus.Text = "Login Success";
                    
                    // Add user_type to session
                    Session["user_type"] = designation;
                    if (designation == "User")
                    {
                        Response.Redirect("~/Users.aspx?username=" + username);
                    }                       
                    else if(designation == "Staff")
                    {
                        Response.Redirect("~/Staff.aspx?username=" + username);
                    }
                    else
                    {
                        Response.Redirect("~/Manager.aspx?username=" + username);
                    }
                       
                }

            }
            catch (Exception exception)
            {
                loginstatus.Text = exception.Message;
    
            }
            finally
            {
                loginusernametextbox.Text = "";
            }
        }
    }
}