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
    public partial class frmPrintReadingAquapure : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingAquapure(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingAquapure_Load(object sender, EventArgs e)
        {
            dsPrintReadingAquapure dsPRA = new dsPrintReadingAquapure();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Aquapure", conn);
            sda.Fill(dsPRA, dsPRA.Tables[0].TableName);
            dsPRA.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingAquapure", dsPRA.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingAquapure.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingAquapure.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingAquapure.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingAquapure.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingAquapure.RefreshReport();
        }
    }
}
