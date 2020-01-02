using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaterBillingSystemUI.BLL;
using WaterBillingSystemUI.DAL;

namespace WaterBillingSystemUI.UI
{
    public partial class frmRVAngilan : Form
    {
        public frmRVAngilan()
        {
            InitializeComponent();
        }

        private void frmRVAngilan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAngilan.tbl_Angilan' table. You can move, or remove it, as needed.
            this.tbl_AngilanTableAdapter.Fill(this.dsAngilan.tbl_Angilan);
            this.reportViewerAngilan.RefreshReport();
        }
    }
}
