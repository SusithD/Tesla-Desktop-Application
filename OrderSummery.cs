using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porches
{
    public partial class OrderSummery : Form
    {
        public OrderSummery()
        {
            InitializeComponent();
        }

        

        public string prevform { get; set; }
        public string car { get; set; }
        public string Editon { get; set; }
        public string color { get; set; }
        public string Wheels { get; set; }
        public string Interior { get; set; }

        public string pilot { get; set; }
        public string autopilot { get; set; }
        public string Editonprice { get; set; }
        public string colorprice { get; set; }
        public string Wheelsprice { get; set; }
        public string Interiorprice { get; set; }

        public string autopilotprice { get; set; }

        public string Total { get; set; }

        


        private void OrderSummery_Load(object sender, EventArgs e)
        {
            Model_lbl.Text = car;
            Editon_lbl.Text = Editon;
            Editon_lbl_price.Text = Editonprice;
            color_lbl.Text = color+" Paint";
            color_price_lbl.Text = colorprice;
            Wheels_lbl.Text = Wheels+" Wheels";
            Wheels_price_lbl.Text = Wheelsprice;
            Interior_lbl.Text = Interior + " Interior";
            Interior_lbl_price.Text = Interiorprice;
            autopilot_lbl.Text = autopilot;
            autopilot_price_lbl.Text = autopilotprice;
            total_lbl.Text = "$ "+Total;

            


            if (car == "Model 3")
            {
                if (color == "Ultra Red")
                {
                    if (Wheels == "Sport")
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
                else if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Sport")
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
                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Sport")
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
                }
            }

            if (car == "Model S")
            {
                if (color == "Ultra Red")
                {
                    if (Wheels == "Arachnid")
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
                }
                else if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Arachnid")
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
                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Arachnid")
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
            }

            if (car == "Model X")
            {
                if (color == "Ultra Red")
                {
                    if (Wheels == "turbine")
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
                }
                else if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "turbine")
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
                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "turbine")
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
            }

            if (car == "Model Y")
            {
                if (color == "Ultra Red")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YRedind.jpeg");
                        frontpicture.Image = Image.FromFile("im_car\\YRedind.jpeg");
                        sidepicture.Image = Image.FromFile("im_car\\YRedindSide.jpeg");
                        backpicture.Image = Image.FromFile("im_car\\YRedindBack.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YRedGemini.jpeg");
                        frontpicture.Image = Image.FromFile("im_car\\YRedGemini.jpeg");
                        sidepicture.Image = Image.FromFile("im_car\\YRedGeminiSide.jpeg");
                        backpicture.Image = Image.FromFile("im_car\\YRedGeminiBack.jpeg");
                    }
                }
                else if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\Yblind.jpeg");
                        frontpicture.Image = Image.FromFile("im_car\\Yblind.jpeg");
                        sidepicture.Image = Image.FromFile("im_car\\YblindSide.jpeg");
                        backpicture.Image = Image.FromFile("im_car\\YblindBack.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YblGemini.jpeg");
                        frontpicture.Image = Image.FromFile("im_car\\YblGemini.jpeg");
                        sidepicture.Image = Image.FromFile("im_car\\YblGeminiSide.jpeg");
                        backpicture.Image = Image.FromFile("im_car\\YblGeminiBack.jpeg"); ;
                    }
                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\4w.jpeg");
                        frontpicture.Image = Image.FromFile("im_car\\4w.jpeg");
                        sidepicture.Image = Image.FromFile("im_car\\44w.jpeg");
                        backpicture.Image = Image.FromFile("im_car\\444w.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\4w.jpeg");
                        frontpicture.Image = Image.FromFile("im_car\\4w.jpeg");
                        sidepicture.Image = Image.FromFile("im_car\\44w.jpeg");
                        backpicture.Image = Image.FromFile("im_car\\444w.jpeg");
                    }
                }
            }


        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            if (car == "Model 3")
            {
                Model_3.Current.Show();
                this.Hide();
            }
            else if (car == "Model S")
            {
                Model_S.Current.Show();
                this.Hide();
            }
            else if (car == "Model X")
            {
                ModelX.Current.Show();
                this.Hide();
            }
            else if (car == "Model Y")
            {
                ModelY.Current.Show();
                this.Hide();
            }

        }

        private void frontpicture_Click(object sender, EventArgs e)
        {
            if (car == "Model Y")
            {
                if (color == "Ultra Red")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YRedind.jpeg");
                        
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YRedGemini.jpeg");
                        
                    }
                }
                else if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\Yblind.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YblGemini.jpeg"); 
                    }
                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\4w.jpeg");
                        
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\4w.jpeg");
                    }
                }
            }
            else if (car == "Model 3")
            {
                if (color == "Ultra Red")
                {
                    if (Wheels == "Sport")
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rw.jpeg");

                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\red.jpeg");

                    }
                }
                else if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Sport")
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\bw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\blue.jpeg");
                    }
                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Sport")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\2sw.jpeg");

                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\2w.jpeg");
                    }
                }
            }
            else if (car == "Model X")
            {
                
                
                    if (color == "Deep Metalic Blue")
                    {
                        if (Wheels == "turbine")
                        {
                            gunaPictureBox1.Image = Image.FromFile("im_car\\XblTur.jpeg");
                        }
                        else
                        {
                            gunaPictureBox1.Image = Image.FromFile("im_car\\xblCyber.jpeg");
                        }

                    }
                    else if (color == "Ultra Red")
                    {
                        if (Wheels == "turbine")
                        {
                            gunaPictureBox1.Image = Image.FromFile("im_car\\XRedTur.jpeg");
                        }
                        else
                        {
                            gunaPictureBox1.Image = Image.FromFile("im_car\\XRedCyber.jpeg");
                        }

                    }
                    else if (color == "Pearl White")
                    {
                        if (Wheels == "turbine")
                        {
                            gunaPictureBox1.Image = Image.FromFile("im_car\\3tw.jpeg");
                        }
                        else
                        {
                            gunaPictureBox1.Image = Image.FromFile("im_car\\3w.jpeg");
                        }

                    }                
            }
            else if (car == "Model S")
            {
                if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Arachnid")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SblAra.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SblTemp.jpeg");
                    }

                }
                else if (color == "Ultra Red")
                {
                    if (Wheels == "Arachnid")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SRedAra.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SRedTemp.jpeg");
                    }

                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Arachnid")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\1aw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\1w.jpeg");
                    }

                }
            }

        }

        private void sidepicture_Click(object sender, EventArgs e)
        {
            if (car == "Model Y")
            {
                if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YblIndSide.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YblGeminiSide.jpeg");
                    }

                }
                else if (color == "Ultra Red")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YRedIndSide.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YRedGeminiSide.jpeg");
                    }

                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\44inw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\44w.jpeg");
                    }

                }
            }
            else if (car == "Model 3")
            {
                if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Sport")
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\sbside.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\side.jpeg");
                    }

                }
                else if (color == "Ultra Red")
                {
                    if (Wheels == "Sport")
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\srside.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rside.jpeg");
                    }

                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Sport")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\22sw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\22w.jpeg");
                    }

                }
            }
            else if (car == "Model X")
            {
                if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "turbine")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\XblTurSide.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\xblCyberSide.jpeg");
                    }

                }
                else if (color == "Ultra Red")
                {
                    if (Wheels == "turbine")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\XRedTurSide.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\XRedCyberSide.jpeg");
                    }

                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "turbine")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\33tw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\33w.jpeg");
                    }

                }
            }
            else if (car == "Model S")
            {
                if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Arachnid")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SblAraSide.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SblTempSide.jpeg");
                    }

                }
                else if (color == "Ultra Red")
                {
                    if (Wheels == "Arachnid")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SRedAraSide.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SRedTempSide.jpeg");
                    }

                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Arachnid")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\11aw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\11w.jpeg");
                    }

                }
            }
        }

        private void backpicture_Click(object sender, EventArgs e)
        {
            if (car == "Model Y")
            {
                if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YblIndBack.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YblGeminiBack.jpeg");
                    }

                }
                else if (color == "Ultra Red")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YRedIndBack.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\YRedGeminiBack.jpeg");
                    }

                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Induction")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\444inw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\444w.jpeg");
                    }

                }

            }
            else if (car == "Model 3")
            {

                if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Sport")
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\sbback.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\back.jpeg");
                    }

                }
                else if (color == "Ultra Red")
                {

                    if (Wheels == "Sport")
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\srback.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile(@"C:\Users\Gimz\Downloads\rback.jpeg");
                    }

                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Sport")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\222sw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\222w.jpeg");
                    }

                }
            }
            else if (car == "Model X")
            {

                if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "turbine")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\XblTurBack.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\XblCyberBack.jpeg");
                    }

                }
                else if (color == "Ultra Red")
                {

                    if (Wheels == "turbine")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\XRedTurBack.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\XRedCyberBack.jpeg");
                    }

                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "turbine")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\333tw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\333w.jpeg");
                    }

                }
            }
            else if (car == "Model S")
            {

                if (color == "Deep Metalic Blue")
                {
                    if (Wheels == "Arachnid")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SblAraBack.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SblTempBack.jpeg");
                    }

                }
                else if (color == "Ultra Red")
                {
                    if (Wheels == "Arachnid")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SRedAraBack.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\SRedTempBack.jpeg");
                    }

                }
                else if (color == "Pearl White")
                {
                    if (Wheels == "Arachnid")
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\111aw.jpeg");
                    }
                    else
                    {
                        gunaPictureBox1.Image = Image.FromFile("im_car\\111w.jpeg");
                    }

                }
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

            OrderNumGen obj1 = new OrderNumGen();
            DBConnection obj = new DBConnection();
            
            string ordernumber = obj1.GenerateOrderNumber();
            string id;
            string pilotv = pilot;
            DateTime CurrentDate = DateTime.Now;

            string quary = "SELECT Cust_ID from CustomerTable where Cust_Email = '" + GetEmail.email + "'  ";
            id = obj.getname(quary);
           
            string query = "Insert into OrderTable values ('" + ordernumber + "','" + id + "','" + CurrentDate + "','" + Editon_lbl.Text + "','" + color + "','" + Wheels + "','" + Interior + "','" + pilotv + "','" + Total + "')";

            try
            {

                SqlConnection con;
                SqlCommand cmd;

                con = new SqlConnection("Data Source=LAPTOP;Initial Catalog=tesla;Integrated Security=True");

                con.Open();
                cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Successfully Request Order", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OrderReq mail = new OrderReq();
                    mail.SendOrderRequestEmail(GetEmail.email, ordernumber);
                }
                else
                {
                    MessageBox.Show("Unsuccessfully Request Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();

            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void ord_lbl_Click(object sender, EventArgs e)
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
    }
}
