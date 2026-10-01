using clsDataAccess;
using DTOs;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace clsBusinessLayer
{
    public class clsMemberShip
    {
        public enum enSaveResult
        {
            Success = 0,
            Failed = 1,
            ValidationError = 2
        }

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        private clsMemberShipModel _MemberShip = new clsMemberShipModel();

        public clsMemberShipModel MemberShipData
        {
            get { return _MemberShip; }
        }

       
        public clsMemberShip()
        {
            _Mode = enMode.AddNew;
        }

        
        private clsMemberShip(clsMemberShipModel memberShipModel)
        {
            _MemberShip = memberShipModel;
            _Mode = enMode.Update;
        }

        
        private bool _Validate()
        {
            
            if (_MemberShip.MemberID <= 0 || _MemberShip.PlanID <= 0)
                return false;

           
            if (_MemberShip.EndDate <= _MemberShip.StartDate)
                return false;

            return true;
        }

        private bool _AddNewMemberShip()
        {
            // تحديث حالة النشاط تلقائياً بناءً على التاريخ الحالي وتاريخ النهاية
            _MemberShip.IsActive = (DateTime.Now <= _MemberShip.EndDate);

            
            _MemberShip.MemberShipID = clsMemberShipData.AddMemberShip(_MemberShip);

            return (_MemberShip.MemberShipID != -1);
        }

        private bool _UpdateMemberShip()
        {
           
            return clsMemberShipData.UpdateMemberShip(_MemberShip);
        }

        public enSaveResult Save()
        {
   
            if (!_Validate())
            {
                return enSaveResult.ValidationError;
            }

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMemberShip())
                    {
                        _Mode = enMode.Update; 
                        return enSaveResult.Success;
                    }
                    return enSaveResult.Failed;

                case enMode.Update:
                    return _UpdateMemberShip() ? enSaveResult.Success : enSaveResult.Failed;
            }

            return enSaveResult.Failed;
        }

        
        public static clsMemberShip FindByID(int memberShipID)
        {
            clsMemberShipModel memberShipModel = clsMemberShipData.GetMemberShipInfoByID(memberShipID);

            if (memberShipModel != null)
            {
                
                return new clsMemberShip(memberShipModel);
            }
            return null;
        }

        public static clsMemberShipModel GetLastMemberShipByMemberID(int memberID)
        {
            return clsMemberShipData.GetLastMemberShipByMemberID(memberID);
        }

        
        public static List<clsMembershipHistoryDTO> GetAllMemberShipsByMemberID(int memberID)
        {
            return clsMemberShipData.GetAllMemberShipsByMemberID(memberID);
        }


        public static BindingList<clsMembershipAlertDTO> GetExpiringMemberships(int daysThreshold)
        {
          return  clsMemberShipData.GetExpiringAndExpiredMemberships(daysThreshold);
            
        }
    }
}
