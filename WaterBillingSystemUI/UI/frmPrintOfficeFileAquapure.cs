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
    public partial class frmPrintOfficeFileAquapure : Form
    {
        string _date, _totalMembers;

        public frmPrintOfficeFileAquapure(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintOfficeFileAquapure_Load(object sender, EventArgs e)
        {
            dsPrintOfficeFileAquapure dsPOFA = new dsPrintOfficeFileAquapure();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Aquapure", conn);
            sda.Fill(dsPOFA, dsPOFA.Tables[0].TableName);
            dsPOFA.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintOfficeFileAquapure", dsPOFA.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintOfficeFileAquapure.LocalReport.DataSources.Clear();
            this.reportViewerPrintOfficeFileAquapure.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintOfficeFileAquapure.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintOfficeFileAquapure.LocalReport.SetParameters(para);
            this.reportViewerPrintOfficeFileAquapure.RefreshReport();
        }
    }
}
