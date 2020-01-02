using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterBillingSystemUI.BLL
{
    public class AquapureBLL
    {
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string Meter_No { get; set; }
        public int Current_ { get; set; }
        public int Previous { get; set; }
        public int Consume { get { return Current_ - Previous; } } // Readonly
        public double CurrentBill { get { return Math.Round((TotalAmount + VAT), 2); } } // Readonly - return Math.Max(0, Math.Round(((TotalAmount + VAT) - PriorityLessAmount), 2));
        public double VAT { get { return 0.12 * TotalAmount; } } // Readonly
        public double TotalAmount { get { return AmountMinCBM + AmountExcessCBM; } } // Readonly
        public int MinCBM { get; set; }
        public double RateMinCBM { get; set; }
        public double AmountMinCBM { get { return MinCBM * RateMinCBM; } } // Readonly
        public int ExcessCBM { get { return Math.Max(0, Consume - MinCBM); } } // Readonly
        public double RateExcessCBM { get; set; }
        public double AmountExcessCBM { get { return ExcessCBM * RateExcessCBM; } } // Readonly
        public double PreviousBalance { get; set; }
        public string ForTheMonthOf { get; set; }
        public double Total { get { return Math.Max(0, Math.Round((CurrentBill - PriorityLessAmount) + PreviousBalance, 2)); } } // Readonly
        public double PrevBalPilipinas { get; set; }
        public double TotalDue { get { return (Total + PrevBalPilipinas); } } // Readonly CurrentBill + PreviousBalance
        public double Balance { get { return PreviousBalance + PrevBalPilipinas; } } // Readonly
        public double AmountPaid { get; set; }
        public string DatePaid { get; set; }
        public double CreditBalance { get { return (CurrentBill + Balance) - AmountPaid; } } // Readonly
        public string Status { get; set; }
        public DateTime Added_Date { get; set; }
        public string OtherInformation { get; set; }
        public double PriorityLessAmount { get; set; }
    }
}
