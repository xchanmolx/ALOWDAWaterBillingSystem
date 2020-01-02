using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using WaterBillingSystemUI.DAL;

namespace WaterBillingSystemUI.UI
{
    public partial class frmPrintPaymentBojo : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentBojo(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentBojo_Load(object sender, EventArgs e)
        {
            dsPrintPaymentBojo dsPPB = new dsPrintPaymentBojo();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Bojo", conn);
            sda.Fill(dsPPB, dsPPB.Tables[0].TableName);
            dsPPB.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentBojo", dsPPB.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentBojo.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentBojo.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentBojo.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentBojo.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentBojo.RefreshReport();
        }
    }
}
