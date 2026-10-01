using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using clsBusinessLayer;
using Models;

namespace Gym
{
    public partial class ucListUsers : BaseUserControl
    {
        private List<clsUserModel> _allUsersList = new List<clsUserModel>();
        private BindingSource _bindingSource;
        private Timer _debounceTimer;

        public ucListUsers()
        {
            InitializeComponent();
            _InitializeBindingSource();
            _InitializeDebounceTimer();
        }

        private void _InitializeBindingSource()
        {
            _bindingSource = new BindingSource();
            dgvUsers.DataSource = _bindingSource;
        }

        private void _InitializeDebounceTimer()
        {
            _debounceTimer = new Timer();
            _debounceTimer.Interval = 250;
            _debounceTimer.Tick += DebounceTimer_Tick;
        }

        private void ucListUsers_Load(object sender, EventArgs e)
        {
            _FillFilterComboBoxes();
            _LoadDataFirstTime();
            AddButtonsToDataGridView();
            _SetupGridColumns();
        }

        private void _FillFilterComboBoxes()
        {
            if (cbStatusFilter.Items.Count > 0)
                cbStatusFilter.SelectedIndex = 0;

            if (cbRoleFilter.Items.Count > 0)
                cbRoleFilter.SelectedIndex = 0;
        }

        private void _LoadDataFirstTime()
        {
            try
            {
                _allUsersList = clsUser.GetAllUsers() ?? new List<clsUserModel>();
                _ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _SetupGridColumns()
        {
            if (dgvUsers.Columns.Contains("CreatedDate"))
                dgvUsers.Columns["CreatedDate"].DefaultCellStyle.Format = "d";

            if (dgvUsers.Columns.Contains("PasswordHash"))
                dgvUsers.Columns["PasswordHash"].Visible = false;

            if (dgvUsers.Columns.Contains("IsActive"))
                dgvUsers.Columns["IsActive"].Visible = false;
        }

        private void AddButtonsToDataGridView()
        {
            if (!dgvUsers.Columns.Contains("btnEdit"))
            {
                DataGridViewImageColumn editButton = new DataGridViewImageColumn
                {
                    Width = 150,
                    HeaderText = "Edit",
                    Name = "btnEdit",
                    Image = Properties.Resources.edit_32
                };
                dgvUsers.Columns.Add(editButton);
            }

            if (!dgvUsers.Columns.Contains("btnChangePassword"))
            {
                DataGridViewImageColumn changePassword = new DataGridViewImageColumn
                {
                    Width = 150,
                    HeaderText = "Change Password",
                    Name = "btnChangePassword",
                    Image = Properties.Resources.icons8_change_40
                };
                dgvUsers.Columns.Add(changePassword);
            }
        }

        private void _ApplyFilters()
        {
            if (_allUsersList == null) return;

            IEnumerable<clsUserModel> filteredQuery = _allUsersList;

            string searchText = txtFilterValue.TextValue.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchText))
            {
                filteredQuery = filteredQuery.Where(u =>
                    (u.FullName != null && u.FullName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (u.UserName != null && u.UserName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                );
            }

            if (cbStatusFilter.SelectedItem != null)
            {
                string selectedStatus = cbStatusFilter.SelectedItem.ToString();
                if (selectedStatus != "All")
                {
                    filteredQuery = filteredQuery.Where(u => u.Status == selectedStatus);
                }
            }

            if (cbRoleFilter.SelectedItem != null)
            {
                string selectedRole = cbRoleFilter.SelectedItem.ToString();
                if (selectedRole != "All")
                {
                    filteredQuery = filteredQuery.Where(u => u.Role == selectedRole);
                }
            }

            _bindingSource.DataSource = filteredQuery.ToList();
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            _debounceTimer.Stop();
            _ApplyFilters();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (!(dgvUsers.Rows[e.RowIndex].DataBoundItem is clsUserModel selectedUser))
                return;

            string columnName = dgvUsers.Columns[e.ColumnIndex].Name;

            if (columnName == "btnEdit")
            {
                using (frmUpdateUser frm = new frmUpdateUser(selectedUser))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _ApplyFilters();
                    }
                }
            }
            else if (columnName == "btnChangePassword")
            {
                using (frmChangePassword frm = new frmChangePassword(selectedUser.UserID))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                bool isActive = e.Value.ToString().Equals("Active", StringComparison.OrdinalIgnoreCase);
                Color statusColor = isActive ? Color.LimeGreen : Color.Crimson;

                e.CellStyle.ForeColor = statusColor;
                e.CellStyle.SelectionForeColor = statusColor;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            using (frmAddUser frm = new frmAddUser())
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.CreatedUser != null)
                {
                    _allUsersList.Add(frm.CreatedUser);
                    _ApplyFilters();
                }
            }
        }

        private void txtFilterValue_TextValueChanged()
        {
            _debounceTimer.Stop();
            _debounceTimer.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _debounceTimer.Stop();
            txtFilterValue.txtClear();

            if (cbStatusFilter.Items.Count > 0) cbStatusFilter.SelectedIndex = 0;
            if (cbRoleFilter.Items.Count > 0) cbRoleFilter.SelectedIndex = 0;

            _ApplyFilters();
        }

        private void cbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void cbRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _debounceTimer?.Dispose();
            _bindingSource?.Dispose();
            this.Dispose();
        }
    }
}