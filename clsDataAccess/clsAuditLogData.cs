using clsDataAccess;
using clsLogger;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace clsDataAccessLayer
{
    public static class clsAuditLogData
    {
        /// <summary>
        /// دالة إضافة سجل جديد في جدول الـ AuditLogs عبر الـ Stored Procedure
        /// </summary>
        public static int AddNewLog(int userID, string actionType, string tableName, int? recordID, string actionDetails)
        {
            int newLogID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                // SP_AddAuditLog the name of Stored Procedure
                using (SqlCommand command = new SqlCommand("SP_AddAuditLog", connection))
                {
                    
                    command.CommandType = CommandType.StoredProcedure;

               
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@ActionType", actionType);
                    command.Parameters.AddWithValue("@TableName", (object)tableName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@RecordID", (object)recordID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ActionDetails", (object)actionDetails ?? DBNull.Value);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newLogID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsAuditLogData.AddNewLog", ex);
                        newLogID = -1;
                        throw;
                    }
                }
            }

            return newLogID;
        }

        /// <summary>
        /// دالة جلب السجلات والفلترة لشاشة الأدمن عبر الـ Stored Procedure
        /// </summary>
        public static List<clsAuditLogDTO> GetAuditLogsPaged(int? userID,string actionType,string tableName,DateTime? fromDate,DateTime? toDate,
              string searchText,int pageNumber,int pageSize,out int totalRecords)
        {
            List<clsAuditLogDTO> listLogs = new List<clsAuditLogDTO>();
            totalRecords = 0;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAuditLogs", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", (object)userID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ActionType", (object)actionType ?? DBNull.Value);
                    command.Parameters.AddWithValue("@TableName", (object)tableName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@FromDate", (object)fromDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ToDate", (object)toDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@SearchText", (object)searchText ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PageNumber", pageNumber);
                    command.Parameters.AddWithValue("@PageSize", pageSize);

                    SqlParameter totalParam = new SqlParameter("@TotalRecords", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(totalParam);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listLogs.Add(new clsAuditLogDTO
                                {
                                    LogID = (int)reader["LogID"],
                                    ActionDate = (DateTime)reader["ActionDate"],
                                    UserName = reader["UserName"].ToString(),
                                    FullName = reader["FullName"].ToString(),
                                    ActionType = reader["ActionType"].ToString(),
                                    TableName = reader["TableName"] != DBNull.Value ? reader["TableName"].ToString() : null,
                                    RecordID = reader["RecordID"] != DBNull.Value ? (int?)reader["RecordID"] : null,
                                    ActionDetails = reader["ActionDetails"] != DBNull.Value ? reader["ActionDetails"].ToString() : null,
                                    HostName = reader["HostName"] != DBNull.Value ? reader["HostName"].ToString() : null
                                });
                            }
                        }

                        if (totalParam.Value != DBNull.Value)
                        {
                            totalRecords = Convert.ToInt32(totalParam.Value);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsAuditLogData.GetAuditLogsPaged", ex);
                        throw;
                    }
                }
            }

            return listLogs;
        }

    }
}