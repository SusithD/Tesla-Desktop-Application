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
    public partial class ModelX : Form
    {
        public static ModelX Current;
        public ModelX()
        {
            InitializeComponent();
            Current=this;
        }

        string Model, Colour, wheel, interior, Editon,editon,pilot;
        double price;

        private void Cyber_Wheels_CheckedChanged(object sender, EventArgs e)
        {
            wheel = "cyber";

            if (Colour == "Deep Metalic Blue")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\xblcyber.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\xblcyber.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\xblCyberSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\XblCyberBack.jpeg");
            }
            else if (Colour == "Ultra Red")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\XRedCyber.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\XRedCyber.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\XRedCyberSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\XRedCyberBack.jpeg");
            }
            else if (Colour == "Pearl White")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\3w.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\3w.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\33w.jpeg");
                backpicture.Image = Image.FromFile("im_car\\333w.jpeg");
            }
            lbl_Wheel.Text = "20'' Cyberstream Wheels       (Included)";


        }

        private void Turbine_Wheels_CheckedChanged(object sender, EventArgs e)
        {
            wheel = "turbine";

            if (Turbine_Wheels.Checked)
            {
                price = price + 5500;
            }
            else
            {
                price = price - 5500;
            }

            if (Colour == "Deep Metalic Blue")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\XblTur.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\XblTur.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\XblTurSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\XblTurBack.jpeg");
            }
            else if (Colour == "Ultra Red")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\XRedTur.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\XRedTur.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\XRedTurSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\XRedTurBack.jpeg");
            }
            else if (Colour == "Pearl White")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\3tw.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\3tw.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\33tw.jpeg");
                backpicture.Image = Image.FromFile("im_car\\333tw.jpeg");
            }

            pricelbl.Text = Convert.ToString(price);

            lbl_Wheel.Text = "22'' Turbine Wheels     $5500";
        }

        private void frontpicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "turbine")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XblTur.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\xblCyber.jpeg");
                }

            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "turbine")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XRedTur.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XRedCyber.jpeg");
                }

            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "turbine")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\3tw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\3w.jpeg");
                }

            }
        }

        private void sidepicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "turbine")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XblTurSide.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\xblCyberSide.jpeg");
                }

            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "turbine")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XRedTurSide.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XRedCyberSide.jpeg");
                }

            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "turbine")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\33tw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\33w.jpeg");
                }

            }
        }

        private void backpicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "turbine")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XblTurBack.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XblCyberBack.jpeg");
                }

            }
            else if (Colour == "Ultra Red")
            {

                if (wheel == "turbine")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XRedTurBack.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\XRedCyberBack.jpeg");
                }

            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "turbine")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\333tw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\333w.jpeg");
                }

            }
        }

        private void interior_black_CheckedChanged(object sender, EventArgs e)
        {
            interior = "black";
            lbl_int.Text = "All Black       (Included)";
            gunaPictureBox1.Image = Image.FromFile("im_car\\xblackint.jpeg");
        }

        private void interior_white_CheckedChanged(object sender, EventArgs e)
        {
            interior = "white";
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

            gunaPictureBox1.Image = Image.FromFile("im_car\\xwhiteint.jpeg");
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
            gunaPictureBox1.Image = Image.FromFile("im_car\\giphy.gif");
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void standard_edition_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Model = "Model X";
            editon = "Tesla Model X Standard";
            Editon = "Tesla_Model_X_Standard";
            if (standard_edition_rbtn.Checked)
            {
                price = price + 98490;
            }
            else
            {
                price = price - 98490;
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

        private void Back_btn_Click(object sender, EventArgs e)
        {
            ModelMenu obj = new ModelMenu();
            obj.Show();
            this.Hide();

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
                else if (!White_Radiobtn.Checked && !BlueColorRadio.Checked && !RedColorRadio.Checked)
                {
                    MessageBox.Show("Choose a Color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Cyber_Wheels.Checked && !Turbine_Wheels.Checked)
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
                        obj.Editonprice = "$98490";
                    }
                    else if (Plaid_edition_rbtn.Checked)
                    {
                        obj.Editonprice = "$108490";
                    }

                    obj.color = Colour;

                    if (White_Radiobtn.Checked)
                    {
                        obj.colorprice = "Included";
                    }
                    else if (RedColorRadio.Checked)
                    {
                        obj.colorprice = "$1500";
                    }
                    else if (BlueColorRadio.Checked)
                    {
                        obj.colorprice = "$1500";
                    }

                    obj.Wheels = wheel;

                    if (Cyber_Wheels.Checked)
                    {
                        obj.Wheelsprice = "Included";
                    }
                    else if (Turbine_Wheels.Checked)
                    {
                        obj.Wheelsprice = "$5500";
                    }

                    obj.Interior = interior;

                    if (interior_black.Checked)
                    {
                        obj.Interiorprice = "Included";
                    }
                    else if (interior_white.Checked)
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

        private void Plaid_edition_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Model = "Model X";
            editon = "Tesla Model X Plaid";
            Editon = "Tesla_Model_X_Plaid";
            if (Plaid_edition_rbtn.Checked)
            {
                price = price + 108490;
            }
            else
            {
                price = price - 108490;
            }

            pricelbl.Text = Convert.ToString(price);
        }

        private void White_Radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            
            Colour = "Pearl White";
            lbl_color.Text = "Pearl White";
            if (wheel == "turbine")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\3tw.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\3tw.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\33tw.jpeg");
                backpicture.Image = Image.FromFile("im_car\\333tw.jpeg");
            }
            else
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\3w.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\3w.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\33w.jpeg");
                backpicture.Image = Image.FromFile("im_car\\333w.jpeg");
            }
        }

        private void BlueColorRadio_CheckedChanged(object sender, EventArgs e)
        {
            Colour = "Deep Metalic Blue";
            lbl_color.Text = "Deep Metalic Blue";

            if (BlueColorRadio.Checked)
            {
                price = price + 1500;
            }
            else
            {
                price = price - 1500;
            }

            if (wheel == "turbine")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\XblTur.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\XblTur.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\XblTurSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\XblTurBack.jpeg");
            }
            else
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\xblcyber.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\xblcyber.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\xblCyberSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\XblCyberBack.jpeg");
            }
            pricelbl.Text = Convert.ToString(price);
        }

        private void RedColorRadio_CheckedChanged(object sender, EventArgs e)
        {
            Colour = "Ultra Red";
            lbl_color.Text = "Ultra Red";

            if (RedColorRadio.Checked)
            {
                price = price + 1500;
            }
            else
            {
                price = price - 1500;
            }

            if (wheel == "turbine")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\XRedTur.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\XRedTur.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\XRedTurSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\XRedTurBack.jpeg");
            }
            else
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\XRedCyber.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\XRedCyber.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\XRedCyberSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\XRedCyberBack.jpeg");
            }
            pricelbl.Text = Convert.ToString(price);



        }
    }
}
