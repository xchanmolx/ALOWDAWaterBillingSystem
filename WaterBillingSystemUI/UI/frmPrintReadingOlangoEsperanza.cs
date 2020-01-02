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
    public partial class frmPrintReadingOlangoEsperanza : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingOlangoEsperanza(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingOlangoEsperanza_Load(object sender, EventArgs e)
        {
            dsPrintReadingOlangoEsperanza dsPROE = new dsPrintReadingOlangoEsperanza();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_OlangoEsperanza", conn);
            sda.Fill(dsPROE, dsPROE.Tables[0].TableName);
            dsPROE.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingOlangoEsperanza", dsPROE.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingOlangoEsperanza.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingOlangoEsperanza.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingOlangoEsperanza.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingOlangoEsperanza.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingOlangoEsperanza.RefreshReport();
        }
    }
}
