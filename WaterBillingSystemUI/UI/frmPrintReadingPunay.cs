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
    public partial class frmPrintReadingPunay : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingPunay(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingPunay_Load(object sender, EventArgs e)
        {
            dsPrintReadingPunay dsPRP = new dsPrintReadingPunay();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Punay", conn);
            sda.Fill(dsPRP, dsPRP.Tables[0].TableName);
            dsPRP.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingPunay", dsPRP.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingPunay.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingPunay.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingPunay.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingPunay.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingPunay.RefreshReport();
        }
    }
}
