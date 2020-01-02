using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WaterBillingSystemUI
{
    public partial class HomeCustomControl : UserControl
    {
        public HomeCustomControl()
        {
            InitializeComponent();
        }

        private void btnChangeMeter_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\NoticeOfChangeMeter.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Change Meter Information!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnDisconnection_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\NoticeOfDisconnection.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Disconnection Of Water Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\NoticeOfPenalty.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice Of Penalty Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWaterApplicationRequirements_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\WaterApplicationRequirements.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Water Application Requirements Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWaterConnectionMaterials_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\WaterConnectionMaterials.xls");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Water Connection Materials Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRequestForReconnection_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\RequestForReconnection.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Request For Reconnection Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
