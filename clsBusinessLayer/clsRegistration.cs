using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDataAccess;

namespace clsBusinessLayer
{
    public class clsRegistration
    {
        public static bool RegisterMemberWithMemberShip(string FirstName, string LastName, string Phone, DateTime DateOfBirth, byte Gendor, int PlanID, DateTime StartDate,
         DateTime EndDate, decimal Amount, string Notes, out int NewMemberID,out int NewMemberShipID)
        {
            NewMemberID = -1;

            
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                throw new ArgumentException("First name and last name are required and cannot be left empty.");

            if (string.IsNullOrWhiteSpace(Phone))
                throw new ArgumentException("Phone number is required for member registration.");

            int age = DateTime.Today.Year - DateOfBirth.Year;
            if (DateOfBirth.Date > DateTime.Today.AddYears(-age)) age--; 

            if (age < 12 || age > 80)
                throw new ArgumentException("Member's age must be between 12 and 80 years to register in the gym.");


            if (Amount <= 0)
                throw new ArgumentException("The paid amount must be greater than zero.");

            if (PlanID <= 0)
                throw new ArgumentException("A valid subscription plan must be selected.");


            return clsRegistrationData.RegisterMemberWithMemberShip(FirstName, LastName, Phone, DateOfBirth, Gendor, PlanID, StartDate, EndDate, Amount, Notes, out NewMemberID,out NewMemberShipID);
        }

        public static bool RenewMemberShipWithPayment(int ExistingMemberID, int OldMemberShipID, int PLanID, DateTime StartDate, DateTime EndDate, decimal Amount, string Notes, out int NewMemberShipID)
        {
            NewMemberShipID = -1;

           
            if (ExistingMemberID <= 0 || OldMemberShipID <= 0)
                throw new ArgumentException("Invalid member or old membership data for renewal.");

            
            if (EndDate <= StartDate)
                throw new ArgumentException("The new membership end date must be after the start date.");

            
            if (Amount <= 0)
                throw new ArgumentException("The renewal amount must be greater than zero.");

           
            return clsRegistrationData.RenewMemberShipWithPayment(ExistingMemberID, OldMemberShipID, PLanID, StartDate, EndDate, Amount, Notes, out NewMemberShipID);
        }

    }
}
