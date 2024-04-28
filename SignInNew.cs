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
    public partial class SignInNew : Form
    {
        public SignInNew()
        {
            InitializeComponent();
            textboxPassword.UseSystemPasswordChar = true;
        }

        DBConnection obj = new DBConnection();

        private void buttonSignIn_Click(object sender, EventArgs e)
        {

            GetEmail.email = textboxEmail.Text;

            if (textboxEmail.Text.Length == 0 || textboxPassword.Text.Length == 0)
            {
                MessageBox.Show("Email or Password Connt Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "select count (*) from CustomerTable where Cust_Email ='" + textboxEmail.Text + "'and Cust_Password ='" + textboxPassword.Text + "'  ";

                int i = obj.Scalar(query);

                if (i == 1)
                {
                    
                    Home mm = new Home();
                    mm.Show();
                    textboxEmail.Text = "";
                    textboxPassword.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chk_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pass.Checked)
            {
                textboxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textboxPassword.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Sinupnew obj = new Sinupnew();
            obj.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminLoginNew obj = new AdminLoginNew();
            obj.Show();
            this.Hide();

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
