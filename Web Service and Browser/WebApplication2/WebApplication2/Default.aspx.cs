using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        
        protected void c2f_button_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service_one = new ServiceReference1.Service1Client();
            if(!String.IsNullOrWhiteSpace(c2f_textbox.Text))
            {
                int farenheit = service_one.c2f(Convert.ToInt32(c2f_textbox.Text));
                c2f_label.Text = Convert.ToString(farenheit) + "F";
                
            }
            else
            {
                c2f_label.Text = " Please Enter a number to convert";
                return;
            }
        }
        
        protected void f2c_button_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service_two = new ServiceReference1.Service1Client();
            if (!String.IsNullOrWhiteSpace(f2c_textbox.Text))
            {
                int Celsius = service_two.f2c(Convert.ToInt32(f2c_textbox.Text));
                f2c_label.Text = Convert.ToString(Celsius) + " C";
                
            }
            else
            {
                f2c_label.Text = " Please Enter a number to convert";
            }
        }

        protected void Clear_all_button(object sender, EventArgs e)
        {
            f2c_label.Text = "";
            c2f_label.Text = "";
            f2c_textbox.Text = "";
            c2f_textbox.Text = "";
            return;
        }

    }
}