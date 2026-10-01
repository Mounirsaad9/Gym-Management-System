using clsBusinessLayer;
using Models;
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
    public partial class frmAddUser : BaseForm
    {

        public clsUserModel CreatedUser { get; private set; }

        public frmAddUser()
        {
            InitializeComponent();
            //this to let user fill any fields he wants first (e.g..,password before username)
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }  
       
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            cbRole.Items.Clear();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Employee");
            cbRole.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
      
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               
                clsUser user = new clsUser();
                user.UserData.UserName = txtUserName.TextValue.Trim();
                user.UserData.PasswordHash = txtPassword.TextValue; 
                user.UserData.FullName = txtFullName.TextValue.Trim();
                user.UserData.Role = cbRole.SelectedItem.ToString();

                user.UserData.IsActive = true;
                user.UserData.CreatedDate = DateTime.Now;

                if (user.Save())
                {
                    MessageBox.Show("User Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CreatedUser = user.UserData;

                    // 📝 تسجيل عملية إضافة مستخدم جديد
                    clsAuditLog.Log(
                        userID: clsCurrentUser.UserID,      
                        actionType: "INSERT",
                        tableName: "Users",
                        recordID: CreatedUser.UserID,            
                        actionDetails: $"Added new user '{CreatedUser.UserName}' (IsActive: {CreatedUser.IsActive})"
                    );

                    this.DialogResult = DialogResult.OK;
                    CloseWithFadeOut(); 
                }
                else
                {
                    MessageBox.Show("Failed to add user. Please review the inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.TextValue))
            {
                errorProvider1.SetError(txtUserName, "UserName cannot be empty!");
                e.Cancel = true;
            }
            else if (clsUser.IsUserNameExists(txtUserName.TextValue.Trim()))
            {
                errorProvider1.SetError(txtUserName, "UserName already exists!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.TextValue))
            {
                errorProvider1.SetError(txtConfirmPassword, "Please confirm your password!");
                e.Cancel = true;
            }
            else if (txtPassword.TextValue != txtConfirmPassword.TextValue)
            {
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.TextValue))
            {
                errorProvider1.SetError(txtFullName, "Full Name is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtFullName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.TextValue))
            {
                errorProvider1.SetError(txtPassword, "Password cannot be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }


    }
}
