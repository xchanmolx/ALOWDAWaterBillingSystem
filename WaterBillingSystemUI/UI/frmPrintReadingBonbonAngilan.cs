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
    public partial class frmPrintReadingBonbonAngilan : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingBonbonAngilan(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingBonbonAngilan_Load(object sender, EventArgs e)
        {
            dsPrintReadingBonbonAngilan dsPRBA = new dsPrintReadingBonbonAngilan();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_BonbonAngilan", conn);
            sda.Fill(dsPRBA, dsPRBA.Tables[0].TableName);
            dsPRBA.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingBonbonAngilan", dsPRBA.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingBonbonAngilan.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingBonbonAngilan.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingBonbonAngilan.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingBonbonAngilan.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingBonbonAngilan.RefreshReport();
        }
    }
}
