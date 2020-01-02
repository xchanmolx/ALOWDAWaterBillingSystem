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
    public partial class frmPrintPaymentZaragosa : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentZaragosa(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentZaragosa_Load(object sender, EventArgs e)
        {
            dsPrintPaymentZaragosa dsPPZ = new dsPrintPaymentZaragosa();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Zaragosa", conn);
            sda.Fill(dsPPZ, dsPPZ.Tables[0].TableName);
            dsPPZ.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentZaragosa", dsPPZ.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentZaragosa.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentZaragosa.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentZaragosa.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentZaragosa.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentZaragosa.RefreshReport();
        }
    }
}
