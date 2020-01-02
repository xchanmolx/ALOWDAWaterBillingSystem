namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReceiptPoblacionKanlagono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReceiptPoblacionKanlagono));
            this.reportViewerPrintReceiptPoblacionKanlagono = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReceiptPoblacionKanlagono
            // 
            this.reportViewerPrintReceiptPoblacionKanlagono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReceiptPoblacionKanlagono.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReceiptPoblacionKanlagono.rdlc";
            this.reportViewerPrintReceiptPoblacionKanlagono.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReceiptPoblacionKanlagono.Name = "reportViewerPrintReceiptPoblacionKanlagono";
            this.reportViewerPrintReceiptPoblacionKanlagono.Size = new System.Drawing.Size(855, 441);
            this.reportViewerPrintReceiptPoblacionKanlagono.TabIndex = 0;
            // 
            // frmPrintReceiptPoblacionKanlagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 441);
            this.Controls.Add(this.reportViewerPrintReceiptPoblacionKanlagono);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintReceiptPoblacionKanlagono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Billing Statement for Member (Poblacion-Kanlagono)";
            this.Load += new System.EventHandler(this.frmPrintReceiptPoblacionKanlagono_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReceiptPoblacionKanlagono;
    }
}