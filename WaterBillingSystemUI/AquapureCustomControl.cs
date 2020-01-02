using System;
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
    public partial class AquapureCustomControl : UserControl
    {
        public AquapureCustomControl()
        {
            InitializeComponent();

            dgvAquapure.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvAquapure.EnableHeadersVisualStyles = false;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\WaterApplicationFormAquapure.xls");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aquapure Form Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUserAgreement_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\RULESANDREGULATIONSAQUAPURE.doc");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Angilan User Agreement Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMayorsAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\MayorsAccount.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aquapure Mayor's Account Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        AquapureBLL a = new AquapureBLL();
        AquapureDAL dal = new AquapureDAL();
        int id = 1;

        private void Clear()
        {
            txtCustomerCode.Text = "";
            txtName.Text = "";
            txtMeterNumber.Text = "";
            txtCurrentReading.Text = "";
            txtPreviousReading.Text = "";
            txtMinimumCubicMeter.Text = "";
            txtAmountPaid.Text = "";
            txtDatePaid.Text = "";
            txtPreviousBalance.Text = "";
            txtOtherInformation.Text = "";
            txtPriorityLessAmount.Text = "";
            txtForTheMonthOf.Text = "";
            cmbBoxStatus.Text = "Status";
            txtPreviousBalancePillipinas.Text = "";

            txtSearch.Text = "";

            id = 1;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            errorProviderAquapure.Clear();
        }

        private bool ValidateForm()
        {
            bool bStatus = true;

            if (txtCustomerCode.Text == "")
            {
                errorProviderAquapure.SetError(txtCustomerCode, "Required Customer Code");
                bStatus = false;
            }
            else if (txtName.Text == "")
            {
                errorProviderAquapure.SetError(txtName, "Required Name");
                bStatus = false;
            }
            else if (txtMeterNumber.Text == "")
            {
                errorProviderAquapure.SetError(txtMeterNumber, "Required Meter Number");
                bStatus = false;
            }
            else if (cmbBoxStatus.Text == "Status")
            {
                errorProviderAquapure.SetError(cmbBoxStatus, "Required Status");
                bStatus = false;
            }
            else
            {
                errorProviderAquapure.Clear();
            }

            return bStatus;
        }

        private void dgvAquapure_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dgvAquapure.Rows)
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
                dgvAquapure.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
            else
            {
                // Use select method to display all items
                DataTable dt = dal.Select();
                dgvAquapure.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void txtCurrentReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderAquapure.SetError(txtCurrentReading, "Please enter only numbers.");
            }
        }

        private void txtPreviousReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderAquapure.SetError(txtPreviousReading, "Please enter only numbers.");
            }
        }

        private void txtMinimumCubicMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderAquapure.SetError(txtMinimumCubicMeter, "Please enter only numbers.");
            }
        }

        private void AquapureCustomControl_Load(object sender, EventArgs e)
        {
            // View the data from datagridview
            DataTable dt = dal.Select();
            dgvAquapure.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "Name";
            DataTable sortedDT = dv.ToTable();

            dgvAquapure.Columns[0].Visible = false;
            cmbBoxStatus.SelectedIndex = 0;
            cmbBoxFocus.SelectedIndex = 0;


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

        private void dgvAquapure_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvAquapure.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Disconnection")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (dgvAquapure.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Penalty/Warning")
                {
                    e.CellStyle.BackColor = Color.Olive;
                }
                else if (dgvAquapure.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Government")
                {
                    e.CellStyle.BackColor = Color.Magenta;
                }
                else if (dgvAquapure.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "PriorityLessCBM")
                {
                    e.CellStyle.BackColor = Color.Teal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataGridView Aquapure CellFormatting Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            var column = dgvAquapure.Columns[e.ColumnIndex];
            if (column.Name == "CurrentBill")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "VAT")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "TotalAmount")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "RateMinCBM")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "AmountMinCBM")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "RateExcessCBM")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "AmountExcessCBM")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "PreviousBalance")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "Total")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "PrevBalPilipinas")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "TotalDue")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "Balance")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "AmountPaid")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "CreditBalance")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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
            else if (column.Name == "PriorityLessAmount")
            {
                var cell = dgvAquapure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (double)e.Value;
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

        private void dgvAquapure_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the index of particular row
            int rowIndex = e.RowIndex;
            id = Convert.ToInt32(dgvAquapure.Rows[rowIndex].Cells[0].Value.ToString());
            txtCustomerCode.Text = dgvAquapure.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvAquapure.Rows[rowIndex].Cells[2].Value.ToString();
            txtMeterNumber.Text = dgvAquapure.Rows[rowIndex].Cells[3].Value.ToString();
            txtCurrentReading.Text = dgvAquapure.Rows[rowIndex].Cells[4].Value.ToString();
            txtPreviousReading.Text = dgvAquapure.Rows[rowIndex].Cells[5].Value.ToString();
            txtConsume.Text = dgvAquapure.Rows[rowIndex].Cells[6].Value.ToString();
            txtCurrentBill.Text = dgvAquapure.Rows[rowIndex].Cells[7].Value.ToString();
            txtVAT.Text = dgvAquapure.Rows[rowIndex].Cells[8].Value.ToString();
            txtTotalAmount.Text = dgvAquapure.Rows[rowIndex].Cells[9].Value.ToString();
            txtMinimumCubicMeter.Text = dgvAquapure.Rows[rowIndex].Cells[10].Value.ToString();
            txtRateMinimumCubicMeter.Text = dgvAquapure.Rows[rowIndex].Cells[11].Value.ToString();
            txtAmountMinimumCubicMeter.Text = dgvAquapure.Rows[rowIndex].Cells[12].Value.ToString();
            txtExcessCBM.Text = dgvAquapure.Rows[rowIndex].Cells[13].Value.ToString();
            txtRateExcessCubicMeter.Text = dgvAquapure.Rows[rowIndex].Cells[14].Value.ToString();
            txtAmountExcessCubicMeter.Text = dgvAquapure.Rows[rowIndex].Cells[15].Value.ToString();
            txtPreviousBalance.Text = dgvAquapure.Rows[rowIndex].Cells[16].Value.ToString();
            txtForTheMonthOf.Text = dgvAquapure.Rows[rowIndex].Cells[17].Value.ToString();
            txtTotal.Text = dgvAquapure.Rows[rowIndex].Cells[18].Value.ToString();
            txtPreviousBalancePillipinas.Text = dgvAquapure.Rows[rowIndex].Cells[19].Value.ToString();
            txtTotalDue.Text = dgvAquapure.Rows[rowIndex].Cells[20].Value.ToString();
            txtBalance.Text = dgvAquapure.Rows[rowIndex].Cells[21].Value.ToString();
            txtAmountPaid.Text = dgvAquapure.Rows[rowIndex].Cells[22].Value.ToString();
            txtDatePaid.Text = dgvAquapure.Rows[rowIndex].Cells[23].Value.ToString();
            txtCreditBalance.Text = dgvAquapure.Rows[rowIndex].Cells[24].Value.ToString();
            cmbBoxStatus.Text = dgvAquapure.Rows[rowIndex].Cells[25].Value.ToString();
            txtOtherInformation.Text = dgvAquapure.Rows[rowIndex].Cells[27].Value.ToString();
            txtPriorityLessAmount.Text = dgvAquapure.Rows[rowIndex].Cells[28].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            if (cmbBoxFocus.Text == "Current_Reading")
            {
                txtCurrentReading.Focus();
            }
            else if (cmbBoxFocus.Text == "Amount_Paid")
            {
                txtAmountPaid.Focus();
            }

            this.dgvAquapure.Size = new System.Drawing.Size(1123, 305);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                double rateMinCBM, rateExcessCBM, previousBalance, prevBalPilipinas, amountPaid, priorityLessAmount;
                int current, previous, minCBM;
                int.TryParse(txtCurrentReading.Text, out current);
                int.TryParse(txtPreviousReading.Text, out previous);
                int.TryParse(txtMinimumCubicMeter.Text, out minCBM);
                double.TryParse(txtRateMinimumCubicMeter.Text, out rateMinCBM);
                double.TryParse(txtRateExcessCubicMeter.Text, out rateExcessCBM);
                double.TryParse(txtPreviousBalance.Text, out previousBalance);
                double.TryParse(txtPreviousBalancePillipinas.Text, out prevBalPilipinas);
                double.TryParse(txtAmountPaid.Text, out amountPaid);
                double.TryParse(txtPriorityLessAmount.Text, out priorityLessAmount);

                // Getting data from UI
                a.CustomerID = txtCustomerCode.Text;
                a.Name = txtName.Text;
                a.Meter_No = txtMeterNumber.Text;
                a.Current_ = current;
                a.Previous = previous;
                a.MinCBM = minCBM;
                a.PreviousBalance = previousBalance;
                a.ForTheMonthOf = txtForTheMonthOf.Text;
                a.PrevBalPilipinas = prevBalPilipinas;
                a.AmountPaid = amountPaid;
                a.DatePaid = txtDatePaid.Text;
                a.Status = cmbBoxStatus.Text;
                a.Added_Date = DateTime.Now;
                a.OtherInformation = txtOtherInformation.Text;
                a.PriorityLessAmount = priorityLessAmount;

                a.RateMinCBM = rateMinCBM;
                a.RateExcessCBM = rateExcessCBM;

                // Inserting data into Database
                bool success = dal.Insert(a);

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
                dgvAquapure.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting User ID from Form
            a.ID = id;

            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete?", "Delete Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bool success = dal.Delete(a);
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
            dgvAquapure.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "Name";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                double rateMinCBM, rateExcessCBM, previousBalance, prevBalPilipinas, amountPaid, priorityLessAmount;
                int current, previous, minCBM;
                int.TryParse(txtCurrentReading.Text, out current);
                int.TryParse(txtPreviousReading.Text, out previous);
                int.TryParse(txtMinimumCubicMeter.Text, out minCBM);
                double.TryParse(txtRateMinimumCubicMeter.Text, out rateMinCBM);
                double.TryParse(txtRateExcessCubicMeter.Text, out rateExcessCBM);
                double.TryParse(txtPreviousBalance.Text, out previousBalance);
                double.TryParse(txtPreviousBalancePillipinas.Text, out prevBalPilipinas);
                double.TryParse(txtAmountPaid.Text, out amountPaid);
                double.TryParse(txtPriorityLessAmount.Text, out priorityLessAmount);

                // Get the values from User UI
                a.ID = id;
                a.CustomerID = txtCustomerCode.Text;
                a.Name = txtName.Text;
                a.Meter_No = txtMeterNumber.Text;
                a.Current_ = current;
                a.Previous = previous;
                a.MinCBM = minCBM;
                a.PreviousBalance = previousBalance;
                a.ForTheMonthOf = txtForTheMonthOf.Text;
                a.PrevBalPilipinas = prevBalPilipinas;
                a.AmountPaid = amountPaid;
                a.DatePaid = txtDatePaid.Text;
                a.Status = cmbBoxStatus.Text;
                a.OtherInformation = txtOtherInformation.Text;
                a.PriorityLessAmount = priorityLessAmount;

                a.RateMinCBM = rateMinCBM;
                a.RateExcessCBM = rateExcessCBM;
                //a.Added_Date = DateTime.Now;

                // Updating data into Database
                bool success = dal.Update(a);

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
                dgvAquapure.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update not successful!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnTransferThenUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to transfer value from Current Reading to Previous Reading?", "Transfer Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                for (int i = 0; i < dgvAquapure.Rows.Count; i++)
                {   // Previous Reading                  // Current Reading
                    dgvAquapure.Rows[i].Cells[5].Value = dgvAquapure.Rows[i].Cells[4].Value; // Current Reading to Previous Reading
                }

                // Update all rows from database to datagridview
                using (SqlConnection conn = new SqlConnection(UserDAL.myconnstrng))
                using (SqlCommand cmd = new SqlCommand(@"UPDATE tbl_Aquapure SET CustomerID=@CustomerID, Name=@Name, Meter_No=@Meter_No, Current_=@Current, Previous=@Previous, Consume=@Consume, CurrentBill=@CurrentBill, VAT=@VAT, TotalAmount=@TotalAmount, MinCBM=@MinCBM, RateMinCBM=@RateMinCBM, AmountMinCBM=@AmountMinCBM, ExcessCBM=@ExcessCBM, RateExcessCBM=@RateExcessCBM, AmountExcessCBM=@AmountExcessCBM, PreviousBalance=@PreviousBalance, ForTheMonthOf=@ForTheMonthOf, Total=@Total, PrevBalPilipinas=@PrevBalPilipinas, TotalDue=@TotalDue, Balance=@Balance, AmountPaid=@AmountPaid, DatePaid=@DatePaid, CreditBalance=@CreditBalance, Status=@Status, OtherInformation=@OtherInformation, PriorityLessAmount=@PriorityLessAmount WHERE ID=@ID", conn))
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
                        cmd.Parameters.Add("@Consume", SqlDbType.Int);
                        cmd.Parameters.Add("@CurrentBill", SqlDbType.Float);
                        cmd.Parameters.Add("@VAT", SqlDbType.Float);
                        cmd.Parameters.Add("@TotalAmount", SqlDbType.Float);
                        cmd.Parameters.Add("@MinCBM", SqlDbType.Int);
                        cmd.Parameters.Add("@RateMinCBM", SqlDbType.Float);
                        cmd.Parameters.Add("@AmountMinCBM", SqlDbType.Float);
                        cmd.Parameters.Add("@ExcessCBM", SqlDbType.Int);
                        cmd.Parameters.Add("@RateExcessCBM", SqlDbType.Float);
                        cmd.Parameters.Add("@AmountExcessCBM", SqlDbType.Float);
                        cmd.Parameters.Add("@PreviousBalance", SqlDbType.Float);
                        cmd.Parameters.Add("@ForTheMonthOf", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Total", SqlDbType.Float);
                        cmd.Parameters.Add("@PrevBalPilipinas", SqlDbType.Float);
                        cmd.Parameters.Add("@TotalDue", SqlDbType.Float);
                        cmd.Parameters.Add("@Balance", SqlDbType.Float);
                        cmd.Parameters.Add("@AmountPaid", SqlDbType.Float);
                        cmd.Parameters.Add("@DatePaid", SqlDbType.VarChar);
                        cmd.Parameters.Add("@CreditBalance", SqlDbType.Float);
                        cmd.Parameters.Add("@Status", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Added_Date", SqlDbType.DateTime);
                        cmd.Parameters.Add("@OtherInformation", SqlDbType.VarChar);
                        cmd.Parameters.Add("@PriorityLessAmount", SqlDbType.Float);
                        cmd.Parameters.Add("@ID", SqlDbType.Int);

                        foreach (DataGridViewRow item in dgvAquapure.Rows)
                        {
                            cmd.Parameters["@CustomerID"].Value = item.Cells[1].Value;
                            cmd.Parameters["@Name"].Value = item.Cells[2].Value;
                            cmd.Parameters["@Meter_No"].Value = item.Cells[3].Value;
                            cmd.Parameters["@Current"].Value = item.Cells[4].Value;
                            cmd.Parameters["@Previous"].Value = item.Cells[5].Value;
                            cmd.Parameters["@Consume"].Value = item.Cells[6].Value;
                            cmd.Parameters["@CurrentBill"].Value = item.Cells[7].Value;
                            cmd.Parameters["@VAT"].Value = item.Cells[8].Value;
                            cmd.Parameters["@TotalAmount"].Value = item.Cells[9].Value;
                            cmd.Parameters["@MinCBM"].Value = item.Cells[10].Value;
                            cmd.Parameters["@RateMinCBM"].Value = item.Cells[11].Value;
                            cmd.Parameters["@AmountMinCBM"].Value = item.Cells[12].Value;
                            cmd.Parameters["@ExcessCBM"].Value = item.Cells[13].Value;
                            cmd.Parameters["@RateExcessCBM"].Value = item.Cells[14].Value;
                            cmd.Parameters["@AmountExcessCBM"].Value = item.Cells[15].Value;
                            cmd.Parameters["@PreviousBalance"].Value = item.Cells[16].Value;
                            cmd.Parameters["@ForTheMonthOf"].Value = item.Cells[17].Value;
                            cmd.Parameters["@Total"].Value = item.Cells[18].Value;
                            cmd.Parameters["@PrevBalPilipinas"].Value = item.Cells[19].Value;
                            cmd.Parameters["@TotalDue"].Value = item.Cells[20].Value;
                            cmd.Parameters["@Balance"].Value = item.Cells[21].Value;
                            cmd.Parameters["@AmountPaid"].Value = item.Cells[22].Value;
                            cmd.Parameters["@DatePaid"].Value = item.Cells[23].Value;
                            cmd.Parameters["@CreditBalance"].Value = item.Cells[24].Value;
                            cmd.Parameters["@Status"].Value = item.Cells[25].Value;
                            cmd.Parameters["@Added_Date"].Value = item.Cells[26].Value;
                            cmd.Parameters["@OtherInformation"].Value = item.Cells[27].Value;
                            cmd.Parameters["@PriorityLessAmount"].Value = item.Cells[28].Value;
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
            frmPrintReadingAquapure frm = new frmPrintReadingAquapure(DateTime.Now.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
            frm.Show();
        }

        private void btnPaymentForTreasurer_Click(object sender, EventArgs e)
        {
            if (checkBoxLastMonthPrintPayment.Checked)
            {
                DateTime today = DateTime.Now;
                DateTime lastMonth = today.AddMonths(-1);


                frmPrintPaymentAquapure frm = new frmPrintPaymentAquapure(lastMonth.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show();
            }
            else
            {
                frmPrintPaymentAquapure frm = new frmPrintPaymentAquapure(DateTime.Now.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmPrintReceiptAquapure frm = new frmPrintReceiptAquapure(DateTime.Now.ToString("MMMM dd, yyyy"), string.Format("{0}", txtCustomerCode.Text), string.Format("{0}", txtName.Text), string.Format("{0}", txtMeterNumber.Text), string.Format("{0}", Convert.ToInt32(txtCurrentReading.Text)), string.Format("{0}", Convert.ToInt32(txtPreviousReading.Text)), string.Format("{0}", Convert.ToInt32(txtConsume.Text)), string.Format("{0}", Convert.ToInt32(txtMinimumCubicMeter.Text)), string.Format("{0}", Convert.ToDouble(txtRateMinimumCubicMeter.Text)), string.Format("{0:N2}", Convert.ToDouble(txtAmountMinimumCubicMeter.Text)), string.Format("{0}", Convert.ToInt32(txtExcessCBM.Text)), string.Format("{0}", Convert.ToDouble(txtRateExcessCubicMeter.Text)), string.Format("{0:N2}", Convert.ToDouble(txtAmountExcessCubicMeter.Text)), string.Format("{0:N2}", Convert.ToDouble(txtTotalAmount.Text)), string.Format("{0:N2}", Convert.ToDouble(txtVAT.Text)), string.Format("{0:N2}", Convert.ToDouble(txtCurrentBill.Text)), string.Format("{0:N2}", Convert.ToDouble(txtPreviousBalance.Text)), string.Format("{0:N2}", Convert.ToDouble(txtTotal.Text)), string.Format("{0:N2}", Convert.ToDouble(txtPreviousBalancePillipinas.Text)), string.Format("{0:N2}", Convert.ToDouble(txtTotalDue.Text)), string.Format("{0:N2}", Convert.ToDouble(txtPriorityLessAmount.Text))))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Statement Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrintOfficeFile_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime lastMonth = today.AddMonths(-1);

            frmPrintOfficeFileAquapure frm = new frmPrintOfficeFileAquapure(lastMonth.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
            frm.Show();
        }

        private void btnPrintMonthlyReading_Click(object sender, EventArgs e)
        {
            if (checkBoxLastMonthPrintMonthlyReading.Checked)
            {
                DateTime today = DateTime.Now;
                DateTime lastMonth = today.AddMonths(-1);

                frmPrintMonthlyReadingAquapure frm = new frmPrintMonthlyReadingAquapure(lastMonth.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show(); 
            }
            else
            {
                frmPrintMonthlyReadingAquapure frm = new frmPrintMonthlyReadingAquapure(DateTime.Now.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show();
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            this.dgvAquapure.Size = new System.Drawing.Size(1123, 305);

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtCustomerCode.Focus();

            Clear();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.dgvAquapure.Size = new System.Drawing.Size(1123, 459);

            Clear();
        }
    }
}
