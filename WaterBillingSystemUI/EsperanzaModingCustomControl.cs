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
    public partial class EsperanzaModingCustomControl : UserControl
    {
        public EsperanzaModingCustomControl()
        {
            InitializeComponent();

            dgvEsperanzaModing.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvEsperanzaModing.EnableHeadersVisualStyles = false;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\WaterApplicationFormEsperanza-Moding.xls");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Esperanza-Moding Form Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(ex.Message, "Esperanza-Moding User Agreement Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        EsperanzaModingBLL em = new EsperanzaModingBLL();
        EsperanzaModingDAL dal = new EsperanzaModingDAL();
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

            errorProviderEsperanzaModing.Clear();
        }

        private bool ValidateForm()
        {
            bool bStatus = true;

            if (txtCustomerCode.Text == "")
            {
                errorProviderEsperanzaModing.SetError(txtCustomerCode, "Required Customer Code");
                bStatus = false;
            }
            else if (txtName.Text == "")
            {
                errorProviderEsperanzaModing.SetError(txtName, "Required Name");
                bStatus = false;
            }
            else if (txtMeterNumber.Text == "")
            {
                errorProviderEsperanzaModing.SetError(txtMeterNumber, "Required Meter Number");
                bStatus = false;
            }
            else if (cmbBoxStatus.Text == "Status")
            {
                errorProviderEsperanzaModing.SetError(cmbBoxStatus, "Required Status");
                bStatus = false;
            }
            else
            {
                errorProviderEsperanzaModing.Clear();
            }

            return bStatus;
        }

        private void dgvEsperanzaModing_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dgvEsperanzaModing.Rows)
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
                dgvEsperanzaModing.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
            else
            {
                // Use select method to display all items
                DataTable dt = dal.Select();
                dgvEsperanzaModing.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void txtCurrentReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderEsperanzaModing.SetError(txtCurrentReading, "Please enter only numbers.");
            }
        }

        private void txtLessCubicMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderEsperanzaModing.SetError(txtLessCubicMeter, "Please enter only numbers.");
            }
        }

        private void txtPreviousReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderEsperanzaModing.SetError(txtPreviousReading, "Please enter only numbers.");
            }
        }

        private void txtAmountPerCubicMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderEsperanzaModing.SetError(txtAmountPerCubicMeter, "Please enter only numbers.");
            }
        }

        private void EsperanzaModingCustomControl_Load(object sender, EventArgs e)
        {
            // View the data from datagridview
            DataTable dt = dal.Select();
            dgvEsperanzaModing.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "Name";
            DataTable sortedDT = dv.ToTable();

            dgvEsperanzaModing.Columns[0].Visible = false;
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

        private void dgvEsperanzaModing_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvEsperanzaModing.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Disconnection")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (dgvEsperanzaModing.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Penalty/Warning")
                {
                    e.CellStyle.BackColor = Color.Olive;
                }
                else if (dgvEsperanzaModing.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Government")
                {
                    e.CellStyle.BackColor = Color.Magenta;
                }
                else if (dgvEsperanzaModing.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "PriorityLessCBM")
                {
                    e.CellStyle.BackColor = Color.Teal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataGridView Esperanza-Moding CellFormatting Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            var column = dgvEsperanzaModing.Columns[e.ColumnIndex];
            if (column.Name == "Bill")
            {
                var cell = dgvEsperanzaModing.Rows[e.RowIndex].Cells[e.ColumnIndex];
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
                var cell = dgvEsperanzaModing.Rows[e.RowIndex].Cells[e.ColumnIndex];
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

        private void dgvEsperanzaModing_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the index of particular row
            int rowIndex = e.RowIndex;
            id = Convert.ToInt32(dgvEsperanzaModing.Rows[rowIndex].Cells[0].Value.ToString());
            txtCustomerCode.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[2].Value.ToString();
            txtMeterNumber.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[3].Value.ToString();
            txtCurrentReading.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[4].Value.ToString();
            txtPreviousReading.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[5].Value.ToString();
            txtConsume.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[6].Value.ToString();
            txtLessCubicMeter.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[7].Value.ToString();
            txtTotalCBM.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[8].Value.ToString();
            txtAmountPerCubicMeter.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[9].Value.ToString();
            txtCurrentBill.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[10].Value.ToString();
            txtPreviousBalance.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[11].Value.ToString();
            txtAmountPaid.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[12].Value.ToString();
            txtDatePaid.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[13].Value.ToString();
            txtORNo.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[14].Value.ToString();
            txtBalance.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[15].Value.ToString();
            cmbBoxStatus.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[16].Value.ToString();
            txtOtherInformation.Text = dgvEsperanzaModing.Rows[rowIndex].Cells[18].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            txtCurrentReading.Focus();

            this.dgvEsperanzaModing.Size = new System.Drawing.Size(1123, 290);
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
                em.CustomerID = txtCustomerCode.Text;
                em.Name = txtName.Text;
                em.Meter_No = txtMeterNumber.Text;
                em.Current_ = current;
                em.Previous = previous;
                //em.Consumed = Convert.ToInt32(txtConsumed.Text); Read only
                em.LessCBM = lessCubicMeter; // 5 cubic
                //em.Total_Cubic_Meter = Convert.ToInt32(txtTotalCubicMeter.Text); Read only
                em.AmountPerCBM = amountPerCubicMeter; // 15 pesos
                //em.Current_Bill = Convert.ToDecimal(txtCurrentBill.Text); Read only
                em.PreviousBalance = txtPreviousBalance.Text;
                em.AmountPaid = txtAmountPaid.Text;
                em.DatePaid = txtDatePaid.Text;
                em.OR_No = txtORNo.Text;
                em.Balance = txtBalance.Text;
                em.Status = cmbBoxStatus.Text;
                em.Added_Date = DateTime.Now;
                em.OtherInformation = txtOtherInformation.Text;

                // Inserting data into Database
                bool success = dal.Insert(em);

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
                dgvEsperanzaModing.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting User ID from Form
            em.ID = id;

            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete?", "Delete Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bool success = dal.Delete(em);
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
            dgvEsperanzaModing.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "Name";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the values from User UI
            em.ID = id;
            em.CustomerID = txtCustomerCode.Text;
            em.Name = txtName.Text;
            em.Meter_No = txtMeterNumber.Text;
            em.Current_ = Convert.ToInt32(txtCurrentReading.Text);
            em.Previous = Convert.ToInt32(txtPreviousReading.Text);
            em.LessCBM = Convert.ToInt32(txtLessCubicMeter.Text);
            em.AmountPerCBM = Convert.ToDecimal(txtAmountPerCubicMeter.Text);
            em.PreviousBalance = txtPreviousBalance.Text;
            em.AmountPaid = txtAmountPaid.Text;
            em.DatePaid = txtDatePaid.Text;
            em.OR_No = txtORNo.Text;
            em.Balance = txtBalance.Text;
            em.Status = cmbBoxStatus.Text;
            //em.Added_Date = DateTime.Now;
            em.OtherInformation = txtOtherInformation.Text;

            // Updating data into Database
            bool success = dal.Update(em);

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
            dgvEsperanzaModing.DataSource = dt;

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
                for (int i = 0; i < dgvEsperanzaModing.Rows.Count; i++)
                {
                    dgvEsperanzaModing.Rows[i].Cells[5].Value = dgvEsperanzaModing.Rows[i].Cells[4].Value;

                    //dgvEsperanzaModing.Rows[i].Cells[6].Value = 0;  // Read only "Consumed" column
                    //dgvEsperanzaModing.Rows[i].Cells[8].Value = 0;  // Read only "Total Cubic Meter" column
                    //dgvEsperanzaModing.Rows[i].Cells[10].Value = 0; // Read only "Current Bill" column
                }

                // Update all rows from database to datagridview
                using (SqlConnection conn = new SqlConnection(UserDAL.myconnstrng))
                using (SqlCommand cmd = new SqlCommand(@"UPDATE tbl_EsperanzaModing SET CustomerID=@CustomerID, Name=@Name, Meter_No=@Meter_No, Current_=@Current, Previous=@Previous, Consume=@Consume, LessCBM=@LessCBM, TotalCBM=@TotalCBM, AmountPerCBM=@AmountPerCBM, Bill=@Bill, PreviousBalance=@PreviousBalance, AmountPaid=@AmountPaid, DatePaid=@DatePaid, OR_No=@OR_No, Balance=@Balance, Status=@Status, Added_Date=@Added_Date, OtherInformation=@OtherInformation WHERE ID=@ID", conn))
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

                        foreach (DataGridViewRow item in dgvEsperanzaModing.Rows)
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
            frmPrintReadingEsperanzaModing frm = new frmPrintReadingEsperanzaModing(DateTime.Now.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
            frm.Show();
        }

        private void btnPaymentForTreasurer_Click(object sender, EventArgs e)
        {
            if (checkBoxLastMonthPrintPayment.Checked)
            {
                DateTime today = DateTime.Now;
                DateTime lastMonth = today.AddMonths(-1);

                frmPrintPaymentEsperanzaModing frm = new frmPrintPaymentEsperanzaModing(lastMonth.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show();
            }
            else
            {
                frmPrintPaymentEsperanzaModing frm = new frmPrintPaymentEsperanzaModing(DateTime.Now.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmPrintReceiptEsperanzaModing frm = new frmPrintReceiptEsperanzaModing(string.Format("{0}", txtName.Text), string.Format("{0}", Convert.ToInt32(txtCurrentReading.Text)), string.Format("{0}", Convert.ToInt32(txtPreviousReading.Text)), DateTime.Now.ToString("MMMM dd, yyyy"), string.Format("{0:N2}", Convert.ToDecimal(txtCurrentBill.Text)), string.Format("{0}", Convert.ToInt32(txtConsume.Text)), string.Format("{0}", Convert.ToInt32(txtLessCubicMeter.Text)), string.Format("{0}", Convert.ToInt32(txtTotalCBM.Text)), string.Format("{0:N2}", Convert.ToDecimal(txtAmountPerCubicMeter.Text))))
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
            this.dgvEsperanzaModing.Size = new System.Drawing.Size(1123, 290);

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtCustomerCode.Focus();

            Clear();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.dgvEsperanzaModing.Size = new System.Drawing.Size(1123, 459);

            Clear();
        }
    }
}
