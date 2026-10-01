using clsBusinessLayer;
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
    public partial class frmSubscriptionPlans : BaseForm
    {
        
        private List<clsSubscriptionPlansModel> _PlansList;

        public frmSubscriptionPlans()
        {
            InitializeComponent();
           
        }

        private void frmSubscriptionPlans_Load(object sender, EventArgs e)
        {
            
            _PlansList = clsSubscriptionPlans.GetAllSubscriptionPlans();

            dgvSubscriptionPlans.DataSource = _PlansList;

            
            lblRecords.Text = _PlansList.Count.ToString(); 
            

            if (!dgvSubscriptionPlans.Columns.Contains("btnEdit"))
            {
                DataGridViewImageColumn editButton = new DataGridViewImageColumn();
                editButton.Width = 50;
                editButton.Image = Properties.Resources.edit_32; 
                editButton.HeaderText = "Edit";
                editButton.Name = "btnEdit";
                dgvSubscriptionPlans.Columns.Add(editButton);
            }

            dgvSubscriptionPlans.AdjustGridHeight(_PlansList.Count);

            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void dgvSubscriptionPlans_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)  return;

            if (e.ColumnIndex == dgvSubscriptionPlans.Columns["btnEdit"].Index)
            {

                if (!clsCurrentUser.IsAdmin())
                {
                    MessageBox.Show("Access Denied. Admin Only.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                clsSubscriptionPlansModel selectedPlan = (clsSubscriptionPlansModel)dgvSubscriptionPlans.Rows[e.RowIndex].DataBoundItem;

                frmUpdateSubscriptionPlan frm = new frmUpdateSubscriptionPlan(selectedPlan);

   
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgvSubscriptionPlans.Refresh();
                }
            }
        }

    }
}
