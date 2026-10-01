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
    public partial class frmSetLockerMaintenance : BaseForm
    {
        public clsLockerDTO CurrentLockerDTO { get; private set; }

        public frmSetLockerMaintenance(clsLockerDTO LockerDTO)
        {
            InitializeComponent();
            CurrentLockerDTO = LockerDTO;
        }

        private void frmSetLockerMaintenance_Load(object sender, EventArgs e)
        {
            lblLockerNumber.Text = $"Locker #{CurrentLockerDTO.LockerNumber}";
            lblCurrentStatus.Text = $"Current Status: {CurrentLockerDTO.StatusName}";


            if (CurrentLockerDTO.StatusID == 2) // 2 = Rented
            {
                lblWarning.Text = "Warning: This locker is currently rented. You must end the rental first.";
                btnSetMaintenance.Enabled = false;
            }
            else if (CurrentLockerDTO.StatusID == 3) // 3 = Maintenance
            {
                btnSetMaintenance.Text = "Set as Available";
            }
            else
            {
                btnSetMaintenance.Text = "Set to Maintenance";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void btnSetMaintenance_Click(object sender, EventArgs e)
        {
            if (CurrentLockerDTO.StatusID == 3)//Miantenance
            {
                if (clsLocker.SetAvailable(CurrentLockerDTO.LockerID))
                {
                    MessageBox.Show("Locker is now Available!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    CurrentLockerDTO.StatusID = 1;
                    CurrentLockerDTO.StatusName = "Available";
                    this.DialogResult = DialogResult.OK;
                    CloseWithFadeOut();
                }
                else
                {
                    MessageBox.Show("Failed to set locker as available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            {
                if (clsLocker.SetUnderMaintenance(CurrentLockerDTO.LockerID, out string errorMessage))
                {
                    MessageBox.Show("Locker set to Maintenance successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    CurrentLockerDTO.StatusID = 3;
                    CurrentLockerDTO.StatusName = "Under Maintenance";
                    this.DialogResult = DialogResult.OK;
                    CloseWithFadeOut();
                }
                else
                {
                    
                    MessageBox.Show(errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


    }
}
