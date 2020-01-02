namespace WaterBillingSystemUI.UI
{
    partial class frmPrintPaymentSaksak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintPaymentSaksak));
            this.reportViewerPrintPaymentSaksak = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintPaymentSaksak
            // 
            this.reportViewerPrintPaymentSaksak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintPaymentSaksak.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintPaymentSaksak.rdlc";
            this.reportViewerPrintPaymentSaksak.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintPaymentSaksak.Name = "reportViewerPrintPaymentSaksak";
            this.reportViewerPrintPaymentSaksak.Size = new System.Drawing.Size(1251, 512);
            this.reportViewerPrintPaymentSaksak.TabIndex = 0;
            // 
            // frmPrintPaymentSaksak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 512);
            this.Controls.Add(this.reportViewerPrintPaymentSaksak);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintPaymentSaksak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Payment for Treasurer\'s Office (Barangay Saksak)";
            this.Load += new System.EventHandler(this.frmPrintPaymentSaksak_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintPaymentSaksak;
    }
}