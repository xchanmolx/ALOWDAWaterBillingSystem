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
    public partial class frmPrintReadingZaragosa : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingZaragosa(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingZaragosa_Load(object sender, EventArgs e)
        {
            dsPrintReadingZaragosa dsPRZ = new dsPrintReadingZaragosa();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Zaragosa", conn);
            sda.Fill(dsPRZ, dsPRZ.Tables[0].TableName);
            dsPRZ.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingZaragosa", dsPRZ.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingZaragosa.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingZaragosa.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingZaragosa.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingZaragosa.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingZaragosa.RefreshReport();
        }
    }
}
