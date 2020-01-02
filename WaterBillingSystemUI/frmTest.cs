using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaterBillingSystemUI.BLL;

namespace WaterBillingSystemUI
{
    public partial class frmTest : Form
    {
        List<AngilanBLL> _list;
        string _date;

        public frmTest(List<AngilanBLL> dataSource, string date)
        {
            InitializeComponent();
            _list = dataSource;
            _date = date;
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            AngilanBLLBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date)
            };
            this.reportViewerTest.LocalReport.SetParameters(para);
            this.reportViewerTest.RefreshReport();
        }
    }
}
