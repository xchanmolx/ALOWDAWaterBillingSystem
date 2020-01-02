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
    public partial class frmPrintPaymentEsperanzaModing : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentEsperanzaModing(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentEsperanzaModing_Load(object sender, EventArgs e)
        {
            dsPrintPaymentEsperanzaModing dsPPEM = new dsPrintPaymentEsperanzaModing();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_EsperanzaModing", conn);
            sda.Fill(dsPPEM, dsPPEM.Tables[0].TableName);
            dsPPEM.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentEsperanzaModing", dsPPEM.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentEsperanzaModing.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentEsperanzaModing.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentEsperanzaModing.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentEsperanzaModing.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentEsperanzaModing.RefreshReport();
        }
    }
}
