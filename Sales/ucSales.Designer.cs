namespace Gym
{
    partial class ucSales
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
            this.panelProductsSide = new Gym.CustomControls.RoundedPanel();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.flowCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchProduct = new Gym.ucTextBox();
            this.panelInvoiceSide = new Gym.CustomControls.RoundedPanel();
            this.txtSearchMember = new Gym.ucTextBox();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            this.panelMemberResult = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblMemberStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmSale = new Gym.CustomControls.RoundedButton();
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowInvoiceItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panelProductsSide.SuspendLayout();
            this.panelInvoiceSide.SuspendLayout();
            this.panelMemberResult.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProductsSide
            // 
            this.panelProductsSide.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelProductsSide.BorderRadius = 15;
            this.panelProductsSide.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.panelProductsSide.BorderThickness = 1;
            this.panelProductsSide.Controls.Add(this.flowProducts);
            this.panelProductsSide.Controls.Add(this.flowCategories);
            this.panelProductsSide.Controls.Add(this.txtSearchProduct);
            this.panelProductsSide.CornerBottomLeft = true;
            this.panelProductsSide.CornerBottomRight = false;
            this.panelProductsSide.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.panelProductsSide.CornerTopLeft = true;
            this.panelProductsSide.CornerTopRight = false;
            this.panelProductsSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductsSide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panelProductsSide.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panelProductsSide.ForceGlow = false;
            this.panelProductsSide.GlowColor = System.Drawing.Color.DodgerBlue;
            this.panelProductsSide.GlowEnabled = false;
            this.panelProductsSide.GlowSize = 5;
            this.panelProductsSide.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelProductsSide.Location = new System.Drawing.Point(0, 0);
            this.panelProductsSide.Name = "panelProductsSide";
            this.panelProductsSide.Size = new System.Drawing.Size(769, 777);
            this.panelProductsSide.TabIndex = 1;
            this.panelProductsSide.UnderlineColor = System.Drawing.Color.LightGray;
            this.panelProductsSide.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.panelProductsSide.UnderlineOnly = false;
            this.panelProductsSide.UnderlineThickness = 2;
            // 
            // flowProducts
            // 
            this.flowProducts.AutoScroll = true;
            this.flowProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.flowProducts.Location = new System.Drawing.Point(29, 242);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(679, 509);
            this.flowProducts.TabIndex = 2;
            // 
            // flowCategories
            // 
            this.flowCategories.AutoScroll = true;
            this.flowCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.flowCategories.Location = new System.Drawing.Point(29, 121);
            this.flowCategories.Name = "flowCategories";
            this.flowCategories.Size = new System.Drawing.Size(679, 91);
            this.flowCategories.TabIndex = 1;
            this.flowCategories.WrapContents = false;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchProduct.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchProduct.BorderRadius = 25;
            this.txtSearchProduct.BorderThickness = 2;
            this.txtSearchProduct.EnableEnterPress = false;
            this.txtSearchProduct.EnableGroupSeparators = true;
            this.txtSearchProduct.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchProduct.GlowEnabled = false;
            this.txtSearchProduct.GlowSize = 5;
            this.txtSearchProduct.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtSearchProduct.LeftIconImage = null;
            this.txtSearchProduct.LeftIconOffsetX = 0;
            this.txtSearchProduct.LeftIconSize = 25;
            this.txtSearchProduct.Location = new System.Drawing.Point(29, 38);
            this.txtSearchProduct.Multiline = false;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchProduct.PlaceholderText = "Search for Product..";
            this.txtSearchProduct.RightAndLeftIconVisible = true;
            this.txtSearchProduct.RightIconImage = null;
            this.txtSearchProduct.RightIconOffsetX = 0;
            this.txtSearchProduct.RightIconSize = 25;
            this.txtSearchProduct.Size = new System.Drawing.Size(360, 62);
            this.txtSearchProduct.TabIndex = 0;
            this.txtSearchProduct.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtSearchProduct.TextBoxForeColor = System.Drawing.Color.White;
            this.txtSearchProduct.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearchProduct.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtSearchProduct.TextValue = "";
            this.txtSearchProduct.TxtOffsetX = 0;
            this.txtSearchProduct.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtSearchProduct.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchProduct.UnderlineOnly = false;
            this.txtSearchProduct.UnderlineThickness = 2;
            this.txtSearchProduct.UsePasswordChar = false;
            this.txtSearchProduct.TextValueChanged += new System.Action(this.txtSearchProduct_TextValueChanged);
            // 
            // panelInvoiceSide
            // 
            this.panelInvoiceSide.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelInvoiceSide.BorderRadius = 15;
            this.panelInvoiceSide.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.panelInvoiceSide.BorderThickness = 1;
            this.panelInvoiceSide.Controls.Add(this.txtSearchMember);
            this.panelInvoiceSide.Controls.Add(this.btnClose);
            this.panelInvoiceSide.Controls.Add(this.panelMemberResult);
            this.panelInvoiceSide.Controls.Add(this.label2);
            this.panelInvoiceSide.Controls.Add(this.btnConfirmSale);
            this.panelInvoiceSide.Controls.Add(this.roundedPanel1);
            this.panelInvoiceSide.Controls.Add(this.flowInvoiceItems);
            this.panelInvoiceSide.CornerBottomLeft = false;
            this.panelInvoiceSide.CornerBottomRight = true;
            this.panelInvoiceSide.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight)));
            this.panelInvoiceSide.CornerTopLeft = false;
            this.panelInvoiceSide.CornerTopRight = true;
            this.panelInvoiceSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInvoiceSide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panelInvoiceSide.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panelInvoiceSide.ForceGlow = false;
            this.panelInvoiceSide.GlowColor = System.Drawing.Color.DodgerBlue;
            this.panelInvoiceSide.GlowEnabled = false;
            this.panelInvoiceSide.GlowSize = 5;
            this.panelInvoiceSide.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelInvoiceSide.Location = new System.Drawing.Point(769, 0);
            this.panelInvoiceSide.Name = "panelInvoiceSide";
            this.panelInvoiceSide.Size = new System.Drawing.Size(472, 777);
            this.panelInvoiceSide.TabIndex = 0;
            this.panelInvoiceSide.UnderlineColor = System.Drawing.Color.LightGray;
            this.panelInvoiceSide.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.panelInvoiceSide.UnderlineOnly = false;
            this.panelInvoiceSide.UnderlineThickness = 2;
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchMember.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchMember.BorderRadius = 25;
            this.txtSearchMember.BorderThickness = 2;
            this.txtSearchMember.EnableEnterPress = false;
            this.txtSearchMember.EnableGroupSeparators = true;
            this.txtSearchMember.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchMember.GlowEnabled = false;
            this.txtSearchMember.GlowSize = 5;
            this.txtSearchMember.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtSearchMember.LeftIconImage = null;
            this.txtSearchMember.LeftIconOffsetX = 0;
            this.txtSearchMember.LeftIconSize = 25;
            this.txtSearchMember.Location = new System.Drawing.Point(23, 431);
            this.txtSearchMember.Multiline = false;
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchMember.PlaceholderText = "Search By Name or ID..";
            this.txtSearchMember.RightAndLeftIconVisible = true;
            this.txtSearchMember.RightIconImage = null;
            this.txtSearchMember.RightIconOffsetX = 0;
            this.txtSearchMember.RightIconSize = 25;
            this.txtSearchMember.Size = new System.Drawing.Size(271, 49);
            this.txtSearchMember.TabIndex = 3;
            this.txtSearchMember.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.txtSearchMember.TextBoxForeColor = System.Drawing.Color.White;
            this.txtSearchMember.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearchMember.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtSearchMember.TextValue = "";
            this.txtSearchMember.TxtOffsetX = 0;
            this.txtSearchMember.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtSearchMember.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchMember.UnderlineOnly = false;
            this.txtSearchMember.UnderlineThickness = 2;
            this.txtSearchMember.UsePasswordChar = false;
            this.txtSearchMember.TextValueChanged += new System.Action(this.txtSearchMember_TextValueChanged);
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
            this.btnClose.Location = new System.Drawing.Point(294, 618);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(156, 54);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMemberResult
            // 
            this.panelMemberResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panelMemberResult.Controls.Add(this.lblMemberName);
            this.panelMemberResult.Controls.Add(this.lblMemberStatus);
            this.panelMemberResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMemberResult.Location = new System.Drawing.Point(23, 500);
            this.panelMemberResult.Name = "panelMemberResult";
            this.panelMemberResult.Size = new System.Drawing.Size(410, 84);
            this.panelMemberResult.TabIndex = 7;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.White;
            this.lblMemberName.Location = new System.Drawing.Point(3, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(18, 30);
            this.lblMemberName.TabIndex = 3;
            this.lblMemberName.Text = ".";
            this.lblMemberName.Visible = false;
            // 
            // lblMemberStatus
            // 
            this.lblMemberStatus.AutoSize = true;
            this.lblMemberStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMemberStatus.Location = new System.Drawing.Point(3, 30);
            this.lblMemberStatus.Name = "lblMemberStatus";
            this.lblMemberStatus.Size = new System.Drawing.Size(18, 30);
            this.lblMemberStatus.TabIndex = 2;
            this.lblMemberStatus.Text = ".";
            this.lblMemberStatus.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(18, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search about Member";
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmSale.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmSale.BorderRadius = 20;
            this.btnConfirmSale.BorderThickness = 0;
            this.btnConfirmSale.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnConfirmSale.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnConfirmSale.DisabledForeColor = System.Drawing.Color.White;
            this.btnConfirmSale.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmSale.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnConfirmSale.FlatAppearance.BorderSize = 0;
            this.btnConfirmSale.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSale.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnConfirmSale.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSale.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnConfirmSale.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnConfirmSale.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnConfirmSale.ImageColor = System.Drawing.Color.White;
            this.btnConfirmSale.ImageColorMode = false;
            this.btnConfirmSale.ImageSize = new System.Drawing.Size(0, 0);
            this.btnConfirmSale.IsSelected = false;
            this.btnConfirmSale.Location = new System.Drawing.Point(28, 618);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnConfirmSale.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnConfirmSale.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirmSale.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnConfirmSale.Size = new System.Drawing.Size(246, 54);
            this.btnConfirmSale.TabIndex = 5;
            this.btnConfirmSale.Text = "Confirm Sale";
            this.btnConfirmSale.UseVisualStyleBackColor = false;
            this.btnConfirmSale.Click += new System.EventHandler(this.btnConfirmSale_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.lblTotalAmount);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.CornerBottomLeft = true;
            this.roundedPanel1.CornerBottomRight = true;
            this.roundedPanel1.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.roundedPanel1.CornerTopLeft = true;
            this.roundedPanel1.CornerTopRight = true;
            this.roundedPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.roundedPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.roundedPanel1.ForceGlow = false;
            this.roundedPanel1.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.GlowEnabled = false;
            this.roundedPanel1.GlowSize = 5;
            this.roundedPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel1.Location = new System.Drawing.Point(28, 302);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(410, 86);
            this.roundedPanel1.TabIndex = 3;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(193, 25);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(22, 30);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total : ";
            // 
            // flowInvoiceItems
            // 
            this.flowInvoiceItems.AutoScroll = true;
            this.flowInvoiceItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.flowInvoiceItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowInvoiceItems.Location = new System.Drawing.Point(28, 82);
            this.flowInvoiceItems.Name = "flowInvoiceItems";
            this.flowInvoiceItems.Size = new System.Drawing.Size(410, 199);
            this.flowInvoiceItems.TabIndex = 2;
            this.flowInvoiceItems.WrapContents = false;
            // 
            // ucSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProductsSide);
            this.Controls.Add(this.panelInvoiceSide);
            this.Name = "ucSales";
            this.Size = new System.Drawing.Size(1241, 777);
            this.panelProductsSide.ResumeLayout(false);
            this.panelInvoiceSide.ResumeLayout(false);
            this.panelInvoiceSide.PerformLayout();
            this.panelMemberResult.ResumeLayout(false);
            this.panelMemberResult.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel panelInvoiceSide;
        private CustomControls.RoundedPanel panelProductsSide;
        private ucTextBox txtSearchProduct;
        private System.Windows.Forms.FlowLayoutPanel flowCategories;
        private System.Windows.Forms.FlowLayoutPanel flowInvoiceItems;
        private ucTextBox txtSearchMember;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedButton btnConfirmSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelMemberResult;
        private CustomControls.RoundedButton btnClose;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblMemberStatus;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
    }
}
