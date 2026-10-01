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
    public partial class frmLogin : BaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //this to let the user see the password that he inputs
            ucTextBoxPassword.UsePasswordChar = !chkShowPassword.Checked;
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners();
            this.BackColor = Color.FromArgb(21,30,39);

        }

        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ucTextBoxUserName.TextValue) || string.IsNullOrWhiteSpace(ucTextBoxPassword.TextValue))
            {
                lblError.Text = "Please Enter UserName and Password";
                lblError.Visible = true;
                return;
            }

            clsUser LogedInUser = clsUser.Login(ucTextBoxUserName.TextValue.Trim(), ucTextBoxPassword.TextValue);

            if (LogedInUser == null)
            {
                lblError.Text = "Invalid UserName/Password";
                lblError.Visible = true;

                return;
            }

            clsCurrentUser.UserID = LogedInUser.UserData.UserID;
            clsCurrentUser.UserName = LogedInUser.UserData.UserName;
            clsCurrentUser.FullName = LogedInUser.UserData.FullName;
            clsCurrentUser.Role = LogedInUser.UserData.Role;

            // 2. 📝 تسجيل حركة تسجيل الدخول بنجاح في الـ Audit Log
            clsAuditLog.Log(
                userID: clsCurrentUser.UserID,
                actionType: "LOGIN",
                tableName: "Users",
                recordID: clsCurrentUser.UserID,
                actionDetails: $"User '{clsCurrentUser.UserName}' logged into the system successfully"
            );
            this.DialogResult = DialogResult.OK;
            CloseWithFadeOut();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void ucTextBoxUserName_TextValueChanged()
        {
            if (lblError.Visible)
                lblError.Visible = false;
        }
    }
}
