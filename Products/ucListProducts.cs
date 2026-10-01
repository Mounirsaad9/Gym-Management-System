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
    public partial class ucListProducts : UserControl
    {
        public ucListProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            _ShowProductsPanel();
        }

        private void roundedButtonProducts_Click(object sender, EventArgs e)
        {
            _ShowProductsPanel();
        }

        private void roundedButtonCategories_Click(object sender, EventArgs e)
        {
            _ShowCategoriesPanel();
        }

        private void _ShowProductsPanel()
        {
            roundedPanelContentArea.Controls.Clear();
            
            ucProducts products = new ucProducts();
            products.Dock = DockStyle.Fill;
            roundedPanelContentArea.Controls.Add(products);
            
            roundedButtonProducts.FillColor = Color.CornflowerBlue;
            roundedButtonProducts.FillColor2 = Color.SlateBlue;

            roundedButtonCategories.FillColor = Color.FromArgb(28,30,48);
            roundedButtonCategories.FillColor2 = Color.FromArgb(28, 30, 48);
            
        }

        private void _ShowCategoriesPanel()
        {
            roundedPanelContentArea.Controls.Clear();

            ucCategories categories = new ucCategories();
            categories.Dock = DockStyle.Fill;
            roundedPanelContentArea.Controls.Add(categories);

            roundedButtonCategories.FillColor = Color.CornflowerBlue;
            roundedButtonCategories.FillColor2 = Color.SlateBlue;

            roundedButtonProducts.FillColor = Color.FromArgb(28, 30, 48);
            roundedButtonProducts.FillColor2 = Color.FromArgb(28, 30, 48);
        }

        private void roundedButtonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
