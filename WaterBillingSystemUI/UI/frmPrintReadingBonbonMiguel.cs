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
    public partial class frmPrintReadingBonbonMiguel : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingBonbonMiguel(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingBonbonMiguel_Load(object sender, EventArgs e)
        {
            dsPrintReadingBonbonMiguel dsPRBM = new dsPrintReadingBonbonMiguel();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_BonbonMiguel", conn);
            sda.Fill(dsPRBM, dsPRBM.Tables[0].TableName);
            dsPRBM.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingBonbonMiguel", dsPRBM.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingBonbonMiguel.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingBonbonMiguel.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingBonbonMiguel.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingBonbonMiguel.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingBonbonMiguel.RefreshReport();
        }
    }
}
