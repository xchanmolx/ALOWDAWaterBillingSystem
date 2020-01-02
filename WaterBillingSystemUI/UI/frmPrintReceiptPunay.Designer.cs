namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReceiptPunay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReceiptPunay));
            this.reportViewerPrintReceiptPunay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReceiptPunay
            // 
            this.reportViewerPrintReceiptPunay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReceiptPunay.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReceiptPunay.rdlc";
            this.reportViewerPrintReceiptPunay.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReceiptPunay.Name = "reportViewerPrintReceiptPunay";
            this.reportViewerPrintReceiptPunay.Size = new System.Drawing.Size(855, 441);
            this.reportViewerPrintReceiptPunay.TabIndex = 0;
            // 
            // frmPrintReceiptPunay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 441);
            this.Controls.Add(this.reportViewerPrintReceiptPunay);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintReceiptPunay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Billing Statement for Member (Punay)";
            this.Load += new System.EventHandler(this.frmPrintReceiptPunay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReceiptPunay;
    }
}