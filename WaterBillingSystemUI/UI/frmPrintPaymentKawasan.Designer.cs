﻿namespace WaterBillingSystemUI.UI
{
    partial class frmPrintPaymentKawasan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintPaymentKawasan));
            this.reportViewerPrintPaymentKawasan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintPaymentKawasan
            // 
            this.reportViewerPrintPaymentKawasan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintPaymentKawasan.LocalReport.ReportEmbeddedResource = "WaterBillingSystemUI.rptPrintPaymentKawasan.rdlc";
            this.reportViewerPrintPaymentKawasan.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintPaymentKawasan.Name = "reportViewerPrintPaymentKawasan";
            this.reportViewerPrintPaymentKawasan.Size = new System.Drawing.Size(1251, 512);
            this.reportViewerPrintPaymentKawasan.TabIndex = 0;
            // 
            // frmPrintPaymentKawasan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 512);
            this.Controls.Add(this.reportViewerPrintPaymentKawasan);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintPaymentKawasan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Payment for Treasurer\'s Office (Barangay Kawasan)";
            this.Load += new System.EventHandler(this.frmPrintPaymentKawasan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintPaymentKawasan;
    }
}