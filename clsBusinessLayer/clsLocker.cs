using clsDataAccessLayer;
using DTOs;
using GymDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace clsBusinessLayer
{
    public class clsLocker
    {

        public static List<clsLockerDTO> GetAllLockers()
        {
            return clsLockerData.GetAllLockers();
        }

        public static clsLockerDTO GetLockerByID(int lockerID)
        {
            if (lockerID <= 0) return null;
            return clsLockerData.GetLockerByID(lockerID);
        }

        public static bool SetUnderMaintenance(int lockerID, out string errorMessage)
        {
            errorMessage = string.Empty;

            clsLockerDTO locker = GetLockerByID(lockerID);
            if (locker == null)
            {
                errorMessage = "Locker not found.";
                return false;
            }

            if (locker.StatusID == 2)
            {
                errorMessage = "Cannot set locker to maintenance because it is currently rented. Please end the rental or transfer the member first.";
                return false;
            }

            return clsLockerData.UpdateLockerStatus(lockerID, 3);
        }

        public static bool SetAvailable(int lockerID)
        {
            return clsLockerData.UpdateLockerStatus(lockerID, 1);
        }

        public static bool AddNewLocker(string lockerNumber, out int newLockerID, out string errorMessage)
        {
            newLockerID = -1;
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(lockerNumber))
            {
                errorMessage = "Locker number cannot be empty.";
                return false;
            }

            if (clsLockerData.IsLockerExistByNumber(lockerNumber.Trim()))
            {
                errorMessage = "Locker number already exists in the system.";
                return false;
            }

            newLockerID = clsLockerData.AddNewLocker(lockerNumber.Trim());
            return (newLockerID > 0);
        }

        public static List<clsLockerDTO> GetPagedLockers(int pageNumber, int pageSize, string searchText, byte? statusID, out int totalRecords)
        {
            return clsLockerData.GetPagedLockers(pageNumber, pageSize, searchText, statusID, out totalRecords);
        }

        public static int AddBulkLockers(int count, int startNumber, string prefix = null)
        {
            
            if (count <= 0 || startNumber <= 0)
            {
                return 0;
            }

            
            return clsLockerData.AddBulkLockers(count, startNumber, prefix);
        }

        public static string GetHighestLockerNumber()
        {
            return clsLockerData.GetHighestLockerNumber();
        }

        public static int GetNextLockerNumber(string prefix = null)
        {
            string highestLocker = GetHighestLockerNumber();

            if (string.IsNullOrEmpty(highestLocker))
            {
                return 1; 
            }

            // استخراج الأرقام فقط من نص الخزنة باستخدام Regex
            Match match = Regex.Match(highestLocker, @"\d+");

            if (match.Success && int.TryParse(match.Value, out int lastNumber))
            {
                return lastNumber + 1;
            }

            return 1;
        }

    }
}
