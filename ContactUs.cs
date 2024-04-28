using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porches
{
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void Findus_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tesla.com/findus?v=2&bounds=54.173986607479684%2C-57.079102750000004%2C22.164984976686902%2C-141.45410275&zoom=5&filters=store%2Cservice%2Csupercharger%2Cdestination%20charger%2Cbodyshop%2Cparty");
        }

        private void Support_Linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tesla.com/support");
        }

        private void IntPhoneNum_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tesla.com/roadside-assistance");
        }

        private void Careers_Linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           System.Diagnostics.Process.Start("https://www.tesla.com/careers");
        }

        private void Responder_Linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tesla.com/firstresponders");
        }

        private void Directions1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://goo.gl/maps/1eGZYXu1RBEZ6u7DA"); 
        }

        private void Directions2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://goo.gl/maps/qcxYGdqWndau3XTv8");
        }

        private void Directions3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://goo.gl/maps/D5YpaZhD2V9Zz7B27"); 
        }

        private void Directions4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://goo.gl/maps/EwTDexGMsBsbPgB46");
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            ModelMenu obj = new ModelMenu();
            obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            ContactUs obj = new ContactUs();
            obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            AboutUs obj = new AboutUs();
            obj.Show();
            this.Hide();
        }
    }
}
