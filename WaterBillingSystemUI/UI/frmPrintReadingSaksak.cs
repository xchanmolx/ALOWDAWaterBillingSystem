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
    public partial class frmPrintReadingSaksak : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingSaksak(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingSaksak_Load(object sender, EventArgs e)
        {
            dsPrintReadingSaksak dsPRS = new dsPrintReadingSaksak();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Saksak", conn);
            sda.Fill(dsPRS, dsPRS.Tables[0].TableName);
            dsPRS.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingSaksak", dsPRS.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingSaksak.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingSaksak.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingSaksak.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingSaksak.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingSaksak.RefreshReport();
        }
    }
}
