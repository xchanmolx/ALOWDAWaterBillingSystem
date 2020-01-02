namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingKawasan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingKawasan));
            this.reportViewerPrintReadingKawasan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingKawasan
            // 
            this.reportViewerPrintReadingKawasan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingKawasan.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingKawasan.rdlc";
            this.reportViewerPrintReadingKawasan.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingKawasan.Name = "reportViewerPrintReadingKawasan";
            this.reportViewerPrintReadingKawasan.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingKawasan.TabIndex = 0;
            // 
            // frmPrintReadingKawasan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingKawasan);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintReadingKawasan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Kawasan";
            this.Load += new System.EventHandler(this.frmPrintReadingKawasan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingKawasan;
    }
}