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
    public partial class frmPrintPaymentPoblacionKanlagono : Form
    {
        string _date, _totalMembers;

        public frmPrintPaymentPoblacionKanlagono(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintPaymentPoblacionKanlagono_Load(object sender, EventArgs e)
        {
            dsPrintPaymentPoblacionKanlagono dsPPPK = new dsPrintPaymentPoblacionKanlagono();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_PoblacionKanlagono", conn);
            sda.Fill(dsPPPK, dsPPPK.Tables[0].TableName);
            dsPPPK.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintPaymentPoblacionKanlagono", dsPPPK.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintPaymentPoblacionKanlagono.LocalReport.DataSources.Clear();
            this.reportViewerPrintPaymentPoblacionKanlagono.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintPaymentPoblacionKanlagono.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintPaymentPoblacionKanlagono.LocalReport.SetParameters(para);
            this.reportViewerPrintPaymentPoblacionKanlagono.RefreshReport();
        }
    }
}
