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
    public partial class frmPrintPaymentKawasan : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentKawasan(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentKawasan_Load(object sender, EventArgs e)
        {
            dsPrintPaymentKawasan dsPPK = new dsPrintPaymentKawasan();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Kawasan", conn);
            sda.Fill(dsPPK, dsPPK.Tables[0].TableName);
            dsPPK.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentKawasan", dsPPK.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentKawasan.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentKawasan.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentKawasan.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentKawasan.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentKawasan.RefreshReport();
        }
    }
}
