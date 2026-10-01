using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using clsDataAccess;
using System.Data;
using DTOs;

namespace clsBusinessLayer
{
    public class clsPayment
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        private clsPaymentsModel _Payment = new clsPaymentsModel();

        public clsPaymentsModel Payment
        {
            get { return _Payment; }
        }

        
        public clsPayment()
        {
            _Mode = enMode.AddNew;
            
            _Payment.PaymentID = -1;
            _Payment.PaymentDate = DateTime.Now;
            _Payment.Amount = 0;
            _Payment.Notes = "";
        }

        
        private clsPayment(clsPaymentsModel paymentModel)
        {
            _Payment = paymentModel;
            _Mode = enMode.Update;
        }

       
        public static clsPayment FindByID(int paymentID)
        {
            
            clsPaymentsModel paymentModel = clsPaymentsData.GetPaymentInfoByID(paymentID);

            if (paymentModel != null)
            {
                
                return new clsPayment(paymentModel);
            }

            return null; 
        }

        
        private bool _AddNewPayment()
        {
            _Payment.PaymentID = clsPaymentsData.AddPayment(_Payment);
            return (_Payment.PaymentID != -1);
        }

        private bool _UpdatePayment()
        {
            return clsPaymentsData.UpdatePayment(_Payment);
        }

        
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    return _AddNewPayment();

                case enMode.Update:
                    return _UpdatePayment();
            }
            return false;
        }

     
        public static List<clsPaymentsModel> GetPaymentsByMemberShip(int memberShipID)
        {
            return clsPaymentsData.GetPaymentsByMemberShipID(memberShipID);
        }

     
        public static List<clsPaymentHistoryDTO> GetAllPaymentsByMemberID(int memberID)
        {
            return clsPaymentsData.GetAllPaymentsByMemberID(memberID);
        }
    }
}
