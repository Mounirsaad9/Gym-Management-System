using clsDataAccess;
using clsLogger;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GymDataAccess
{
    public static class clsLockerRentalData
    {
        
        public static int RentLocker(clsLockerRentalDTO rentalDTO)
        {
            int newRentalID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // أ. إضافة سجل التأجير
                    string insertQuery = @"
                        INSERT INTO LockerRentals 
                        (LockerID, MemberID, StartDate, EndDate, RentalDays, TotalAmount, IsActive, Notes, CreatedByUserID)
                        VALUES 
                        (@LockerID, @MemberID, @StartDate, @EndDate, @RentalDays, @TotalAmount, 1, @Notes, @CreatedByUserID);
                        SELECT SCOPE_IDENTITY();";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                    {
                        insertCommand.Parameters.AddWithValue("@LockerID", rentalDTO.LockerID);
                        insertCommand.Parameters.AddWithValue("@MemberID", rentalDTO.MemberID);
                        insertCommand.Parameters.AddWithValue("@StartDate", rentalDTO.StartDate);
                        insertCommand.Parameters.AddWithValue("@EndDate", rentalDTO.EndDate);
                        insertCommand.Parameters.AddWithValue("@RentalDays", rentalDTO.RentalDays);
                        insertCommand.Parameters.AddWithValue("@TotalAmount", rentalDTO.TotalAmount);
                        insertCommand.Parameters.AddWithValue("@Notes", (object)rentalDTO.Notes ?? DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@CreatedByUserID", rentalDTO.CreatedByUserID);

                        object result = insertCommand.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newRentalID = insertedID;
                        }
                    }

                    // ب. تحديث حالة الخزانة لتصبح Rented (2)
                    string updateLockerQuery = "UPDATE Lockers SET StatusID = 2 WHERE LockerID = @LockerID";
                    using (SqlCommand updateCommand = new SqlCommand(updateLockerQuery, connection, transaction))
                    {
                        updateCommand.Parameters.AddWithValue("@LockerID", rentalDTO.LockerID);
                        updateCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    clsLog.LogError("clsLockerRentalData.RentLocker", ex);
                    throw;
                }
            }

            return newRentalID;
        }

        
        public static bool EndRental(int rentalID, int lockerID)
        {
            bool isSuccess = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // أ. جعل العقد غير فعال
                    string updateRentalQuery = "UPDATE LockerRentals SET IsActive = 0 WHERE RentalID = @RentalID";
                    using (SqlCommand rentalCmd = new SqlCommand(updateRentalQuery, connection, transaction))
                    {
                        rentalCmd.Parameters.AddWithValue("@RentalID", rentalID);
                        rentalCmd.ExecuteNonQuery();
                    }

                    // ب. إرجاع حالة الخزانة إلى Available (1)
                    string updateLockerQuery = "UPDATE Lockers SET StatusID = 1 WHERE LockerID = @LockerID";
                    using (SqlCommand lockerCmd = new SqlCommand(updateLockerQuery, connection, transaction))
                    {
                        lockerCmd.Parameters.AddWithValue("@LockerID", lockerID);
                        lockerCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    clsLog.LogError("clsLockerRentalData.EndRental", ex);
                    throw;
                }
            }

            return isSuccess;
        }

       
        public static bool TransferLocker(int rentalID, int oldLockerID, int newLockerID)
        {
            bool isSuccess = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // أ. تحديث رقم الخزانة في العقد
                    string updateRentalQuery = "UPDATE LockerRentals SET LockerID = @NewLockerID WHERE RentalID = @RentalID";
                    using (SqlCommand cmd1 = new SqlCommand(updateRentalQuery, connection, transaction))
                    {
                        cmd1.Parameters.AddWithValue("@NewLockerID", newLockerID);
                        cmd1.Parameters.AddWithValue("@RentalID", rentalID);
                        cmd1.ExecuteNonQuery();
                    }

                    // ب. تحرير الخزانة القديمة (Available = 1)
                    string freeOldLockerQuery = "UPDATE Lockers SET StatusID = 1 WHERE LockerID = @OldLockerID";
                    using (SqlCommand cmd2 = new SqlCommand(freeOldLockerQuery, connection, transaction))
                    {
                        cmd2.Parameters.AddWithValue("@OldLockerID", oldLockerID);
                        cmd2.ExecuteNonQuery();
                    }

                    // ج. حجز الخزانة الجديدة (Rented = 2)
                    string lockNewLockerQuery = "UPDATE Lockers SET StatusID = 2 WHERE LockerID = @NewLockerID";
                    using (SqlCommand cmd3 = new SqlCommand(lockNewLockerQuery, connection, transaction))
                    {
                        cmd3.Parameters.AddWithValue("@NewLockerID", newLockerID);
                        cmd3.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    clsLog.LogError("clsLockerRentalData.TransferLocker", ex);
                    throw;
                }
            }

            return isSuccess;
        }

        
        public static clsLockerRentalDTO GetActiveRentalByMemberID(int memberID)
        {
            clsLockerRentalDTO rental = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"
                    SELECT 
                        R.RentalID, R.LockerID, L.LockerNumber, R.MemberID, 
                        M.FullName AS MemberFullName, R.StartDate, R.EndDate, 
                        R.RentalDays, R.TotalAmount, R.IsActive, R.Notes, 
                        R.CreatedByUserID, U.UserName AS CreatedByUserName, R.CreatedDate
                    FROM LockerRentals R
                    INNER JOIN Lockers L ON R.LockerID = L.LockerID
                    INNER JOIN Members_View M ON R.MemberID = M.MemberID
                    INNER JOIN Users U ON R.CreatedByUserID = U.UserID
                    WHERE R.MemberID = @MemberID AND R.IsActive = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                rental = new clsLockerRentalDTO
                                {
                                    RentalID = (int)reader["RentalID"],
                                    LockerID = (int)reader["LockerID"],
                                    LockerNumber = (string)reader["LockerNumber"],
                                    MemberID = (int)reader["MemberID"],
                                    MemberFullName = (string)reader["MemberFullName"],
                                    StartDate = (DateTime)reader["StartDate"],
                                    EndDate = (DateTime)reader["EndDate"],
                                    RentalDays = (int)reader["RentalDays"],
                                    TotalAmount = (decimal)reader["TotalAmount"],
                                    IsActive = (bool)reader["IsActive"],
                                    Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : null,
                                    CreatedByUserID = (int)reader["CreatedByUserID"],
                                    CreatedByUserName = (string)reader["CreatedByUserName"],
                                    CreatedDate = (DateTime)reader["CreatedDate"]
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerRentalData.GetActiveRentalByMemberID", ex);
                        throw;
                    }
                }
            }

            return rental;
        }

        
        public static List<clsLockerRentalDTO> GetRentalHistoryByMemberID(int memberID)
        {
            var historyList = new List<clsLockerRentalDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"
                    SELECT 
                        R.RentalID, R.LockerID, L.LockerNumber, R.MemberID, 
                        M.FullName AS MemberFullName, R.StartDate, R.EndDate, 
                        R.RentalDays, R.TotalAmount, R.IsActive, R.Notes, 
                        R.CreatedByUserID, U.UserName AS CreatedByUserName, R.CreatedDate
                    FROM LockerRentals R
                    INNER JOIN Lockers L ON R.LockerID = L.LockerID
                    INNER JOIN Members_View M ON R.MemberID = M.MemberID
                    INNER JOIN Users U ON R.CreatedByUserID = U.UserID
                    WHERE R.MemberID = @MemberID
                    ORDER BY R.RentalID DESC";

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
                                historyList.Add(new clsLockerRentalDTO
                                {
                                    RentalID = (int)reader["RentalID"],
                                    LockerID = (int)reader["LockerID"],
                                    LockerNumber = (string)reader["LockerNumber"],
                                    MemberID = (int)reader["MemberID"],
                                    MemberFullName = (string)reader["MemberFullName"],
                                    StartDate = (DateTime)reader["StartDate"],
                                    EndDate = (DateTime)reader["EndDate"],
                                    RentalDays = (int)reader["RentalDays"],
                                    TotalAmount = (decimal)reader["TotalAmount"],
                                    IsActive = (bool)reader["IsActive"],
                                    Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : null,
                                    CreatedByUserID = (int)reader["CreatedByUserID"],
                                    CreatedByUserName = (string)reader["CreatedByUserName"],
                                    CreatedDate = (DateTime)reader["CreatedDate"]
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerRentalData.GetRentalHistoryByMemberID", ex);
                        throw;
                    }
                }
            }

            return historyList;
        }
    }
}