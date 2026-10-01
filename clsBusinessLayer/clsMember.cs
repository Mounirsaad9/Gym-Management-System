using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using clsDataAccess;
using Models;
using DTOs;

namespace clsBusinessLayer
{
    public class clsMember
    {
        public enum enSaveResult
        {
            Success = 0,
            Failed = 1,
            ValidationError = 2
        }

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        private clsMemberModel _Member = new clsMemberModel();

        public clsMemberModel MemberData
        {
            get { return _Member; }
        }

        public string FullName
        {
            get { return _Member.FirstName + " " + _Member.LastName; }
        }
 
        public clsMember()
        {
            _Member.MemberID = -1;
            _Member.FirstName = "";
            _Member.LastName = "";
            _Member.Phone = "";
            _Member.DateOfBirth = DateTime.Now;
            _Member.CreatedDate = DateTime.Now;
            _Mode = enMode.AddNew;
        }

        
        public clsMember(clsMemberModel member)
        {
            _Member = member;
            _Mode = enMode.Update;
        }


        private bool _Validate()
        {
            if (string.IsNullOrWhiteSpace(_Member.FirstName) || string.IsNullOrWhiteSpace(_Member.LastName))
                return false;

            if (string.IsNullOrWhiteSpace(_Member.Phone) || _Member.Phone.Length < 7)
                return false;

            // شرط للنادي: ألا يقل عمر المشترك عن 12 عاماً مثلاً
            if (DateTime.Now.Year - _Member.DateOfBirth.Year < 12)
                return false;

            return true;
        }


        private bool _AddNewMember()
        {
       
            _Member.MemberID = clsMemberData.AddMember(_Member);
            return (_Member.MemberID != -1);
        }

        private bool _UpdateMember()
        {
        
            return clsMemberData.UpdateMember(_Member);
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
                    if (_AddNewMember())
                    {
                        _Mode = enMode.Update;
                        return enSaveResult.Success;
                    }
                    else
                    {
                        return enSaveResult.Failed;
                    }

                case enMode.Update:
                    return _UpdateMember() ? enSaveResult.Success : enSaveResult.Failed;
            }

            return enSaveResult.Failed;
        }

        public static clsMember FindByID(int MemberID)
        {
            clsMemberModel memberModel = clsMemberData.GetMemberInfoByID(MemberID);

            if (memberModel != null)
            {
                return new clsMember(memberModel);
            }

            return null;
        }

        public static List<clsMemberDTO> GetAllMembers()
        {
            return clsMemberData.GetAllMembers();
        }

        public static clsMemberDTO GetMemberDTOByID(int memberID)
        {
            return clsMemberData.GetMemberDTOByID(memberID);
        }
    }
}