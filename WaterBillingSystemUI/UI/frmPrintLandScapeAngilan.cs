using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaterBillingSystemUI.DAL;
using System.Drawing.Printing;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;


namespace WaterBillingSystemUI.UI
{
    public partial class frmPrintLandScapeAngilan : Form
    {
        string _date, _totalMembers;

        public frmPrintLandScapeAngilan(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintLandScapeAngilan_Load(object sender, EventArgs e)
        {
            dsPrintPaymentAngilan dsPPA = new dsPrintPaymentAngilan();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Angilan", conn);
            sda.Fill(dsPPA, dsPPA.Tables[0].TableName);
            dsPPA.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentAngilan", dsPPA.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentAngilan.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentAngilan.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentAngilan.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentAngilan.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentAngilan.RefreshReport();
        }

        private void dgvAngilan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                e.CellStyle.Format = "N2";
            }
        }
    }
}
