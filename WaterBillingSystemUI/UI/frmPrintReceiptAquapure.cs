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
    public partial class frmPrintReceiptAquapure : Form
    {
        string _previousDate, _date, _customerID, _customerName, _meterSerialNo, _currentReading, _previousReading, _totalConsumed, _minimumCubic, _rateMinCubicMeter, _amountMinimum, _excessCubicMeter, _rateExcessCubicMeter, _amountExcess, _totalAmount, _VAT, _currentBill, _previousBalance, _amountDue, _balancePilipinas, _totalDue, _priorityLessAmount;

        public frmPrintReceiptAquapure(string previousDate, string date, string customerID, string customerName, string meterSerialNo, string currentReading, string previousReading, string totalConsumed, string minimumCubic, string rateMinCubicMeter, string amountMinimum, string excessCubicMeter, string rateExcessCubicMeter, string amountExcess, string totalAmount, string VAT, string currentBill, string previousBalance, string amountDue, string balancePilipinas, string totalDue, string priorityLessAmount)
        {
            InitializeComponent();

            _previousDate = previousDate;
            _date = date;
            _customerID = customerID;
            _customerName = customerName;
            _meterSerialNo = meterSerialNo;
            _currentReading = currentReading;
            _previousReading = previousReading;
            _totalConsumed = totalConsumed;
            _minimumCubic = minimumCubic;
            _rateMinCubicMeter = rateMinCubicMeter;
            _amountMinimum = amountMinimum;
            _excessCubicMeter = excessCubicMeter;
            _rateExcessCubicMeter = rateExcessCubicMeter;
            _amountExcess = amountExcess;
            _totalAmount = totalAmount;
            _VAT = VAT;
            _currentBill = currentBill;
            _previousBalance = previousBalance;
            _amountDue = amountDue;
            _balancePilipinas = balancePilipinas;
            _totalDue = totalDue;
            _priorityLessAmount = priorityLessAmount;
        }

        private void frmPrintReceiptAquapure_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pPreviousDate", _previousDate),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pCustomerID", _customerID),
                new Microsoft.Reporting.WinForms.ReportParameter("pCustomerName", _customerName),
                new Microsoft.Reporting.WinForms.ReportParameter("pMeterSerialNo", _meterSerialNo),
                new Microsoft.Reporting.WinForms.ReportParameter("pCurrentReading", _currentReading),
                new Microsoft.Reporting.WinForms.ReportParameter("pPreviousReading", _previousReading),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalConsumed", _totalConsumed),
                new Microsoft.Reporting.WinForms.ReportParameter("pMinimumCubic", _minimumCubic),
                new Microsoft.Reporting.WinForms.ReportParameter("pRateMinCubicMeter", _rateMinCubicMeter),
                new Microsoft.Reporting.WinForms.ReportParameter("pAmountMinimum", _amountMinimum),
                new Microsoft.Reporting.WinForms.ReportParameter("pExcessCubicMeter", _excessCubicMeter),
                new Microsoft.Reporting.WinForms.ReportParameter("pRateExcessCubicMeter", _rateExcessCubicMeter),
                new Microsoft.Reporting.WinForms.ReportParameter("pAmountExcess", _amountExcess),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalAmount", _totalAmount),
                new Microsoft.Reporting.WinForms.ReportParameter("pVAT", _VAT),
                new Microsoft.Reporting.WinForms.ReportParameter("pCurrentBill", _currentBill),
                new Microsoft.Reporting.WinForms.ReportParameter("pPreviousBalance", _previousBalance),
                new Microsoft.Reporting.WinForms.ReportParameter("pAmountDue", _amountDue),
                new Microsoft.Reporting.WinForms.ReportParameter("pBalancePilipinas", _balancePilipinas),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalDue", _totalDue),
                new Microsoft.Reporting.WinForms.ReportParameter("pPriorityLessAmount", _priorityLessAmount)
            };
            this.reportViewerPrintReceiptAquapure.LocalReport.SetParameters(para);
            this.reportViewerPrintReceiptAquapure.RefreshReport();
        }
    }
}
