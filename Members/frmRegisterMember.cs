using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using clsBusinessLayer;
using DTOs;

namespace Gym
{
    public partial class frmRegisterMember : BaseForm
    {
        private List<clsSubscriptionPlansModel> _Plans;
        private DateTime _CalculateEndDate;

        public clsMemberDTO SavedMember { get; private set; }

        
        private byte _selectedGender = 0;
        public frmRegisterMember()
        {
            InitializeComponent();
            // This to allow user to fill any field he wants first 
            // For Example Last Name before First Name
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

        }

        private void frmRegisterMember_Load(object sender, EventArgs e)
        {

            _Plans = clsSubscriptionPlans.GetAllSubscriptionPlans();

            cbPlan.DisplayMember = "PlanName";
            cbPlan.ValueMember = "PlanID";
            cbPlan.DataSource = _Plans;

            txtStartDate.TextValue = DateTime.Now.ToShortDateString();

            UpdateButtonGenderStyles();
        }

        private void UpdateButtonGenderStyles()
        {
            
            if (_selectedGender == 0) 
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

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlan.SelectedValue == null || _Plans == null) return;

            int planID = Convert.ToInt32(cbPlan.SelectedValue);

            clsSubscriptionPlansModel selectedPlan = _Plans.FirstOrDefault(p => p.PlanID == planID);

            if (selectedPlan != null)
            {
           
                int durationDays = selectedPlan.DurationDays;
                decimal price = selectedPlan.Price;

                DateTime endDate = DateTime.Now.AddDays(durationDays);
                _CalculateEndDate = endDate;
                txtEndDate.TextValue = endDate.ToShortDateString();

                txtAmount.TextValue = price.ToString("0.00");
            }
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            _selectedGender = 0;
            UpdateButtonGenderStyles();
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            _selectedGender = 1;
            UpdateButtonGenderStyles();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.TextValue))
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
            if (string.IsNullOrWhiteSpace(txtLastName.TextValue))
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
            if (string.IsNullOrWhiteSpace(txtPhone.TextValue))
            {
                errorProvider1.SetError(txtPhone, "This field is required!");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.TextValue))
            {
                errorProvider1.SetError(txtAmount, "This field is required");
                e.Cancel = true;
            }

            else if (!decimal.TryParse(txtAmount.TextValue, out decimal amount) || amount <= 0)
            {
                errorProvider1.SetError(txtAmount, "Amont must be a positive number!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAmount, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some fields are not valid! Hover over the red icon(s) to view the error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int age = DateTime.Now.Year - dtpDateOfBirth.Value.Year;
                if (dtpDateOfBirth.Value > DateTime.Now || age > 80 || age < 12)
                {
                    MessageBox.Show("Please enter a valid Date of Birth.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int planID = Convert.ToInt32(cbPlan.SelectedValue);
                DateTime startDate = DateTime.Now;
                DateTime endDate = _CalculateEndDate;
                decimal amount = Convert.ToDecimal(txtAmount.TextValue);
                int newMemberID;
                int newMemberShipID;

                bool success = clsRegistration.RegisterMemberWithMemberShip(
                    txtFirstName.TextValue.Trim(),
                    txtLastName.TextValue.Trim(),
                    txtPhone.TextValue.Trim(),
                    dtpDateOfBirth.Value,
                    _selectedGender,
                    planID,
                    startDate,
                    endDate,
                    amount,
                    txtNotes.TextValue.Trim(),
                    out newMemberID, out newMemberShipID);

                if (success)
                {

                    SavedMember = new clsMemberDTO
                    {
                        MemberID = newMemberID,
                        Name = (txtFirstName.TextValue.Trim() + " " + txtLastName.TextValue.Trim()).Trim(),
                        Phone = txtPhone.TextValue.Trim(),
                        DateOfBirth = dtpDateOfBirth.Value,

                        Gendor = (_selectedGender == 0) ? "Male" : "Female",

                        MemberShipID = newMemberShipID,
                        StartDate = startDate,
                        EndDate = endDate,

                        PlanName = cbPlan.Text,
                        IsActive = "Active"
                    };

                    // 📝 تسجيل الحركة في الـ Audit Log
                    clsAuditLog.Log(
                        userID: clsCurrentUser.UserID,
                        actionType: "INSERT",
                        tableName: "Members",
                        recordID: newMemberID,
                        actionDetails: $"Registered new member '{SavedMember.Name}' with Plan '{cbPlan.Text}' (Membership ID: {newMemberShipID})"
                    );

                    MessageBox.Show("Member Registered Successfully with ID: " + newMemberID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    CloseWithFadeOut();
                }
                else
                {
                    MessageBox.Show("Failed to register the member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Catch الأولى: للإمساك بالأخطاء الموجهة من طبقة الـ Business وعرضها كتحذير واضحة
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Catch الثانية: لأي خطأ غير متوقع على مستوى النظام وقاعدة البيانات
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected system error occurred in {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
    }
}