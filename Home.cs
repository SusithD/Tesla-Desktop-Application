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
    public partial class Home : Form
    {
        private List<Guna.UI.WinForms.GunaLabel> gunaLabelsPictureBox1 = new List<Guna.UI.WinForms.GunaLabel>();
        private List<Guna.UI.WinForms.GunaLabel> gunaLabelsPictureBox2 = new List<Guna.UI.WinForms.GunaLabel>();
        private List<Guna.UI.WinForms.GunaLabel> gunaLabelsPictureBox3 = new List<Guna.UI.WinForms.GunaLabel>();
        private List<Guna.UI.WinForms.GunaLabel> gunaLabelsPictureBox4 = new List<Guna.UI.WinForms.GunaLabel>();

        public Home()
        {
            InitializeComponent();


            gunaLabelsPictureBox1.Add(gunaLabel1);
            gunaLabelsPictureBox1.Add(gunaLabel2);
            gunaLabelsPictureBox1.Add(gunaLabel3);
            gunaLabelsPictureBox1.Add(gunaLabel4);
            gunaLabelsPictureBox2.Add(gunaLabel6);
            gunaLabelsPictureBox3.Add(gunaLabel7);
            gunaLabelsPictureBox4.Add(gunaLabel8);


            foreach (var label in gunaLabelsPictureBox1)
            {
                label.Parent = guna2PictureBox1;
                label.BackColor = Color.Transparent;
            }

            foreach (var label in gunaLabelsPictureBox2)
            {
                label.Parent = guna2PictureBox2;
                label.BackColor = Color.Transparent;
            }

            foreach (var label in gunaLabelsPictureBox3)
            {
                label.Parent = guna2PictureBox3;
                label.BackColor = Color.Transparent;
            }

            foreach (var label in gunaLabelsPictureBox4)
            {
                label.Parent = guna2PictureBox4;
                label.BackColor = Color.Transparent;
            }

        }
        DBConnection obj = new DBConnection();

        int cpt = 1;

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ModelMenu obj = new ModelMenu();
            obj.Show();
            this.Hide();
        }

        private void btn_Model_Menu_Click(object sender, EventArgs e)
        {
            ModelMenu obj = new ModelMenu();
            obj.Show();
            this.Hide();
        }

        private void btn_ContactUs_Click(object sender, EventArgs e)
        {
            ContactUs obj = new ContactUs();
            obj.Show();
            this.Hide();
        }

        private void btn_AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs obj = new AboutUs();
            obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string name;
            string quary = "SELECT Cust_FName from CustomerTable where Cust_Email = '" + GetEmail.email + "'  ";

            name = obj.getname(quary);

            username.Text = "Welcome " + name;
        }
    }
}
