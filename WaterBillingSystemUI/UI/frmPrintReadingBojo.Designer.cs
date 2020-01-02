namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingBojo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingBojo));
            this.reportViewerPrintReadingBojo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingBojo
            // 
            this.reportViewerPrintReadingBojo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingBojo.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingBojo.rdlc";
            this.reportViewerPrintReadingBojo.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingBojo.Name = "reportViewerPrintReadingBojo";
            this.reportViewerPrintReadingBojo.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingBojo.TabIndex = 0;
            // 
            // frmPrintReadingBojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingBojo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrintReadingBojo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Bojo";
            this.Load += new System.EventHandler(this.frmPrintReadingBojo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingBojo;
    }
}