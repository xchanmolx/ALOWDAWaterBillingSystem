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
    public partial class frmPrintAngilan : Form
    {
        public frmPrintAngilan()
        {
            InitializeComponent();
        }

        private void frmPrintAngilan_Load(object sender, EventArgs e)
        {

            this.reportViewerAngilan.RefreshReport();
        }
    }
}
