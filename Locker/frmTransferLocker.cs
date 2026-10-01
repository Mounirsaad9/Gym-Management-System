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
    public partial class frmTransferLocker : BaseForm
    {
        public clsLockerDTO CurrentLockerDTO { get; private set; }
      

        private List<clsLockerDTO> _availableLockersList;

        public frmTransferLocker(clsLockerDTO LockerDTO)
        {
            InitializeComponent();
            CurrentLockerDTO = LockerDTO;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void _LoadData()
        {
            lblTitle.Text = $"Transfer Locker _ #{CurrentLockerDTO.LockerNumber}";
            lblCurrentLockerInfo.Text = $"Locker: #{CurrentLockerDTO.LockerNumber} \n" +
                $"Member: {CurrentLockerDTO.MemberFullName}";

            _availableLockersList = clsLocker.GetAllLockers().Where(l => l.StatusID == 1 && l.LockerID != CurrentLockerDTO.LockerID).ToList();

            if (_availableLockersList.Count == 0)
            {
                MessageBox.Show("No available lockers to transfer to!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnTransfer.Enabled = false;
                return;
            }

            cbAvailableLockers.DataSource = _availableLockersList;
            cbAvailableLockers.DisplayMember = "LockerNumber";
            cbAvailableLockers.ValueMember = "LockerID";
        }

        private void frmTransferLocker_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (CurrentLockerDTO.CurrentRentalID == null || CurrentLockerDTO.CurrentRentalID <= 0)
            {
                MessageBox.Show("This locker does not have an active rental to transfer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbAvailableLockers.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid new locker.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newLockerID = (int)cbAvailableLockers.SelectedValue;
            clsLockerDTO NewLockerDTO = (clsLockerDTO)cbAvailableLockers.SelectedItem;

            int currentRentalID = CurrentLockerDTO.CurrentRentalID.Value;
            int oldLockerID = CurrentLockerDTO.LockerID;
            
            if (clsLocalRental.TransferLocker(currentRentalID, oldLockerID, newLockerID, out string errorMessage))
            {
                MessageBox.Show($"Locker transferred successfully to #{NewLockerDTO.LockerNumber}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CurrentLockerDTO.StatusID = 1; 
                CurrentLockerDTO.StatusName = "Available";
                CurrentLockerDTO.CurrentRentalID = null;
                CurrentLockerDTO.MemberID = null;
                CurrentLockerDTO.MemberFullName = null;
                CurrentLockerDTO.EndDate = null;

                this.DialogResult = DialogResult.OK;
                CloseWithFadeOut();
            }
            else
            {
                MessageBox.Show($"Failed to transfer locker: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
