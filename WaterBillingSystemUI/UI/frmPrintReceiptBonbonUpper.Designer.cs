namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReceiptBonbonUpper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReceiptBonbonUpper));
            this.reportViewerPrintReceiptBonbonUpper = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReceiptBonbonUpper
            // 
            this.reportViewerPrintReceiptBonbonUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReceiptBonbonUpper.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReceiptBonbonUpper.rdlc";
            this.reportViewerPrintReceiptBonbonUpper.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReceiptBonbonUpper.Name = "reportViewerPrintReceiptBonbonUpper";
            this.reportViewerPrintReceiptBonbonUpper.Size = new System.Drawing.Size(855, 441);
            this.reportViewerPrintReceiptBonbonUpper.TabIndex = 0;
            // 
            // frmPrintReceiptBonbonUpper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 441);
            this.Controls.Add(this.reportViewerPrintReceiptBonbonUpper);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintReceiptBonbonUpper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Billing Statement for Member (Bonbon-Upper)";
            this.Load += new System.EventHandler(this.frmPrintReceiptBonbonUpper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReceiptBonbonUpper;
    }
}