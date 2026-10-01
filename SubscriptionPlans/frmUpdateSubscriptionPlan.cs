using clsBusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gym
{
    public partial class frmUpdateSubscriptionPlan : BaseForm
    {

        private readonly clsSubscriptionPlansModel _Plan;
      
        public frmUpdateSubscriptionPlan(clsSubscriptionPlansModel plan)
        {
            InitializeComponent();
            _Plan = plan;

        }

        private void frmUpdateSubscriptionPlan_Load(object sender, EventArgs e)
        {
            if (_Plan == null)
            {
                MessageBox.Show("Plan data is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPlanID.Text = _Plan.PlanID.ToString();
            txtPlanName.TextValue = _Plan.PlanName;
            txtDurationDays.TextValue = _Plan.DurationDays.ToString();
            txtPrice.TextValue = _Plan.Price.ToString();

            txtPrice.Focus();


        }

        private void btnCanncel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            CloseWithFadeOut();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateUIInputs())
                return;

            try
            {
  
                _Plan.PlanName = txtPlanName.TextValue.Trim();
                _Plan.DurationDays = int.Parse(txtDurationDays.TextValue);
                _Plan.Price = decimal.Parse(txtPrice.TextValue);

         
                clsSubscriptionPlans businessPlan = new clsSubscriptionPlans();
                businessPlan.MemberPlan.PlanID = _Plan.PlanID;
                businessPlan.MemberPlan.PlanName = _Plan.PlanName;
                businessPlan.MemberPlan.DurationDays = _Plan.DurationDays;
                businessPlan.MemberPlan.Price = _Plan.Price;

                clsSubscriptionPlans.enSaveResult result = businessPlan.UpdatePlan();

                switch (result)
                {
                    case clsSubscriptionPlans.enSaveResult.Success:
                        MessageBox.Show("Plan Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 📝 تسجيل عملية تعديل الخطة في الـ Audit Log
                        clsAuditLog.Log(
                            userID: clsCurrentUser.UserID,
                            actionType: "UPDATE",
                            tableName: "SubscriptionPlans",
                            recordID: _Plan.PlanID,
                            actionDetails: $"Updated subscription plan '{_Plan.PlanName}' (Duration: {_Plan.DurationDays} days, Price: ${_Plan.Price})"
                        );

                        this.DialogResult = DialogResult.OK; 
                        this.Close();
                        break;

                    case clsSubscriptionPlans.enSaveResult.InvalidName:
                        errorProvider1.SetError(txtPlanName, "Plan name cannot be empty.");
                        txtPlanName.Focus();
                        break;

                    case clsSubscriptionPlans.enSaveResult.InvalidDuration:
                        errorProvider1.SetError(txtDurationDays, "Duration must be greater than 0 days.");
                        txtDurationDays.Focus();
                        break;

                    case clsSubscriptionPlans.enSaveResult.InvalidPrice:
                        errorProvider1.SetError(txtPrice, "Price cannot be a negative value.");
                        txtPrice.Focus();
                        break;

                    case clsSubscriptionPlans.enSaveResult.Failed:
                        MessageBox.Show("Failed to update plan in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateUIInputs()
        {
            bool isValid = true;
            errorProvider1.Clear(); 

       
            if (string.IsNullOrWhiteSpace(txtPlanName.TextValue))
            {
                errorProvider1.SetError(txtPlanName, "Plan name is required.");
                isValid = false;
            }

            if (!int.TryParse(txtDurationDays.TextValue, out int days) || days <= 0)
            {
                errorProvider1.SetError(txtDurationDays, "Please enter a valid number of days (> 0).");
                isValid = false;
            }

     
            if (!decimal.TryParse(txtPrice.TextValue, out decimal price) || price < 0)
            {
                errorProvider1.SetError(txtPrice, "Please enter a valid price (>= 0).");
                isValid = false;
            }

            return isValid;
        }
    }



}

