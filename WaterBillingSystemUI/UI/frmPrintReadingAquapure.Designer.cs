namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingAquapure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingAquapure));
            this.reportViewerPrintReadingAquapure = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingAquapure
            // 
            this.reportViewerPrintReadingAquapure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingAquapure.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingAquapure.rdlc";
            this.reportViewerPrintReadingAquapure.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingAquapure.Name = "reportViewerPrintReadingAquapure";
            this.reportViewerPrintReadingAquapure.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingAquapure.TabIndex = 0;
            // 
            // frmPrintReadingAquapure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingAquapure);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintReadingAquapure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for \"AQUAPURE\"";
            this.Load += new System.EventHandler(this.frmPrintReadingAquapure_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingAquapure;
    }
}