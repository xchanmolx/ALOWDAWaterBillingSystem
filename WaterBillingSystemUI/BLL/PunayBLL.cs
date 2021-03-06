﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterBillingSystemUI.BLL
{
    public class PunayBLL
    {
        const decimal Min_Charge = 120;
        const decimal Zero = 0;
        decimal totalCharge;

        public int ID { get; set; }
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string Meter_No { get; set; }
        public int Current_ { get; set; }
        public int Previous { get; set; }
        public decimal Consume { get { return Math.Max(0, Current_ - Previous); } }
        public int LessCBM { get; set; }
        public decimal TotalCBM { get { return Math.Max(0, Consume - LessCBM); } }
        public decimal AmountPerCBM { get; set; }
        public decimal Bill
        {
            get
            {
                if (TotalCBM <= 10)
                {
                    totalCharge = Min_Charge;

                    if (TotalCBM <= 0)
                    {
                        totalCharge = Zero;
                    }
                }
                else
                {
                    totalCharge = ((TotalCBM - 10) * AmountPerCBM) + Min_Charge;
                }

                return totalCharge;
            }
        }
        public string PreviousBalance { get; set; }
        public string AmountPaid { get; set; }
        public string DatePaid { get; set; }
        public string OR_No { get; set; }
        public string Balance { get; set; }
        public string Status { get; set; }
        public DateTime Added_Date { get; set; }
        public string OtherInformation { get; set; }
    }
}
