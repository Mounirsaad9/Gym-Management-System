using clsBusinessLayer;
using DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gym
{
    public partial class frmRentLocker : BaseForm
    {
        public clsLockerDTO LockerDTO { get; private set; }
        private List<clsMemberDTO> _memberInfoList;

        private int? _selectedMemberID = null;
        private clsMemberDTO _selectedMemberDTO = null;
        private decimal _calculatedAmount = 0;
        private int _rentalDaysCount = 0;

        public frmRentLocker(clsLockerDTO locker)
        {
            InitializeComponent();
            LockerDTO = locker;
        }

        private void frmRentLocker_Load(object sender, EventArgs e)
        {
            _memberInfoList = clsMember.GetAllMembers();
            _ResetDefaultValues();
        }

        private void _ResetDefaultValues()
        {
            lblLockerNumber.Text = LockerDTO.LockerNumber;
            dtpStartDate.Value = DateTime.Now;

            txtDays.TextValue = "1";
            txtMonths.TextValue = "1";

            chkType.Checked = false;
            _UpdatePeriodVisibility();

            _ClearMemberCard();
        }

        private void _ClearMemberCard()
        {
            _selectedMemberID = null;
            _selectedMemberDTO = null;

            lblMemberID.Text = "?";
            lblMemberName.Text = "?";
            lblMemberPhone.Text = "?";
            lblMemberShipStatus.Text = "?";
            lblEnd.Text = "?";
            lblMemberShipStatus.ForeColor = Color.White;
        }

        private void _UpdatePeriodVisibility()
        {
            if (!chkType.Checked)
            {
                txtDays.Visible = true;
                txtMonths.Visible = false;
                lblType.Text = "Daily";
            }
            else
            {
                txtDays.Visible = false;
                txtMonths.Visible = true;
                lblType.Text = "Monthly";
            }
            _CalculateRentalAmount();
        }

        private void _CalculateRentalAmount()
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime calculatedEndDate;

            if (chkType.Checked) // Monthly
            {
                int.TryParse(txtMonths.TextValue, out int months);
                if (months < 1) months = 1;
                if (months > 12) months = 12;

                calculatedEndDate = startDate.AddMonths(months);
                _rentalDaysCount = (calculatedEndDate - startDate).Days;
                _calculatedAmount = clsLocalRental.CalculatePackageRentalAmount(months);
            }
            else // Daily
            {
                int.TryParse(txtDays.TextValue, out int days);
                if (days < 1) days = 1;
                //if (days > 30) days = 30;

                calculatedEndDate = startDate.AddDays(days);
                _rentalDaysCount = days;
                _calculatedAmount = clsLocalRental.CalculateDailyRentalAmount(days);
            }

            lblEndDate.Text = calculatedEndDate.ToString("yyyy-MM-dd");
            lblTotalFees.Text = _calculatedAmount.ToString("C2");
        }

        private void chkType_CheckedChanged(object sender, EventArgs e)
        {
            _UpdatePeriodVisibility();
        }

        private void txtSearchMember_TextValueChanged()
        {
            string searchText = txtSearchMember.TextValue.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                _ClearMemberCard();
                return;
            }

            bool isNumeric = int.TryParse(searchText, out int memberID);

            clsMemberDTO foundMember = _memberInfoList.FirstOrDefault(m =>
            (isNumeric && m.MemberID == memberID) ||
            (!string.IsNullOrEmpty(m.Name) && m.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (!string.IsNullOrEmpty(m.Phone) && m.Phone.Contains(searchText)));

            if (foundMember == null)
            {
                _ClearMemberCard();
                return;
            }

            _DisplayMemberDetails(foundMember);
        }

        private void _DisplayMemberDetails(clsMemberDTO member)
        {
            _selectedMemberID = member.MemberID;
            _selectedMemberDTO = member;

            lblMemberID.Text = member.MemberID.ToString();
            lblMemberName.Text = member.Name;
            lblMemberPhone.Text = member.Phone;
            lblEnd.Text = member.EndDate.ToShortDateString();

            bool isActive = string.Equals(member.IsActive, "Active", StringComparison.OrdinalIgnoreCase);
            lblMemberShipStatus.Text = member.IsActive;
            lblMemberShipStatus.ForeColor = isActive ? Color.MediumSeaGreen : Color.IndianRed;
        }

        private void txtDays_TextValueChanged()
        {
            _CalculateRentalAmount();
        }

        private void txtMonths_TextValueChanged()
        {
            _CalculateRentalAmount();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            _CalculateRentalAmount();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (_selectedMemberID == null)
            {
                MessageBox.Show("Please select a valid member first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = DateTime.Parse(lblEndDate.Text);

          
            clsLockerRentalDTO newRental = new clsLockerRentalDTO
            {
                LockerID = LockerDTO.LockerID,
                MemberID = _selectedMemberID.Value,
                StartDate = startDate,
                EndDate = endDate,
                RentalDays = _rentalDaysCount,
                TotalAmount = _calculatedAmount,
                IsActive = true,
                Notes = "",
                CreatedByUserID = clsCurrentUser.UserID
            };

            if (clsLocalRental.RentLocker(newRental, out int newRentalID, out string errorMessage))
            {
                MessageBox.Show("Locker rented successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                LockerDTO.StatusID = 2; // Rented
                LockerDTO.StatusName = "Rented";
                LockerDTO.CurrentRentalID = newRentalID;
                LockerDTO.MemberID = _selectedMemberID;
                LockerDTO.MemberFullName = _selectedMemberDTO != null ? _selectedMemberDTO.Name : "";
                LockerDTO.EndDate = endDate;

                this.DialogResult = DialogResult.OK;
                CloseWithFadeOut();
            }
            else
            {
                MessageBox.Show($"Failed to rent locker: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }
    }
}