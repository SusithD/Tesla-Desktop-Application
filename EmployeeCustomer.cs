using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porches
{
    public partial class EmployeeCustomer : Form
    {
        public EmployeeCustomer()
        {
            InitializeComponent();
            DisplayCustomer();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP;Initial Catalog=tesla;Integrated Security=True");

        private void Clear()
        {
            txt_Cust_ID.Text = "";
            txt_first_name.Text = "";
            txt_last_name.Text = "";
            txt_address.Text = "";
            txt_Email.Text = "";
            txt_Pass.Text = "";
            txt_tel_number.Text = "";
            txt_Country.Text = "";
        }


        private void DisplayCustomer()
        {
            con.Open();
            String query = "Select * from CustomerTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            customer_grid_view.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=LAPTOP;Initial Catalog=tesla;Integrated Security=True");


            string quary = "Update CustomerTable set Cust_FName ='" + txt_first_name.Text + "',Cust_LName ='" + txt_last_name.Text + "',Cust_Email ='" + txt_Email.Text + "',Cust_Add ='" + txt_address.Text + "',Cust_Country ='" + txt_Country.Text + "',Cust_Phone ='" + txt_tel_number.Text + "',Cust_Password ='" + txt_Pass.Text + "' where Cust_ID = '" + txt_Cust_ID.Text + "' ";


            if (txt_first_name.Text.Length == 0)
            {
                MessageBox.Show("First Name Connt Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_first_name.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name Connt Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_last_name.Text.Length == 0)
            {
                MessageBox.Show("Last Name Connt Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_last_name.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Last Name Connt Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txt_Email.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"))
            {
                MessageBox.Show("Please Enter a Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_address.Text.Length == 0)
            {
                MessageBox.Show("Address Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Country.Text.Length == 0 || txt_Country.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Country Cannot Be Blank or Contain Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_tel_number.Text.Length != 10 || txt_tel_number.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Make Sure The Phone Number Entered Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Pass.Text.Length <= 6)
            {
                MessageBox.Show("Pasword Must Be Greater Than 6 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(quary, con);
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Successfully Upadated Customer", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessfull Upadateding  Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();

                DisplayCustomer();
            }


        }

        int key = 0;
        private void customer_grid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Cust_ID.Text = customer_grid_view.SelectedRows[0].Cells[0].Value.ToString();
            txt_first_name.Text = customer_grid_view.SelectedRows[0].Cells[1].Value.ToString();
            txt_last_name.Text = customer_grid_view.SelectedRows[0].Cells[2].Value.ToString();
            txt_Email.Text = customer_grid_view.SelectedRows[0].Cells[3].Value.ToString();
            txt_address.Text = customer_grid_view.SelectedRows[0].Cells[4].Value.ToString();
            txt_Country.Text = customer_grid_view.SelectedRows[0].Cells[5].Value.ToString();
            txt_tel_number.Text = customer_grid_view.SelectedRows[0].Cells[6].Value.ToString();
            txt_Pass.Text = customer_grid_view.SelectedRows[0].Cells[7].Value.ToString();
            


            if (txt_Cust_ID.Text == "")
            {
                key = Convert.ToInt32(customer_grid_view.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            Employee_ord obj = new Employee_ord();
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

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            AdminLoginNew obj = new AdminLoginNew();
            obj.Show();
            this.Hide();
        }
    }
}
