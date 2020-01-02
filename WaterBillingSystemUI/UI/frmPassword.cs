using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaterBillingSystemUI.DAL;
using WaterBillingSystemUI.BLL;

namespace WaterBillingSystemUI.UI
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        UserBLL u = new UserBLL();
        UserDAL dal = new UserDAL();

        private void btnVerifyPassword_Click(object sender, EventArgs e)
        {
            u.Password = txtPassword.Text.Trim();

            DataTable dt = dal.PasswordVerify(u);

            if (dt.Rows.Count == 1)
            {
                frmCreateAccount frm = new frmCreateAccount();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Check your Password!", "Password Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
