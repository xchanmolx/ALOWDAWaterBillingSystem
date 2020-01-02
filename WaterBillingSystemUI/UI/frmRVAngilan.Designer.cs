namespace WaterBillingSystemUI.UI
{
    partial class frmRVAngilan
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
            this.reportViewerAngilan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerAngilan
            // 
            this.reportViewerAngilan.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetAngilan";
            this.reportViewerAngilan.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerAngilan.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.UI.rptAngilan.rdlc";
            this.reportViewerAngilan.Location = new System.Drawing.Point(0, 0);
            this.reportViewerAngilan.Name = "reportViewerAngilan";
            this.reportViewerAngilan.Size = new System.Drawing.Size(589, 412);
            this.reportViewerAngilan.TabIndex = 0;
            // 
            // frmRVAngilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 412);
            this.Controls.Add(this.reportViewerAngilan);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRVAngilan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viever for Barangay Angilan";
            this.Load += new System.EventHandler(this.frmRVAngilan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAngilan;

    }
}