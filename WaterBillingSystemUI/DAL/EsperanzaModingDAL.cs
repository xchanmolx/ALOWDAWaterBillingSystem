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
    public class EsperanzaModingDAL
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
                string sql = "SELECT * FROM tbl_EsperanzaModing";

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
        public bool Insert(EsperanzaModingBLL em)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_EsperanzaModing (CustomerID, Name, Meter_No, Current_, Previous, Consume, LessCBM, TotalCBM, AmountPerCBM, Bill, PreviousBalance, AmountPaid, DatePaid, OR_No, Balance, Status, Added_Date, OtherInformation) VALUES (@CustomerID, @Name, @Meter_No, @Current, @Previous, @Consume, @LessCBM, @TotalCBM, @AmountPerCBM, @Bill, @PreviousBalance, @AmountPaid, @DatePaid, @OR_No, @Balance, @Status, @Added_Date, @OtherInformation)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CustomerID", em.CustomerID);
                cmd.Parameters.AddWithValue("@Name", em.Name);
                cmd.Parameters.AddWithValue("@Meter_No", em.Meter_No);
                cmd.Parameters.AddWithValue("@Current", em.Current_);
                cmd.Parameters.AddWithValue("@Previous", em.Previous);
                cmd.Parameters.AddWithValue("@Consume", em.Consume);
                cmd.Parameters.AddWithValue("@LessCBM", em.LessCBM);
                cmd.Parameters.AddWithValue("@TotalCBM", em.TotalCBM);
                cmd.Parameters.AddWithValue("@AmountPerCBM", em.AmountPerCBM);
                cmd.Parameters.AddWithValue("@Bill", em.Bill);
                cmd.Parameters.AddWithValue("@PreviousBalance", em.PreviousBalance);
                cmd.Parameters.AddWithValue("@AmountPaid", em.AmountPaid);
                cmd.Parameters.AddWithValue("@DatePaid", em.DatePaid);
                cmd.Parameters.AddWithValue("@OR_No", em.OR_No);
                cmd.Parameters.AddWithValue("@Balance", em.Balance);
                cmd.Parameters.AddWithValue("@Status", em.Status);
                cmd.Parameters.AddWithValue("@Added_Date", em.Added_Date);
                cmd.Parameters.AddWithValue("@OtherInformation", em.OtherInformation);

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
        public bool Update(EsperanzaModingBLL em)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "UPDATE tbl_EsperanzaModing SET CustomerID=@CustomerID, Name=@Name, Meter_No=@Meter_No, Current_=@Current, Previous=@Previous, Consume=@Consume, LessCBM=@LessCBM, TotalCBM=@TotalCBM, AmountPerCBM=@AmountPerCBM, Bill=@Bill, PreviousBalance=@PreviousBalance, AmountPaid=@AmountPaid, DatePaid=@DatePaid, OR_No=@OR_No, Balance=@Balance, Status=@Status, OtherInformation=@OtherInformation WHERE ID=@ID"; // Added_Date=@Added_Date,
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CustomerID", em.CustomerID);
                cmd.Parameters.AddWithValue("@Name", em.Name);
                cmd.Parameters.AddWithValue("@Meter_No", em.Meter_No);
                cmd.Parameters.AddWithValue("@Current", em.Current_);
                cmd.Parameters.AddWithValue("@Previous", em.Previous);
                cmd.Parameters.AddWithValue("@Consume", em.Consume);
                cmd.Parameters.AddWithValue("@LessCBM", em.LessCBM);
                cmd.Parameters.AddWithValue("@TotalCBM", em.TotalCBM);
                cmd.Parameters.AddWithValue("@AmountPerCBM", em.AmountPerCBM);
                cmd.Parameters.AddWithValue("@Bill", em.Bill);
                cmd.Parameters.AddWithValue("@PreviousBalance", em.PreviousBalance);
                cmd.Parameters.AddWithValue("@AmountPaid", em.AmountPaid);
                cmd.Parameters.AddWithValue("@DatePaid", em.DatePaid);
                cmd.Parameters.AddWithValue("@OR_No", em.OR_No);
                cmd.Parameters.AddWithValue("@Balance", em.Balance);
                cmd.Parameters.AddWithValue("@Status", em.Status);
                //cmd.Parameters.AddWithValue("@Added_Date", b.Added_Date);
                cmd.Parameters.AddWithValue("@OtherInformation", em.OtherInformation);
                cmd.Parameters.AddWithValue("@ID", em.ID);

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
        public bool Delete(EsperanzaModingBLL em)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_EsperanzaModing WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", em.ID);

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
                String sql = "SELECT * FROM tbl_EsperanzaModing WHERE CustomerID LIKE '%" + keywords + "%' OR Name LIKE '%" + keywords + "%' OR Meter_No LIKE '%" + keywords + "%' OR Status LIKE '%" + keywords + "%' ";

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
