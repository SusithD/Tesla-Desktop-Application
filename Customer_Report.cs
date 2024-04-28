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
    public partial class Customer_Report : Form
    {
        public Customer_Report()
        {
            InitializeComponent();
        }

        private void Customer_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerReport.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.customerReport.CustomerTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
