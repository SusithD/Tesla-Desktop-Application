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
    public partial class ModelMenu : Form
    {
        public ModelMenu()
        {
            InitializeComponent();
        }

        DBConnection obj = new DBConnection();

        int cpt = 1;

        private void ModelMenu_Load(object sender, EventArgs e)
        {
            string name;
            string quary = "SELECT Cust_FName from CustomerTable where Cust_Email = '" + GetEmail.email + "'  ";

            name = obj.getname(quary);

            lbl_user.Text = "Welcome " + name;

            gunaDataGridView1.Rows.Add(4);
            

            gunaDataGridView1.Rows[0].Cells[0].Value = Image.FromFile("im_car\\1.jpeg");
            gunaDataGridView1.Rows[1].Cells[0].Value = Image.FromFile("im_car\\2.jpeg");
            gunaDataGridView1.Rows[2].Cells[0].Value = Image.FromFile("im_car\\3.jpeg");
            gunaDataGridView1.Rows[3].Cells[0].Value = Image.FromFile("im_car\\4.jpeg");

            gunaDataGridView1.Rows[0].Cells[1].Value = "Model S";
            gunaDataGridView1.Rows[1].Cells[1].Value = "Model 3";
            gunaDataGridView1.Rows[2].Cells[1].Value = "Model X";
            gunaDataGridView1.Rows[3].Cells[1].Value = "Model Y";

            gunaDataGridView1.Rows[0].Cells[2].Value = "Acceleration (0-60 mph): Less than 2 seconds\n Top Speed: 200+ mph\n Range: Up to 390 miles (depending on the variant \n and configuration)\n Motor Power: Tri-motor all-wheel drive\n Horsepower: Over 1,000 hp\nTorque: Over 1,000 lb-f";
            gunaDataGridView1.Rows[1].Cells[2].Value = "Acceleration (0-60 mph): Around 3.1 seconds\n Top Speed: 162 mph\n Range: 250 to 322 miles (depending on the variant \n and configuration)\n Motor Power: Dual Motor AWD\n Horsepower: 450 hp\nTorque: Over 471 lb-ft";
            gunaDataGridView1.Rows[2].Cells[2].Value = "Acceleration (0-60 mph): Around 3.8 seconds \n Top Speed: 155 mph\n Range: Up to 348 miles (depending on the variant \n and configuration)\n Motor Power: Dual Motor all-wheel drive\n Horsepower: Over 670 hp\nTorque: 485 lb-ft";
            gunaDataGridView1.Rows[3].Cells[2].Value = "Acceleration (0-60 mph): Around 5.0 seconds\n Top Speed: 135 mph\n Range: Up to 279 miles (depending on the variant \n and configuration)\n Motor Power: Dual Motor all-wheel drive\n Horsepower: 204 Hp\nTorque: 258.15 lb.-ft.";

            gunaDataGridView1.Rows[0].Cells[3].Value = "Up to 390 miles";
            gunaDataGridView1.Rows[1].Cells[3].Value = "250 to 322 miles";
            gunaDataGridView1.Rows[2].Cells[3].Value = "Up to 348 miles";
            gunaDataGridView1.Rows[3].Cells[3].Value = "Up to 279 miles";

            gunaDataGridView1.Rows[0].Cells[4].Value = "200+ mph";
            gunaDataGridView1.Rows[1].Cells[4].Value = "162 mph";
            gunaDataGridView1.Rows[2].Cells[4].Value = "155 mph";
            gunaDataGridView1.Rows[3].Cells[4].Value = "135 mph";


        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
                cpt++;
                if (cpt < gunaDataGridView1.Rows.Count)
                {
                    MainPicturebox.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                    lbl_Model.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                    lbl_info.Text = gunaDataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();
                    Range_lbl.Text = gunaDataGridView1.Rows[cpt - 1].Cells[3].Value.ToString();
                    Topspeed_lbl.Text = gunaDataGridView1.Rows[cpt - 1].Cells[4].Value.ToString();
                    MiniPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + ".jpeg");
                    MiniPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".jpeg");
                    MiniPictureBox_car3.Image = MainPicturebox.Image;
                }
                else
                {
                    cpt = 1;
                    MainPicturebox.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                    lbl_Model.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                    lbl_info.Text = gunaDataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();
                    Range_lbl.Text = gunaDataGridView1.Rows[cpt - 1].Cells[3].Value.ToString();
                    Topspeed_lbl.Text = gunaDataGridView1.Rows[cpt - 1].Cells[4].Value.ToString();
                    MiniPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + ".jpeg");
                    MiniPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".jpeg");
                    MiniPictureBox_car3.Image = MainPicturebox.Image;
                }

            
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {

            cpt--;
            if (cpt >= 1)
            {
                MainPicturebox.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                lbl_Model.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                lbl_info.Text = gunaDataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();
                Range_lbl.Text = gunaDataGridView1.Rows[cpt - 1].Cells[3].Value.ToString();
                Topspeed_lbl.Text = gunaDataGridView1.Rows[cpt - 1].Cells[4].Value.ToString();
                MiniPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + ".jpeg");
                MiniPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".jpeg");
                MiniPictureBox_car3.Image = MainPicturebox.Image;
            }
            else
            {
                cpt = 4;
                MainPicturebox.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                lbl_Model.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                lbl_info.Text = gunaDataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();
                Range_lbl.Text = gunaDataGridView1.Rows[cpt - 1].Cells[3].Value.ToString();
                Topspeed_lbl.Text = gunaDataGridView1.Rows[cpt - 1].Cells[4].Value.ToString();
                MiniPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + ".jpeg");
                MiniPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".jpeg");
                MiniPictureBox_car3.Image = MainPicturebox.Image;
            }
        }

        private void MiniPictureBox_car1_Click(object sender, EventArgs e)
        {
            MainPicturebox.Image = MiniPictureBox_car1.Image;
        }

        private void MiniPictureBox_car2_Click(object sender, EventArgs e)
        {
            MainPicturebox.Image = MiniPictureBox_car2.Image;
        }

        private void MiniPictureBox_car3_Click(object sender, EventArgs e)
        {
            MainPicturebox.Image = MiniPictureBox_car3.Image;
        }

        private void bluecolorradio_Click(object sender, EventArgs e)
        {
            MainPicturebox.Load("im_car\\" + cpt.ToString() + "bl.jpeg");

            MiniPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + "bl.jpeg");
            MiniPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "bl.jpeg");
            MiniPictureBox_car3.Load("im_car\\" + cpt.ToString() + "bl.jpeg");
        }

        private void redColorRadio_Click(object sender, EventArgs e)
        {
            MainPicturebox.Load("im_car\\" + cpt.ToString() + "r.jpeg");

            MiniPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + "r.jpeg");
            MiniPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "r.jpeg");
            MiniPictureBox_car3.Load("im_car\\" + cpt.ToString() + "r.jpeg");
        }

        private void WhiteColorRadio_Click(object sender, EventArgs e)
        {
            MainPicturebox.Load("im_car\\" + cpt.ToString() + "w.jpeg");

            MiniPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + "w.jpeg");
            MiniPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "w.jpeg");
            MiniPictureBox_car3.Load("im_car\\" + cpt.ToString() + "w.jpeg");
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btn_Customize_Click(object sender, EventArgs e)
        {
            string model = lbl_Model.Text;

            if (model == "Model 3")
            {
                Model_3 obj = new Model_3();
                obj.Show();
                this.Hide();
            }
            else if (model == "Model X")
            {
                ModelX obj = new ModelX();
                obj.Show();
                this.Hide();
            }
            else if (model == "Model S")
            {
                Model_S obj = new Model_S();
                obj.Show();
                this.Hide();
            }
            else if (model == "Model Y")
            {
                ModelY obj = new ModelY();
                obj.Show();
                this.Hide();
            }

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

            if (cpt < gunaDataGridView1.Rows.Count)
            {

                cpt++;
                MainPicturebox.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                lbl_Model.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                MiniPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + ".jpeg");
                MiniPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".jpeg");
                MiniPictureBox_car3.Image = MainPicturebox.Image;

            }
            else cpt = 1;
        }

        private void lbl_Model_dis_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            AboutUs obj = new AboutUs();
            obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            ContactUs obj = new ContactUs();
            obj.Show();
            this.Hide();

        }
    }
}
