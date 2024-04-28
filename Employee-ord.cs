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

namespace porches
{
    public partial class Employee_ord : Form
    {
        public Employee_ord()
        {
            InitializeComponent();
            DisplayEmployee();
            Displayordere();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP;Initial Catalog=tesla;Integrated Security=True");

        private void DisplayEmployee()
        {
            con.Open();
            String query = "Select * from OrderTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            customer_grid_view.DataSource = ds.Tables[0];
            con.Close();
        }

        int key = 0;

        private void customer_grid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            order_Id_lb.Text = customer_grid_view.SelectedRows[0].Cells[0].Value.ToString();
            cust_id_lb.Text = customer_grid_view.SelectedRows[0].Cells[1].Value.ToString();
            Vehi_mod_lb.Text = customer_grid_view.SelectedRows[0].Cells[3].Value.ToString();
            Order_date_lb.Text = customer_grid_view.SelectedRows[0].Cells[2].Value.ToString();
            Total_amount_lb.Text = customer_grid_view.SelectedRows[0].Cells[8].Value.ToString();

            if (cust_id_lb.Text == "")
            {
                key = Convert.ToInt32(customer_grid_view.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void Displayordere()
        {
            con.Open();
            String query = "Select * from Order_approve_Table";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Approve_view.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            DBConnection obj = new DBConnection();

            DateTime CurrentDate = DateTime.Now;
            string Y = "Approved";
            string id;

            string quary = "SELECT Emp_ID from EmployeeTable where Emp_Email = '" + GetEmail.email + "'  ";
            id = obj.getname(quary);

            string query = "Insert into Order_approve_Table values ('" + order_Id_lb.Text + "','" + Y + "','" + tex_reason_box.Text + "','" + CurrentDate + "','" + id + "')";

            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=LAPTOP;Initial Catalog=tesla;Integrated Security=True");


            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Successfully Request Order", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Displayordere();

                }
                else
                {
                    MessageBox.Show("Unsuccessfully Request Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Order Number Already exists in the database", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_disapprove_Click(object sender, EventArgs e)
        {
            DBConnection obj = new DBConnection();

            string id;

            string quary = "SELECT Emp_ID from EmployeeTable where Emp_Email = '" + GetEmail.email + "'  ";
            id = obj.getname(quary);

            DateTime CurrentDate = DateTime.Now;
            string X = "Disapproved";

            string query = "Insert into Order_approve_Table values ('" + order_Id_lb.Text + "','" + X + "','" + tex_reason_box.Text + "','" + CurrentDate + "','" + id + "')";

            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection("Data Source=LAPTOP;Initial Catalog=tesla;Integrated Security=True");

            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                Displayordere();

                if (i == 1)
                {
                    MessageBox.Show("Successfully Request Order", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Displayordere();
                }
                else
                {
                    MessageBox.Show("Unsuccessfully Request Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Order Number Already exists in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void EmployeeCustomer_Click(object sender, EventArgs e)
        {
            EmployeeCustomer obj = new EmployeeCustomer();
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
