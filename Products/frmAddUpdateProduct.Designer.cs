namespace Gym
{
    partial class frmAddUpdateProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new Gym.CustomControls.RoundedButton();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            this.txtProductName = new Gym.ucTextBox();
            this.txtSellingPrice = new Gym.ucTextBox();
            this.txtPurchasePrice = new Gym.ucTextBox();
            this.txtStockQuantity = new Gym.ucTextBox();
            this.txtMinStockAlert = new Gym.ucTextBox();
            this.cbCategories = new Gym.CustomControls.ucComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderThickness = 0;
            this.btnSave.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnSave.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnSave.DisabledForeColor = System.Drawing.Color.White;
            this.btnSave.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnSave.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnSave.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnSave.ImageColor = System.Drawing.Color.White;
            this.btnSave.ImageColorMode = false;
            this.btnSave.ImageSize = new System.Drawing.Size(0, 0);
            this.btnSave.IsSelected = false;
            this.btnSave.Location = new System.Drawing.Point(192, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnSave.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnSave.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSave.Size = new System.Drawing.Size(133, 52);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.BorderRadius = 20;
            this.btnClose.BorderThickness = 0;
            this.btnClose.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnClose.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnClose.DisabledForeColor = System.Drawing.Color.White;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnClose.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnClose.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnClose.ImageColor = System.Drawing.Color.White;
            this.btnClose.ImageColorMode = false;
            this.btnClose.ImageSize = new System.Drawing.Size(0, 0);
            this.btnClose.IsSelected = false;
            this.btnClose.Location = new System.Drawing.Point(46, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(133, 52);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtProductName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtProductName.BorderRadius = 25;
            this.txtProductName.BorderThickness = 2;
            this.txtProductName.EnableEnterPress = false;
            this.txtProductName.EnableGroupSeparators = true;
            this.txtProductName.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtProductName.GlowEnabled = false;
            this.txtProductName.GlowSize = 5;
            this.txtProductName.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtProductName.LeftIconImage = null;
            this.txtProductName.LeftIconOffsetX = 0;
            this.txtProductName.LeftIconSize = 25;
            this.txtProductName.Location = new System.Drawing.Point(36, 86);
            this.txtProductName.Multiline = false;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtProductName.PlaceholderText = "Product Name";
            this.txtProductName.RightAndLeftIconVisible = true;
            this.txtProductName.RightIconImage = null;
            this.txtProductName.RightIconOffsetX = 0;
            this.txtProductName.RightIconSize = 25;
            this.txtProductName.Size = new System.Drawing.Size(289, 34);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtProductName.TextBoxForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtProductName.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductName.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtProductName.TextValue = "";
            this.txtProductName.TxtOffsetX = 0;
            this.txtProductName.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtProductName.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtProductName.UnderlineOnly = false;
            this.txtProductName.UnderlineThickness = 2;
            this.txtProductName.UsePasswordChar = false;
            this.txtProductName.Validating += new System.ComponentModel.CancelEventHandler(this.ucTextBoxProductName_Validating);
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSellingPrice.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSellingPrice.BorderRadius = 25;
            this.txtSellingPrice.BorderThickness = 2;
            this.txtSellingPrice.EnableEnterPress = false;
            this.txtSellingPrice.EnableGroupSeparators = true;
            this.txtSellingPrice.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtSellingPrice.GlowEnabled = false;
            this.txtSellingPrice.GlowSize = 5;
            this.txtSellingPrice.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtSellingPrice.LeftIconImage = null;
            this.txtSellingPrice.LeftIconOffsetX = 0;
            this.txtSellingPrice.LeftIconSize = 25;
            this.txtSellingPrice.Location = new System.Drawing.Point(46, 231);
            this.txtSellingPrice.Multiline = false;
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSellingPrice.PlaceholderText = "";
            this.txtSellingPrice.RightAndLeftIconVisible = true;
            this.txtSellingPrice.RightIconImage = null;
            this.txtSellingPrice.RightIconOffsetX = 0;
            this.txtSellingPrice.RightIconSize = 25;
            this.txtSellingPrice.Size = new System.Drawing.Size(133, 34);
            this.txtSellingPrice.TabIndex = 4;
            this.txtSellingPrice.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtSellingPrice.TextBoxForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSellingPrice.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSellingPrice.TextMode = Gym.ucTextBox.InputMode.NumbersOnly;
            this.txtSellingPrice.TextValue = "";
            this.txtSellingPrice.TxtOffsetX = 0;
            this.txtSellingPrice.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtSellingPrice.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSellingPrice.UnderlineOnly = false;
            this.txtSellingPrice.UnderlineThickness = 2;
            this.txtSellingPrice.UsePasswordChar = false;
            this.txtSellingPrice.Validating += new System.ComponentModel.CancelEventHandler(this.ucTextBoxSellingPrice_Validating);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPurchasePrice.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPurchasePrice.BorderRadius = 25;
            this.txtPurchasePrice.BorderThickness = 2;
            this.txtPurchasePrice.EnableEnterPress = false;
            this.txtPurchasePrice.EnableGroupSeparators = true;
            this.txtPurchasePrice.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtPurchasePrice.GlowEnabled = false;
            this.txtPurchasePrice.GlowSize = 5;
            this.txtPurchasePrice.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtPurchasePrice.LeftIconImage = null;
            this.txtPurchasePrice.LeftIconOffsetX = 0;
            this.txtPurchasePrice.LeftIconSize = 25;
            this.txtPurchasePrice.Location = new System.Drawing.Point(192, 231);
            this.txtPurchasePrice.Multiline = false;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurchasePrice.PlaceholderText = "";
            this.txtPurchasePrice.RightAndLeftIconVisible = true;
            this.txtPurchasePrice.RightIconImage = null;
            this.txtPurchasePrice.RightIconOffsetX = 0;
            this.txtPurchasePrice.RightIconSize = 25;
            this.txtPurchasePrice.Size = new System.Drawing.Size(133, 34);
            this.txtPurchasePrice.TabIndex = 5;
            this.txtPurchasePrice.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtPurchasePrice.TextBoxForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurchasePrice.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPurchasePrice.TextMode = Gym.ucTextBox.InputMode.NumbersOnly;
            this.txtPurchasePrice.TextValue = "";
            this.txtPurchasePrice.TxtOffsetX = 0;
            this.txtPurchasePrice.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtPurchasePrice.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPurchasePrice.UnderlineOnly = false;
            this.txtPurchasePrice.UnderlineThickness = 2;
            this.txtPurchasePrice.UsePasswordChar = false;
            this.txtPurchasePrice.Validating += new System.ComponentModel.CancelEventHandler(this.ucTextBoxPurchasePrice_Validating);
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtStockQuantity.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtStockQuantity.BorderRadius = 25;
            this.txtStockQuantity.BorderThickness = 2;
            this.txtStockQuantity.EnableEnterPress = false;
            this.txtStockQuantity.EnableGroupSeparators = true;
            this.txtStockQuantity.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtStockQuantity.GlowEnabled = false;
            this.txtStockQuantity.GlowSize = 5;
            this.txtStockQuantity.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtStockQuantity.LeftIconImage = null;
            this.txtStockQuantity.LeftIconOffsetX = 0;
            this.txtStockQuantity.LeftIconSize = 25;
            this.txtStockQuantity.Location = new System.Drawing.Point(192, 303);
            this.txtStockQuantity.Multiline = false;
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStockQuantity.PlaceholderText = "";
            this.txtStockQuantity.RightAndLeftIconVisible = true;
            this.txtStockQuantity.RightIconImage = null;
            this.txtStockQuantity.RightIconOffsetX = 0;
            this.txtStockQuantity.RightIconSize = 25;
            this.txtStockQuantity.Size = new System.Drawing.Size(133, 34);
            this.txtStockQuantity.TabIndex = 7;
            this.txtStockQuantity.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtStockQuantity.TextBoxForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStockQuantity.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtStockQuantity.TextMode = Gym.ucTextBox.InputMode.NumbersOnly;
            this.txtStockQuantity.TextValue = "";
            this.txtStockQuantity.TxtOffsetX = 0;
            this.txtStockQuantity.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtStockQuantity.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtStockQuantity.UnderlineOnly = false;
            this.txtStockQuantity.UnderlineThickness = 2;
            this.txtStockQuantity.UsePasswordChar = false;
            this.txtStockQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.ucTextBoxStockQuantity_Validating);
            // 
            // txtMinStockAlert
            // 
            this.txtMinStockAlert.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMinStockAlert.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMinStockAlert.BorderRadius = 25;
            this.txtMinStockAlert.BorderThickness = 2;
            this.txtMinStockAlert.EnableEnterPress = false;
            this.txtMinStockAlert.EnableGroupSeparators = true;
            this.txtMinStockAlert.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtMinStockAlert.GlowEnabled = false;
            this.txtMinStockAlert.GlowSize = 5;
            this.txtMinStockAlert.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtMinStockAlert.LeftIconImage = null;
            this.txtMinStockAlert.LeftIconOffsetX = 0;
            this.txtMinStockAlert.LeftIconSize = 25;
            this.txtMinStockAlert.Location = new System.Drawing.Point(46, 303);
            this.txtMinStockAlert.Multiline = false;
            this.txtMinStockAlert.Name = "txtMinStockAlert";
            this.txtMinStockAlert.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMinStockAlert.PlaceholderText = "";
            this.txtMinStockAlert.RightAndLeftIconVisible = true;
            this.txtMinStockAlert.RightIconImage = null;
            this.txtMinStockAlert.RightIconOffsetX = 0;
            this.txtMinStockAlert.RightIconSize = 25;
            this.txtMinStockAlert.Size = new System.Drawing.Size(133, 34);
            this.txtMinStockAlert.TabIndex = 6;
            this.txtMinStockAlert.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtMinStockAlert.TextBoxForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMinStockAlert.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMinStockAlert.TextMode = Gym.ucTextBox.InputMode.NumbersOnly;
            this.txtMinStockAlert.TextValue = "";
            this.txtMinStockAlert.TxtOffsetX = 0;
            this.txtMinStockAlert.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtMinStockAlert.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMinStockAlert.UnderlineOnly = false;
            this.txtMinStockAlert.UnderlineThickness = 2;
            this.txtMinStockAlert.UsePasswordChar = false;
            this.txtMinStockAlert.Validating += new System.ComponentModel.CancelEventHandler(this.ucTextBoxMinStockAlert_Validating);
            // 
            // cbCategories
            // 
            this.cbCategories.AutoHeight = false;
            this.cbCategories.BackColor = System.Drawing.Color.Transparent;
            this.cbCategories.BorderColor = System.Drawing.Color.DarkGray;
            this.cbCategories.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.cbCategories.BorderRadius = 20;
            this.cbCategories.BorderThickness = 1;
            this.cbCategories.cbFont = new System.Drawing.Font("Segoe UI", 9F);
            this.cbCategories.cbForeColor = System.Drawing.SystemColors.Control;
            this.cbCategories.DataSource = null;
            this.cbCategories.DisplayMember = "";
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cbCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategories.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbCategories.HoverForeColor = System.Drawing.Color.DodgerBlue;
            this.cbCategories.Location = new System.Drawing.Point(36, 147);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(5);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.PlaceholderColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategories.PlaceholderText = "Categotry";
            this.cbCategories.SelectedIndex = -1;
            this.cbCategories.SelectedItem = null;
            this.cbCategories.SelectedValue = null;
            this.cbCategories.Size = new System.Drawing.Size(287, 41);
            this.cbCategories.TabIndex = 3;
            this.cbCategories.ValueMember = "";
            this.cbCategories.VerticalPadding = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(92, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 37);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Add Product";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(45, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selling Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(197, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Purchase Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(45, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min Stock Alert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(197, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock Quantity";
            // 
            // frmAddUpdateProduct
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(368, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.txtMinStockAlert);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateProduct";
            this.ShowIcon = false;
            this.Text = "frmAddUpdateProduct";
            this.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.Load += new System.EventHandler(this.frmAddUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedButton btnSave;
        private CustomControls.RoundedButton btnClose;
        private ucTextBox txtProductName;
        private ucTextBox txtSellingPrice;
        private ucTextBox txtPurchasePrice;
        private ucTextBox txtStockQuantity;
        private ucTextBox txtMinStockAlert;
        private CustomControls.ucComboBox cbCategories;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}