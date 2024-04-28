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
    public partial class ModelY : Form
    {
        public static ModelY Current;
        public ModelY()
        {
            InitializeComponent();
            Current = this;
        }

        string Model, Colour, wheel, interior,Editon,editon,pilot;
        double price;

        private void interior_black_CheckedChanged(object sender, EventArgs e)
        {
            interior = "black";
            lbl_int.Text = "All Black       (Included)";
            MainPictureBox.Image = Image.FromFile("im_car\\Yblackint.jpeg");
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

            MainPictureBox.Image = Image.FromFile("im_car\\YWhitwint.jpeg");
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

            MainPictureBox.Image = Image.FromFile("im_car\\giphy.gif");
        }

        private void frontpicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "Induction")
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YblInd.jpeg");
                }
                else
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YblGemini.jpeg");
                }

            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "Induction")
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YRedInd.jpeg");
                }
                else
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YRedGemini.jpeg");
                }

            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "Induction")
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\4inw.jpeg");
                }
                else
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\4w.jpeg");
                }

            }
        }

        private void sidepicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "Induction")
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YblIndSide.jpeg");
                }
                else
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YblGeminiSide.jpeg");
                }

            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "Induction")
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YRedIndSide.jpeg");
                }
                else
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YRedGeminiSide.jpeg");
                }

            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "Induction")
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\44inw.jpeg");
                }
                else
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\44w.jpeg");
                }

            }
        }

        private void backpicture_Click(object sender, EventArgs e)
        {
            if (Colour == "Deep Metalic Blue")
            {
                if (wheel == "Induction")
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YblIndBack.jpeg");
                }
                else
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YblGeminiBack.jpeg");
                }

            }
            else if (Colour == "Ultra Red")
            {
                if (wheel == "Induction")
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YRedIndBack.jpeg");
                }
                else
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\YRedGeminiBack.jpeg");
                }

            }
            else if (Colour == "Pearl White")
            {
                if (wheel == "Induction")
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\444inw.jpeg");
                }
                else
                {
                    MainPictureBox.Image = Image.FromFile("im_car\\444w.jpeg");
                }

            }
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

            if (wheel == "Induction")
            {
                MainPictureBox.Image = Image.FromFile("im_car\\4inw.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\4inw.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\44inw.jpeg");
                backpicture.Image = Image.FromFile("im_car\\444inw.jpeg");
            }
            else
            {
                MainPictureBox.Image = Image.FromFile("im_car\\4w.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\4w.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\44w.jpeg");
                backpicture.Image = Image.FromFile("im_car\\444w.jpeg");
            }
            pricelbl.Text = Convert.ToString(price);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ModelMenu obj = new ModelMenu();
            obj.Show();
            this.Hide();
        }

        private void Plaid_edition_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Model = "Modle Y";
            editon = "Tesla Modle Y Long Range";
            Editon = "Tesla_Modle_Y_LongRange";
            if (Plaid_edition_rbtn.Checked)
            {
                price = price + 50490;
            }
            else
            {
                price = price - 50490;
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
                else if (!Induction_Wheels.Checked && !Gemini_Wheels.Checked)
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
                        obj.Editonprice = "$47740";
                    }
                    else if (Plaid_edition_rbtn.Checked)
                    {
                        obj.Editonprice = "$50490";
                    }

                    obj.color = Colour;

                    if (BlueColorRadio.Checked)
                    {
                        obj.colorprice = "Included";
                    }
                    else if (White_Radiobtn.Checked)
                    {
                        obj.colorprice = "$1500";
                    }
                    else if (RedColorRadio.Checked)
                    {
                        obj.colorprice = "$1500";
                    }

                    obj.Wheels = wheel;

                    if (Gemini_Wheels.Checked)
                    {
                        obj.Wheelsprice = "Included";
                    }
                    else if (Induction_Wheels.Checked)
                    {
                        obj.Wheelsprice = "$2000";
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

        private void Gemini_Wheels_CheckedChanged(object sender, EventArgs e)
        {
            wheel = "Gemeni";


            if (Colour == "Deep Metalic Blue")
            {
                MainPictureBox.Image = Image.FromFile("im_car\\YblGemini.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\YblGemini.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\YblGeminiSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\YblGeminiBack.jpeg");
            }
            else if (Colour == "Ultra Red")
            {

                MainPictureBox.Image = Image.FromFile("im_car\\YRedGemini.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\YRedGemini.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\YRedGeminiSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\YRedGeminiBack.jpeg");
            }
            else if (Colour == "Pearl White")
            {

                MainPictureBox.Image = Image.FromFile("im_car\\4w.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\4w.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\44w.jpeg");
                backpicture.Image = Image.FromFile("im_car\\444w.jpeg");
            }
            lbl_Wheel.Text = "19’’ Gemeni Wheels      (Included)";
        }

        private void Induction_Wheels_CheckedChanged(object sender, EventArgs e)
        {
            wheel = "Induction";

            if (Induction_Wheels.Checked)
            {
                price = price + 2000;
            }
            else
            {
                price = price - 2000;
            }

            if (Colour == "Deep Metalic Blue")
            {
                MainPictureBox.Image = Image.FromFile("im_car\\Yblind.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\Yblind.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\YblindSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\YblindBack.jpeg");
            }
            else if (Colour == "Ultra Red")
            {

                MainPictureBox.Image = Image.FromFile("im_car\\YRedind.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\YRedind.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\YRedindSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\YRedindBack.jpeg");
            }
            else if (Colour == "Pearl White")
            {

                MainPictureBox.Image = Image.FromFile("im_car\\4w.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\4w.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\44w.jpeg");
                backpicture.Image = Image.FromFile("im_car\\444w.jpeg");
            }
            pricelbl.Text = Convert.ToString(price);

            lbl_Wheel.Text = "20’’ Induction Wheels      ($2000)";
        }

        private void standard_edition_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Model = "Modle Y";
            editon = "Tesla Modle Y Standard";
            Editon = "Tesla_Modle_Y_Standard";
            if (standard_edition_rbtn.Checked)
            {
                price = price + 47740;
            }
            else
            {
                price = price - 47740;
            }

            pricelbl.Text = Convert.ToString(price);
        }

        



        private void RedColorRadio_CheckedChanged(object sender, EventArgs e)
        {
            Colour = "Ultra Red";
            lbl_color.Text = " Ultra Red        $2000";

            if (RedColorRadio.Checked)
            {
                price = price + 2000;
            }
            else
            {
                price = price - 2000;
            }

            if (wheel == "Induction")
            {
                MainPictureBox.Image = Image.FromFile("im_car\\YRedInd.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\YRedInd.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\YRedIndSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\YRedIndBack.jpeg");
            }
            else
            {
                MainPictureBox.Image = Image.FromFile("im_car\\YRedGemini.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\YRedGemini.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\YRedGeminiSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\YRedGeminiBack.jpeg");
            }
            pricelbl.Text = Convert.ToString(price);
        }

        


        private void BlueColorRadio_CheckedChanged(object sender, EventArgs e)
        {
            Colour = "Deep Metalic Blue";
            lbl_color.Text = "Deep Metalic Blue     (Included)";

            if (wheel == "Induction")
            {
                MainPictureBox.Image = Image.FromFile("im_car\\YblInd.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\YblInd.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\YblIndSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\YblIndBack.jpeg");
            }
            else
            {
                MainPictureBox.Image = Image.FromFile("im_car\\YblGemini.jpeg");
                frontpicture.Image = Image.FromFile("im_car\\YblGemini.jpeg");
                sidepicture.Image = Image.FromFile("im_car\\YblGeminiSide.jpeg");
                backpicture.Image = Image.FromFile("im_car\\YblGeminiBack.jpeg");
            }
        }
    }
}
