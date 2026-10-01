namespace Gym
{
    partial class ucProducts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new Gym.CustomDataGridView();
            this.btnAddProduct = new Gym.CustomControls.RoundedButton();
            this.txtSearch = new Gym.ucTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(20, 108);
            this.dgvProducts.MaxVisibleRows = 14;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1198, 407);
            this.dgvProducts.TabIndex = 9;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProducts_CellFormatting);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProduct.BorderRadius = 20;
            this.btnAddProduct.BorderThickness = 0;
            this.btnAddProduct.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnAddProduct.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnAddProduct.DisabledForeColor = System.Drawing.Color.White;
            this.btnAddProduct.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddProduct.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnAddProduct.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnAddProduct.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnAddProduct.ImageColor = System.Drawing.Color.White;
            this.btnAddProduct.ImageColorMode = false;
            this.btnAddProduct.ImageSize = new System.Drawing.Size(0, 0);
            this.btnAddProduct.IsSelected = false;
            this.btnAddProduct.Location = new System.Drawing.Point(607, 30);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnAddProduct.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnAddProduct.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddProduct.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnAddProduct.Size = new System.Drawing.Size(155, 46);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add Product ";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderRadius = 25;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.EnableEnterPress = false;
            this.txtSearch.EnableGroupSeparators = true;
            this.txtSearch.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.GlowEnabled = false;
            this.txtSearch.GlowSize = 5;
            this.txtSearch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtSearch.LeftIconImage = global::Gym.Properties.Resources.icons8_search_48;
            this.txtSearch.LeftIconOffsetX = 0;
            this.txtSearch.LeftIconSize = 45;
            this.txtSearch.Location = new System.Drawing.Point(811, 18);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearch.PlaceholderText = "Search For Product...";
            this.txtSearch.RightAndLeftIconVisible = true;
            this.txtSearch.RightIconImage = null;
            this.txtSearch.RightIconOffsetX = 0;
            this.txtSearch.RightIconSize = 25;
            this.txtSearch.Size = new System.Drawing.Size(407, 70);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.txtSearch.TextBoxForeColor = System.Drawing.Color.White;
            this.txtSearch.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtSearch.TextValue = "";
            this.txtSearch.TxtOffsetX = 0;
            this.txtSearch.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtSearch.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.UnderlineOnly = false;
            this.txtSearch.UnderlineThickness = 2;
            this.txtSearch.UsePasswordChar = false;
            this.txtSearch.TextValueChanged += new System.Action(this.txtSearch_TextValueChanged);
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtSearch);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(1230, 682);
            this.Load += new System.EventHandler(this.ucProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedButton btnAddProduct;
        private ucTextBox txtSearch;
        private CustomDataGridView dgvProducts;
    }
}
