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
    public partial class frmPrintReadingEsperanzaModing : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingEsperanzaModing(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingEsperanzaModing_Load(object sender, EventArgs e)
        {
            dsPrintReadingEsperanzaModing dsPREM = new dsPrintReadingEsperanzaModing();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_EsperanzaModing", conn);
            sda.Fill(dsPREM, dsPREM.Tables[0].TableName);
            dsPREM.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingEsperanzaModing", dsPREM.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingEsperanzaModing.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingEsperanzaModing.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingEsperanzaModing.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingEsperanzaModing.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingEsperanzaModing.RefreshReport();
        }
    }
}
