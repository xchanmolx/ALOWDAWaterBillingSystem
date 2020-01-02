﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using WaterBillingSystemUI.BLL;
using WaterBillingSystemUI.DAL;
using System.Data.SqlClient;
using WaterBillingSystemUI.UI;

namespace WaterBillingSystemUI
{
    public partial class BonbonAngilanCustomControl : UserControl
    {
        public BonbonAngilanCustomControl()
        {
            InitializeComponent();

            dgvBonbonAngilan.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvBonbonAngilan.EnableHeadersVisualStyles = false;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\WaterApplicationFormBonbon-Angilan.xls");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bonbon-Angilan Form Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUserAgreement_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\UserAgreementALOWDA.doc");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bonbon-Angilan User Agreement Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        BonbonAngilanBLL ba = new BonbonAngilanBLL();
        BonbonAngilanDAL dal = new BonbonAngilanDAL();
        int id = 1;

        private void Clear()
        {
            txtCustomerCode.Text = "";
            txtName.Text = "";
            txtMeterNumber.Text = "";
            txtCurrentReading.Text = "";
            txtPreviousReading.Text = "";
            txtLessCubicMeter.Text = "";
            txtAmountPerCubicMeter.Text = "";
            txtPreviousBalance.Text = "";
            txtAmountPaid.Text = "";
            txtDatePaid.Text = "";
            txtORNo.Text = "";
            txtBalance.Text = "";
            cmbBoxStatus.Text = "Status";
            txtOtherInformation.Text = "";

            txtSearch.Text = "";

            id = 1;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            errorProviderBonbonAngilan.Clear();
        }

        private bool ValidateForm()
        {
            bool bStatus = true;

            if (txtCustomerCode.Text == "")
            {
                errorProviderBonbonAngilan.SetError(txtCustomerCode, "Required Customer Code");
                bStatus = false;
            }
            else if (txtName.Text == "")
            {
                errorProviderBonbonAngilan.SetError(txtName, "Required Name");
                bStatus = false;
            }
            else if (txtMeterNumber.Text == "")
            {
                errorProviderBonbonAngilan.SetError(txtMeterNumber, "Required Meter Number");
                bStatus = false;
            }
            else if (cmbBoxStatus.Text == "Status")
            {
                errorProviderBonbonAngilan.SetError(cmbBoxStatus, "Required Status");
                bStatus = false;
            }
            else
            {
                errorProviderBonbonAngilan.Clear();
            }

            return bStatus;
        }

        private void dgvBonbonAngilan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dgvBonbonAngilan.Rows)
                {
                    txtTotalMembers.Text = String.Format("Members - {0}", row.Index + 1);
                }
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            // Get the keywords
            string keywords = txtSearch.Text;

            // Filter the items based on keywords
            if (keywords != null)
            {
                // Use search method to display items
                DataTable dt = dal.Search(keywords);
                dgvBonbonAngilan.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
            else
            {
                // Use select method to display all items
                DataTable dt = dal.Select();
                dgvBonbonAngilan.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void txtCurrentReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderBonbonAngilan.SetError(txtCurrentReading, "Please enter only numbers.");
            }
        }

        private void txtLessCubicMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderBonbonAngilan.SetError(txtLessCubicMeter, "Please enter only numbers.");
            }
        }

        private void txtPreviousReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderBonbonAngilan.SetError(txtPreviousReading, "Please enter only numbers.");
            }
        }

        private void txtAmountPerCubicMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderBonbonAngilan.SetError(txtAmountPerCubicMeter, "Please enter only numbers.");
            }
        }

        private void BonbonAngilanCustomControl_Load(object sender, EventArgs e)
        {
            // View the data from datagridview
            DataTable dt = dal.Select();
            dgvBonbonAngilan.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "Name";
            DataTable sortedDT = dv.ToTable();

            dgvBonbonAngilan.Columns[0].Visible = false;
            cmbBoxStatus.SelectedIndex = 0;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnUpdate.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dgvBonbonAngilan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvBonbonAngilan.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Disconnection")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (dgvBonbonAngilan.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Penalty/Warning")
                {
                    e.CellStyle.BackColor = Color.Olive;
                }
                else if (dgvBonbonAngilan.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Government")
                {
                    e.CellStyle.BackColor = Color.Magenta;
                }
                else if (dgvBonbonAngilan.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "PriorityLessCBM")
                {
                    e.CellStyle.BackColor = Color.Teal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataGridView Bonbon-Angilan CellFormatting Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            var column = dgvBonbonAngilan.Columns[e.ColumnIndex];
            if (column.Name == "Bill")
            {
                var cell = dgvBonbonAngilan.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (decimal)e.Value;
                if (cell.IsInEditMode)
                {
                    e.Value = value.ToString(); // Display all digits
                }
                else
                {
                    // Display only two digits of decimals without rounding
                    var twoDigitsValue = Math.Truncate(100 * value) / 100;
                    e.Value = twoDigitsValue.ToString("N2");
                }
            }
            else if (column.Name == "AmountPerCBM")
            {
                var cell = dgvBonbonAngilan.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (decimal)e.Value;
                if (cell.IsInEditMode)
                {
                    e.Value = value.ToString(); // Display all digits
                }
                else
                {
                    // Display only two digits of decimals without rounding
                    var twoDigitsValue = Math.Truncate(100 * value) / 100;
                    e.Value = twoDigitsValue.ToString("N2");
                }
            }
        }

        private void dgvBonbonAngilan_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the index of particular row
            int rowIndex = e.RowIndex;
            id = Convert.ToInt32(dgvBonbonAngilan.Rows[rowIndex].Cells[0].Value.ToString());
            txtCustomerCode.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[2].Value.ToString();
            txtMeterNumber.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[3].Value.ToString();
            txtCurrentReading.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[4].Value.ToString();
            txtPreviousReading.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[5].Value.ToString();
            txtConsume.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[6].Value.ToString();
            txtLessCubicMeter.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[7].Value.ToString();
            txtTotalCBM.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[8].Value.ToString();
            txtAmountPerCubicMeter.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[9].Value.ToString();
            txtCurrentBill.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[10].Value.ToString();
            txtPreviousBalance.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[11].Value.ToString();
            txtAmountPaid.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[12].Value.ToString();
            txtDatePaid.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[13].Value.ToString();
            txtORNo.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[14].Value.ToString();
            txtBalance.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[15].Value.ToString();
            cmbBoxStatus.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[16].Value.ToString();
            txtOtherInformation.Text = dgvBonbonAngilan.Rows[rowIndex].Cells[18].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            txtCurrentReading.Focus();

            this.dgvBonbonAngilan.Size = new System.Drawing.Size(1123, 305);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                int current, previous, lessCubicMeter;
                decimal amountPerCubicMeter;
                int.TryParse(txtCurrentReading.Text, out current);
                int.TryParse(txtPreviousReading.Text, out previous);
                int.TryParse(txtLessCubicMeter.Text, out lessCubicMeter);
                decimal.TryParse(txtAmountPerCubicMeter.Text, out amountPerCubicMeter);

                // Getting data from UI
                ba.CustomerID = txtCustomerCode.Text;
                ba.Name = txtName.Text;
                ba.Meter_No = txtMeterNumber.Text;
                ba.Current_ = current;
                ba.Previous = previous;
                //ba.Consumed = Convert.ToInt32(txtConsumed.Text); Read only
                ba.LessCBM = lessCubicMeter; // 5 cubic
                //ba.Total_Cubic_Meter = Convert.ToInt32(txtTotalCubicMeter.Text); Read only
                ba.AmountPerCBM = amountPerCubicMeter; // 15 pesos
                //ba.Current_Bill = Convert.ToDecimal(txtCurrentBill.Text); Read only
                ba.PreviousBalance = txtPreviousBalance.Text;
                ba.AmountPaid = txtAmountPaid.Text;
                ba.DatePaid = txtDatePaid.Text;
                ba.OR_No = txtORNo.Text;
                ba.Balance = txtBalance.Text;
                ba.Status = cmbBoxStatus.Text;
                ba.Added_Date = DateTime.Now;
                ba.OtherInformation = txtOtherInformation.Text;

                // Inserting data into Database
                bool success = dal.Insert(ba);

                // If the data is successfully inserted then the value of success will be true else it will be false
                if (success == true)
                {
                    // Data successfully inserted
                    MessageBox.Show("Member successfully saved.", "Member Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    txtCustomerCode.Focus();
                }
                else
                {
                    // Failed to insert data
                    MessageBox.Show("Failed to add new member.", "Member Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Refreshing Data Grid View
                DataTable dt = dal.Select();
                dgvBonbonAngilan.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting User ID from Form
            ba.ID = id;

            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete?", "Delete Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bool success = dal.Delete(ba);
                success = true;
                Clear();
                txtSearch.Focus();
            }
            else
            {
                Clear();
            }

            // Refresing Data Grid View
            DataTable dt = dal.Select();
            dgvBonbonAngilan.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "Name";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the values from User UI
            ba.ID = id;
            ba.CustomerID = txtCustomerCode.Text;
            ba.Name = txtName.Text;
            ba.Meter_No = txtMeterNumber.Text;
            ba.Current_ = Convert.ToInt32(txtCurrentReading.Text);
            ba.Previous = Convert.ToInt32(txtPreviousReading.Text);
            ba.LessCBM = Convert.ToInt32(txtLessCubicMeter.Text);
            ba.AmountPerCBM = Convert.ToDecimal(txtAmountPerCubicMeter.Text);
            ba.PreviousBalance = txtPreviousBalance.Text;
            ba.AmountPaid = txtAmountPaid.Text;
            ba.DatePaid = txtDatePaid.Text;
            ba.OR_No = txtORNo.Text;
            ba.Balance = txtBalance.Text;
            ba.Status = cmbBoxStatus.Text;
            //ba.Added_Date = DateTime.Now;
            ba.OtherInformation = txtOtherInformation.Text;

            // Updating data into Database
            bool success = dal.Update(ba);

            // If data is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                // Data updated successfully 
                MessageBox.Show("User successfully updated!", "Update Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtSearch.Focus();
            }
            else
            {
                // Failed to update user 
                MessageBox.Show("Failed to update user!", "Update Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvBonbonAngilan.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "Name";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnTransferThenUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to transfer value from Current Reading to Previous Reading?", "Transfer Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                for (int i = 0; i < dgvBonbonAngilan.Rows.Count; i++)
                {
                    dgvBonbonAngilan.Rows[i].Cells[5].Value = dgvBonbonAngilan.Rows[i].Cells[4].Value;

                    //dgvBonbonAngilan.Rows[i].Cells[6].Value = 0;  // Read only "Consumed" column
                    //dgvBonbonAngilan.Rows[i].Cells[8].Value = 0;  // Read only "Total Cubic Meter" column
                    //dgvBonbonAngilan.Rows[i].Cells[10].Value = 0; // Read only "Current Bill" column
                }

                // Update all rows from database to datagridview
                using (SqlConnection conn = new SqlConnection(UserDAL.myconnstrng))
                using (SqlCommand cmd = new SqlCommand(@"UPDATE tbl_BonbonAngilan SET CustomerID=@CustomerID, Name=@Name, Meter_No=@Meter_No, Current_=@Current, Previous=@Previous, Consume=@Consume, LessCBM=@LessCBM, TotalCBM=@TotalCBM, AmountPerCBM=@AmountPerCBM, Bill=@Bill, PreviousBalance=@PreviousBalance, AmountPaid=@AmountPaid, DatePaid=@DatePaid, OR_No=@OR_No, Balance=@Balance, Status=@Status, Added_Date=@Added_Date, OtherInformation=@OtherInformation WHERE ID=@ID", conn))
                {
                    conn.Open();
                    using (SqlTransaction tr = conn.BeginTransaction())
                    {
                        cmd.Transaction = tr;
                        cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Meter_No", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Current", SqlDbType.Int);
                        cmd.Parameters.Add("@Previous", SqlDbType.Int);

                        cmd.Parameters.Add("@Consume", SqlDbType.Decimal);

                        cmd.Parameters.Add("@LessCBM", SqlDbType.Int);

                        cmd.Parameters.Add("@TotalCBM", SqlDbType.Decimal);

                        cmd.Parameters.Add("@AmountPerCBM", SqlDbType.Decimal);

                        cmd.Parameters.Add("@Bill", SqlDbType.Decimal);

                        cmd.Parameters.Add("@PreviousBalance", SqlDbType.VarChar);
                        cmd.Parameters.Add("@AmountPaid", SqlDbType.VarChar);
                        cmd.Parameters.Add("@DatePaid", SqlDbType.VarChar);
                        cmd.Parameters.Add("@OR_No", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Balance", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Added_Date", SqlDbType.DateTime);
                        cmd.Parameters.Add("@OtherInformation", SqlDbType.VarChar);
                        cmd.Parameters.Add("@ID", SqlDbType.Int);

                        foreach (DataGridViewRow item in dgvBonbonAngilan.Rows)
                        {
                            cmd.Parameters["@CustomerID"].Value = item.Cells[1].Value;
                            cmd.Parameters["@Name"].Value = item.Cells[2].Value;
                            cmd.Parameters["@Meter_No"].Value = item.Cells[3].Value;
                            cmd.Parameters["@Current"].Value = item.Cells[4].Value;
                            cmd.Parameters["@Previous"].Value = item.Cells[5].Value;

                            cmd.Parameters["@Consume"].Value = item.Cells[6].Value;

                            cmd.Parameters["@LessCBM"].Value = item.Cells[7].Value;

                            cmd.Parameters["@TotalCBM"].Value = item.Cells[8].Value;

                            cmd.Parameters["@AmountPerCBM"].Value = item.Cells[9].Value;

                            cmd.Parameters["@Bill"].Value = item.Cells[10].Value;

                            cmd.Parameters["@PreviousBalance"].Value = item.Cells[11].Value;
                            cmd.Parameters["@AmountPaid"].Value = item.Cells[12].Value;
                            cmd.Parameters["@DatePaid"].Value = item.Cells[13].Value;
                            cmd.Parameters["@OR_No"].Value = item.Cells[14].Value;
                            cmd.Parameters["@Balance"].Value = item.Cells[15].Value;
                            cmd.Parameters["@Status"].Value = item.Cells[16].Value;
                            cmd.Parameters["@Added_Date"].Value = item.Cells[17].Value;
                            cmd.Parameters["@OtherInformation"].Value = item.Cells[18].Value;
                            cmd.Parameters["@ID"].Value = item.Cells[0].Value;

                            cmd.ExecuteNonQuery();
                        }
                        tr.Commit();
                    }

                    conn.Close();
                }
            }
        }

        private void btnPrintWaterReading_Click(object sender, EventArgs e)
        {
            frmPrintReadingBonbonAngilan frm = new frmPrintReadingBonbonAngilan(DateTime.Now.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
            frm.Show();
        }

        private void btnPaymentForTreasurer_Click(object sender, EventArgs e)
        {
            if (checkBoxLastMonthPrintPayment.Checked)
            {
                DateTime today = DateTime.Now;
                DateTime lastMonth = today.AddMonths(-1);

                frmPrintPaymentBonbonAngilan frm = new frmPrintPaymentBonbonAngilan(lastMonth.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show();
            }
            else
            {
                frmPrintPaymentBonbonAngilan frm = new frmPrintPaymentBonbonAngilan(DateTime.Now.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmPrintReceiptBonbonAngilan frm = new frmPrintReceiptBonbonAngilan(string.Format("{0}", txtName.Text), string.Format("{0}", Convert.ToInt32(txtCurrentReading.Text)), string.Format("{0}", Convert.ToInt32(txtPreviousReading.Text)), DateTime.Now.ToString("MMMM dd, yyyy"), string.Format("{0:N2}", Convert.ToDecimal(txtCurrentBill.Text)), string.Format("{0}", Convert.ToInt32(txtConsume.Text)), string.Format("{0}", Convert.ToInt32(txtLessCubicMeter.Text)), string.Format("{0}", Convert.ToInt32(txtTotalCBM.Text)), string.Format("{0:N2}", Convert.ToDecimal(txtAmountPerCubicMeter.Text))))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Statement Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            this.dgvBonbonAngilan.Size = new System.Drawing.Size(1123, 305);

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtCustomerCode.Focus();

            Clear();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.dgvBonbonAngilan.Size = new System.Drawing.Size(1123, 459);

            Clear();
        }
    }
}
