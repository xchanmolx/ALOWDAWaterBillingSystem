namespace WaterBillingSystemUI.UI
{
    partial class frmPrintTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintTest));
            this.reportViewerTest = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AngilanBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AngilanBLLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerTest
            // 
            this.reportViewerTest.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsTest";
            reportDataSource1.Value = this.AngilanBLLBindingSource;
            this.reportViewerTest.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerTest.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptTest.rdlc";
            this.reportViewerTest.Location = new System.Drawing.Point(0, 0);
            this.reportViewerTest.Name = "reportViewerTest";
            this.reportViewerTest.Size = new System.Drawing.Size(766, 503);
            this.reportViewerTest.TabIndex = 0;
            // 
            // AngilanBLLBindingSource
            // 
            this.AngilanBLLBindingSource.DataSource = typeof(WaterBillingSystemUI.BLL.AngilanBLL);
            // 
            // frmPrintTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 503);
            this.Controls.Add(this.reportViewerTest);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrintTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Test";
            this.Load += new System.EventHandler(this.frmPrintTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AngilanBLLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTest;
        private System.Windows.Forms.BindingSource AngilanBLLBindingSource;
    }
}