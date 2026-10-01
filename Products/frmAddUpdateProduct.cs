using clsBusinessLayer;
using Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Gym
{
    public partial class frmAddUpdateProduct : BaseForm
    {
        private clsProduct _Product;
        private bool _IsEditMode = false;

        public clsProductModel SavedProduct { get; private set; }

        public frmAddUpdateProduct()
        {
            InitializeComponent();
            _Product = new clsProduct();
            _IsEditMode = false;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        public frmAddUpdateProduct(clsProductModel product)
        {
            InitializeComponent();
            _IsEditMode = true;

            _Product = new clsProduct(product);
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void frmAddUpdateProduct_Load(object sender, EventArgs e)
        {
            txtProductName.Focus();

            cbCategories.DataSource = clsProductCategory.GetAllCategories();
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryID";

            if (cbCategories.Items.Count > 0)
                cbCategories.SelectedIndex = 0;

            if (_IsEditMode)
            {
                lblTitle.Text = "Update Product";
                this.Text = "Update Product";

                cbCategories.SelectedValue = _Product.ProductData.CategoryID;
                txtSellingPrice.TextValue = _Product.ProductData.SellingPrice.ToString();
                txtPurchasePrice.TextValue = _Product.ProductData.PurchasePrice.ToString();
                txtProductName.TextValue = _Product.ProductData.ProductName;
                txtMinStockAlert.TextValue = _Product.ProductData.MinStockAlert.ToString();
                txtStockQuantity.TextValue = _Product.ProductData.StockQuantity.ToString();
            }
            else
            {
                lblTitle.Text = "Add Product";
                this.Text = "Add Product";
                txtMinStockAlert.TextValue = "10"; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbCategories.SelectedValue == null)
            {
                MessageBox.Show("Please choose a category", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            _Product.ProductData.ProductName = txtProductName.TextValue.Trim();
            _Product.ProductData.CategoryID = Convert.ToInt32(cbCategories.SelectedValue);

            _Product.ProductData.SellingPrice = Convert.ToDecimal(txtSellingPrice.TextValue);
            _Product.ProductData.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.TextValue);

            _Product.ProductData.StockQuantity = Convert.ToInt32(txtStockQuantity.TextValue);
            _Product.ProductData.MinStockAlert = Convert.ToInt32(txtMinStockAlert.TextValue); ;

            
            clsProduct.enSaveResult result = _Product.Save();

            switch (result)
            {
                case clsProduct.enSaveResult.Success:
                    SavedProduct = _Product.ProductData;

                    // 📝 تسجيل الحركة في الـ Audit Log بحسب نوع العملية (إضافة/تعديل)
                    string actionType = _IsEditMode ? "UPDATE" : "INSERT";
                    string actionDetails = _IsEditMode
                        ? $"Updated product '{SavedProduct.ProductName}' details"
                        : $"Added new product '{SavedProduct.ProductName}' (Price: ${SavedProduct.SellingPrice}, Stock: {SavedProduct.StockQuantity})";

                    clsAuditLog.Log(
                        userID: clsCurrentUser.UserID,
                        actionType: actionType,
                        tableName: "Products",
                        recordID: SavedProduct.ProductID,
                        actionDetails: actionDetails
                    );

                    this.DialogResult = DialogResult.OK;
                    this.CloseWithFadeOut();
                    break;

                case clsProduct.enSaveResult.DuplicateName:
                    MessageBox.Show("Product Name already chosen, please choose another one.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                    break;

                case clsProduct.enSaveResult.InvalidPrice:
                    MessageBox.Show("Selling Price must be greater than zero.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSellingPrice.Focus();
                    break;

                case clsProduct.enSaveResult.InvalidPurchasePrice:
                    MessageBox.Show("Purchase Price must be greater than zero.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPurchasePrice.Focus();
                    break;

                
                case clsProduct.enSaveResult.SellingLessThanPurchase:
                    MessageBox.Show("Selling price cannot be less than purchase price! Protect your profit margins.", "Business Rule Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSellingPrice.Focus();
                    break;

                case clsProduct.enSaveResult.InvalidStock:
                    MessageBox.Show("Invalid quantity or stock alert value.", "Invalid Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case clsProduct.enSaveResult.Failed:
                    MessageBox.Show("An error occurred while saving the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ucTextBoxProductName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtProductName.TextValue))
            {
                errorProvider1.SetError(txtProductName, "Please Enter Product Name");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtProductName, "");
            }
        }

        private void ucTextBoxSellingPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSellingPrice.TextValue) || !decimal.TryParse(txtSellingPrice.TextValue, out decimal price) || price <= 0) 
            {
                errorProvider1.SetError(txtSellingPrice, "Please enter a valid Selling Price greater than zero");
                e.Cancel = true;
            }
            
            else
            {
                errorProvider1.SetError(txtSellingPrice, "");
            }
        }

        private void ucTextBoxPurchasePrice_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPurchasePrice.TextValue) || !decimal.TryParse(txtPurchasePrice.TextValue, out decimal price) || price < 0)
            {
                errorProvider1.SetError(txtPurchasePrice, "Please enter a valid Purchase Price greater than zero");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPurchasePrice, "");
            }
        }

        private void ucTextBoxStockQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStockQuantity.TextValue) || !int.TryParse(txtStockQuantity.TextValue, out int quantity) || quantity < 0) 
            {
                errorProvider1.SetError(txtStockQuantity, "Please enter a valid quantity (zero or more)");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtStockQuantity, "");
            }
        }

        private void ucTextBoxMinStockAlert_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMinStockAlert.TextValue) || !int.TryParse(txtMinStockAlert.TextValue, out int minStock) || minStock < 0)
            {
                errorProvider1.SetError(txtMinStockAlert, "Min stock alert cannot be empty or negative.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtMinStockAlert, "");
            }
        }

    
    }
}
