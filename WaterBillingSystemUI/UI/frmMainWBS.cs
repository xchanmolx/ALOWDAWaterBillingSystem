using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WaterBillingSystemUI
{
    public partial class frmMainWBS : Form
    {
        int panelWidth;
        bool Hidden;

        public frmMainWBS()
        {
            InitializeComponent();
            panelWidth = panelSlider.Width;
            Hidden = false;

            panelSide.Height = btnHome.Height;
            panelSide.Top = btnHome.Top;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSlider.Start();
        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelSlider.Width = panelSlider.Width - 10;
                if (panelSlider.Width <= panelWidth)
                {
                    timerSlider.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlider.Width = panelSlider.Width + 10;
                if (panelSlider.Width >= 218)
                {
                    timerSlider.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void timerShutdown_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.3;
            }
            else
            {
                timerShutdown.Stop();
                Application.Exit();
            }
        }

        #region Menu Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnHome.Height;
            panelSide.Top = btnHome.Top;
            homeCustomControl1.BringToFront();
        }

        private void btnAquapure_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnAquapure.Height;
            panelSide.Top = btnAquapure.Top;
            aquapureCustomControl1.BringToFront();
        }

        private void btnAngilan_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnAngilan.Height;
            panelSide.Top = btnAngilan.Top;
            angilanCustomControl1.BringToFront();
        }

        private void btnBojo_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnBojo.Height;
            panelSide.Top = btnBojo.Top;
            bojoCustomControl1.BringToFront();
        }

        private void btnBonbonAngilan_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnBonbonAngilan.Height;
            panelSide.Top = btnBonbonAngilan.Top;
            bonbonAngilanCustomControl1.BringToFront();
        }

        private void btnBonbonMiguel_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnBonbonMiguel.Height;
            panelSide.Top = btnBonbonMiguel.Top;
            bonbonMiguelCustomControl1.BringToFront();
        }

        private void btnBonbonUpper_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnBonbonUpper.Height;
            panelSide.Top = btnBonbonUpper.Top;
            bonbonUpperCustomControl11.BringToFront();
        }

        private void btnEsperanzaModing_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnEsperanzaModing.Height;
            panelSide.Top = btnEsperanzaModing.Top;
            esperanzaModingCustomControl1.BringToFront();
        }

        private void btnKantabogon_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnKantabogon.Height;
            panelSide.Top = btnKantabogon.Top;
            kantabogonCustomControl1.BringToFront();
        }

        private void btnKawasan_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnKawasan.Height;
            panelSide.Top = btnKawasan.Top;
            kawasanCustomControl1.BringToFront();
        }

        private void btnOlangoEsperanza_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnOlangoEsperanza.Height;
            panelSide.Top = btnOlangoEsperanza.Top;
            olangoEsperanzaCustomControl1.BringToFront();
        }

        private void btnPoblacionKanlagono_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnPoblacionKanlagono.Height;
            panelSide.Top = btnPoblacionKanlagono.Top;
            poblacionKanlagonoCustomControl1.BringToFront();
        }

        private void btnPunay_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnPunay.Height;
            panelSide.Top = btnPunay.Top;
            punayCustomControl1.BringToFront();
        }

        private void btnSaksak_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnSaksak.Height;
            panelSide.Top = btnSaksak.Top;
            saksakCustomControl1.BringToFront();
        }

        private void btnZaragosa_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnZaragosa.Height;
            panelSide.Top = btnZaragosa.Top;
            zaragosaCustomControl1.BringToFront();
        }
        #endregion

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calculator Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmMainWBS_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();

            //homeCustomControl1.BringToFront();

            txtDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                timerShutdown.Start();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // There should be no GUI component method
            for (int i = 0; i <= 100; i++)
            {
                SimulateHeavyWork();
                backgroundWorker.ReportProgress(i);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // This is updated from DoWork. Its where GUI component are updated
            // Receive updates after 100 ms
            bunifuCircleProgressbar.Value = e.ProgressPercentage;
            lblPercentage.Text = "Please wait for processing the database... " + e.ProgressPercentage.ToString() + " %";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Called when the heavy operation in backgroundWorker is over. Can also accept GUI components
            homeCustomControl1.BringToFront();
        }

        // Simulate complex calculations
        private void SimulateHeavyWork()
        {
            Thread.Sleep(100);
        }
    }
}
