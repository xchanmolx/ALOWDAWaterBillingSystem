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
    public partial class frmPrintPaymentBonbonAngilan : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentBonbonAngilan(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentBonbonAngilan_Load(object sender, EventArgs e)
        {
            dsPrintPaymentBonbonAngilan dsPPBA = new dsPrintPaymentBonbonAngilan();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_BonbonAngilan", conn);
            sda.Fill(dsPPBA, dsPPBA.Tables[0].TableName);
            dsPPBA.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentBonbonAngilan", dsPPBA.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentBonbonAngilan.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentBonbonAngilan.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentBonbonAngilan.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentBonbonAngilan.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentBonbonAngilan.RefreshReport();
        }
    }
}
