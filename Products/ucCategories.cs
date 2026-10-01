using clsBusinessLayer;
using Gym.CustomControls;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gym
{
    public partial class ucCategories : BaseUserControl
    {
    
        private Dictionary<int, clsProductCategoryModel> _categoriesDict = new Dictionary<int, clsProductCategoryModel>();
        private Dictionary<int, RoundedPanel> _categoryPanelsDict = new Dictionary<int, RoundedPanel>();

        private clsProductCategoryModel _SelectedCategory = null;

        private RoundedPanel _selectedPanel = null;
        public ucCategories()
        {
            InitializeComponent();
        }

        private void _LoadCategoriesFirstTime()
        {
            flowLayoutPanel1.SuspendLayout();
            try
            {
                flowLayoutPanel1.Controls.Clear();
                _categoryPanelsDict.Clear();

                var list = clsProductCategory.GetAllCategories() ?? new List<clsProductCategoryModel>();
                _categoriesDict = list.ToDictionary(c => c.CategoryID, c => c);

                foreach (var category in _categoriesDict.Values)
                {
                    _AddCategoryPanel(category);
                }
            }
            finally
            {
                flowLayoutPanel1.ResumeLayout(true);
            }
        }

        private void _AddCategoryPanel(clsProductCategoryModel category)
        {
            RoundedPanel panel = new RoundedPanel
            {
                Width = flowLayoutPanel1.Width - 25,
                Height = 45,
                Margin = new Padding(0, 0, 0, 8),
                Tag = category,
                FillColor = Color.FromArgb(48, 52, 72),
                FillColor2 = Color.FromArgb(48, 52, 72)
            };

            Label lbl = new Label
            {
                Text = category.CategoryName,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Italic),
                Tag = category
            };

            panel.Controls.Add(lbl);

            panel.Click += CategoryItem_Click;
            lbl.Click += CategoryItem_Click;

            _categoryPanelsDict[category.CategoryID] = panel;

            flowLayoutPanel1.Controls.Add(panel);
        }

        private void CategoryItem_Click(object sender, EventArgs e)
        {
            RoundedPanel clickedPanel = (sender is Label lbl) ? (RoundedPanel)lbl.Parent : (RoundedPanel)sender;
            clsProductCategoryModel clickedCategory = (clsProductCategoryModel)clickedPanel.Tag;

            if (_SelectedCategory != null && _SelectedCategory.CategoryID == clickedCategory.CategoryID)
            {
                _ResetFormAfterSuccess();
                return;
            }
           
            if (_selectedPanel != null)
            {
                
                _selectedPanel.FillColor = Color.FromArgb(48, 52, 72);
                _selectedPanel.FillColor2 = Color.FromArgb(48, 52, 72);
            }

            _SelectedCategory = clickedCategory;
            _selectedPanel = clickedPanel;
            _selectedPanel.FillColor = Color.CornflowerBlue;
            _selectedPanel.FillColor2 = Color.SlateBlue;

            txtCategoryName.TextValue = _SelectedCategory.CategoryName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.TextValue?.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Please Enter Category Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsProductCategory category;
            clsProductCategory.enSaveResult result;

            // حالة إضافة فئة جديدة
            if (_SelectedCategory == null)
            {
                category = new clsProductCategory();
                category.CategoryData.CategoryName = categoryName;
                result = category.Save();

                if (result == clsProductCategory.enSaveResult.Success)
                {
                    _categoriesDict[category.CategoryData.CategoryID] = category.CategoryData;
                    _AddCategoryPanel(category.CategoryData);
                    _ResetFormAfterSuccess();
                }
            }
            // حالة تعديل فئة موجودة
            else
            {
                category = new clsProductCategory(_SelectedCategory.CategoryID, categoryName);
                result = category.Save();

                if (result == clsProductCategory.enSaveResult.Success)
                {
                    _SelectedCategory.CategoryName = categoryName;

                    if (_categoryPanelsDict.TryGetValue(_SelectedCategory.CategoryID, out RoundedPanel targetPanel))
                    {
                        if (targetPanel.Controls.Count > 0 && targetPanel.Controls[0] is Label lbl)
                        {
                            lbl.Text = categoryName;
                        }
                    }

                    _ResetFormAfterSuccess();
                }
            }

            if (result == clsProductCategory.enSaveResult.DuplicateName)
            {
                MessageBox.Show("This Name already used! choose another one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
            }
            else if (result == clsProductCategory.enSaveResult.Failed)
            {
                MessageBox.Show("An error occurred while saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
            }
        }

        private void _ResetFormAfterSuccess()
        {
            txtCategoryName.txtClear();
            _SelectedCategory = null;

            if (_selectedPanel != null)
            {
                _selectedPanel.FillColor = Color.FromArgb(48, 52, 72);
                _selectedPanel.FillColor2 = Color.FromArgb(48, 52, 72);
                _selectedPanel = null; 
            }
        }

        private void ucCategories_Load(object sender, EventArgs e)
        {
            _LoadCategoriesFirstTime();
        }

        private void ucCategories_Click(object sender, EventArgs e)
        {
            if (_SelectedCategory != null)
            {
                _ResetFormAfterSuccess();
            }
        }

        private void MainPanel_Click(object sender, EventArgs e)
        {
            if (_SelectedCategory != null)
            {
                _ResetFormAfterSuccess();
            }
        }
    }
}