using clsBusinessLayer;
using DTOs;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gym
{
    public partial class ucAuditLogs : BaseUserControl
    {
        private int _currentPage = 1;
        private int _pageSize = 20;
        private int _totalRecords = 0;
        private int _totalPages = 1;

        public ucAuditLogs()
        {
            InitializeComponent();
        }

        private void ucAuditLogs_Load(object sender, EventArgs e)
        {
            _FillComboBoxes();
            _ResetFilters();
            _LoadData();
        }

        private void _FillComboBoxes()
        {
            cbActionTypes.Items.Clear();
            cbActionTypes.Items.AddRange(new string[] { "All", "INSERT", "UPDATE", "DELETE", "LOGIN" ,"BACKUP","RESTORE" });

            cbTables.Items.Clear();
            cbTables.Items.AddRange(new string[] { "All", "Members", "Subscriptions", "Payments", "Products", "Users","Database" });

            List<clsUserModel> usersList = clsUser.GetAllUsers();
            if (usersList == null) usersList = new List<clsUserModel>();
            usersList.Insert(0, new clsUserModel { UserID = -1, UserName = "All" });

            cbUsers.DataSource = usersList;
            cbUsers.DisplayMember = "UserName";
            cbUsers.ValueMember = "UserID";
        }

        private void _ResetFilters()
        {
            cbActionTypes.SelectedIndex = 0;
            cbTables.SelectedIndex = 0;
            if (cbUsers.Items.Count > 0) cbUsers.SelectedIndex = 0;

            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;
            txtSearch.txtClear();

            _currentPage = 1;
        }

        private void _LoadData()
        {
            int? selectedUserID = null;
            if (cbUsers.SelectedValue != null && int.TryParse(cbUsers.SelectedValue.ToString(), out int uID) && uID > 0)
                selectedUserID = uID;

            string selectedAction = (cbActionTypes.Text != "All" && !string.IsNullOrEmpty(cbActionTypes.Text)) ? cbActionTypes.Text : null;
            string selectedTable = (cbTables.Text != "All" && !string.IsNullOrEmpty(cbTables.Text)) ? cbTables.Text : null;

            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1);
            string searchText = txtSearch.TextValue.Trim();

            var pagedLogs = clsAuditLog.GetAuditLogsPaged(
                selectedUserID,
                selectedAction,
                selectedTable,
                fromDate,
                toDate,
                searchText,
                _currentPage,
                _pageSize,
                out _totalRecords);

            dgvAuditLogs.DataSource = pagedLogs;
            _FormatGridColumns();
            _UpdatePagingControls();
        }

        private void _UpdatePagingControls()
        {
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            if (_totalPages == 0) _totalPages = 1;

            lblPageInfo.Text = $"Page {_currentPage} of {_totalPages} (Total: {_totalRecords})";

            btnPreviousPage.Enabled = (_currentPage > 1);
            btnNextPage.Enabled = (_currentPage < _totalPages);
        }

        private void _FormatGridColumns()
        {
            if (dgvAuditLogs.Columns.Count == 0) return;

            if (dgvAuditLogs.Columns["LogID"] != null) dgvAuditLogs.Columns["LogID"].Visible = false;
            if (dgvAuditLogs.Columns["ActionDate"] != null) dgvAuditLogs.Columns["ActionDate"].HeaderText = "Date & Time";
            if (dgvAuditLogs.Columns["UserName"] != null) dgvAuditLogs.Columns["UserName"].HeaderText = "User Name";
            if (dgvAuditLogs.Columns["ActionType"] != null) dgvAuditLogs.Columns["ActionType"].HeaderText = "Action Type";
            if (dgvAuditLogs.Columns["TableName"] != null) dgvAuditLogs.Columns["TableName"].HeaderText = "Table Name";
            if (dgvAuditLogs.Columns["RecordID"] != null) dgvAuditLogs.Columns["RecordID"].HeaderText = "Record ID";
            if (dgvAuditLogs.Columns["ActionDetails"] != null) dgvAuditLogs.Columns["ActionDetails"].HeaderText = "Action Details";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                _LoadData();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                _LoadData();
            }
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e) 
        {
            _currentPage = 1; 
            _LoadData();
        }

        private void cbActionTypes_SelectedIndexChanged(object sender, EventArgs e) 
        { 
            _currentPage = 1; 
            _LoadData(); 
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e) 
        { 
            _currentPage = 1; 
            _LoadData(); 
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e) 
        { 
            _currentPage = 1;
            _LoadData(); 
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e) 
        { 
            _currentPage = 1; 
            _LoadData(); 
        }

        private void txtSearch_TextValueChanged()
        {
            _currentPage = 1; 
            _LoadData(); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _ResetFilters();
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}