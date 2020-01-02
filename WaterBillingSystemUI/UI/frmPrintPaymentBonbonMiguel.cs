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
    public partial class frmPrintPaymentBonbonMiguel : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentBonbonMiguel(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentBonbonMiguel_Load(object sender, EventArgs e)
        {
            dsPrintPaymentBonbonMiguel dsPPBM = new dsPrintPaymentBonbonMiguel();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_BonbonMiguel", conn);
            sda.Fill(dsPPBM, dsPPBM.Tables[0].TableName);
            dsPPBM.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentBonbonMiguel", dsPPBM.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentBonbonMiguel.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentBonbonMiguel.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentBonbonMiguel.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentBonbonMiguel.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentBonbonMiguel.RefreshReport();
        }
    }
}
