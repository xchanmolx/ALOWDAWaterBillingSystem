namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingOlangoEsperanza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingOlangoEsperanza));
            this.reportViewerPrintReadingOlangoEsperanza = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingOlangoEsperanza
            // 
            this.reportViewerPrintReadingOlangoEsperanza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingOlangoEsperanza.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingOlangoEsperanza.rdlc";
            this.reportViewerPrintReadingOlangoEsperanza.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingOlangoEsperanza.Name = "reportViewerPrintReadingOlangoEsperanza";
            this.reportViewerPrintReadingOlangoEsperanza.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingOlangoEsperanza.TabIndex = 0;
            // 
            // frmPrintReadingOlangoEsperanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingOlangoEsperanza);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintReadingOlangoEsperanza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Olango-Esperanza";
            this.Load += new System.EventHandler(this.frmPrintReadingOlangoEsperanza_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingOlangoEsperanza;
    }
}