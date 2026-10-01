using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;
using clsLogger;
using DTOs; 

namespace clsDataAccess
{
    public class clsPaymentsData
    {
        
        public static int AddPayment(clsPaymentsModel payment)
        {
            int paymentID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"INSERT INTO Payments (MemberShipID, PaymentDate, Amount, Notes) 
                             VALUES (@MemberShipID, @PaymentDate, @Amount, @Notes);
                             SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberShipID", payment.MemberShipID);
                    command.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                    command.Parameters.AddWithValue("@Amount", payment.Amount);
                    command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(payment.Notes) ? (object)DBNull.Value : payment.Notes);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            paymentID = ID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsPaymentData.AddPayment", ex);
                        throw;
                    }
                }
            }
            return paymentID;
        }

        
        public static clsPaymentsModel GetPaymentInfoByID(int paymentID)
        {
            clsPaymentsModel payment = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT * FROM Payments WHERE PaymentID = @PaymentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", paymentID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                payment = new clsPaymentsModel
                                {
                                    PaymentID = paymentID,
                                    MemberShipID = (int)reader["MemberShipID"],
                                    PaymentDate = (DateTime)reader["PaymentDate"],
                                    Amount = (decimal)reader["Amount"],           
                                    Notes = reader["Notes"] == DBNull.Value ? "" : reader["Notes"].ToString()
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsPaymentData.GetPaymentInfoByID", ex);
                        throw;
                    }
                }
            }
            return payment;
        }

        
        public static bool UpdatePayment(clsPaymentsModel payment)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"UPDATE Payments SET Notes = @Notes WHERE PaymentID = @PaymentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", payment.PaymentID);
                    command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(payment.Notes) ? (object)DBNull.Value : payment.Notes);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsPaymentData.UpdatePayment", ex);
                        throw;
                    }
                }
            }
            return (rowsAffected > 0);
        }

       
        public static List<clsPaymentsModel> GetPaymentsByMemberShipID(int memberShipID)
        {
            List<clsPaymentsModel> list = new List<clsPaymentsModel>();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT * FROM Payments WHERE MemberShipID = @MemberShipID ORDER BY PaymentDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberShipID", memberShipID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new clsPaymentsModel
                                {
                                    PaymentID = (int)reader["PaymentID"],
                                    MemberShipID = (int)reader["MemberShipID"],
                                    PaymentDate = (DateTime)reader["PaymentDate"],
                                    Amount = (decimal)reader["Amount"],
                                    Notes = reader["Notes"] == DBNull.Value ? "" : reader["Notes"].ToString()
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsPaymentData.GetPaymentsByMemberShipID", ex);
                        throw;
                    }
                }
            }
            return list;
        }

       
        public static List<clsPaymentHistoryDTO> GetAllPaymentsByMemberID(int memberID)
        {
            List<clsPaymentHistoryDTO> historyList = new List<clsPaymentHistoryDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT 
                                p.PaymentID,
                                CONVERT(VARCHAR, p.PaymentDate, 103) AS PaymentDate,
                                p.Amount,
                                sp.PlanName,
                                p.Notes
                             FROM Payments p
                             INNER JOIN MemberShips ms ON p.MemberShipID = ms.MemberShipID
                             INNER JOIN SubscriptionPlans sp ON ms.PlanID = sp.PlanID
                             WHERE ms.MemberID = @MemberID
                             ORDER BY p.PaymentDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                historyList.Add(new clsPaymentHistoryDTO
                                {
                                    PaymentID = (int)reader["PaymentID"],
                                    PaymentDate = reader["PaymentDate"].ToString(),
                                    Amount = (decimal)reader["Amount"],
                                    PlanName = reader["PlanName"].ToString(),
                                    Notes = reader["Notes"] == DBNull.Value ? "" : reader["Notes"].ToString()
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsPaymentData.GetAllPaymentsByMemberID", ex);
                        throw;
                    }
                }
            }
            return historyList;
        }

    }
}
