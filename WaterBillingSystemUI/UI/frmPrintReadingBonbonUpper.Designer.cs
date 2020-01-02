namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingBonbonUpper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingBonbonUpper));
            this.reportViewerPrintReadingBonbonUpper = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingBonbonUpper
            // 
            this.reportViewerPrintReadingBonbonUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingBonbonUpper.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingBonbonUpper.rdlc";
            this.reportViewerPrintReadingBonbonUpper.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingBonbonUpper.Name = "reportViewerPrintReadingBonbonUpper";
            this.reportViewerPrintReadingBonbonUpper.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingBonbonUpper.TabIndex = 0;
            // 
            // frmPrintReadingBonbonUpper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingBonbonUpper);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrintReadingBonbonUpper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Bonbon-Upper";
            this.Load += new System.EventHandler(this.frmPrintReadingBonbonUpper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingBonbonUpper;
    }
}