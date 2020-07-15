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
    public partial class BojoCustomControl : UserControl
    {
        public BojoCustomControl()
        {
            InitializeComponent();

            dgvBojo.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvBojo.EnableHeadersVisualStyles = false;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\WaterApplicationFormBojo.xls");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bojo Form Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(ex.Message, "Bojo User Agreement Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        BojoBLL b = new BojoBLL();
        BojoDAL dal = new BojoDAL();
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

            errorProviderBojo.Clear();
        }

        private bool ValidateForm()
        {
            bool bStatus = true;

            if (txtCustomerCode.Text == "")
            {
                errorProviderBojo.SetError(txtCustomerCode, "Required Customer Code");
                bStatus = false;
            }
            else if (txtName.Text == "")
            {
                errorProviderBojo.SetError(txtName, "Required Name");
                bStatus = false;
            }
            else if (txtMeterNumber.Text == "")
            {
                errorProviderBojo.SetError(txtMeterNumber, "Required Meter Number");
                bStatus = false;
            }
            else if (cmbBoxStatus.Text == "Status")
            {
                errorProviderBojo.SetError(cmbBoxStatus, "Required Status");
                bStatus = false;
            }
            else
            {
                errorProviderBojo.Clear();
            }

            return bStatus;
        }

        private void dgvBojo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dgvBojo.Rows)
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
                dgvBojo.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
            else
            {
                // Use select method to display all items
                DataTable dt = dal.Select();
                dgvBojo.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void txtCurrentReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderBojo.SetError(txtCurrentReading, "Please enter only numbers.");
            }
        }

        private void txtLessCubicMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderBojo.SetError(txtLessCubicMeter, "Please enter only numbers.");
            }
        }

        private void txtPreviousReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderBojo.SetError(txtPreviousReading, "Please enter only numbers.");
            }
        }

        private void txtAmountPerCubicMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderBojo.SetError(txtAmountPerCubicMeter, "Please enter only numbers.");
            }
        }

        private void BojoCustomControl_Load(object sender, EventArgs e)
        {
            // View the data from datagridview
            DataTable dt = dal.Select();
            dgvBojo.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "Name";
            DataTable sortedDT = dv.ToTable();

            dgvBojo.Columns[0].Visible = false;
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

        private void dgvBojo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvBojo.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Disconnection")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (dgvBojo.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Penalty/Warning")
                {
                    e.CellStyle.BackColor = Color.Olive;
                }
                else if (dgvBojo.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Government")
                {
                    e.CellStyle.BackColor = Color.Magenta;
                }
                else if (dgvBojo.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "PriorityLessCBM")
                {
                    e.CellStyle.BackColor = Color.Teal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataGridView Bojo CellFormatting Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            var column = dgvBojo.Columns[e.ColumnIndex];
            if (column.Name == "Bill")
            {
                var cell = dgvBojo.Rows[e.RowIndex].Cells[e.ColumnIndex];
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
                var cell = dgvBojo.Rows[e.RowIndex].Cells[e.ColumnIndex];
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

        private void dgvBojo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the index of particular row
            int rowIndex = e.RowIndex;
            id = Convert.ToInt32(dgvBojo.Rows[rowIndex].Cells[0].Value.ToString());
            txtCustomerCode.Text = dgvBojo.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvBojo.Rows[rowIndex].Cells[2].Value.ToString();
            txtMeterNumber.Text = dgvBojo.Rows[rowIndex].Cells[3].Value.ToString();
            txtCurrentReading.Text = dgvBojo.Rows[rowIndex].Cells[4].Value.ToString();
            txtPreviousReading.Text = dgvBojo.Rows[rowIndex].Cells[5].Value.ToString();
            txtConsume.Text = dgvBojo.Rows[rowIndex].Cells[6].Value.ToString();
            txtLessCubicMeter.Text = dgvBojo.Rows[rowIndex].Cells[7].Value.ToString();
            txtTotalCBM.Text = dgvBojo.Rows[rowIndex].Cells[8].Value.ToString();
            txtAmountPerCubicMeter.Text = dgvBojo.Rows[rowIndex].Cells[9].Value.ToString();
            txtCurrentBill.Text = dgvBojo.Rows[rowIndex].Cells[10].Value.ToString();
            txtPreviousBalance.Text = dgvBojo.Rows[rowIndex].Cells[11].Value.ToString();
            txtAmountPaid.Text = dgvBojo.Rows[rowIndex].Cells[12].Value.ToString();
            txtDatePaid.Text = dgvBojo.Rows[rowIndex].Cells[13].Value.ToString();
            txtORNo.Text = dgvBojo.Rows[rowIndex].Cells[14].Value.ToString();
            txtBalance.Text = dgvBojo.Rows[rowIndex].Cells[15].Value.ToString();
            cmbBoxStatus.Text = dgvBojo.Rows[rowIndex].Cells[16].Value.ToString();
            txtOtherInformation.Text = dgvBojo.Rows[rowIndex].Cells[18].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            txtCurrentReading.Focus();

            this.dgvBojo.Size = new System.Drawing.Size(1123, 290);
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
                b.CustomerID = txtCustomerCode.Text;
                b.Name = txtName.Text;
                b.Meter_No = txtMeterNumber.Text;
                b.Current_ = current;
                b.Previous = previous;
                //b.Consumed = Convert.ToInt32(txtConsumed.Text); Read only
                b.LessCBM = lessCubicMeter; // 5 cubic
                //b.Total_Cubic_Meter = Convert.ToInt32(txtTotalCubicMeter.Text); Read only
                b.AmountPerCBM = amountPerCubicMeter; // 15 pesos
                //b.Current_Bill = Convert.ToDecimal(txtCurrentBill.Text); Read only
                b.PreviousBalance = txtPreviousBalance.Text;
                b.AmountPaid = txtAmountPaid.Text;
                b.DatePaid = txtDatePaid.Text;
                b.OR_No = txtORNo.Text;
                b.Balance = txtBalance.Text;
                b.Status = cmbBoxStatus.Text;
                b.Added_Date = DateTime.Now;
                b.OtherInformation = txtOtherInformation.Text;

                // Inserting data into Database
                bool success = dal.Insert(b);

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
                dgvBojo.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "Name";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting User ID from Form
            b.ID = id;

            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete?", "Delete Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bool success = dal.Delete(b);
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
            dgvBojo.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "Name";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the values from User UI
            b.ID = id;
            b.CustomerID = txtCustomerCode.Text;
            b.Name = txtName.Text;
            b.Meter_No = txtMeterNumber.Text;
            b.Current_ = Convert.ToInt32(txtCurrentReading.Text);
            b.Previous = Convert.ToInt32(txtPreviousReading.Text);
            b.LessCBM = Convert.ToInt32(txtLessCubicMeter.Text);
            b.AmountPerCBM = Convert.ToDecimal(txtAmountPerCubicMeter.Text);
            b.PreviousBalance = txtPreviousBalance.Text;
            b.AmountPaid = txtAmountPaid.Text;
            b.DatePaid = txtDatePaid.Text;
            b.OR_No = txtORNo.Text;
            b.Balance = txtBalance.Text;
            b.Status = cmbBoxStatus.Text;
            //a.Added_Date = DateTime.Now;
            b.OtherInformation = txtOtherInformation.Text;

            // Updating data into Database
            bool success = dal.Update(b);

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
            dgvBojo.DataSource = dt;

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
                for (int i = 0; i < dgvBojo.Rows.Count; i++)
                {
                    dgvBojo.Rows[i].Cells[5].Value = dgvBojo.Rows[i].Cells[4].Value;

                    //dgvBojo.Rows[i].Cells[6].Value = 0;  // Read only "Consumed" column
                    //dgvBojo.Rows[i].Cells[8].Value = 0;  // Read only "Total Cubic Meter" column
                    //dgvBojo.Rows[i].Cells[10].Value = 0; // Read only "Current Bill" column
                }

                // Update all rows from database to datagridview
                using (SqlConnection conn = new SqlConnection(UserDAL.myconnstrng))
                using (SqlCommand cmd = new SqlCommand(@"UPDATE tbl_Bojo SET CustomerID=@CustomerID, Name=@Name, Meter_No=@Meter_No, Current_=@Current, Previous=@Previous, Consume=@Consume, LessCBM=@LessCBM, TotalCBM=@TotalCBM, AmountPerCBM=@AmountPerCBM, Bill=@Bill, PreviousBalance=@PreviousBalance, AmountPaid=@AmountPaid, DatePaid=@DatePaid, OR_No=@OR_No, Balance=@Balance, Status=@Status, Added_Date=@Added_Date, OtherInformation=@OtherInformation WHERE ID=@ID", conn))
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

                        foreach (DataGridViewRow item in dgvBojo.Rows)
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
            frmPrintReadingBojo frm = new frmPrintReadingBojo(DateTime.Now.ToString("MMMM - yyyy"), string.Format("{0}",txtTotalMembers.Text));
            frm.Show();
        }

        private void btnPaymentForTreasurer_Click(object sender, EventArgs e)
        {
            if (checkBoxLastMonthPrintPayment.Checked)
            {
                DateTime today = DateTime.Now;
                DateTime lastMonth = today.AddMonths(-1);

                frmPrintPaymentBojo frm = new frmPrintPaymentBojo(lastMonth.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show();
            }
            else
            {
                frmPrintPaymentBojo frm = new frmPrintPaymentBojo(DateTime.Now.ToString("MMMM - yyyy"), string.Format("{0}", txtTotalMembers.Text));
                frm.Show();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmPrintReceiptBojo frm = new frmPrintReceiptBojo(string.Format("{0}", txtName.Text), string.Format("{0}", Convert.ToInt32(txtCurrentReading.Text)), string.Format("{0}", Convert.ToInt32(txtPreviousReading.Text)), DateTime.Now.ToString("MMMM dd, yyyy"), string.Format("{0:N2}", Convert.ToDecimal(txtCurrentBill.Text)), string.Format("{0}", Convert.ToInt32(txtConsume.Text)), string.Format("{0}", Convert.ToInt32(txtLessCubicMeter.Text)), string.Format("{0}", Convert.ToInt32(txtTotalCBM.Text)), string.Format("{0:N2}", Convert.ToDecimal(txtAmountPerCubicMeter.Text))))
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
            this.dgvBojo.Size = new System.Drawing.Size(1123, 290);

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtCustomerCode.Focus();

            Clear();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.dgvBojo.Size = new System.Drawing.Size(1123, 459);

            Clear();
        }
    }
}
