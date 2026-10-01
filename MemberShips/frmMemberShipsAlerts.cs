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
    public partial class frmMemberShipsAlerts : BaseForm
    {
       
        private BindingSource _bindingSourse = new BindingSource();
        private BindingList<clsMembershipAlertDTO> _allAlertsList = new BindingList<clsMembershipAlertDTO>();

        public frmMemberShipsAlerts()
        {
            InitializeComponent();
           
        }

        private void frmMemberShipsAlerts_Load(object sender, EventArgs e)
        {
            _LoadData();
            _AddButtonsToDataGridView();
            _FormatDataGridView();
        }

        private void _FormatDataGridView()
        {
            if (dgvMembershipAlerts.Columns["MemberShipID"] != null)
                dgvMembershipAlerts.Columns["MemberShipID"].Visible = false;

            if (dgvMembershipAlerts.Columns["MemberFullName"] != null)
                dgvMembershipAlerts.Columns["MemberFullName"].HeaderText = "Name";

            if (dgvMembershipAlerts.Columns["PlanName"] != null)
                dgvMembershipAlerts.Columns["PlanName"].HeaderText = "Plan";

            if (dgvMembershipAlerts.Columns["StartDate"] != null)
            {
                dgvMembershipAlerts.Columns["StartDate"].HeaderText = "Start Date";
                dgvMembershipAlerts.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvMembershipAlerts.Columns["EndDate"] != null)
            {
                dgvMembershipAlerts.Columns["EndDate"].HeaderText = "End Date";
                dgvMembershipAlerts.Columns["EndDate"].DefaultCellStyle.Format = "yyyy-MM-dd"; 
            }

            if (dgvMembershipAlerts.Columns["DaysRemaining"] != null)
                dgvMembershipAlerts.Columns["DaysRemaining"].Visible = false;

            if (dgvMembershipAlerts.Columns["DisplayDaysRemaining"] != null)
                dgvMembershipAlerts.Columns["DisplayDaysRemaining"].HeaderText = "Days Remaining";

            if (dgvMembershipAlerts.Columns["IsActive"] != null)
                dgvMembershipAlerts.Columns["IsActive"].HeaderText = "Status";


        }

        private void _LoadData()
        {
            
            _allAlertsList = clsMemberShip.GetExpiringMemberships(10);
            _bindingSourse.DataSource = _allAlertsList;
            dgvMembershipAlerts.DataSource = _bindingSourse;

            dgvMembershipAlerts.AdjustGridHeight(_allAlertsList.Count);

            UpdateCounters();
        }

        private void UpdateCounters()
        {
            if (_allAlertsList == null) return;

            int expiredCount = _allAlertsList.Count(x => x.DaysRemaining <= 0);
            int expiringSoonCount = _allAlertsList.Count(x => x.DaysRemaining > 0 && x.DaysRemaining <= 10);

            lblExpiredCount.Text = expiredCount.ToString();
            lblExpiringSoonCount.Text = expiringSoonCount.ToString();
            lblTotalAlertsCount.Text = _allAlertsList.Count.ToString();
        }

        private void _AddButtonsToDataGridView()
        {
            if (!dgvMembershipAlerts.Columns.Contains("btnRenew"))
            {
                DataGridViewImageColumn RenewButton = new DataGridViewImageColumn
                {
                    Width = 30,
                    Image = Properties.Resources.refresh,
                    Name = "btnRenew",
                    HeaderText = "Renew"
                };
                dgvMembershipAlerts.Columns.Add(RenewButton);
            }
        }

        private void dgvMembershipAlerts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvMembershipAlerts.Columns[e.ColumnIndex].Name == "btnRenew")
            {
                var selectedAlert = (clsMembershipAlertDTO)dgvMembershipAlerts.Rows[e.RowIndex].DataBoundItem;

                if (selectedAlert != null)
                {

                    RenewMemberShip frm = new RenewMemberShip(selectedAlert.MemberID);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                        _allAlertsList.Remove(selectedAlert);
                        UpdateCounters();
                    }
                }
            }
        }

        private void dgvMembershipAlerts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)  return;

            var selectedAlert = (clsMembershipAlertDTO)dgvMembershipAlerts.Rows[e.RowIndex].DataBoundItem;

            if (selectedAlert != null)
            {
            
                frmMemberProfile frm = new frmMemberProfile(selectedAlert.MemberID);
                frm.ShowDialog();
            }


        }

        private void txtSerach_TextValueChanged()
        {
            string searchText = txtSerach.TextValue.Trim().ToLower();
            bool isNumirec = int.TryParse(searchText, out int SearchID);
            if (string.IsNullOrEmpty(searchText))
            {
                _bindingSourse.DataSource = _allAlertsList;
            }
            else
            {
                var filteredList = _allAlertsList
                    .Where(x => (!string.IsNullOrEmpty(x.MemberFullName) && x.MemberFullName.ToLower().Contains(searchText)) ||
                                (!string.IsNullOrEmpty(x.Phone) && x.Phone.Contains(searchText)) || isNumirec && x.MemberID == SearchID)
                    .ToList();

                _bindingSourse.DataSource = new BindingList<clsMembershipAlertDTO>(filteredList);

            }
            dgvMembershipAlerts.AdjustGridHeight(_bindingSourse.Count);
        }

        private void dgvMembershipAlerts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.ColumnIndex < 0) return;

            string columnName = dgvMembershipAlerts.Columns[e.ColumnIndex].Name;

           if (columnName.Equals("IsActive", StringComparison.OrdinalIgnoreCase))
           {
                string statusStr = e.Value.ToString();

                if (statusStr.Equals("Active", StringComparison.OrdinalIgnoreCase)) e.CellStyle.ForeColor = Color.LightGreen;
                else if (statusStr.Equals("Inactive", StringComparison.OrdinalIgnoreCase)) e.CellStyle.ForeColor = Color.Crimson;
                else if (statusStr.Equals("Frozen", StringComparison.OrdinalIgnoreCase)) e.CellStyle.ForeColor = Color.Orange;

                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
           }
        }
    }
}
