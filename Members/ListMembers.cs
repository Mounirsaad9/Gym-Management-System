using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DTOs;
using clsBusinessLayer;

namespace Gym
{
    public partial class ucListMembers : BaseUserControl
    {
        private List<clsMemberDTO> _allMembersList;
        private BindingSource _bindingSource;
        private Timer _debounceTimer;

        public ucListMembers()
        {
            InitializeComponent();
            _InitializeBindingSource();
            _InitializeDebounceTimer();
        }

        private void _InitializeBindingSource()
        {
            _bindingSource = new BindingSource();
            dgvMembers.DataSource = _bindingSource;
        }

        private void _InitializeDebounceTimer()
        {
            _debounceTimer = new Timer();
            _debounceTimer.Interval = 250;
            _debounceTimer.Tick += DebounceTimer_Tick;
        }

        private void ucListMembers_Load(object sender, EventArgs e)
        {
            _FillFilterComboBoxes();
            _LoadAllMembersData();
            AddButtonsToDataGridView();
            _SetupGridColumns();
        }

        private void _FillFilterComboBoxes()
        {
            cbGender.Items.Clear();
            cbGender.Items.AddRange(new string[] { "All", "Male", "Female" });
            cbGender.SelectedIndex = 0;

            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(new string[] { "All", "Active", "Inactive", "Frozen" });
            cbStatus.SelectedIndex = 0;
        }

        private void _LoadAllMembersData()
        {
            _allMembersList = clsMember.GetAllMembers();
            _bindingSource.DataSource = _allMembersList;
        }

        private void _SetupGridColumns()
        {
            if (dgvMembers.Columns.Contains("MemberID"))
                dgvMembers.Columns["MemberID"].Visible = false;

            if (dgvMembers.Columns.Contains("MembershipID"))
                dgvMembers.Columns["MembershipID"].Visible = false;

            if (dgvMembers.Columns.Contains("StartDate"))
                dgvMembers.Columns["StartDate"].DefaultCellStyle.Format = "d";

            if (dgvMembers.Columns.Contains("EndDate"))
                dgvMembers.Columns["EndDate"].DefaultCellStyle.Format = "d";

            if (dgvMembers.Columns.Contains("DateOfBirth"))
                dgvMembers.Columns["DateOfBirth"].DefaultCellStyle.Format = "d";
        }

        private void AddButtonsToDataGridView()
        {
            if (!dgvMembers.Columns.Contains("btnEdit"))
            {
                DataGridViewImageColumn editButton = new DataGridViewImageColumn
                {
                    Width = 30,
                    Image = Properties.Resources.edit_32,
                    Name = "btnEdit",
                    HeaderText = "Edit"
                };
                dgvMembers.Columns.Add(editButton);
            }

            if (!dgvMembers.Columns.Contains("btnRenew"))
            {
                DataGridViewImageColumn renewButton = new DataGridViewImageColumn
                {
                    Width = 30,
                    Image = Properties.Resources.refresh,
                    Name = "btnRenew",
                    HeaderText = "Renew"
                };
                dgvMembers.Columns.Add(renewButton);
            }
        }

        private void _ApplyFilters()
        {
            if (_allMembersList == null) return;

            IEnumerable<clsMemberDTO> filteredQuery = _allMembersList;

            string searchText = txtSearch.TextValue.Trim().ToLower();
            bool isNumeric = int.TryParse(searchText, out int searchID);

            if (!string.IsNullOrEmpty(searchText)) 
            {
                filteredQuery = filteredQuery.Where(m =>
                    (m.Name != null && m.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (m.Phone != null && m.Phone.Contains(searchText)) ||
                    (isNumeric && m.MemberID == searchID)
                );
            }

            if (cbGender.SelectedIndex > 0)
            {
                string selectedGender = cbGender.SelectedItem.ToString();
                filteredQuery = filteredQuery.Where(m => m.Gendor != null && m.Gendor.Equals(selectedGender, StringComparison.OrdinalIgnoreCase));
            }

            if (cbStatus.SelectedIndex > 0)
            {
                string selectedStatus = cbStatus.SelectedItem.ToString();
                filteredQuery = filteredQuery.Where(m => m.IsActive != null && m.IsActive.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase));
            }

            _bindingSource.DataSource = filteredQuery.ToList();
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            _debounceTimer.Stop();
            _ApplyFilters();
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            using (frmRegisterMember frm = new frmRegisterMember())
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.SavedMember != null)
                {
                    _allMembersList.Add(frm.SavedMember);
                    _ApplyFilters();
                }
            }
        }

        private void txtSearch_TextValueChanged()
        {
            _debounceTimer.Stop();
            _debounceTimer.Start();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            _debounceTimer.Stop();
            txtSearch.txtClear();
            cbGender.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;

            _bindingSource.DataSource = _allMembersList;
        }

        private void dgvMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.RowIndex < 0) return;

            string columnName = dgvMembers.Columns[e.ColumnIndex].Name;

            if (columnName.Equals("Gendor", StringComparison.OrdinalIgnoreCase))
            {
                string genderStr = e.Value.ToString();
                e.CellStyle.ForeColor = genderStr.Equals("Male", StringComparison.OrdinalIgnoreCase) ? Color.LightSkyBlue : Color.Tomato;
                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
            }
            else if (columnName.Equals("IsActive", StringComparison.OrdinalIgnoreCase))
            {
                string statusStr = e.Value.ToString();
                if (statusStr.Equals("Active", StringComparison.OrdinalIgnoreCase)) e.CellStyle.ForeColor = Color.LightGreen;
                else if (statusStr.Equals("Expired", StringComparison.OrdinalIgnoreCase)) e.CellStyle.ForeColor = Color.Crimson;
                else if (statusStr.Equals("Frozen", StringComparison.OrdinalIgnoreCase)) e.CellStyle.ForeColor = Color.Orange;

                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
            }
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (!(dgvMembers.Rows[e.RowIndex].DataBoundItem is clsMemberDTO selectedMember))
                return;

            string columnName = dgvMembers.Columns[e.ColumnIndex].Name;

            if (columnName == "btnEdit")
            {
                using (UpdateMember frm = new UpdateMember(selectedMember))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _ApplyFilters();
                    }
                }
            }
            else if (columnName == "btnRenew")
            {
                using (RenewMemberShip frm = new RenewMemberShip(selectedMember))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _ApplyFilters();
                    }
                }
            }
        }

        private void dgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvMembers.Rows[e.RowIndex].DataBoundItem is clsMemberDTO selectedMember)
            {
                using (frmMemberProfile frm = new frmMemberProfile(selectedMember.MemberID))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _debounceTimer?.Dispose();
            _bindingSource?.Dispose();
            this.Dispose();
        }

        private void btnSubscriptionPLans_Click(object sender, EventArgs e)
        {
            using (frmSubscriptionPlans frm = new frmSubscriptionPlans())
            {
                frm.ShowDialog();
            }
        }
    }
}