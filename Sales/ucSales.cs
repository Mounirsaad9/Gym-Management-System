using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBusinessLayer;
using DTOs;
using Gym.CustomControls;
using Models;

namespace Gym
{
    public partial class ucSales : BaseUserControl
    {
        private readonly ToolTip _toolTip = new ToolTip();

        private class InvoiceRowItem
        {
            public clsSaleItemModel Model { get; set; }
            public RoundedPanel RowPanel { get; set; }
            public Label QtyLabel { get; set; }
        }

        private Dictionary<int, RoundedPanel> _ProductCardsDict = new Dictionary<int, RoundedPanel>();
        private Dictionary<int, clsProductModel> _ProductsDict = new Dictionary<int, clsProductModel>();
        private readonly Dictionary<int, InvoiceRowItem> _InvoiceRows = new Dictionary<int, InvoiceRowItem>();

        private List<clsProductCategoryModel> _Categories = new List<clsProductCategoryModel>();
        private List<clsMemberDTO> _MembersList = new List<clsMemberDTO>();

        private int _SelectedCategoryID = 0;
        private int? _SelectedMemberID = null;

        public ucSales()
        {
            InitializeComponent();
            _LoadDataFirstTime();
        }

        private void _LoadDataFirstTime()
        {
            var productsList = clsProduct.GetAllProducts();
            _ProductsDict = productsList.ToDictionary(p => p.ProductID);

            _MembersList = clsMember.GetAllMembers();
            _Categories = clsProductCategory.GetAllCategories();

            _BuildCategoryChips();
            _BuildProductCards(productsList);
        }

        private void _BuildCategoryChips()
        {
            flowCategories.SuspendLayout();
            flowCategories.Controls.Clear();

            RoundedButton chipAll = new RoundedButton();
            chipAll.Text = "All";
            chipAll.Tag = 0;
            chipAll.AutoSize = true;
            chipAll.Padding = new Padding(12, 6, 12, 6);
            chipAll.Margin = new Padding(0, 0, 10, 8);
            chipAll.FillColor = Color.CornflowerBlue;
            chipAll.FillColor2 = Color.SlateBlue;
            chipAll.Click += CategoryChip_Click;
            flowCategories.Controls.Add(chipAll);

            foreach (var category in _Categories)
            {
                RoundedButton chip = new RoundedButton();
                chip.Text = category.CategoryName;
                chip.Tag = category.CategoryID;
                chip.AutoSize = true;
                chip.Padding = new Padding(14, 6, 14, 6);
                chip.Margin = new Padding(0, 0, 10, 8);
                chip.FillColor = Color.FromArgb(38, 40, 58);
                chip.FillColor2 = Color.FromArgb(38, 40, 58);
                chip.Click += CategoryChip_Click;
                flowCategories.Controls.Add(chip);
            }

            flowCategories.ResumeLayout(true);
        }

        private void _BuildProductCards(List<clsProductModel> products)
        {
            flowProducts.SuspendLayout();
            flowProducts.Controls.Clear();
            _ProductCardsDict.Clear();

            foreach (var product in products)
            {
                RoundedPanel card = new RoundedPanel();
                card.Width = 140;
                card.Height = 95;
                card.Margin = new Padding(6);
                card.Tag = product.ProductID;

                bool isInInvoice = _InvoiceRows.ContainsKey(product.ProductID);
                Color baseColor = isInInvoice ? Color.FromArgb(42, 45, 90) : Color.FromArgb(28, 33, 47);

                card.FillColor = baseColor;
                card.FillColor2 = baseColor;

                Label lblName = new Label
                {
                    Text = product.ProductName,
                    ForeColor = Color.White,
                    Font = new Font("Cairo", 9, FontStyle.Bold),
                    Location = new Point(10, 8),
                    Size = new Size(120, 25),
                    AutoSize = false,
                    AutoEllipsis = true
                };

                Label lblPrice = new Label
                {
                    Text = product.SellingPrice.ToString("N2"),
                    ForeColor = Color.FromArgb(126, 230, 168),
                    Font = new Font("Cairo", 10, FontStyle.Bold),
                    Location = new Point(10, 36),
                    AutoSize = true
                };

                Label lblStock = new Label
                {
                    Text = "Available: " + product.StockQuantity,
                    Name = "lblStock",
                    ForeColor = Color.FromArgb(148, 163, 184),
                    Font = new Font("Cairo", 8),
                    Location = new Point(10, 64),
                    AutoSize = true
                };

                _toolTip.SetToolTip(card, product.ProductName);
                _toolTip.SetToolTip(lblName, product.ProductName);

                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(lblStock);

                card.Click += ProductCard_Click;
                lblName.Click += ProductCard_Click;
                lblPrice.Click += ProductCard_Click;
                lblStock.Click += ProductCard_Click;

                flowProducts.Controls.Add(card);
                _ProductCardsDict[product.ProductID] = card;
            }
            flowProducts.ResumeLayout(true);
        }

        private void CategoryChip_Click(object sender, EventArgs e)
        {
            RoundedButton clickedChip = (RoundedButton)sender;
            _SelectedCategoryID = (int)clickedChip.Tag;

            flowCategories.SuspendLayout();
            foreach (Control c in flowCategories.Controls)
            {
                if (c is RoundedButton btn)
                {
                    if ((int)btn.Tag == _SelectedCategoryID)
                    {
                        btn.FillColor = Color.CornflowerBlue;
                        btn.FillColor2 = Color.SlateBlue;
                    }
                    else
                    {
                        btn.FillColor = Color.FromArgb(38, 40, 58);
                        btn.FillColor2 = Color.FromArgb(38, 40, 58);
                    }
                }
            }
            flowCategories.ResumeLayout(true);

            _ApplyFilters();
        }

        private void txtSearchProduct_TextValueChanged()
        {
            _ApplyFilters();
        }

        private void _ApplyFilters()
        {
            string searchText = txtSearchProduct.TextValue.Trim();
            flowProducts.SuspendLayout();

            foreach (Control control in flowProducts.Controls)
            {
                if (control is RoundedPanel card && card.Tag != null)
                {
                    int productID = Convert.ToInt32(card.Tag);
                    if (_ProductsDict.TryGetValue(productID, out var product))
                    {
                        bool matchesCategory = (_SelectedCategoryID == 0 || product.CategoryID == _SelectedCategoryID);
                        bool matchesSearch = (string.IsNullOrEmpty(searchText) ||
                                              product.ProductName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

                        card.Visible = (matchesCategory && matchesSearch);
                    }
                }
            }
            flowProducts.ResumeLayout(true);
        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            RoundedPanel clickedPanel = (sender is Control ctrl && ctrl.Parent is RoundedPanel parentPanel) ? parentPanel : (RoundedPanel)sender;
            int productID = (int)clickedPanel.Tag;

            if (!_ProductsDict.TryGetValue(productID, out clsProductModel product)) return;

            int currentQtyInInvoice = _InvoiceRows.TryGetValue(productID, out var existingRow) ? existingRow.Model.Quantity : 0;

            if (currentQtyInInvoice >= product.StockQuantity)
            {
                MessageBox.Show("Cannot add more items. Insufficient stock available!", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _AddOrUpdateInvoiceItem(product);

            clickedPanel.FillColor = Color.FromArgb(42, 45, 90);
            clickedPanel.FillColor2 = Color.FromArgb(42, 45, 90);
            clickedPanel.Refresh();
        }

        private void _AddOrUpdateInvoiceItem(clsProductModel product)
        {
            if (_InvoiceRows.TryGetValue(product.ProductID, out var existingRow))
            {
                existingRow.Model.Quantity++;
                existingRow.Model.TotalPrice = existingRow.Model.Quantity * existingRow.Model.UnitPrice;
                existingRow.QtyLabel.Text = existingRow.Model.Quantity.ToString();
                existingRow.QtyLabel.Refresh();
            }
            else
            {
                var newItemModel = new clsSaleItemModel
                {
                    ProductID = product.ProductID,
                    UnitPrice = product.SellingPrice,
                    Quantity = 1,
                    TotalPrice = product.SellingPrice
                };

                var newRowItem = _CreateInvoiceRowUI(newItemModel, product.ProductName);
                _InvoiceRows.Add(product.ProductID, newRowItem);

                flowInvoiceItems.SuspendLayout();
                flowInvoiceItems.Controls.Add(newRowItem.RowPanel);
                flowInvoiceItems.ResumeLayout(true);
            }

            _UpdateTotalAmount();
        }

        private InvoiceRowItem _CreateInvoiceRowUI(clsSaleItemModel model, string productName)
        {
            RoundedPanel row = new RoundedPanel
            {
                Width = flowInvoiceItems.Width - 20,
                Height = 50,
                Margin = new Padding(0, 0, 0, 6),
                Tag = model.ProductID,
                FillColor = Color.FromArgb(28, 33, 47),
                FillColor2 = Color.FromArgb(28, 33, 47)
            };

            Label lblName = new Label
            {
                Text = productName,
                ForeColor = Color.White,
                Font = new Font("Cairo", 9, FontStyle.Bold),
                Location = new Point(10, 8),
                AutoSize = true
            };

            Label lblUnit = new Label
            {
                Text = model.UnitPrice.ToString("N2"),
                ForeColor = Color.FromArgb(148, 163, 184),
                Font = new Font("Cairo", 7),
                Location = new Point(10, 28),
                AutoSize = true
            };

            RoundedButton btnMinus = new RoundedButton
            {
                Text = "−",
                Width = 26,
                Height = 26,
                Location = new Point(row.Width - 100, 12),
                Tag = model.ProductID
            };
            btnMinus.Click += DecreaseQuantity_Click;

            Label lblQty = new Label
            {
                Name = "lblQty",
                Text = model.Quantity.ToString(),
                ForeColor = Color.White,
                Font = new Font("Cairo", 9, FontStyle.Bold),
                Location = new Point(row.Width - 65, 15),
                AutoSize = true
            };

            RoundedButton btnPlus = new RoundedButton
            {
                Text = "+",
                Width = 26,
                Height = 26,
                Location = new Point(row.Width - 40, 12),
                Tag = model.ProductID
            };
            btnPlus.Click += IncreaseQuantity_Click;

            row.Controls.Add(lblName);
            row.Controls.Add(lblUnit);
            row.Controls.Add(btnMinus);
            row.Controls.Add(lblQty);
            row.Controls.Add(btnPlus);

            return new InvoiceRowItem
            {
                Model = model,
                RowPanel = row,
                QtyLabel = lblQty
            };
        }

        private void IncreaseQuantity_Click(object sender, EventArgs e)
        {
            if (sender is RoundedButton btnPlus && btnPlus.Tag != null)
            {
                int productID = Convert.ToInt32(btnPlus.Tag);
                if (!_ProductsDict.TryGetValue(productID, out var product)) return;
                if (!_InvoiceRows.TryGetValue(productID, out var row)) return;

                if (row.Model.Quantity >= product.StockQuantity) return;

                row.Model.Quantity++;
                row.Model.TotalPrice = row.Model.Quantity * row.Model.UnitPrice;
                row.QtyLabel.Text = row.Model.Quantity.ToString();
                row.QtyLabel.Refresh();

                _UpdateTotalAmount();
            }
        }

        private void DecreaseQuantity_Click(object sender, EventArgs e)
        {
            if (sender is RoundedButton btnMinus && btnMinus.Tag != null)
            {
                int productID = Convert.ToInt32(btnMinus.Tag);
                if (!_InvoiceRows.TryGetValue(productID, out var row)) return;

                row.Model.Quantity--;

                if (row.Model.Quantity <= 0)
                {
                    flowInvoiceItems.Controls.Remove(row.RowPanel);
                    row.RowPanel.Dispose();
                    _InvoiceRows.Remove(productID);

                    if (_ProductCardsDict.TryGetValue(productID, out RoundedPanel productCard))
                    {
                        productCard.FillColor = Color.FromArgb(28, 33, 47);
                        productCard.FillColor2 = Color.FromArgb(28, 33, 47);
                        productCard.Refresh();
                    }
                }
                else
                {
                    row.Model.TotalPrice = row.Model.Quantity * row.Model.UnitPrice;
                    row.QtyLabel.Text = row.Model.Quantity.ToString();
                    row.QtyLabel.Refresh();
                }

                _UpdateTotalAmount();
            }
        }

        private void _UpdateTotalAmount()
        {
            decimal total = _InvoiceRows.Values.Sum(r => r.Model.TotalPrice);
            lblTotalAmount.Text = total.ToString("N2");
        }

        private void _ResetInvoice()
        {
            _InvoiceRows.Clear();
            _SelectedMemberID = null;

            flowInvoiceItems.Controls.Clear();

            lblMemberName.Visible = false;
            lblMemberStatus.Visible = false;
            txtSearchMember.txtClear();

            _UpdateTotalAmount();
            _ApplyFilters();
        }

        private void txtSearchMember_TextValueChanged()
        {
            string searchText = txtSearchMember.TextValue.Trim();
            _SelectedMemberID = null;

            if (string.IsNullOrEmpty(searchText))
            {
                lblMemberName.Text = "Guest Customer (Walk-in)";
                lblMemberName.ForeColor = Color.LightGray;
                lblMemberName.Visible = true;
                lblMemberStatus.Visible = false;
                return;
            }

            bool isNumeric = int.TryParse(searchText, out int memberID);

            var foundMember = _MembersList.FirstOrDefault(m =>
                (isNumeric && m.MemberID == memberID) ||
                (m.Name != null && m.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0));

            if (foundMember == null)
            {
                lblMemberName.Text = "Guest Customer (Not Found)";
                lblMemberName.ForeColor = Color.Orange;
                lblMemberName.Visible = true;
                lblMemberStatus.Visible = false;
                return;
            }

            bool isActive = string.Equals(foundMember.IsActive, "Active", StringComparison.OrdinalIgnoreCase);
            _SelectedMemberID = foundMember.MemberID;

            lblMemberName.Text = foundMember.Name;
            lblMemberName.ForeColor = Color.White;
            lblMemberName.Visible = true;

            lblMemberStatus.Text = foundMember.IsActive;
            lblMemberStatus.ForeColor = isActive ? Color.Green : Color.Red;
            lblMemberStatus.Visible = true;
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            if (_InvoiceRows.Count == 0)
            {
                MessageBox.Show("The invoice is empty, please add products first", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<clsSaleItemModel> invoiceItems = _InvoiceRows.Values
                                                             .Select(r => r.Model)
                                                             .ToList();

            clsSale sale = new clsSale(_SelectedMemberID, clsCurrentUser.UserID, invoiceItems);
            clsSale.enSaveResult result = sale.Save();

            switch (result)
            {
                case clsSale.enSaveResult.Success:
                    MessageBox.Show("Sale completed successfully. Invoice #" + sale.SaleData.SaleID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (var item in invoiceItems)
                    {
                        if (_ProductsDict.TryGetValue(item.ProductID, out var product))
                        {
                            product.StockQuantity -= item.Quantity;

                            if (_ProductCardsDict.TryGetValue(item.ProductID, out RoundedPanel card))
                            {
                                card.FillColor = Color.FromArgb(28, 33, 47);
                                card.FillColor2 = Color.FromArgb(28, 33, 47);
                    
                                if (card.Controls["lblStock"] is Label lblStock)
                                {
                                    lblStock.Text = "Available: " + product.StockQuantity;
                                }
                            }
                        }
                    }

                    clsAuditLog.Log(
                        userID: clsCurrentUser.UserID,
                        actionType: "INSERT",
                        tableName: "Sales",
                        recordID: sale.SaleData.SaleID,
                        actionDetails: $"Completed sale invoice #{sale.SaleData.SaleID} containing ({invoiceItems.Count}) item(s)"
                    );

                    _ResetInvoice();
                    break;

                case clsSale.enSaveResult.EmptyInvoice:
                    MessageBox.Show("The invoice is empty");
                    break;

                case clsSale.enSaveResult.InsuficientStock:
                    MessageBox.Show("One or more products do not have enough stock available");
                    break;

                case clsSale.enSaveResult.Failed:
                    MessageBox.Show("An error occurred while completing the sale");
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}