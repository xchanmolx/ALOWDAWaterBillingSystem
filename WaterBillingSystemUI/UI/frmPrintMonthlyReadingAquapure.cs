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
    public partial class frmPrintMonthlyReadingAquapure : Form
    {
        string _date, _totalMembers;

        public frmPrintMonthlyReadingAquapure(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintMonthlyReadingAquapure_Load(object sender, EventArgs e)
        {
            dsPrintMonthlyReadingAquapure dsPMRA = new dsPrintMonthlyReadingAquapure();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Aquapure", conn);
            sda.Fill(dsPMRA, dsPMRA.Tables[0].TableName);
            dsPMRA.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintMonthlyReadingAquapure", dsPMRA.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintMonthlyReadingAquapure.LocalReport.DataSources.Clear();
            this.reportViewerPrintMonthlyReadingAquapure.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintMonthlyReadingAquapure.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintMonthlyReadingAquapure.LocalReport.SetParameters(para);
            this.reportViewerPrintMonthlyReadingAquapure.RefreshReport();
        }
    }
}
