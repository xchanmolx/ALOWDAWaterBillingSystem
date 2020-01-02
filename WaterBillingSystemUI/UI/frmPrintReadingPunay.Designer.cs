namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingPunay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingPunay));
            this.reportViewerPrintReadingPunay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingPunay
            // 
            this.reportViewerPrintReadingPunay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingPunay.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingPunay.rdlc";
            this.reportViewerPrintReadingPunay.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingPunay.Name = "reportViewerPrintReadingPunay";
            this.reportViewerPrintReadingPunay.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingPunay.TabIndex = 0;
            // 
            // frmPrintReadingPunay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingPunay);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintReadingPunay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Punay";
            this.Load += new System.EventHandler(this.frmPrintReadingPunay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingPunay;
    }
}