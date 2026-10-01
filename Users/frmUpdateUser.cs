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
    public partial class frmUpdateUser : BaseForm
    {

        private readonly clsUserModel _CurrentUser;

        public frmUpdateUser(clsUserModel userModel)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            // التحقق من أن الكائن ليس فارغاً لمنع أي خطأ
            _CurrentUser = userModel ?? throw new ArgumentNullException(nameof(userModel));
        }

        private void _DisplayMemberAvatar(string fullName)
        {
          
            PanelAvatar.Width = 90;
            PanelAvatar.Height = 90;
            PanelAvatar.BorderRadius = 45;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                lblAvatar.Text = "??";
                return;
            }

            string[] nameParts = fullName.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string initials = "";

            //the first nameParts[0] menas first word and the second [0] in the same line means the first letter
            if (nameParts.Length > 0)
                initials += nameParts[0][0]; // الحرف الأول من الاسم الأول


            // (nameParts.Length > 1) means if the nameParts has more than two words get the last one 
            //[nameParts.Length - 1] calculates the position of the last word
            if (nameParts.Length > 1)
                initials += nameParts[nameParts.Length - 1][0]; // الحرف الأول من الاسم الأخير

            lblAvatar.Text = !string.IsNullOrEmpty(initials) ? initials.ToUpper() : "??";
        }

        private void _LoadUserData()
        {
        
            lblUserID.Text = _CurrentUser.UserID.ToString();
            lblUserName.Text = _CurrentUser.UserName;
            txtFullName.TextValue = _CurrentUser.FullName;
            cbRole.SelectedItem = _CurrentUser.Role;

            chkIsActive.Checked = _CurrentUser.IsActive;
            _UpdateActiveLabelStatus(_CurrentUser.IsActive);

            _DisplayMemberAvatar(_CurrentUser.FullName);
        }

        private void _UpdateActiveLabelStatus(bool isActive)
        {
            if (isActive)
            {
                lblActive.Text = "Active";
                lblActive.ForeColor = Color.LimeGreen; 
            }
            else
            {
                lblActive.Text = "Inactive";
                lblActive.ForeColor = Color.Crimson; 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a Role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            clsUser user = new clsUser(_CurrentUser.UserID, txtFullName.TextValue.Trim(), cbRole.SelectedItem.ToString(), chkIsActive.Checked);

            if (user.Save())
            {
           
                _CurrentUser.FullName = txtFullName.TextValue.Trim();
                _CurrentUser.Role = cbRole.SelectedItem.ToString();
                _CurrentUser.IsActive = chkIsActive.Checked;

                MessageBox.Show("User Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 📝 تسجيل عملية تعديل بيانات مستخدم
                clsAuditLog.Log(
                    userID: clsCurrentUser.UserID,
                    actionType: "UPDATE",
                    tableName: "Users",
                    recordID: _CurrentUser.UserID,           
                    actionDetails: $"Updated user profile and permissions for '{_CurrentUser.UserName}'"
                );


                this.DialogResult = DialogResult.OK;
                this.CloseWithFadeOut();
            }
            else
            {
                MessageBox.Show("An error occurred while saving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.TextValue))
            {
                errorProvider1.SetError(txtFullName, "Full Name is required.");
                e.Cancel = true;
            }
         
            else
            {
                errorProvider1.SetError(txtFullName, "");
            }
        }
        
        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _UpdateActiveLabelStatus(chkIsActive.Checked);
        }

        private void _FillRoleComboBox()
        {
            cbRole.Items.Clear();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Employee");
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            _FillRoleComboBox();
            _LoadUserData();   
            
        }
    }
}
