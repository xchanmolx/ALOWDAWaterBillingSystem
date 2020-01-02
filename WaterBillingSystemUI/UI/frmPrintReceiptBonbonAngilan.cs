using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterBillingSystemUI.UI
{
    public partial class frmPrintReceiptBonbonAngilan : Form
    {
        string _name, _current, _previous, _date, _bill, _consume, _lessCBM, _totalCBM, _amountPerCBM;

        public frmPrintReceiptBonbonAngilan(string name, string current, string previous, string date, string bill, string consume, string lessCBM, string totalCBM, string amountPerCBM)
        {
            InitializeComponent();
            _name = name;
            _current = current;
            _previous = previous;
            _date = date;
            _bill = bill;
            _consume = consume;
            _lessCBM = lessCBM;
            _totalCBM = totalCBM;
            _amountPerCBM = amountPerCBM;
        }

        private void frmPrintReceiptBonbonAngilan_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pName", _name),
                new Microsoft.Reporting.WinForms.ReportParameter("pCurrent", _current),
                new Microsoft.Reporting.WinForms.ReportParameter("pPrevious", _previous),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pBill", _bill),
                new Microsoft.Reporting.WinForms.ReportParameter("pConsume", _consume),
                new Microsoft.Reporting.WinForms.ReportParameter("pLessCBM", _lessCBM),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalCBM", _totalCBM),
                new Microsoft.Reporting.WinForms.ReportParameter("pAmountPerCBM", _amountPerCBM)
            };
            this.reportViewerPrintReceiptBonbonAngilan.LocalReport.SetParameters(para);
            this.reportViewerPrintReceiptBonbonAngilan.RefreshReport();
        }
    }
}
