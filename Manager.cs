using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace porches
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            Displayordere();

        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP;Initial Catalog=tesla;Integrated Security=True");

        int key = 0;

        private void Clear()
        {
            txt_Emp_ID.Text = "";
            txt_first_name.Text = "";
            txt_last_name.Text = "";
            Emp_DOB.Text = "";
            txt_address.Text = "";
            txt_Email.Text = "";
            txt_Pass.Text = "";
            txt_tel_number.Text = "";
            Gender_combo.Text = "";
        }
        private void Displayordere()
        {
            con.Open();
            String query = "Select * from EmployeeTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            grid_view_employee.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=LAPTOP;Initial Catalog=tesla;Integrated Security=True");

            EmpNumGen obj1 = new EmpNumGen();
            string Empnumber = obj1.GenerateEmpNumber();


            DateTime selecteddate = Emp_DOB.Value;
            DateTime mindate = new DateTime(1963, 1, 1);
            DateTime maxdate = new DateTime(2005, 12, 31);
            string quary = "Insert into EmployeeTable values ('" + Empnumber + "','" + txt_first_name.Text + "','" + txt_last_name.Text + "','" + Emp_DOB.Value + "','" + txt_address.Text + "','" + txt_Email.Text + "','" + txt_Pass.Text + "','" + txt_tel_number.Text + "','" + Gender_combo.Text + "')";

            try
            {
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
                else if (selecteddate < mindate || selecteddate > maxdate)
                {
                    MessageBox.Show("Please Enter a Valid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_address.Text.Length == 0)
                {
                    MessageBox.Show("Address Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_Email.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"))
                {
                    MessageBox.Show("Please Enter a Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Pass.Text.Length <= 6)
                {
                    MessageBox.Show("Pasword Must Be Greater Than 6 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_tel_number.Text.Length != 10 || txt_tel_number.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Make Sure The Phone Number Entered Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Gender_combo.SelectedIndex == -1)
                {
                    MessageBox.Show("Selcet a Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand(quary, con);
                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Successfully Added Employee", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessfull Adding  Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();

                    Displayordere();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void grid_view_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Emp_ID.Text = grid_view_employee.SelectedRows[0].Cells[0].Value.ToString();
            txt_first_name.Text = grid_view_employee.SelectedRows[0].Cells[1].Value.ToString();
            txt_last_name.Text = grid_view_employee.SelectedRows[0].Cells[2].Value.ToString();
            txt_address.Text = grid_view_employee.SelectedRows[0].Cells[4].Value.ToString();
            txt_Email.Text = grid_view_employee.SelectedRows[0].Cells[5].Value.ToString();
            txt_Pass.Text = grid_view_employee.SelectedRows[0].Cells[6].Value.ToString();
            txt_tel_number.Text = grid_view_employee.SelectedRows[0].Cells[7].Value.ToString();


            if (txt_Emp_ID.Text == "")
            {
                key = Convert.ToInt32(grid_view_employee.SelectedRows[0].Cells[0].Value.ToString());
            }

        }



        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=LAPTOP;Initial Catalog=tesla;Integrated Security=True");

            EmpNumGen obj1 = new EmpNumGen();
            string Empnumber = obj1.GenerateEmpNumber();


            DateTime selecteddate = Emp_DOB.Value;
            DateTime mindate = new DateTime(1963, 1, 1);
            DateTime maxdate = new DateTime(2005, 12, 31);
            string quary = "Update EmployeeTable set Emp_f_name ='" + txt_first_name.Text + "',Emp_L_name ='" + txt_last_name.Text + "',Date_of_Birth ='" + Emp_DOB.Value + "',Emp_Address ='" + txt_address.Text + "',Emp_Email ='" + txt_Email.Text + "',Emp_Pass ='" + txt_Pass.Text + "',Emp_telnumber ='" + txt_tel_number.Text + "',Gender ='" + Gender_combo.Text + "'where Emp_ID = '" + txt_Emp_ID.Text + "' ";

            try
            {
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
                else if (selecteddate < mindate || selecteddate > maxdate)
                {
                    MessageBox.Show("Please Enter a Valid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_address.Text.Length == 0)
                {
                    MessageBox.Show("Address Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_tel_number.Text.Length != 10 || txt_tel_number.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Make Sure The Phone Number Entered Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Gender_combo.SelectedIndex == -1)
                {
                    MessageBox.Show("Selcet a Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand(quary, con);
                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Successfully Upadated Employee", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessfull Upadateding  Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();

                    Displayordere();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DBConnection obj = new DBConnection();

            if (txt_Emp_ID.Text == "")
            {
                MessageBox.Show("Select an Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "Delete From EmployeeTable where Emp_ID = '" + txt_Emp_ID.Text + "' ";
                    string querydis = "select*from EmployeeTable";

                    int i = obj.Save_Edit_Delete(query);


                    if (i == 1)
                    {
                        MessageBox.Show("Successfully Deleted Data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grid_view_employee.DataSource = obj.Dsipaly(querydis).Tables[0];
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cannot Delete Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Gender_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            ManagerLogin obj = new ManagerLogin();
            obj.Show();
            this.Hide();
        }
    }
}
