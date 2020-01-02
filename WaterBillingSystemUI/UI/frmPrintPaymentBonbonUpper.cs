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
    public partial class frmPrintPaymentBonbonUpper : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentBonbonUpper(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentBonbonUpper_Load(object sender, EventArgs e)
        {
            dsPrintPaymentBonbonUpper dsPPBU = new dsPrintPaymentBonbonUpper();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_BonbonUpper", conn);
            sda.Fill(dsPPBU, dsPPBU.Tables[0].TableName);
            dsPPBU.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentBonbonUpper", dsPPBU.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentBonbonUpper.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentBonbonUpper.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentBonbonUpper.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentBonbonUpper.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentBonbonUpper.RefreshReport();
        }
    }
}
