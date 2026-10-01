using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using clsDataAccess;
using System.Data;
using System.ComponentModel;

namespace clsBusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        private clsUserModel _User = new clsUserModel();

        public clsUserModel UserData
        {
            get { return _User; }
        }

        public clsUser()
        {
            _Mode = enMode.AddNew;
        }

        public clsUser(int UserID, string FullName, string Role, bool IsActive)
        {
            _User.UserID = UserID;
            _User.FullName = FullName;
            _User.Role = Role;
            _User.IsActive = IsActive;
            _Mode = enMode.Update;
        }

        public static clsUser Login(string UserName, string Password)
        {
            clsUserModel user = clsUserData.Login(UserName, Password);
            if (user != null)
            {
                clsUser LoggedInUser = new clsUser();
                LoggedInUser._User = user;
                LoggedInUser._Mode = enMode.Update; // تم تعيين النمط لـ Update لأن المستخدم موجود بالفعل
                return LoggedInUser;
            }
            return null;
        }
      
        public static List<clsUserModel> GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        private bool _AddUser()
        {
            
            _User.UserID = clsUserData.AddUser(_User.UserName, _User.PasswordHash, _User.FullName, _User.Role);
            return (_User.UserID != -1);
        }

        public static bool IsUserNameExists(string userName)
        {
            return clsUserData.IsUserNameExists(userName);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(_User.UserID, _User.FullName, _User.Role, _User.IsActive);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            return clsUserData.ChangePassword(UserID, NewPassword);
        }

        public static clsUser GetUserInfoByID(int UserID)
        {
            clsUserModel user = clsUserData.GetUserInfoByID(UserID);

            if (user != null)
            {
                clsUser foundUser = new clsUser();
                foundUser._User = user;
                foundUser._Mode = enMode.Update;
                return foundUser;
            }
            return null;
        }

        public static bool VerifyPassword(int userID, string password)
        {
            return clsUserData.VerifyPassword(userID, password);
        }
    }
}
