namespace WaterBillingSystemUI.UI
{
    partial class frmPrintAngilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintAngilan));
            this.reportViewerPrintReadingAngilan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingAngilan
            // 
            this.reportViewerPrintReadingAngilan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingAngilan.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingAngilan.rdlc";
            this.reportViewerPrintReadingAngilan.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingAngilan.Name = "reportViewerPrintReadingAngilan";
            this.reportViewerPrintReadingAngilan.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingAngilan.TabIndex = 0;
            // 
            // frmPrintAngilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingAngilan);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrintAngilan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Angilan";
            this.Load += new System.EventHandler(this.frmAngilan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousReadingDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingAngilan;
    }
}