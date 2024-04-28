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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void trackbar_Price_ValueChanged(object sender, EventArgs e)
        {
            lbl_Price.Text = trackbar_Price.Value.ToString() + "$";
        }

        private void YearTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lbl_Year.Text = YearTrackBar.Value.ToString();
        }

        private void KiloMeterTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lbl_kilometer.Text = KiloMeterTrackBar.Value.ToString() + "Km";
        }

        private void gunaImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Model_3 obj = new Model_3();
            obj.Show();
            this.Hide();

        }
    }
}
