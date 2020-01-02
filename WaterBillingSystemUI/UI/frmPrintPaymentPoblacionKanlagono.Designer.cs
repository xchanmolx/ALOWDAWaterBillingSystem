namespace WaterBillingSystemUI.UI
{
    partial class frmPrintPaymentPoblacionKanlagono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintPaymentPoblacionKanlagono));
            this.reportViewerPrintPaymentPoblacionKanlagono = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintPaymentPoblacionKanlagono
            // 
            this.reportViewerPrintPaymentPoblacionKanlagono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintPaymentPoblacionKanlagono.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintPaymentPoblacionKanlagono.rdlc";
            this.reportViewerPrintPaymentPoblacionKanlagono.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintPaymentPoblacionKanlagono.Name = "reportViewerPrintPaymentPoblacionKanlagono";
            this.reportViewerPrintPaymentPoblacionKanlagono.Size = new System.Drawing.Size(1251, 512);
            this.reportViewerPrintPaymentPoblacionKanlagono.TabIndex = 0;
            // 
            // frmPrintPaymentPoblacionKanlagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 512);
            this.Controls.Add(this.reportViewerPrintPaymentPoblacionKanlagono);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintPaymentPoblacionKanlagono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Payment for Treasurer\'s Office (Barangay Poblacion-Kanlagono)";
            this.Load += new System.EventHandler(this.frmPrintPaymentPoblacionKanlagono_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintPaymentPoblacionKanlagono;
    }
}