using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WaterBillingSystemUI.DAL;
using Microsoft.Reporting.WinForms;

namespace WaterBillingSystemUI.UI
{
    public partial class frmPrintReadingBojo : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingBojo(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingBojo_Load(object sender, EventArgs e)
        {
            dsPrintReadingBojo dsPRB = new dsPrintReadingBojo();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Bojo", conn);
            sda.Fill(dsPRB, dsPRB.Tables[0].TableName);
            dsPRB.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingBojo", dsPRB.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingBojo.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingBojo.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingBojo.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingBojo.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingBojo.RefreshReport();
        }
    }
}
