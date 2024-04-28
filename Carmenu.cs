using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cpt = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.Rows.Add(3);

            gunaDataGridView1.Rows[0].Cells[0].Value = Image.FromFile("im_car\\1.jpeg");
            gunaDataGridView1.Rows[1].Cells[0].Value = Image.FromFile("im_car\\2.jpeg");
            gunaDataGridView1.Rows[2].Cells[0].Value = Image.FromFile("im_car\\3.jpeg");

            gunaDataGridView1.Rows[0].Cells[1].Value = "Tesla Model S";
            gunaDataGridView1.Rows[1].Cells[1].Value = "Tesla Model Y";
            gunaDataGridView1.Rows[2].Cells[1].Value = "Tesla Model X ";


        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < gunaDataGridView1.Rows.Count)
            {

                cpt++;
                gunaPictureBox_car.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                lbl_Model.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                gunaPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + ".jpeg");
                gunaPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".jpeg");
                gunaPictureBox_car3.Image = gunaPictureBox_car.Image;
                
            }
            else cpt = 1;
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;
                gunaPictureBox_car.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                lbl_Model.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                gunaPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + ".jpeg");
                gunaPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".jpeg");
                gunaPictureBox_car3.Image = gunaPictureBox_car.Image;
                
            }
            else cpt = 1;
        }

        private void gunaPictureBox_car1_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox_car1.Image;
        }

        private void gunaPictureBox_car2_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox_car2.Image;
        }

        private void gunaPictureBox_car3_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox_car3.Image;
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Load("im_car\\" + cpt.ToString() + "bl.jpeg");

            gunaPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + "bl.jpeg");
            gunaPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "bl.jpeg");
            gunaPictureBox_car3.Load("im_car\\" + cpt.ToString() + "bl.jpeg");
        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Load("im_car\\" + cpt.ToString() + "r.jpeg");

            gunaPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + "r.jpeg");
            gunaPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "r.jpeg");
            gunaPictureBox_car3.Load("im_car\\" + cpt.ToString() + "r.jpeg");
        }

        private void gunaCirclePictureBox3_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Load("im_car\\" + cpt.ToString() + "w.jpeg");

            gunaPictureBox_car1.Load("im_car\\" + cpt.ToString() + cpt.ToString() + "w.jpeg");
            gunaPictureBox_car2.Load("im_car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "w.jpeg");
            gunaPictureBox_car3.Load("im_car\\" + cpt.ToString() + "w.jpeg");
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
