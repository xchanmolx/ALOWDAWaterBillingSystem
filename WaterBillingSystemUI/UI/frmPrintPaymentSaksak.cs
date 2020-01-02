using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using WaterBillingSystemUI.DAL;

namespace WaterBillingSystemUI.UI
{
    public partial class frmPrintPaymentSaksak : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentSaksak(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentSaksak_Load(object sender, EventArgs e)
        {
            dsPrintPaymentSaksak dsPPS = new dsPrintPaymentSaksak();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Saksak", conn);
            sda.Fill(dsPPS, dsPPS.Tables[0].TableName);
            dsPPS.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentSaksak", dsPPS.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentSaksak.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentSaksak.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentSaksak.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentSaksak.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentSaksak.RefreshReport();
        }
    }
}
