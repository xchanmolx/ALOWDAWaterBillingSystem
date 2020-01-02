namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingEsperanzaModing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingEsperanzaModing));
            this.reportViewerPrintReadingEsperanzaModing = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingEsperanzaModing
            // 
            this.reportViewerPrintReadingEsperanzaModing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingEsperanzaModing.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingEsperanzaModing.rdlc";
            this.reportViewerPrintReadingEsperanzaModing.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingEsperanzaModing.Name = "reportViewerPrintReadingEsperanzaModing";
            this.reportViewerPrintReadingEsperanzaModing.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingEsperanzaModing.TabIndex = 0;
            // 
            // frmPrintReadingEsperanzaModing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingEsperanzaModing);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrintReadingEsperanzaModing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Esperanza-Moding";
            this.Load += new System.EventHandler(this.frmPrintReadingEsperanzaModing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingEsperanzaModing;
    }
}