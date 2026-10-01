using clsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class frmChangePassword : BaseForm
    {
        private bool _IsAdminChangingOther;
        private int _UserID;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _IsAdminChangingOther = true;
            txtCurrentPassword.Visible = false;
            
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        public frmChangePassword()
        {
            InitializeComponent();
            _UserID = clsCurrentUser.UserID;
            _IsAdminChangingOther = false;
            txtCurrentPassword.Visible = true;
            
            lblTitle.Text = "Changing My Password";
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            clsUser user = clsUser.GetUserInfoByID(_UserID);

            if (user != null)
            {
                txtFullName.TextValue = user.UserData.FullName;
            }
            else
            {
                MessageBox.Show("User data could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //ValidationConstraints.Visible this will check only on visible items incase there are unvisible items.
            if (!this.ValidateChildren(ValidationConstraints.Visible))
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // إذا كان المستخدم يغير لنفسه، يجب التحقق من صحة كلمة السر الحالية أولاً
            if (!_IsAdminChangingOther)
            {
                if (!clsUser.VerifyPassword(_UserID, txtCurrentPassword.TextValue))
                {
                    MessageBox.Show("Current Password is Incorrect.", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCurrentPassword.txtClear();
                    txtCurrentPassword.Focus();
                    return;
                }
            }

            try
            {
               
                bool success = clsUser.ChangePassword(_UserID, txtNewPassword.TextValue);

                if (success)
                {
                    // 📝 تسجيل عملية تغيير كلمة المرور
                    clsAuditLog.Log(
                        userID: clsCurrentUser.UserID,
                        actionType: "UPDATE",
                        tableName: "Users",
                        recordID: _UserID,             // ID المستخدم الذي تم تغيير كلمة مروره
                        actionDetails: $"Changed password for user (FullName) '{txtFullName.TextValue}'"
                    );

                    MessageBox.Show("Password Changed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CloseWithFadeOut(); 
                }
                else
                {
                    MessageBox.Show("Failed to change Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!txtCurrentPassword.Visible) return;

            if (string.IsNullOrWhiteSpace(txtCurrentPassword.TextValue))
            {
                errorProvider1.SetError(txtCurrentPassword, "Current Password is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, "");
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.TextValue))
            {
                errorProvider1.SetError(txtNewPassword, "New Password cannot be empty!");
                e.Cancel = true;
            }
            else if (txtNewPassword.TextValue.Contains(" "))
            {
                errorProvider1.SetError(txtNewPassword, "Password cannot contain spaces!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.TextValue))
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password cannot be empty!");
                e.Cancel = true;
            }
            else if (txtNewPassword.TextValue != txtConfirmPassword.TextValue)
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }
    }
}
