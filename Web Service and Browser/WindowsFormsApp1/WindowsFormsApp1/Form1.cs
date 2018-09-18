using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;
using WindowsFormsApp1.ServiceReference2;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Go_button_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient myClient = new ServiceReference1.ServiceClient();
            try { encrypted_label.Text = myClient.Encrypt(txtUrl.Text); }
            catch (Exception ec) { encrypted_label.Text = ec.Message.ToString(); }
            try { label_decrypted.Text = myClient.Decrypt(encrypted_label.Text); }
            catch (Exception dc) { label_decrypted.Text = dc.Message.ToString(); }

            ServiceReference2.ServiceClient myClient2 = new ServiceReference2.ServiceClient();
            try { label_stock.Text = myClient2.getStockquote(textBox_input_stock.Text); }
            catch (Exception ec_stock) { label_stock.Text = ec_stock.Message.ToString(); }

            webBrowser1.Navigate(txtUrl.Text);
        }

        private void stock_button_Click(object sender, EventArgs e)
        {
            ServiceReference2.ServiceClient myClient2 = new ServiceReference2.ServiceClient();
            try { label_stock.Text = myClient2.getStockquote(textBox_input_stock.Text); }
            catch (Exception ec_stock) { label_stock.Text = ec_stock.Message.ToString(); }
        }
    }
}