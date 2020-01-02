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
    public partial class frmPrintReadingKantabogon : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingKantabogon(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingKantabogon_Load(object sender, EventArgs e)
        {
            dsPrintReadingKantabogon dsPRK = new dsPrintReadingKantabogon();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Kantabogon", conn);
            sda.Fill(dsPRK, dsPRK.Tables[0].TableName);
            dsPRK.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingKantabogon", dsPRK.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingKantabogon.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingKantabogon.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingKantabogon.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingKantabogon.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingKantabogon.RefreshReport();
        }
    }
}
