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
    public partial class Model_S : Form
    {
        public static Model_S Current;
        public Model_S()
        {
            InitializeComponent();
            Current = this;
        }

        string Model, Colour, wheel, interior,Editon,editon,pilot;
        double price;

        



        private void Plaid_edition_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Model = "Model S";
            editon = "Tesla Model S Plaid";
            Editon = "Tesla_Model_S_Plaid";
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

        private void standard_edition_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Model = "Model S";
            editon = "Tesla Model S Standard";
            Editon = "Tesla_Model_S_Standard";
            if (standard_edition_rbtn.Checked)
            {
                price = price + 88490;
            }
            else
            {
                price = price - 88490;
            }
            
            pricelbl.Text = Convert.ToString(price);
        }
        private void Tempest_Wheels_CheckedChanged(object sender, EventArgs e)
        {
            wheel = "Tempest";

            if (Colour == "Deep Metalic Blue")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\SblTemp.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\SblTemp.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\SblTempSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\SblTempBack.jpeg");
            }
            else if (Colour == "Ultra Red")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\SRedTemp.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\SRedTemp.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\SRedTempSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\SRedTempBack.jpeg");

            }
            else if (Colour == "Pearl White")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\1w.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\1w.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\11w.jpeg");
                backpicture.Image = Image.FromFile("im_car\\111w.jpeg");
            }
            lbl_Wheel.Text = "19’’ Tempest Wheels       (Inculded)";
        }

        private void frontpicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "Arachnid")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SblAra.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SblTemp.jpeg");
                }

            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "Arachnid")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SRedAra.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SRedTemp.jpeg");
                }

            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "Arachnid")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\1aw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\1w.jpeg");
                }

            }
        }

        private void sidepicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "Arachnid")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SblAraSide.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SblTempSide.jpeg");
                }

            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "Arachnid")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SRedAraSide.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SRedTempSide.jpeg");
                }

            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "Arachnid")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\11aw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\11w.jpeg");
                }

            }
        }

        private void backpicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "Arachnid")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SblAraBack.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SblTempBack.jpeg");
                }

            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "Arachnid")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SRedAraBack.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\SRedTempBack.jpeg");
                }

            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "Arachnid")
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\111aw.jpeg");
                }
                else
                {
                    gunaPictureBox1.Image = Image.FromFile("im_car\\111w.jpeg");
                }

            }
        }

        private void interior_black_CheckedChanged(object sender, EventArgs e)
        {
            interior = "black";
            lbl_int.Text = "All Black       Included";
            gunaPictureBox1.Image = Image.FromFile("im_car\\SBlackint.jpeg");
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
            
            gunaPictureBox1.Image = Image.FromFile("im_car\\Swhiteint.jpeg");

            pricelbl.Text = Convert.ToString(price);
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

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Model_S_Load(object sender, EventArgs e)
        {

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
                else if (!Tempest_Wheels.Checked && !Arachnid_Wheels.Checked)
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
                        obj.Editonprice = "$88490";
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
                    else if (BlueColorRadio.Checked)
                    {
                        obj.colorprice = "$1500";
                    }
                    else if (RedColorRadio.Checked)
                    {
                        obj.colorprice = "$1500";
                    }

                    obj.Wheels = wheel;

                    if (Tempest_Wheels.Checked)
                    {
                        obj.Wheelsprice = "Included";
                    }
                    else if (Arachnid_Wheels.Checked)
                    {
                        obj.Wheelsprice = "$4500";
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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ModelMenu obj = new ModelMenu();
            obj.Show();
            this.Hide();
        }

        private void White_Radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            
            Colour = "Pearl White";
            lbl_color.Text = "Pearl White";
            if (wheel == "Arachnid")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\1aw.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\1aw.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\11aw.jpeg");
                backpicture.Image = Image.FromFile("im_car\\111aw.jpeg");
            }
            else
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\1w.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\1w.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\11w.jpeg");
                backpicture.Image = Image.FromFile("im_car\\111w.jpeg");
            }
        }

        

        private void Arachnid_Wheels_CheckedChanged(object sender, EventArgs e)
        {
            wheel = "Arachnid";
            if (Arachnid_Wheels.Checked)
            {
                price = price + 4500;
            }
            else
            {
                price = price - 4500;
            }
            

            if (Colour == "Deep Metalic Blue")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\SblAra.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\SblAra.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\SblAraSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\SblAraBack.jpeg");
            }
            else if (Colour == "Ultra Red")
            {

                gunaPictureBox1.Image = Image.FromFile("im_car\\SRedAra.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\SRedAra.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\SRedAraSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\SRedAraBack.jpeg");
            }
            else if (Colour == "Pearl White")
            { 
                gunaPictureBox1.Image = Image.FromFile("im_car\\1aw.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\1aw.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\11aw.jpeg");
                backpicture.Image = Image.FromFile("im_car\\111aw.jpeg");
            }
            lbl_Wheel.Text = "19’’ Arachnid Wheels      $4500";
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

            if (wheel == "Arachnid")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\SRedAra.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\SRedAra.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\SRedAraSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\SRedAraBack.jpeg");
            }
            else
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\SRedTemp.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\SRedTemp.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\SRedTempSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\SRedTempBack.jpeg");
            }
            pricelbl.Text = Convert.ToString(price);
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

            if (wheel == "Arachnid")
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\SblAra.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\SblAra.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\SblAraSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\SblAraBack.jpeg");
            }
            else
            {
                gunaPictureBox1.Image = Image.FromFile("im_car\\SblTemp.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\SblTemp.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\SblTempSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\SblTempBack.jpeg");
            }
            pricelbl.Text = Convert.ToString(price);
        }
    }
}
