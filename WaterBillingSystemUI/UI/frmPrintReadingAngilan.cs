using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaterBillingSystemUI.DAL;
using WaterBillingSystemUI.BLL;
using System.Drawing.Printing;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace WaterBillingSystemUI.UI
{
    public partial class frmPrintAngilan : Form
    {
        string _date, _totalMembers;

        public frmPrintAngilan(string date, string totalMembers)
        {
            InitializeComponent();
            
            _date = date;
            _totalMembers = totalMembers;
        }


        private void frmAngilan_Load(object sender, EventArgs e)
        {
            dsPrintReadingAngilan dsPRA = new dsPrintReadingAngilan();            
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Angilan", conn);
            sda.Fill(dsPRA, dsPRA.Tables[0].TableName);
            dsPRA.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingAngilan", dsPRA.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingAngilan.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingAngilan.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingAngilan.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingAngilan.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingAngilan.RefreshReport();
        }
    }
}
