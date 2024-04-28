 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porches
{
    public partial class Sinupnew : Form
    {
        public Sinupnew()
        {
            InitializeComponent();
            textboxPassword.UseSystemPasswordChar = true;
            textboxConPass.UseSystemPasswordChar = true;
        }

        DBConnection obj = new DBConnection();

        private void buttonCreateAcc_Click(object sender, EventArgs e)
        {

        }

        private void txt_Signin_Click(object sender, EventArgs e)
        {
            CustNumGen obj1 = new CustNumGen();
            string Custnumber = obj1.GenerateOrderNumber();

            string query = "Insert into CustomerTable values ('"+ Custnumber + "','" + textboxFName.Text + "','" + textboxLName.Text + "','" + textboxEmail.Text + "','" + textAddress.Text + "','" + textCountry.Text + "','" + textboxPNum.Text + "','" + textboxPassword.Text + "')";


            try
            {
                if (textboxFName.Text.Length == 0)
                {
                    MessageBox.Show("First Name Connt Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textboxFName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Name Connt Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textboxLName.Text.Length == 0)
                {
                    MessageBox.Show("Last Name Connt Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textboxLName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Last Name Connt Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(textboxEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"))
                {
                    MessageBox.Show("Please Enter a Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textAddress.Text.Length == 0)
                {
                    MessageBox.Show("Address Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textCountry.Text.Length == 0 || textCountry.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Country Cannot Be Blank or Contain Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textboxPNum.Text.Length != 10 || textboxPNum.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Make Sure The Phone Number Entered Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textboxPassword.Text.Length <= 6)
                {
                    MessageBox.Show("Pasword Must Be Greater Than 6 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textboxPassword.Text != textboxConPass.Text)
                {

                    MessageBox.Show("Pasword Does Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textboxConPass.Text.Length == 0)
                {
                    MessageBox.Show("Pasword Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i = obj.Save_Edit_Delete(query);

                    SignInNew page = new SignInNew();
                    page.Show();
                    this.Hide();


                    if (i == 1)
                    {
                        MessageBox.Show("Account Created Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot Create Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void chk_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pass.Checked)
            {
                textboxPassword.UseSystemPasswordChar = false;
                textboxConPass.UseSystemPasswordChar = false;
            }
            else
            {
                textboxPassword.UseSystemPasswordChar = true;
                textboxConPass.UseSystemPasswordChar = true;
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
