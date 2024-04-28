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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
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
                string query = "select count (*) from Manager where Mana_Email ='" + textboxEmail.Text + "'and Mana_Pass ='" + textboxPassword.Text + "'  ";

                int i = obj.Scalar(query);

                if (i == 1)
                {
                    MessageBox.Show("Welcome", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Manager mm = new Manager();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SignInNew obj = new SignInNew();
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
    }
}
