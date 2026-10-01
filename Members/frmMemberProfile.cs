using clsBusinessLayer;
using DTOs;
using Gym.CustomControls;
using Models;
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
    public partial class frmMemberProfile : BaseForm
    {
        private readonly int _MemberID;

        private List<clsMembershipHistoryDTO> _MemberShips = new List<clsMembershipHistoryDTO>();
        private List<clsPaymentHistoryDTO> _Payments = new List<clsPaymentHistoryDTO>();

        public frmMemberProfile(int memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            CloseWithFadeOut();
        }

        private void frmMemberProfile_Load(object sender, EventArgs e)
        {
            _LoadPersonInfo();

            _MemberShips = clsMemberShip.GetAllMemberShipsByMemberID(_MemberID);
            _Payments = clsPayment.GetAllPaymentsByMemberID(_MemberID);

            _ShowMembershipHistory();

        }

        private void _DisplayMemberAvatar(string firstName, string lastName)
        {
            PanelAvatar.Width = 90;
            PanelAvatar.Height = 90;
            PanelAvatar.BorderRadius = 45;

            string initials = "";

            if (!string.IsNullOrWhiteSpace(firstName))
                initials += firstName[0];

            if (!string.IsNullOrWhiteSpace(lastName))
                initials += lastName[0];

            lblAvatar.Text = initials.ToUpper();
        }

        private void _LoadPersonInfo()
        {
            clsMember member = clsMember.FindByID(_MemberID);

            if (member == null)
            {
                MessageBox.Show("Member Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            clsMemberModel memberData = member.MemberData;

            lblMemberID.Text = memberData.MemberID.ToString();
            lblName.Text = $"{memberData.FirstName} {memberData.LastName}";
            lblPhone.Text = memberData.Phone.ToString();
            lblMemberSince.Text = memberData.CreatedDate.ToShortDateString();
            lblGender.Text = memberData.Gendor == 0 ? "Male" : "Female";
            lblDOB.Text = memberData.DateOfBirth.ToShortDateString();

            lblStatus.ForeColor = Color.FromArgb(46, 204, 113);

            _DisplayMemberAvatar(memberData.FirstName, memberData.LastName);
        }

        private void _ShowMembershipHistory()
        {

            customDataGridView1.DataSource = null;
            customDataGridView1.DataSource = _MemberShips;
            customDataGridView1.AdjustGridHeight(_MemberShips.Count);


            _ToggleButtonVisuals(btnMemberShip, btnPayments);
        }

        private void _ShowPaymentsHistory()
        {
            customDataGridView1.DataSource = null;
            customDataGridView1.DataSource = _Payments;
            customDataGridView1.AdjustGridHeight(_Payments.Count);

            _ToggleButtonVisuals(btnPayments, btnMemberShip);
        }

        private void _ToggleButtonVisuals(RoundedButton activeVisualBtn, RoundedButton inactiveVisualBtn)
        {
            activeVisualBtn.FillColor = Color.CornflowerBlue;
            activeVisualBtn.FillColor2 = Color.SlateBlue;

            inactiveVisualBtn.FillColor = Color.FromArgb(45, 52, 71);
            inactiveVisualBtn.FillColor2 = Color.FromArgb(45, 52, 71);
        }

        private void btnMemberShip_Click(object sender, EventArgs e)
        {
            _ShowMembershipHistory();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            _ShowPaymentsHistory();
        }
    }
}
