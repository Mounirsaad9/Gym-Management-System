using clsDataAccessLayer;
using DTOs;
using System;
using System.Collections.Generic;

namespace clsBusinessLayer
{
    public static class clsAuditLog
    {

        public static bool Log(int userID, string actionType, string tableName = null, int? recordID = null, string actionDetails = null)
        {
            if (userID <= 0)
                return false;

            int newLogID = clsAuditLogData.AddNewLog(userID, actionType, tableName, recordID, actionDetails);
            return (newLogID > 0);
        }

        public static bool Log(string actionType, string tableName = null, int? recordID = null, string actionDetails = null)
        {
            return Log(clsCurrentUser.UserID, actionType, tableName, recordID, actionDetails);
        }

        public static List<clsAuditLogDTO> GetAuditLogsPaged(int? userID,string actionType,string tableName,DateTime? fromDate,DateTime? toDate,
            string searchText,int pageNumber,int pageSize,out int totalRecords)
        {
            return clsAuditLogData.GetAuditLogsPaged(userID, actionType, tableName, fromDate, toDate, searchText, pageNumber, pageSize, out totalRecords);
        }
    }
}