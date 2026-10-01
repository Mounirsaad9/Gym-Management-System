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
    public partial class frmSalesHistory : BaseForm
    {
        public frmSalesHistory()
        {
            InitializeComponent();
          
        }

        private void ucSalesHistory_Load(object sender, EventArgs e)
        {
            try
            {

                _SetupSalesGridColumns();
                _SetupSaleItemsGridColumns();

                List<clsSaleHistoryModel> allSales = clsSaleHistory.GetAllSales() ?? new List<clsSaleHistoryModel>();

           
                dgvSales.DataSource = allSales;
                dgvSales.AdjustGridHeight(allSales.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales history: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _SetupSalesGridColumns()
        {
            dgvSales.AutoGenerateColumns = false;
            dgvSales.Columns.Clear();

            dgvSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SaleID",
                HeaderText = "Sale ID",
                Width = 90,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MemberName",
                HeaderText = "Member Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserName",
                HeaderText = "User Name",
                Width = 140
            });

            dgvSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SaleDate",
                HeaderText = "Sale Date",
                Width = 160,
                DefaultCellStyle = { Format = "dd/MM/yyyy hh:mm tt", Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Total Amount",
                Width = 120,
                DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
        }

        private void _SetupSaleItemsGridColumns()
        {
            dgvSaleItems.AutoGenerateColumns = false;
            dgvSaleItems.Columns.Clear();

            dgvSaleItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSaleItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantity",
                Width = 80,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvSaleItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "Unit Price",
                Width = 110,
                DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvSaleItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "Total Price",
                Width = 120,
                DefaultCellStyle = { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
        }

        private void dgvSales_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvSales.SelectedRows.Count > 0 && dgvSales.SelectedRows[0].DataBoundItem is clsSaleHistoryModel selectedSale)
            {

                
                List<clsSaleItemHistoryModel> saleItems = clsSaleHistory.GetSaleItemsBySaleID(selectedSale.SaleID) ?? new List<clsSaleItemHistoryModel>();

                dgvSaleItems.DataSource = saleItems;
                dgvSaleItems.AdjustGridHeight(saleItems.Count);

                lblSale.Text = $"Details for Sale #{selectedSale.SaleID}";
            }
            else
            {
                dgvSaleItems.DataSource = null;
                lblSale.Text = "No Sale Selected";
            }
        }

      
    }

   

}
    

