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
    public partial class frmPrintReadingPoblacionKanlagono : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingPoblacionKanlagono(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingPoblacionKanlagono_Load(object sender, EventArgs e)
        {
            dsPrintReadingPoblacionKanlagono dsPRPK = new dsPrintReadingPoblacionKanlagono();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_PoblacionKanlagono", conn);
            sda.Fill(dsPRPK, dsPRPK.Tables[0].TableName);
            dsPRPK.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingPoblacionKanlagono", dsPRPK.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingPoblacionKanlagono.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingPoblacionKanlagono.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingPoblacionKanlagono.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingPoblacionKanlagono.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingPoblacionKanlagono.RefreshReport();
        }
    }
}
