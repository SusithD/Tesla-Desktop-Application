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
    public partial class Model_3 : Form
    {

        public static Model_3 Current;
        public Model_3()
        {
            InitializeComponent();
            Current = this;
        }
        string Model,Colour, wheel,interior, Editon, editon, pilot;
        double price;
        





        private void gunaImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Colour = "Deep Metalic Blue";
            lbl_color.Text = "Deep Metalic Blue";
            
            if (gunaImageRadioButton1.Checked)
            {
                price = price + 1500;
            }
            else
            {
                price = price - 1500;
            }

            if (wheel == "sport")
            {
                gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\bw.jpeg");
                frontpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\bw.jpeg");
                sidepicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\sbside.jpeg");
                backpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\sbback.jpeg");
            }
            else
            {
                gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\blue.jpeg");
                frontpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\blue.jpeg");
                sidepicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\side.jpeg");
                backpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\back.jpeg");
            }

            pricelbl.Text = Convert.ToString(price);

        }

        private void gunaImageRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Colour = "Ultra Red";
            lbl_color.Text = "Ultra Red";
            if (wheel == "sport")
            {
                gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rw.jpeg");
                frontpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rw.jpeg");
                sidepicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\srside.jpeg");
                backpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\srback.jpeg");
            }
            else
            {
                gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\red.jpeg");
                frontpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\red.jpeg");
                sidepicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rside.jpeg");
                backpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rback.jpeg");
            }
            


        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Aero_Wheels_CheckedChanged(object sender, EventArgs e)
        {
            wheel = "aero";

            if (Colour == "Deep Metalic Blue")
            {
                gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\blue.jpeg");
                frontpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\blue.jpeg");
                sidepicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\side.jpeg");
                backpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\back.jpeg");
            }
            else if(Colour == "Ultra Red")
            {
                
                gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\red.jpeg");
                frontpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\red.jpeg");
                sidepicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rside.jpeg");
                backpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rback.jpeg");
            }
            else if (Colour == "Pearl White")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\2w.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\2w.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\22w.jpeg");
                backpicture.Image = Image.FromFile("im_car\\222w.jpeg");
            }

            
        }

        private void gunaImageRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            wheel = "Sport";
            
            if (gunaImageRadioButton3.Checked)
            {
                price = price + 1500;
            }
            else
            {
                price = price - 1500;
            }

            if (Colour == "Deep Metalic Blue")
            {
                gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\bw.jpeg");
                frontpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\bw.jpeg");
                sidepicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\sbside.jpeg");
                backpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\sbback.jpeg");
            }
            else if (Colour == "Ultra Red")
            {
                gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rw.jpeg");
                frontpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rw.jpeg");
                sidepicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\srside.jpeg");
                backpicture.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\srback.jpeg");
            }
            else if (Colour == "Pearl White")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\2sw.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\2sw.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\22sw.jpeg");
                backpicture.Image = Image.FromFile("im_car\\222sw.jpeg");
            }
            pricelbl.Text = Convert.ToString(price);

            lbl_Wheel.Text = "19’’ Sport Wheels";
        }

        private void frontpicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "Sport")
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\bw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\blue.jpeg");
                }
                
            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "Sport")
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\red.jpeg");
                }
                   
            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "Sport")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\2sw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\2w.jpeg");
                }

            }
        }

        private void sidepicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "Sport")
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\sbside.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\side.jpeg");
                }
                
            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "Sport")
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\srside.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rside.jpeg");
                }
                    
            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "Sport")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\22sw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\22w.jpeg");
                }

            }
        }

        private void backpicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "Sport")
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\sbback.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\back.jpeg");
                }
                    
            }
            else if (Colour == "Ultra Red")
            {

                if (wheel == "Sport")
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\srback.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rback.jpeg");
                }
                    
            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "Sport")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\222sw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\222w.jpeg");
                }

            }
        }

        

        private void interior_white_CheckedChanged(object sender, EventArgs e)
        {
            interior = "Black And White";
            lbl_int.Text = "Black And White         $1000";

            if (interior_white.Checked)
            {
                price = price + 1000;
            }
            else
            {
                price = price - 1000;
            }

            pricelbl.Text = Convert.ToString(price);

            gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\intwhite.jpeg");
        }

        private void White_Radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            Colour = "Pearl White";
            lbl_color.Text = "Pearl White";

            if (White_Radiobtn.Checked)
            {
                price = price + 1500;
            }
            else
            {
                price = price - 1500;
            }

            if (wheel == "Sport")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\2sw.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\2sw.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\22sw.jpeg");
                backpicture.Image = Image.FromFile("im_car\\222sw.jpeg");
            }
            else
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\2w.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\2w.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\22w.jpeg");
                backpicture.Image = Image.FromFile("im_car\\222w.jpeg");
            }
            pricelbl.Text = Convert.ToString(price);
        }

        private void Plaid_edition_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Model = "Model 3";
            editon = "Tesla Model 3 Longrange";
            Editon = "Tesla_Model_3_Longrange";
       
            if (Plaid_edition_rbtn.Checked)
            {
                price = price + 47240;
            }
            else
            {
                price = price - 47240;
            }

            pricelbl.Text = Convert.ToString(price);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ModelMenu obj = new ModelMenu();
            obj.Show();
            this.Hide();
        }

        private void standard_edition_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Model = "Model 3";
            editon = "Tesla Model 3 Standard";
            Editon = "Tesla_Model_3_Standard";
            
            if (standard_edition_rbtn.Checked)
            {
                price = price + 40240;
            }
            else
            {
                price = price - 40240;
            }

            pricelbl.Text = Convert.ToString(price);
        }

        private void Model_3_Load(object sender, EventArgs e)
        {

        }

        private void cek_autopilot_CheckedChanged(object sender, EventArgs e)
        {

            if (cek_autopilot.Checked)
            {
                price = price + 15000;
                pilot = "Yes";
            }
            else
            {
                price = price - 15000;
                pilot = "No";
            }

            pricelbl.Text = Convert.ToString(price);

            gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\giphy.gif");

        }

        private void interior_black_CheckedChanged(object sender, EventArgs e)
        {
            interior = "All Black";
            lbl_int.Text = "All Black       Included";
            gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\intblack.jpeg");
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

            OrderSummery obj = new OrderSummery();
            
            try
            {
                if (!standard_edition_rbtn.Checked && !Plaid_edition_rbtn.Checked)
                {
                    MessageBox.Show("Choose a Edition", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (standard_edition_rbtn.Checked && Plaid_edition_rbtn.Checked)
                {
                    MessageBox.Show("Choose only one Edition", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!White_Radiobtn.Checked && !gunaImageRadioButton1.Checked && !gunaImageRadioButton2.Checked)
                {
                    MessageBox.Show("Choose a Color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Aero_Wheels.Checked && !gunaImageRadioButton3.Checked)
                {
                    MessageBox.Show("Choose a Wheel Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!interior_black.Checked && !interior_white.Checked)
                {
                    MessageBox.Show("Choose a Interior Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    obj.car = Model;
                    obj.Editon = editon;

                    if (standard_edition_rbtn.Checked)
                    {
                        obj.Editonprice = "$40240";
                    }
                    else if (Plaid_edition_rbtn.Checked)
                    {
                        obj.Editonprice = "$47240";
                    }

                    obj.color = Colour;

                    if (gunaImageRadioButton2.Checked)
                    {
                        obj.colorprice = "Included";
                    }
                    else if (White_Radiobtn.Checked)
                    {
                        obj.colorprice = "$1500";
                    }
                    else if (gunaImageRadioButton1.Checked)
                    {
                        obj.colorprice = "$1500";
                    }

                    obj.Wheels = wheel;

                    if (Aero_Wheels.Checked)
                    {
                        obj.Wheelsprice = "Included";
                    }
                    else if (gunaImageRadioButton3.Checked)
                    {
                        obj.Wheelsprice = "$1500";
                    }

                    obj.Interior = interior;

                    if (interior_black.Checked)
                    {
                        obj.Interiorprice = "Included";
                    }
                    else if (gunaImageRadioButton3.Checked)
                    {
                        obj.Interiorprice = "$1000";
                    }

                    obj.pilot = pilot;

                    if (cek_autopilot.Checked)
                    {
                        obj.autopilot = "Enhanced Autopilot";
                        obj.autopilotprice = "$15000";
                    }

                    obj.Total = Convert.ToString(price);

                    obj.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }

            
        }
    }
}
