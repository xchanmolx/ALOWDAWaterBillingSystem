﻿using System;
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
    public partial class frmPrintReadingKawasan : Form
    {
        string _date, _totalMembers;

        public frmPrintReadingKawasan(string date, string totalMembers)
        {
            InitializeComponent();

            _date = date;
            _totalMembers = totalMembers;
        }

        private void frmPrintReadingKawasan_Load(object sender, EventArgs e)
        {
            dsPrintReadingKawasan dsPRK = new dsPrintReadingKawasan();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Kawasan", conn);
            sda.Fill(dsPRK, dsPRK.Tables[0].TableName);
            dsPRK.Tables[0].DefaultView.Sort = "Name";
            ReportDataSource rds = new ReportDataSource("dsPrintReadingKawasan", dsPRK.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintReadingKawasan.LocalReport.DataSources.Clear();
            this.reportViewerPrintReadingKawasan.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintReadingKawasan.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalMembers", _totalMembers)
            };
            this.reportViewerPrintReadingKawasan.LocalReport.SetParameters(para);
            this.reportViewerPrintReadingKawasan.RefreshReport();
        }
    }
}
