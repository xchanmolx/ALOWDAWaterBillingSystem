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
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();

            cmbBoxGender.SelectedIndex = 0;
        }

        UserBLL u = new UserBLL();
        UserDAL dal = new UserDAL();

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Getting data from UI
                u.First_Name = txtFirstName.Text;
                u.Last_Name = txtLastName.Text;
                u.Email = txtEmail.Text;
                u.Username = txtUsername.Text;
                u.Password = txtPassword.Text;
                u.Contact = txtContact.Text;
                u.Address = txtAddress.Text;
                u.Gender = cmbBoxGender.Text;
                u.Added_Date = DateTime.Now;

                // Inserting data into Database
                bool success = dal.Insert(u);

                // If the data is successfully inserted then the value of success will be true else it will be false
                if (success == true)
                {
                    // Data successfully inserted
                    MessageBox.Show("User successfully created.", "User Created Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    // Failed to insert data
                    MessageBox.Show("Failed to add new user.", "User Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Refreshing Data Grid View
                //DataTable dt = dal.Select();
                //dgvUsers.DataSource = dt; 
            }
        }

        private bool ValidateForm()
        {
            bool bStatus = true;

            if (txtFirstName.Text == "")
            {
                errorProviderCreateAccount.SetError(txtFirstName, "Required First Name.");
                bStatus = false;
            }
            else if (txtLastName.Text == "")
            {
                errorProviderCreateAccount.SetError(txtLastName, "Required Last Name.");
                bStatus = false;
            }
            else if (txtUsername.Text == "")
            {
                errorProviderCreateAccount.SetError(txtUsername, "Required Username.");
                bStatus = false;
            }
            else if (txtPassword.Text == "")
            {
                errorProviderCreateAccount.SetError(txtPassword, "Required Password.");
                bStatus = false;
            }
            else if (cmbBoxGender.Text == "Gender")
            {
                errorProviderCreateAccount.SetError(cmbBoxGender, "Required Gender.");
                bStatus = false;
            }
            else
            {
                errorProviderCreateAccount.Clear();
            }

            return bStatus;
        }

        private void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbBoxGender.Text = "";
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
                this.Close();
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            timerShutdown.Start();
        }
    }
}
