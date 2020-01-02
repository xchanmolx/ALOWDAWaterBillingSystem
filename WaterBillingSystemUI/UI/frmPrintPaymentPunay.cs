using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaterBillingSystemUI.DAL;

namespace WaterBillingSystemUI.UI
{
    public partial class frmPrintPaymentPunay : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentPunay(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentPunay_Load(object sender, EventArgs e)
        {
            dsPrintPaymentPunay dsPPP = new dsPrintPaymentPunay();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Punay", conn);
            sda.Fill(dsPPP, dsPPP.Tables[0].TableName);
            dsPPP.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentPunay", dsPPP.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentPunay.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentPunay.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentPunay.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentPunay.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentPunay.RefreshReport();
        }
    }
}
