using DTOs;
using GymDataAccess;
using System;
using System.Collections.Generic;

namespace clsBusinessLayer
{
    public class clsLocalRental
    {
        public static bool RentLocker(clsLockerRentalDTO rentalDTO, out int newRentalID, out string errorMessage)
        {
            newRentalID = -1;
            errorMessage = string.Empty;

            if (rentalDTO == null)
            {
                errorMessage = "Rental data is incomplete.";
                return false;
            }

            if (rentalDTO.EndDate <= rentalDTO.StartDate)
            {
                errorMessage = "End date must be after start date.";
                return false;
            }

            //if (rentalDTO.EndDate.Date > memberMembershipEndDate.Date)
            //{
            //    errorMessage = $"Locker rental end date ({rentalDTO.EndDate:yyyy-MM-dd}) cannot exceed member subscription end date ({memberMembershipEndDate:yyyy-MM-dd}).";
            //    return false;
            //}

            clsLockerDTO locker = clsLockerData.GetLockerByID(rentalDTO.LockerID);
            if (locker == null)
            {
                errorMessage = "Selected locker does not exist.";
                return false;
            }

            if (locker.StatusID != 1)
            {
                errorMessage = $"Locker number ({locker.LockerNumber}) is not available for rent.";
                return false;
            }

            newRentalID = clsLockerRentalData.RentLocker(rentalDTO);
            return (newRentalID > 0);
        }

        public static bool EndRental(int rentalID, int lockerID, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (rentalID <= 0 || lockerID <= 0)
            {
                errorMessage = "Invalid operation parameters.";
                return false;
            }

            return clsLockerRentalData.EndRental(rentalID, lockerID);
        }

        public static bool TransferLocker(int currentRentalID, int oldLockerID, int newLockerID, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (oldLockerID == newLockerID)
            {
                errorMessage = "Please select a different locker from the current one.";
                return false;
            }

            clsLockerDTO newLocker = clsLockerData.GetLockerByID(newLockerID);
            if (newLocker == null || newLocker.StatusID != 1)
            {
                errorMessage = "Selected new locker is not available.";
                return false;
            }

            return clsLockerRentalData.TransferLocker(currentRentalID, oldLockerID, newLockerID);
        }

        public static clsLockerRentalDTO GetActiveRentalByMemberID(int memberID)
        {
            if (memberID <= 0) return null;
            return clsLockerRentalData.GetActiveRentalByMemberID(memberID);
        }

        public static List<clsLockerRentalDTO> GetRentalHistoryByMemberID(int memberID)
        {
            if (memberID <= 0) return new List<clsLockerRentalDTO>();
            return clsLockerRentalData.GetRentalHistoryByMemberID(memberID);
        }

        public static decimal CalculateDailyRentalAmount(int Days)
        {
            if (Days <= 0) return 0;
            decimal DailyRate = 0.20m;
            return Days * DailyRate;
        }

        public static decimal CalculatePackageRentalAmount(int numberOfMonths)
        {
            if (numberOfMonths <= 0) return 0;
            decimal monthlyRate = 4m;
            return numberOfMonths * monthlyRate;
        }
        
        public static decimal CalculateAutoRentalAmount(DateTime startDate, DateTime endDate, decimal dailyRate, decimal monthlyRate)
        {
            int totalDays = (endDate.Date - startDate.Date).Days;
            if (totalDays <= 0) totalDays = 1;

            
            if (totalDays < 30)
            {
                return totalDays * dailyRate;
            }
            else
            {
                
                int fullMonths = totalDays / 30;
                int remainingDays = totalDays % 30;

                return (fullMonths * monthlyRate) + (remainingDays * dailyRate);
            }
        }

    }
}
