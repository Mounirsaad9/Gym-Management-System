using clsDataAccess;
using clsLogger;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GymDataAccess
{
    public static class clsLockerData
    {
        
        public static List<clsLockerDTO> GetAllLockers()
        {
            var lockersList = new List<clsLockerDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"
                    SELECT 
                        L.LockerID, 
                        L.LockerNumber, 
                        L.StatusID,
                        StatusName = CASE L.StatusID 
                                        WHEN 1 THEN 'Available' 
                                        WHEN 2 THEN 'Rented' 
                                        WHEN 3 THEN 'Under Maintenance' 
                                        ELSE 'Unknown' 
                                     END,
                        R.RentalID AS CurrentRentalID,
                        R.MemberID,
                        M.Name AS MemberFullName,
                        R.EndDate
                    FROM Lockers L
                    LEFT JOIN LockerRentals R ON L.LockerID = R.LockerID AND R.IsActive = 1
                    LEFT JOIN Members_View M ON R.MemberID = M.MemberID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lockersList.Add(new clsLockerDTO
                                {
                                    LockerID = (int)reader["LockerID"],
                                    LockerNumber = (string)reader["LockerNumber"],
                                    StatusID = (byte)reader["StatusID"],
                                    StatusName = (string)reader["StatusName"],
                                    CurrentRentalID = reader["CurrentRentalID"] != DBNull.Value ? (int?)reader["CurrentRentalID"] : null,
                                    MemberID = reader["MemberID"] != DBNull.Value ? (int?)reader["MemberID"] : null,
                                    MemberFullName = reader["MemberFullName"] != DBNull.Value ? reader["MemberFullName"].ToString() : null,
                                    EndDate = reader["EndDate"] != DBNull.Value ? (DateTime?)reader["EndDate"] : null
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerData.GetAllLockers", ex);
                        throw;
                    }
                }
            }

            return lockersList;
        }

        
        public static clsLockerDTO GetLockerByID(int lockerID)
        {
            clsLockerDTO locker = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"
                    SELECT 
                        L.LockerID, 
                        L.LockerNumber, 
                        L.StatusID,
                        StatusName = CASE L.StatusID 
                                        WHEN 1 THEN 'Available' 
                                        WHEN 2 THEN 'Rented' 
                                        WHEN 3 THEN 'Under Maintenance' 
                                        ELSE 'Unknown' 
                                     END,
                        R.RentalID AS CurrentRentalID,
                        R.MemberID,
                        M.Name AS MemberFullName,
                        R.EndDate
                    FROM Lockers L
                    LEFT JOIN LockerRentals R ON L.LockerID = R.LockerID AND R.IsActive = 1
                    LEFT JOIN Members_View M ON R.MemberID = M.MemberID
                    WHERE L.LockerID = @LockerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LockerID", lockerID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                locker = new clsLockerDTO
                                {
                                    LockerID = (int)reader["LockerID"],
                                    LockerNumber = (string)reader["LockerNumber"],
                                    StatusID = (byte)reader["StatusID"],
                                    StatusName = (string)reader["StatusName"],
                                    CurrentRentalID = reader["CurrentRentalID"] != DBNull.Value ? (int?)reader["CurrentRentalID"] : null,
                                    MemberID = reader["MemberID"] != DBNull.Value ? (int?)reader["MemberID"] : null,
                                    MemberFullName = reader["MemberFullName"] != DBNull.Value ? reader["MemberFullName"].ToString() : null,
                                    EndDate = reader["EndDate"] != DBNull.Value ? (DateTime?)reader["EndDate"] : null
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerData.GetLockerByID", ex);
                        throw;
                    }
                }
            }

            return locker;
        }

      
        public static bool UpdateLockerStatus(int lockerID, byte statusID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"UPDATE Lockers 
                                 SET StatusID = @StatusID 
                                 WHERE LockerID = @LockerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LockerID", lockerID);
                    command.Parameters.AddWithValue("@StatusID", statusID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerData.UpdateLockerStatus", ex);
                        throw;
                    }
                }
            }

            return (rowsAffected > 0);
        }


        public static int AddNewLocker(string lockerNumber)
        {
            int lockerID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"INSERT INTO Lockers (LockerNumber, StatusID) 
                                 VALUES (@LockerNumber, 1);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LockerNumber", lockerNumber);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            lockerID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerData.AddNewLocker", ex);
                        throw;
                    }
                }
            }

            return lockerID;
        }

       
        public static bool IsLockerExistByNumber(string lockerNumber)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = "SELECT Found=1 FROM Lockers WHERE LockerNumber = @LockerNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LockerNumber", lockerNumber);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerData.IsLockerExistByNumber", ex);
                        throw;
                    }
                }
            }

            return isFound;
        }


        public static List<clsLockerDTO> GetPagedLockers(int pageNumber, int pageSize, string searchText, byte? statusID, out int totalRecords)
        {
            var lockersList = new List<clsLockerDTO>();
            totalRecords = 0;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPagedLockers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PageNumber", pageNumber);
                    command.Parameters.AddWithValue("@PageSize", pageSize);
                    command.Parameters.AddWithValue("@SearchText", (object)searchText ?? DBNull.Value);
                    command.Parameters.AddWithValue("@StatusID", (object)statusID ?? DBNull.Value);

                    SqlParameter outputTotalParam = new SqlParameter("@TotalRecords", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputTotalParam);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lockersList.Add(new clsLockerDTO
                                {
                                    LockerID = (int)reader["LockerID"],
                                    LockerNumber = (string)reader["LockerNumber"],
                                    StatusID = (byte)reader["StatusID"],
                                    StatusName = (string)reader["StatusName"],
                                    CurrentRentalID = reader["CurrentRentalID"] != DBNull.Value ? (int?)reader["CurrentRentalID"] : null,
                                    MemberID = reader["MemberID"] != DBNull.Value ? (int?)reader["MemberID"] : null,
                                    MemberFullName = reader["MemberFullName"] != DBNull.Value ? reader["MemberFullName"].ToString() : null,
                                    EndDate = reader["EndDate"] != DBNull.Value ? (DateTime?)reader["EndDate"] : null
                                });
                            }
                        }

                        if (outputTotalParam.Value != DBNull.Value)
                        {
                            totalRecords = (int)outputTotalParam.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerData.GetPagedLockers", ex);
                        throw;
                    }
                }
            }

            return lockersList;
        }


        /// <summary>
        /// استدعاء الـ Stored Procedure لإضافة مجموعة خزائن تلقائياً
        /// </summary>
        public static int AddBulkLockers(int count, int startNumber, string prefix)
        {
            int insertedCount = 0;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddBulkLockers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Count", count);
                    command.Parameters.AddWithValue("@StartNumber", startNumber);

                    command.Parameters.AddWithValue("@Prefix", string.IsNullOrWhiteSpace(prefix) ? (object)DBNull.Value : prefix.Trim());

                    
                    SqlParameter insertedCountParam = new SqlParameter("@InsertedCount", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(insertedCountParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (insertedCountParam.Value != DBNull.Value)
                        {
                            insertedCount = Convert.ToInt32(insertedCountParam.Value);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerData.AddBulkLockers", ex);
                        throw;
                    }
                }
            }

            return insertedCount;
        }

        public static string GetHighestLockerNumber()
        {
            string highestLockerNumber = string.Empty;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
             
                string query = "SELECT TOP 1 LockerNumber FROM dbo.Lockers ORDER BY LockerID DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            highestLockerNumber = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsLockerData.GetHighestLockerNumber", ex);
                        throw;
                    }
                }
            }

            return highestLockerNumber;
        }

    }
}