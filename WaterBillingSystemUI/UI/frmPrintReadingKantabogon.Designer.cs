namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingKantabogon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingKantabogon));
            this.reportViewerPrintReadingKantabogon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingKantabogon
            // 
            this.reportViewerPrintReadingKantabogon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingKantabogon.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingKantabogon.rdlc";
            this.reportViewerPrintReadingKantabogon.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingKantabogon.Name = "reportViewerPrintReadingKantabogon";
            this.reportViewerPrintReadingKantabogon.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingKantabogon.TabIndex = 0;
            // 
            // frmPrintReadingKantabogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingKantabogon);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrintReadingKantabogon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Kantabogon";
            this.Load += new System.EventHandler(this.frmPrintReadingKantabogon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingKantabogon;
    }
}