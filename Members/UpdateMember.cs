using clsBusinessLayer;
using DTOs;
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
    public partial class UpdateMember : BaseForm
    {
        private clsMember _MemberBusiness;
        private clsMemberShip _MembershipBusiness;

        private readonly clsMemberDTO _CurrentMemberDTO;

        private byte _SelectedGendor = 0;

        public UpdateMember(clsMemberDTO memberDTO)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            // التحقق من أن الكائن ليس فارغاً لمنع خطأ NullReferenceException
            _CurrentMemberDTO = memberDTO ?? throw new ArgumentNullException(nameof(memberDTO));
        }

        private void _DisplayMemberAvatar(string firstName, string lastName)
        {

            PanelAvatar.Width = 90;
            PanelAvatar.Height = 90;
            PanelAvatar.BorderRadius = 45;

            string initials = "";

            if (!string.IsNullOrWhiteSpace(firstName))
                initials += firstName[0];

            if (!string.IsNullOrWhiteSpace(lastName))
                initials += lastName[0];

            lblAvatar.Text = initials.ToUpper();
        }

        private void _LoadMemberData()
        {
            _MemberBusiness =  clsMember.FindByID(_CurrentMemberDTO.MemberID);

            if (_MemberBusiness == null)
            {
                MessageBox.Show("Member Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblMemberID.Text = _MemberBusiness.MemberData.MemberID.ToString();
            txtFirstName.TextValue = _MemberBusiness.MemberData.FirstName;
            txtLastName.TextValue = _MemberBusiness.MemberData.LastName;
            txtPhone.TextValue = _MemberBusiness.MemberData.Phone;
            dtpDateOfBirth.Value = _MemberBusiness.MemberData.DateOfBirth;


            _SelectedGendor = _MemberBusiness.MemberData.Gendor;
            _UpdateGendorButtonsUI();
            _DisplayMemberAvatar(txtFirstName.TextValue, txtLastName.TextValue);
        }

        private void _LoadMembershipData()
        {

            _MembershipBusiness = clsMemberShip.FindByID(_CurrentMemberDTO.MemberShipID);

            if (_MembershipBusiness == null)
            {
                MessageBox.Show("Membership data not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string planName = clsSubscriptionPlans.GetPlanNameByID(_MembershipBusiness.MemberShipData.PlanID);
            lblPLan.Text = planName;


            dtpEndDate.Value = _MembershipBusiness.MemberShipData.EndDate;

            if (_MembershipBusiness.MemberShipData.EndDate.Date < DateTime.Now.Date)
            {
                customToggleSwitch1.Checked = false; 
                _UpdateStatusLabel("Expired");       
            }

            else
            {

                if (_MembershipBusiness.MemberShipData.IsActive)
                {
                    customToggleSwitch1.Checked = true;
                    _UpdateStatusLabel("Active");
                }
                else
                {
                    customToggleSwitch1.Checked = false;
                    _UpdateStatusLabel("Frozen");
                }
                
            }
            
        }

        private void _UpdateGendorButtonsUI()
        {
            if (_SelectedGendor == 0) 
            {
                btnMale.FillColor = Color.CornflowerBlue;
                btnMale.FillColor2 = Color.SlateBlue;

                btnFemale.FillColor = Color.FromArgb(45, 52, 71);
                btnFemale.FillColor2 = Color.FromArgb(45, 52, 71);

            }
            else 
            {
                btnMale.FillColor = Color.FromArgb(45, 52, 71);
                btnMale.FillColor2 = Color.FromArgb(45, 52, 71);

                btnFemale.FillColor = Color.CornflowerBlue;
                btnFemale.FillColor2 = Color.SlateBlue;
            }
        }

        private void customToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

            if (customToggleSwitch1.Checked)
            {
               
                if (dtpEndDate.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Cannot activate this membership because the end date has already expired.\nPlease renew the membership instead.",
                        "Activation Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    customToggleSwitch1.Checked = false; 
                    _UpdateStatusLabel("Expired");
                }
                else
                {
                    _UpdateStatusLabel("Active");
                }
            }
            else
            {

                if (dtpEndDate.Value.Date >= DateTime.Now.Date)
                {
                    _UpdateStatusLabel("Frozen");
                }
                else
                {
                    _UpdateStatusLabel("Expired");
                }
            }
        }

        private void _UpdateStatusLabel(string status)
        {
            lblStatusText.Text = status;

            switch (status)
            {
                case "Active":
                    lblStatusText.ForeColor = Color.LightGray;   
                    break;

                case "Frozen":
                    lblStatusText.ForeColor = Color.Orange;    
                    break;

                case "Expired":
                case "Inactive":
                    lblStatusText.ForeColor = Color.Crimson;  
                    break;

                default:
                    lblStatusText.ForeColor = Color.LightGreen;
                    break;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.TextValue.Trim()))
            {
                errorProvider1.SetError(txtFirstName, "This field is required!");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.TextValue.Trim()))
            {
                errorProvider1.SetError(txtLastName, "This field is required!");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.TextValue.Trim()))
            {
                errorProvider1.SetError(txtPhone, "This field is required!");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
 
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                _MemberBusiness.MemberData.FirstName = txtFirstName.TextValue.Trim();
                _MemberBusiness.MemberData.LastName = txtLastName.TextValue.Trim();
                _MemberBusiness.MemberData.Phone = txtPhone.TextValue.Trim();
                _MemberBusiness.MemberData.DateOfBirth = dtpDateOfBirth.Value;
                _MemberBusiness.MemberData.Gendor = _SelectedGendor;

                clsMember.enSaveResult memberResult = _MemberBusiness.Save();


                _MembershipBusiness.MemberShipData.IsActive = customToggleSwitch1.Checked;
                clsMemberShip.enSaveResult membershipResult = _MembershipBusiness.Save();
                

                if (memberResult == clsMember.enSaveResult.Success && membershipResult == clsMemberShip.enSaveResult.Success)
                {

                    _CurrentMemberDTO.MemberID = _MemberBusiness.MemberData.MemberID;
                    _CurrentMemberDTO.MemberShipID = _MembershipBusiness.MemberShipData.MemberShipID;
                    _CurrentMemberDTO.Name = (txtFirstName.TextValue.Trim() + " " + txtLastName.TextValue.Trim()).Trim();
                    _CurrentMemberDTO.Phone = txtPhone.TextValue.Trim();
                    _CurrentMemberDTO.DateOfBirth = dtpDateOfBirth.Value;
                    _CurrentMemberDTO.Gendor = (_SelectedGendor == 0) ? "Male" : "Female";


                    if (!customToggleSwitch1.Checked)
                    {
                        _CurrentMemberDTO.IsActive = "Frozen";
                    }
                    else
                    {
                        _CurrentMemberDTO.IsActive = (dtpEndDate.Value.Date >= DateTime.Now.Date) ? "Active" : "Expired";
                    }

                    // 📝 تسجيل حركة التعديل في الـ Audit Log
                    clsAuditLog.Log(
                        userID: clsCurrentUser.UserID,
                        actionType: "UPDATE",
                        tableName: "Members",
                        recordID: _CurrentMemberDTO.MemberID,
                        actionDetails: $"Updated member details for '{_CurrentMemberDTO.Name}' (Status: {_CurrentMemberDTO.IsActive})"
                    );

                    MessageBox.Show("Member info and Membership status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    CloseWithFadeOut();
                }
                else
                {
                    MessageBox.Show("Failed to save updates into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {
            _LoadMemberData();
            _LoadMembershipData();

            dtpEndDate.Enabled = false;
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            _SelectedGendor = 0;
            _UpdateGendorButtonsUI();
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            _SelectedGendor = 1;
            _UpdateGendorButtonsUI();
        }
    }
}
