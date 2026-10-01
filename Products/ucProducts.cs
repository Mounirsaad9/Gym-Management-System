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
using System.Xml.Serialization;

namespace Gym
{
    public partial class ucProducts : BaseUserControl
    {

        private readonly BindingSource _productBindingSource = new BindingSource();
        private readonly Timer _searchTimer = new Timer();

        private Dictionary<int, clsProductModel> _productsDict = new Dictionary<int, clsProductModel>();
        private Dictionary<int, string> _categoriesDict = new Dictionary<int, string>();

        public class ProductViewDTO
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string Category { get; set; }
            public decimal PurchasePrice { get; set; }
            public decimal SellingPrice { get; set; }
            public decimal Profit { get; set; }
            public int Quantity { get; set; }
            public int MinStockAlert { get; set; }
        }

        public ucProducts()
        {
            InitializeComponent();
            dgvProducts.DataSource = _productBindingSource;

            _searchTimer.Interval = 250;
            _searchTimer.Tick += SearchTimer_Tick;
        }

        private void _LoadProductsFirstTime()
        {
        
            var categoriesList = clsProductCategory.GetAllCategories() ?? new List<clsProductCategoryModel>();
            _categoriesDict = categoriesList.ToDictionary(c => c.CategoryID, c => c.CategoryName);

            var productsList = clsProduct.GetAllProducts() ?? new List<clsProductModel>();
            _productsDict = productsList.ToDictionary(p => p.ProductID, p => p);

            _BindGrid(_productsDict.Values);
        }

        private void _BindGrid(IEnumerable<clsProductModel> products)
        {
            if (products == null) return;

            var displayList = products.Select(product => new ProductViewDTO
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                Category = _categoriesDict.TryGetValue(product.CategoryID, out string categoryName) ? categoryName : "Unknown",
                PurchasePrice = product.PurchasePrice,
                SellingPrice = product.SellingPrice,
                Profit = product.SellingPrice - product.PurchasePrice,
                Quantity = product.StockQuantity,
                MinStockAlert = product.MinStockAlert
            }).ToList();

            _productBindingSource.DataSource = displayList;
            dgvProducts.AdjustGridHeight(_productBindingSource.Count);

        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            string searchText = txtSearch.TextValue?.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                _BindGrid(_productsDict.Values);
                return;
            }

            
            var filtered = _productsDict.Values
                .Where(p => p.ProductName != null && p.ProductName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

            _BindGrid(filtered);
        }

        private void _OpenEditForm(int productID)
        {
          
            if (!_productsDict.TryGetValue(productID, out clsProductModel productToUpdate))
                return;

            using (frmAddUpdateProduct frm = new frmAddUpdateProduct(productToUpdate))
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.SavedProduct != null)
                {   
                    _productsDict[productID] = frm.SavedProduct;
                    _BindGrid(_productsDict.Values);
                }
            }
        }

        private void _DeactivateProduct(int productID)
        {
            if (MessageBox.Show("Are you sure you want to delete this Product?", "Confirm Delete",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            if (_productsDict.TryGetValue(productID, out var productToDelete) && clsProduct.Deactivate(productID))
            {
                // 📝 تسجيل الحركة في الـ Audit Log
                clsAuditLog.Log(
                    userID: clsCurrentUser.UserID,
                    actionType: "DELETE",
                    tableName: "Products",
                    recordID: productID,
                    actionDetails: $"Deactivated product '{productToDelete.ProductName}'"
                );

                _productsDict.Remove(productID);
                _BindGrid(_productsDict.Values);
            }
            else
            {
                MessageBox.Show("An error occurred while deleting this product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateProduct frm = new frmAddUpdateProduct())
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.SavedProduct != null)
                {
                   
                    _productsDict[frm.SavedProduct.ProductID] = frm.SavedProduct;
                    _BindGrid(_productsDict.Values);
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvProducts.Rows[e.RowIndex].DataBoundItem is ProductViewDTO clickedProduct)
            {
                string columnName = dgvProducts.Columns[e.ColumnIndex].Name;

                if (columnName == "btnEdit")
                {
                    _OpenEditForm(clickedProduct.ProductID);
                }
                else if (columnName == "btnDelete")
                {
                    _DeactivateProduct(clickedProduct.ProductID);
                }
            }
        }

        private void txtSearch_TextValueChanged()
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void ucProducts_Load(object sender, EventArgs e)
        {
            _LoadProductsFirstTime();
            _AddButtonsTodgvProducts();
            _ConfigureGridColumnsVisuals();
        }

        private void _ConfigureGridColumnsVisuals()
        {
            if (dgvProducts.Columns["SellingPrice"] != null) dgvProducts.Columns["SellingPrice"].DefaultCellStyle.Format = "N2";
            if (dgvProducts.Columns["PurchasePrice"] != null) dgvProducts.Columns["PurchasePrice"].DefaultCellStyle.Format = "N2";
            if (dgvProducts.Columns["Profit"] != null) dgvProducts.Columns["Profit"].DefaultCellStyle.Format = "N2";

            if (dgvProducts.Columns["ProductID"] != null)
                dgvProducts.Columns["ProductID"].Visible = false;
        }

        private void _AddButtonsTodgvProducts()
        {
            if (!dgvProducts.Columns.Contains("btnEdit"))
            {
                DataGridViewImageColumn EditButton = new DataGridViewImageColumn
                {
                    HeaderText = "Edit",
                    Name = "btnEdit",
                    Image = Properties.Resources.edit_32
                };
                dgvProducts.Columns.Add(EditButton);
            }

            if (!dgvProducts.Columns.Contains("btnDelete"))
            {
                DataGridViewImageColumn DeleteButton = new DataGridViewImageColumn
                {
                    HeaderText = "Delete",
                    Name = "btnDelete",
                    Image = Properties.Resources.icons8_delete_48
                };
                dgvProducts.Columns.Add(DeleteButton);
            }
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string columnName = dgvProducts.Columns[e.ColumnIndex].Name;

           
            if (columnName == "Profit")
            {
                e.CellStyle.ForeColor = Color.CornflowerBlue;
                return;
            }

            if (columnName == "Quantity" && dgvProducts.Rows[e.RowIndex].DataBoundItem is ProductViewDTO productDTO &&
                productDTO.Quantity <= productDTO.MinStockAlert) 
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }
    }
}
