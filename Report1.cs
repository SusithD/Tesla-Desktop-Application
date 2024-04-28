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
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.EmployeeTable' table. You can move, or remove it, as needed.
            this.employeeTableTableAdapter.Fill(this.dataSet1.EmployeeTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
