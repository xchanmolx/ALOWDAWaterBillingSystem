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
    public partial class frmPrintReadingBonbonUpper : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingBonbonUpper(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingBonbonUpper_Load(object sender, EventArgs e)
        {
            dsPrintReadingBonbonUpper dsPRBU = new dsPrintReadingBonbonUpper();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_BonbonUpper", conn);
            sda.Fill(dsPRBU, dsPRBU.Tables[0].TableName);
            dsPRBU.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingBonbonUpper", dsPRBU.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingBonbonUpper.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingBonbonUpper.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingBonbonUpper.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingBonbonUpper.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingBonbonUpper.RefreshReport();
        }
    }
}
