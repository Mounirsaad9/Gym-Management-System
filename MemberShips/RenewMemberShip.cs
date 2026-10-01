using clsBusinessLayer;
using DTOs;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gym
{
    public partial class RenewMemberShip : BaseForm
    {
        private readonly clsMemberDTO _CurrentMemberDTO;

        private DateTime _NewStartDate;
        private DateTime _CalculateEndDate;

        private List<clsSubscriptionPlansModel> _Plans;
        private decimal _PlanPrice;

        public RenewMemberShip(int memberID)
        {
            InitializeComponent();

            clsMember memberBusiness = clsMember.FindByID(memberID);

            if (memberBusiness == null)
            {
                MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _CurrentMemberDTO = new clsMemberDTO
            {
                MemberID = memberBusiness.MemberData.MemberID,
                Name = memberBusiness.FullName,
                Phone = memberBusiness.MemberData.Phone,
                Gendor = memberBusiness.MemberData.Gendor == 0 ? "Male" : "Female",
                DateOfBirth = memberBusiness.MemberData.DateOfBirth,
            };

            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        public RenewMemberShip(clsMemberDTO memberDTO)
        {
            InitializeComponent();
            _CurrentMemberDTO = memberDTO ?? throw new ArgumentNullException(nameof(memberDTO));
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
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

        private void RenewMemberShip_Load(object sender, EventArgs e)
        {
            try
            {
                clsMemberShipModel lastMemberShip = clsMemberShip.GetLastMemberShipByMemberID(_CurrentMemberDTO.MemberID);
                if (lastMemberShip == null)
                {
                    MessageBox.Show("Could not find previous membership details for this member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // for frmMemberShipAlerts 
                _CurrentMemberDTO.MemberShipID = lastMemberShip.MemberShipID;

                DateTime currentEndDate = lastMemberShip.EndDate;
                int daysRemaining = (currentEndDate.Date - DateTime.Now.Date).Days;

                if (daysRemaining >= 10)
                {
                    DialogResult result = MessageBox.Show(
                        $"This member still has {daysRemaining} days remaining in their current subscription.\n\nAre you sure you want to renew the membership now?",
                        "Confirm Early Renewal",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        this.Close();
                        return;
                    }
                }

                _NewStartDate = (currentEndDate > DateTime.Now) ? currentEndDate : DateTime.Now;

                txtMemberShipID.TextValue = lastMemberShip.MemberShipID.ToString();
                txtStartDate.TextValue = _NewStartDate.ToShortDateString();

                _LoadPersonData();
                _LoadSubscriptionPlans();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading membership information.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void _LoadPersonData()
        {
            lblName.Text = _CurrentMemberDTO.Name;
            lblMemberID.Text = _CurrentMemberDTO.MemberID.ToString();

            // استخراج الاسم الأول والأخير لإنشاء الأفاتار
            string[] nameParts = _CurrentMemberDTO.Name?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstName = nameParts != null && nameParts.Length > 0 ? nameParts[0] : "";
            string lastName = nameParts != null && nameParts.Length > 1 ? nameParts[nameParts.Length - 1] : "";

            _DisplayMemberAvatar(firstName, lastName);
        }

        private void _LoadSubscriptionPlans()
        {
            _Plans = clsSubscriptionPlans.GetAllSubscriptionPlans();
            cbPlan.DisplayMember = "PlanName";
            cbPlan.ValueMember = "PlanID";
            cbPlan.DataSource = _Plans;
        }

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlan.SelectedValue == null || _Plans == null) return;
            if (!int.TryParse(cbPlan.SelectedValue.ToString(), out int planID)) return;

            clsSubscriptionPlansModel selectedPlan = _Plans.FirstOrDefault(p => p.PlanID == planID);

            if (selectedPlan != null)
            {
                int durationDays = selectedPlan.DurationDays;
                _PlanPrice = selectedPlan.Price;

                _CalculateEndDate = _NewStartDate.AddDays(durationDays);

                txtEndDate.TextValue = _CalculateEndDate.ToShortDateString();
                txtAmount.TextValue = _PlanPrice.ToString("0.00");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Hover over the red icon(s) to view the error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtAmount.TextValue, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amount < (_PlanPrice * 0.5m))
            {
                DialogResult result = MessageBox.Show("The entered amount is significantly lower than the plan price.\nDo you want to continue anyway?", "Confirm Discount",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel) return;
            }

            try
            {
                int planID = Convert.ToInt32(cbPlan.SelectedValue);
                int newMemberShipID;

                bool success = clsRegistration.RenewMemberShipWithPayment(
                    _CurrentMemberDTO.MemberID,
                    _CurrentMemberDTO.MemberShipID,
                    planID,
                    _NewStartDate,
                    _CalculateEndDate,
                    amount,
                    txtNotes.TextValue.Trim(),
                    out newMemberShipID);

                if (success)
                {
                    _CurrentMemberDTO.MemberID = _CurrentMemberDTO.MemberID;
                    _CurrentMemberDTO.MemberShipID = newMemberShipID;

                    _CurrentMemberDTO.StartDate = _NewStartDate;
                    _CurrentMemberDTO.EndDate = _CalculateEndDate;
                    _CurrentMemberDTO.PlanName = cbPlan.Text;
                    _CurrentMemberDTO.IsActive = "Active";

                    _CurrentMemberDTO.Name = _CurrentMemberDTO.Name;
                    _CurrentMemberDTO.Phone = _CurrentMemberDTO.Phone;
                    _CurrentMemberDTO.DateOfBirth = _CurrentMemberDTO.DateOfBirth;
                    _CurrentMemberDTO.Gendor = _CurrentMemberDTO.Gendor;

                    // 📝 تسجيل حركة التجديد في الـ Audit Log
                    clsAuditLog.Log(
                        userID: clsCurrentUser.UserID,
                        actionType: "UPDATE",
                        tableName: "Subscriptions",
                        recordID: _CurrentMemberDTO.MemberID,
                        actionDetails: $"Renewed membership for '{_CurrentMemberDTO.Name}' with Plan '{cbPlan.Text}' ($ {amount}) (New Membership ID: {newMemberShipID})"
                    );

                    MessageBox.Show("Membership Renewed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    CloseWithFadeOut();
                }
                else
                {
                    MessageBox.Show("Failed to renew the membership.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected system error occurred. Please contact your administrator.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.TextValue))
            {
                errorProvider1.SetError(txtAmount, "Amount is required.");
                e.Cancel = true;
            }
            else if (!decimal.TryParse(txtAmount.TextValue, out decimal amount) || amount <= 0)
            {
                errorProvider1.SetError(txtAmount, "Amount must be a positive number!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAmount, "");
            }
        }
    }
}