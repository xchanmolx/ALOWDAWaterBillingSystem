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
    public partial class frmPrintPaymentAquapure : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentAquapure(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentAquapure_Load(object sender, EventArgs e)
        {
            dsPrintPaymentAquapure dsPPA = new dsPrintPaymentAquapure();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Aquapure", conn);
            sda.Fill(dsPPA, dsPPA.Tables[0].TableName);
            dsPPA.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentAquapure", dsPPA.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentAquapure.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentAquapure.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentAquapure.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentAquapure.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentAquapure.RefreshReport();
        }
    }
}
