using clsBusinessLayer;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gym
{
    public partial class ucLockerManagement : BaseUserControl
    {
        private BindingList<clsLockerDTO> _blLockers;

        private int _currentPage = 1;
        private readonly int _pageSize = 20; 
        private int _totalRecords = 0;
        private int _totalPages = 1;

        public ucLockerManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void _LoadData()
        {
            string searchText = txtSearch.TextValue.Trim();
            byte? statusID = null;

            if (cbFilterByStatus.SelectedIndex > 0)
            {
                string selectedStatus = cbFilterByStatus.SelectedItem.ToString();
                if (selectedStatus == "Available") statusID = 1;
                else if (selectedStatus == "Rented") statusID = 2;
                else if (selectedStatus == "Under Maintenance") statusID = 3;
            }

            var lockersList = clsLocker.GetPagedLockers(_currentPage, _pageSize, searchText, statusID, out _totalRecords);

            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            if (_totalPages == 0) _totalPages = 1;

            _blLockers = new BindingList<clsLockerDTO>(lockersList);
            dgvLockers.DataSource = _blLockers;

            _UpdatePagingUI();
            _ApplyGridCustomizations();
        }

        private void _UpdatePagingUI()
        {
            lblPageInfo.Text = $"Page {_currentPage} of {_totalPages} (Total: {_totalRecords})";
            btnPreviousPage.Enabled = (_currentPage > 1);
            btnNextPage.Enabled = (_currentPage < _totalPages);
        }

        private void _ApplyGridCustomizations()
        {
            if (dgvLockers.Rows.Count == 0) return;

            if (dgvLockers.Columns["LockerID"] != null)
                dgvLockers.Columns["LockerID"].Visible = false;

            dgvLockers.Columns["LockerNumber"].HeaderText = "Locker #";
            dgvLockers.Columns["StatusName"].HeaderText = "Status";
            dgvLockers.Columns["MemberFullName"].HeaderText = "Rented By";
            dgvLockers.Columns["EndDate"].HeaderText = "End Date";

            dgvLockers.AdjustGridHeight(13);
        }

        private void dgvLockers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLockers.CurrentRow == null) return;

            clsLockerDTO selectedLocker = (clsLockerDTO)dgvLockers.CurrentRow.DataBoundItem;

            if (selectedLocker.StatusID == 1) // Available
            {
                btnRent.Visible = true;
                btnMaintenance.Visible = true;
                btnMaintenance.Text = "Set Maintenance";

                btnTransfer.Visible = false;
                btnEndRental.Visible = false;
            }
            else if (selectedLocker.StatusID == 2) // Rented
            {
                btnMaintenance.Visible = false;
                btnRent.Visible = false;
                btnTransfer.Visible = true;
                btnEndRental.Visible = true;
            }
            else if (selectedLocker.StatusID == 3) // Under Maintenance
            {
                btnMaintenance.Visible = true;
                btnMaintenance.Text = "Set Available";

                btnRent.Visible = false;
                btnTransfer.Visible = false;
                btnEndRental.Visible = false;
            }
        }

        private void dgvLockers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvLockers.Columns[e.ColumnIndex].Name == "StatusName" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Available")
                {
                    e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.Font = new Font(dgvLockers.Font, FontStyle.Bold);
                }
                else if (status == "Rented")
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                    e.CellStyle.Font = new Font(dgvLockers.Font, FontStyle.Bold);
                }
                else if (status == "Under Maintenance")
                {
                    e.CellStyle.ForeColor = Color.DarkRed;
                    e.CellStyle.Font = new Font(dgvLockers.Font, FontStyle.Bold);
                }
            }
        }

        private void txtSearch_TextValueChanged()
        {
            _currentPage = 1;
            _LoadData();
        }

        private void sbFilterByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _LoadData();
        }

        private void ucLockerManagement_Load(object sender, EventArgs e)
        {
            cbFilterByStatus.SelectedIndex = 0;
            _LoadData();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                _LoadData();
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                _LoadData();
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (dgvLockers.CurrentRow == null) return;

            clsLockerDTO selectedLocker = (clsLockerDTO)dgvLockers.CurrentRow.DataBoundItem;
            frmRentLocker frm = new frmRentLocker(selectedLocker);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _LoadData();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (dgvLockers.CurrentRow == null) return;

            clsLockerDTO selectedLocker = (clsLockerDTO)dgvLockers.CurrentRow.DataBoundItem;
            frmTransferLocker frm = new frmTransferLocker(selectedLocker);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _LoadData();
            }
        }

        private void btnEndRental_Click(object sender, EventArgs e)
        {
            if (dgvLockers.CurrentRow == null) return;

            clsLockerDTO selectedLocker = (clsLockerDTO)dgvLockers.CurrentRow.DataBoundItem;

            if (selectedLocker.CurrentRentalID == null || selectedLocker.CurrentRentalID <= 0)
            {
                MessageBox.Show("This locker is not currently rented.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                $"Are you sure you want to end rental for Locker #{selectedLocker.LockerNumber} (Member: {selectedLocker.MemberFullName})?",
                "Confirm End Rental",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                int rentalID = selectedLocker.CurrentRentalID.Value;
                int lockerID = selectedLocker.LockerID;

                if (clsLocalRental.EndRental(rentalID, lockerID, out string errorMessage))
                {
                    MessageBox.Show($"Rental for Locker #{selectedLocker.LockerNumber} ended successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadData();
                }
                else
                {
                    MessageBox.Show($"Failed to end rental: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            if (dgvLockers.CurrentRow == null) return;

            clsLockerDTO selectedLocker = (clsLockerDTO)dgvLockers.CurrentRow.DataBoundItem;
            frmSetLockerMaintenance frm = new frmSetLockerMaintenance(selectedLocker);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _LoadData();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmBulkAddLockers frm = new frmBulkAddLockers();
            frm.Show();
            _LoadData();
        }
    }
}