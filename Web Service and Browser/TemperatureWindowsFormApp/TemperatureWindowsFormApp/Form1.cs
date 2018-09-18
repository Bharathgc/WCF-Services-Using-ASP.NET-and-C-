using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureWindowsFormApp.ServiceReference1;
namespace TemperatureWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void c2f_button_1_Click(object sender, EventArgs e)
        {
            IService1 Convert_c2f = new Service1Client();
            if (String.IsNullOrWhiteSpace(c2f_textBox1.Text))
            {
                c2f_label1.Text = "Please Enter a number";
                return;
            }
            int farenheit = Convert_c2f.c2f(Convert.ToInt32(c2f_textBox1.Text));
            c2f_label1.Text = Convert.ToString(farenheit);

        }

        private void f2c_button_1_Click(object sender, EventArgs e)
        {
            IService1 Convert_f2c = new Service1Client();
            if (String.IsNullOrWhiteSpace(f2c_textBox1.Text))
            {
                f2c_label1.Text = " Please Enter a number";
                return;
            }
            int Celsius = Convert.ToInt32(f2c_textBox1.Text);
            f2c_label1.Text = Convert_f2c.f2c(Celsius).ToString();

        }
    }
}
