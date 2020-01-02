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
    public partial class frmPrintPaymentOlangoEsperanza : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentOlangoEsperanza(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentOlangoEsperanza_Load(object sender, EventArgs e)
        {
            dsPrintPaymentOlangoEsperanza dsPPOE = new dsPrintPaymentOlangoEsperanza();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_OlangoEsperanza", conn);
            sda.Fill(dsPPOE, dsPPOE.Tables[0].TableName);
            dsPPOE.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentOlangoEsperanza", dsPPOE.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentOlangoEsperanza.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentOlangoEsperanza.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentOlangoEsperanza.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentOlangoEsperanza.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentOlangoEsperanza.RefreshReport();
        }
    }
}
