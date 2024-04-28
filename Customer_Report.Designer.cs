namespace porches
{
    partial class Customer_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customerReport = new porches.CustomerReport();
            this.customerReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableTableAdapter = new porches.CustomerReportTableAdapters.CustomerTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.customerTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "porches.Customer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(47, 180);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1100, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // customerReport
            // 
            this.customerReport.DataSetName = "CustomerReport";
            this.customerReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerReportBindingSource
            // 
            this.customerReportBindingSource.DataSource = this.customerReport;
            this.customerReportBindingSource.Position = 0;
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.DataMember = "CustomerTable";
            this.customerTableBindingSource.DataSource = this.customerReportBindingSource;
            // 
            // customerTableTableAdapter
            // 
            this.customerTableTableAdapter.ClearBeforeFill = true;
            // 
            // Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 605);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Customer_Report";
            this.Text = "Customer_Report";
            this.Load += new System.EventHandler(this.Customer_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CustomerReport customerReport;
        private System.Windows.Forms.BindingSource customerReportBindingSource;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
        private CustomerReportTableAdapters.CustomerTableTableAdapter customerTableTableAdapter;
    }
}