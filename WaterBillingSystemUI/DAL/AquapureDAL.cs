using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaterBillingSystemUI.BLL;

namespace WaterBillingSystemUI.DAL
{
    public class AquapureDAL
    {
        #region Select data from Database
        public DataTable Select()
        {
            // Static method to connect Database
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            // To hold the data from Database
            DataTable dt = new DataTable();
            try
            {
                // SQL Query to get data from Database
                string sql = "SELECT * FROM tbl_Aquapure";

                // For executing command
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Getting data from Database
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                // Database connection open
                conn.Open();

                // Fill data in our DataTable
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Select data from Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Closing connection
                conn.Close();
            }

            // Return the value in DataTable
            return dt;
        }
        #endregion

        #region Insert data in Database
        public bool Insert(AquapureBLL a)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Aquapure (CustomerID, Name, Meter_No, Current_, Previous, Consume, CurrentBill, VAT, TotalAmount, MinCBM, RateMinCBM, AmountMinCBM, ExcessCBM, RateExcessCBM, AmountExcessCBM, PreviousBalance, ForTheMonthOf, Total, PrevBalPilipinas, TotalDue, Balance, AmountPaid, DatePaid, CreditBalance, Status, Added_Date, OtherInformation, PriorityLessAmount) VALUES (@CustomerID, @Name, @Meter_No, @Current, @Previous, @Consume, @CurrentBill, @VAT, @TotalAmount, @MinCBM, @RateMinCBM, @AmountMinCBM, @ExcessCBM, @RateExcessCBM, @AmountExcessCBM, @PreviousBalance, @ForTheMonthOf, @Total, @PrevBalPilipinas, @TotalDue, @Balance, @AmountPaid, @DatePaid, @CreditBalance, @Status, @Added_Date, @OtherInformation, @PriorityLessAmount)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CustomerID", a.CustomerID);
                cmd.Parameters.AddWithValue("@Name", a.Name);
                cmd.Parameters.AddWithValue("@Meter_No", a.Meter_No);
                cmd.Parameters.AddWithValue("@Current", a.Current_);
                cmd.Parameters.AddWithValue("@Previous", a.Previous);
                cmd.Parameters.AddWithValue("@Consume", a.Consume);
                cmd.Parameters.AddWithValue("@CurrentBill", a.CurrentBill);
                cmd.Parameters.AddWithValue("@VAT", a.VAT);
                cmd.Parameters.AddWithValue("@TotalAmount", a.TotalAmount);
                cmd.Parameters.AddWithValue("@MinCBM", a.MinCBM);
                cmd.Parameters.AddWithValue("@RateMinCBM", a.RateMinCBM);
                cmd.Parameters.AddWithValue("@AmountMinCBM", a.AmountMinCBM);
                cmd.Parameters.AddWithValue("@ExcessCBM", a.ExcessCBM);
                cmd.Parameters.AddWithValue("@RateExcessCBM", a.RateExcessCBM);
                cmd.Parameters.AddWithValue("@AmountExcessCBM", a.AmountExcessCBM);
                cmd.Parameters.AddWithValue("@PreviousBalance", a.PreviousBalance);
                cmd.Parameters.AddWithValue("@ForTheMonthOf", a.ForTheMonthOf);
                cmd.Parameters.AddWithValue("@Total", a.Total);
                cmd.Parameters.AddWithValue("@PrevBalPilipinas", a.PrevBalPilipinas);
                cmd.Parameters.AddWithValue("@TotalDue", a.TotalDue);
                cmd.Parameters.AddWithValue("@Balance", a.Balance);
                cmd.Parameters.AddWithValue("@AmountPaid", a.AmountPaid);
                cmd.Parameters.AddWithValue("@DatePaid", a.DatePaid);
                cmd.Parameters.AddWithValue("@CreditBalance", a.CreditBalance);
                cmd.Parameters.AddWithValue("@Status", a.Status);
                cmd.Parameters.AddWithValue("@Added_Date", a.Added_Date);
                cmd.Parameters.AddWithValue("@OtherInformation", a.OtherInformation);
                cmd.Parameters.AddWithValue("@PriorityLessAmount", a.PriorityLessAmount);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                // If the query is executed successfully then the value to rows will be greaten than 0 else it will be less than 0
                if (rows > 0)
                {
                    // Query successful
                    isSuccess = true;
                }
                else
                {
                    // Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Insert data in Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Update data in Database
        public bool Update(AquapureBLL a)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "UPDATE tbl_Aquapure SET CustomerID=@CustomerID, Name=@Name, Meter_No=@Meter_No, Current_=@Current, Previous=@Previous, Consume=@Consume, CurrentBill=@CurrentBill, VAT=@VAT, TotalAmount=@TotalAmount, MinCBM=@MinCBM, RateMinCBM=@RateMinCBM, AmountMinCBM=@AmountMinCBM, ExcessCBM=@ExcessCBM, RateExcessCBM=@RateExcessCBM, AmountExcessCBM=@AmountExcessCBM, PreviousBalance=@PreviousBalance, ForTheMonthOf=@ForTheMonthOf, Total=@Total, PrevBalPilipinas=@PrevBalPilipinas, TotalDue=@TotalDue, Balance=@Balance, AmountPaid=@AmountPaid, DatePaid=@DatePaid, CreditBalance=@CreditBalance, Status=@Status, OtherInformation=@OtherInformation, PriorityLessAmount=@PriorityLessAmount WHERE ID=@ID"; // Added_Date=@Added_Date,
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CustomerID", a.CustomerID);
                cmd.Parameters.AddWithValue("@Name", a.Name);
                cmd.Parameters.AddWithValue("@Meter_No", a.Meter_No);
                cmd.Parameters.AddWithValue("@Current", a.Current_);
                cmd.Parameters.AddWithValue("@Previous", a.Previous);
                cmd.Parameters.AddWithValue("@Consume", a.Consume);
                cmd.Parameters.AddWithValue("@CurrentBill", a.CurrentBill);
                cmd.Parameters.AddWithValue("@VAT", a.VAT);
                cmd.Parameters.AddWithValue("@TotalAmount", a.TotalAmount);
                cmd.Parameters.AddWithValue("@MinCBM", a.MinCBM);
                cmd.Parameters.AddWithValue("@RateMinCBM", a.RateMinCBM);
                cmd.Parameters.AddWithValue("@AmountMinCBM", a.AmountMinCBM);
                cmd.Parameters.AddWithValue("@ExcessCBM", a.ExcessCBM);
                cmd.Parameters.AddWithValue("@RateExcessCBM", a.RateExcessCBM);
                cmd.Parameters.AddWithValue("@AmountExcessCBM", a.AmountExcessCBM);
                cmd.Parameters.AddWithValue("@PreviousBalance", a.PreviousBalance);
                cmd.Parameters.AddWithValue("@ForTheMonthOf", a.ForTheMonthOf);
                cmd.Parameters.AddWithValue("@Total", a.Total);
                cmd.Parameters.AddWithValue("@PrevBalPilipinas", a.PrevBalPilipinas);
                cmd.Parameters.AddWithValue("@TotalDue", a.TotalDue);
                cmd.Parameters.AddWithValue("@Balance", a.Balance);
                cmd.Parameters.AddWithValue("@AmountPaid", a.AmountPaid);
                cmd.Parameters.AddWithValue("@DatePaid", a.DatePaid);
                cmd.Parameters.AddWithValue("@CreditBalance", a.CreditBalance);
                cmd.Parameters.AddWithValue("@Status", a.Status);
                cmd.Parameters.AddWithValue("@OtherInformation", a.OtherInformation);
                cmd.Parameters.AddWithValue("@PriorityLessAmount", a.PriorityLessAmount);
                //cmd.Parameters.AddWithValue("@Added_Date", a.Added_Date);
                cmd.Parameters.AddWithValue("@ID", a.ID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    // Query successful
                    isSuccess = true;
                }
                else
                {
                    // Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Update data in Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Delete data from Database
        public bool Delete(AquapureBLL a)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_Aquapure WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", a.ID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    // Query successful
                    isSuccess = true;
                }
                else
                {
                    // Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Delete data from Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Method for Search Functionality
        public DataTable Search(string keywords)
        {
            // SQL connection for database connection
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            // Creating data table to hold the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Search items from database
                String sql = "SELECT * FROM tbl_Aquapure WHERE CustomerID LIKE '%" + keywords + "%' OR Name LIKE '%" + keywords + "%' OR Meter_No LIKE '%" + keywords + "%' OR Status LIKE '%" + keywords + "%' ";

                // Creating SQL Commant to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Getting data from database
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                // Open database connection
                conn.Open();

                // Passing values from adapter to Data Table dt
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion        
    }
}
