namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingZaragosa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingZaragosa));
            this.reportViewerPrintReadingZaragosa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingZaragosa
            // 
            this.reportViewerPrintReadingZaragosa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingZaragosa.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingZaragosa.rdlc";
            this.reportViewerPrintReadingZaragosa.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingZaragosa.Name = "reportViewerPrintReadingZaragosa";
            this.reportViewerPrintReadingZaragosa.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingZaragosa.TabIndex = 0;
            // 
            // frmPrintReadingZaragosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingZaragosa);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintReadingZaragosa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Zaragosa";
            this.Load += new System.EventHandler(this.frmPrintReadingZaragosa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingZaragosa;
    }
}