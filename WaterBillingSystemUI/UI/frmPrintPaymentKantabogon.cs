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
    public partial class frmPrintPaymentKantabogon : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentKantabogon(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentKantabogon_Load(object sender, EventArgs e)
        {
            dsPrintPaymentKantabogon dsPPK = new dsPrintPaymentKantabogon();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Kantabogon", conn);
            sda.Fill(dsPPK, dsPPK.Tables[0].TableName);
            dsPPK.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentKantabogon", dsPPK.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentKantabogon.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentKantabogon.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentKantabogon.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentKantabogon.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentKantabogon.RefreshReport();
        }
    }
}
