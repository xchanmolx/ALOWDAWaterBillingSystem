namespace WaterBillingSystemUI.UI
{
    partial class frmPrintReadingPoblacionKanlagono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReadingPoblacionKanlagono));
            this.reportViewerPrintReadingPoblacionKanlagono = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintReadingPoblacionKanlagono
            // 
            this.reportViewerPrintReadingPoblacionKanlagono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintReadingPoblacionKanlagono.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintReadingPoblacionKanlagono.rdlc";
            this.reportViewerPrintReadingPoblacionKanlagono.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintReadingPoblacionKanlagono.Name = "reportViewerPrintReadingPoblacionKanlagono";
            this.reportViewerPrintReadingPoblacionKanlagono.Size = new System.Drawing.Size(826, 512);
            this.reportViewerPrintReadingPoblacionKanlagono.TabIndex = 0;
            // 
            // frmPrintReadingPoblacionKanlagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.reportViewerPrintReadingPoblacionKanlagono);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintReadingPoblacionKanlagono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Water Reading for Barangay Poblacion-Kanlagono";
            this.Load += new System.EventHandler(this.frmPrintReadingPoblacionKanlagono_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintReadingPoblacionKanlagono;
    }
}