namespace Gym
{
    partial class RenewMemberShip
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
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.roundedPanel2 = new Gym.CustomControls.RoundedPanel();
            this.PanelAvatar = new Gym.CustomControls.RoundedPanel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberShipID = new Gym.ucTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndDate = new Gym.ucTextBox();
            this.txtStartDate = new Gym.ucTextBox();
            this.cbPlan = new Gym.CustomControls.ucComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new Gym.CustomControls.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotes = new Gym.ucTextBox();
            this.txtAmount = new Gym.ucTextBox();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            this.btnSave = new Gym.CustomControls.RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.PanelAvatar.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(259, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Renew MemberShip";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel2.BorderRadius = 15;
            this.roundedPanel2.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel2.BorderThickness = 1;
            this.roundedPanel2.Controls.Add(this.PanelAvatar);
            this.roundedPanel2.Controls.Add(this.lblName);
            this.roundedPanel2.Controls.Add(this.lblMemberID);
            this.roundedPanel2.Controls.Add(this.label10);
            this.roundedPanel2.CornerBottomLeft = true;
            this.roundedPanel2.CornerBottomRight = true;
            this.roundedPanel2.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.roundedPanel2.CornerTopLeft = true;
            this.roundedPanel2.CornerTopRight = true;
            this.roundedPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel2.ForceGlow = false;
            this.roundedPanel2.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel2.GlowEnabled = false;
            this.roundedPanel2.GlowSize = 5;
            this.roundedPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel2.Location = new System.Drawing.Point(16, 71);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(369, 108);
            this.roundedPanel2.TabIndex = 8;
            this.roundedPanel2.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel2.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel2.UnderlineOnly = false;
            this.roundedPanel2.UnderlineThickness = 2;
            // 
            // PanelAvatar
            // 
            this.PanelAvatar.BorderColor = System.Drawing.Color.Gainsboro;
            this.PanelAvatar.BorderRadius = 20;
            this.PanelAvatar.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.PanelAvatar.BorderThickness = 1;
            this.PanelAvatar.Controls.Add(this.lblAvatar);
            this.PanelAvatar.CornerBottomLeft = true;
            this.PanelAvatar.CornerBottomRight = true;
            this.PanelAvatar.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.PanelAvatar.CornerTopLeft = true;
            this.PanelAvatar.CornerTopRight = true;
            this.PanelAvatar.FillColor = System.Drawing.Color.CornflowerBlue;
            this.PanelAvatar.FillColor2 = System.Drawing.Color.SlateBlue;
            this.PanelAvatar.ForceGlow = false;
            this.PanelAvatar.GlowColor = System.Drawing.Color.DodgerBlue;
            this.PanelAvatar.GlowEnabled = false;
            this.PanelAvatar.GlowSize = 5;
            this.PanelAvatar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.PanelAvatar.Location = new System.Drawing.Point(11, 7);
            this.PanelAvatar.Name = "PanelAvatar";
            this.PanelAvatar.Size = new System.Drawing.Size(100, 62);
            this.PanelAvatar.TabIndex = 10;
            this.PanelAvatar.UnderlineColor = System.Drawing.Color.LightGray;
            this.PanelAvatar.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.PanelAvatar.UnderlineOnly = false;
            this.PanelAvatar.UnderlineThickness = 2;
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAvatar.Location = new System.Drawing.Point(25, 33);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(28, 25);
            this.lblAvatar.TabIndex = 12;
            this.lblAvatar.Text = "??";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(117, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "????";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMemberID.Location = new System.Drawing.Point(241, 56);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(28, 25);
            this.lblMemberID.TabIndex = 11;
            this.lblMemberID.Text = "??";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(111, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "MemberID :";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(this.txtMemberShipID);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.label11);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.txtEndDate);
            this.roundedPanel1.Controls.Add(this.txtStartDate);
            this.roundedPanel1.Controls.Add(this.cbPlan);
            this.roundedPanel1.CornerBottomLeft = true;
            this.roundedPanel1.CornerBottomRight = true;
            this.roundedPanel1.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.roundedPanel1.CornerTopLeft = true;
            this.roundedPanel1.CornerTopRight = true;
            this.roundedPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel1.ForceGlow = false;
            this.roundedPanel1.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.GlowEnabled = false;
            this.roundedPanel1.GlowSize = 5;
            this.roundedPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel1.Location = new System.Drawing.Point(16, 232);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(726, 188);
            this.roundedPanel1.TabIndex = 9;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(13, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "MemberShipID";
            // 
            // txtMemberShipID
            // 
            this.txtMemberShipID.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMemberShipID.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMemberShipID.BorderRadius = 25;
            this.txtMemberShipID.BorderThickness = 2;
            this.txtMemberShipID.CausesValidation = false;
            this.txtMemberShipID.EnableEnterPress = false;
            this.txtMemberShipID.EnableGroupSeparators = true;
            this.txtMemberShipID.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtMemberShipID.GlowEnabled = false;
            this.txtMemberShipID.GlowSize = 5;
            this.txtMemberShipID.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtMemberShipID.LeftIconImage = null;
            this.txtMemberShipID.LeftIconOffsetX = 0;
            this.txtMemberShipID.LeftIconSize = 25;
            this.txtMemberShipID.Location = new System.Drawing.Point(9, 35);
            this.txtMemberShipID.Multiline = false;
            this.txtMemberShipID.Name = "txtMemberShipID";
            this.txtMemberShipID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMemberShipID.PlaceholderText = "MemberShipID";
            this.txtMemberShipID.RightAndLeftIconVisible = true;
            this.txtMemberShipID.RightIconImage = null;
            this.txtMemberShipID.RightIconOffsetX = 0;
            this.txtMemberShipID.RightIconSize = 25;
            this.txtMemberShipID.Size = new System.Drawing.Size(274, 57);
            this.txtMemberShipID.TabIndex = 14;
            this.txtMemberShipID.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtMemberShipID.TextBoxForeColor = System.Drawing.Color.White;
            this.txtMemberShipID.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMemberShipID.TextMode = Gym.ucTextBox.InputMode.ReadOnly;
            this.txtMemberShipID.TextValue = "";
            this.txtMemberShipID.TxtOffsetX = 0;
            this.txtMemberShipID.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtMemberShipID.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMemberShipID.UnderlineOnly = false;
            this.txtMemberShipID.UnderlineThickness = 2;
            this.txtMemberShipID.UsePasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(430, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Plan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(437, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start Date";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtEndDate.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtEndDate.BorderRadius = 25;
            this.txtEndDate.BorderThickness = 2;
            this.txtEndDate.CausesValidation = false;
            this.txtEndDate.EnableEnterPress = false;
            this.txtEndDate.EnableGroupSeparators = true;
            this.txtEndDate.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtEndDate.GlowEnabled = false;
            this.txtEndDate.GlowSize = 5;
            this.txtEndDate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtEndDate.LeftIconImage = null;
            this.txtEndDate.LeftIconOffsetX = 0;
            this.txtEndDate.LeftIconSize = 25;
            this.txtEndDate.Location = new System.Drawing.Point(428, 122);
            this.txtEndDate.Multiline = false;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEndDate.PlaceholderText = "End Date";
            this.txtEndDate.RightAndLeftIconVisible = true;
            this.txtEndDate.RightIconImage = null;
            this.txtEndDate.RightIconOffsetX = 0;
            this.txtEndDate.RightIconSize = 25;
            this.txtEndDate.Size = new System.Drawing.Size(274, 57);
            this.txtEndDate.TabIndex = 2;
            this.txtEndDate.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtEndDate.TextBoxForeColor = System.Drawing.Color.White;
            this.txtEndDate.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEndDate.TextMode = Gym.ucTextBox.InputMode.ReadOnly;
            this.txtEndDate.TextValue = "";
            this.txtEndDate.TxtOffsetX = 0;
            this.txtEndDate.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtEndDate.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtEndDate.UnderlineOnly = false;
            this.txtEndDate.UnderlineThickness = 2;
            this.txtEndDate.UsePasswordChar = false;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtStartDate.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtStartDate.BorderRadius = 25;
            this.txtStartDate.BorderThickness = 2;
            this.txtStartDate.CausesValidation = false;
            this.txtStartDate.EnableEnterPress = false;
            this.txtStartDate.EnableGroupSeparators = true;
            this.txtStartDate.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtStartDate.GlowEnabled = false;
            this.txtStartDate.GlowSize = 5;
            this.txtStartDate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtStartDate.LeftIconImage = null;
            this.txtStartDate.LeftIconOffsetX = 0;
            this.txtStartDate.LeftIconSize = 25;
            this.txtStartDate.Location = new System.Drawing.Point(11, 123);
            this.txtStartDate.Multiline = false;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtStartDate.PlaceholderText = "Start Date";
            this.txtStartDate.RightAndLeftIconVisible = true;
            this.txtStartDate.RightIconImage = null;
            this.txtStartDate.RightIconOffsetX = 0;
            this.txtStartDate.RightIconSize = 25;
            this.txtStartDate.Size = new System.Drawing.Size(274, 57);
            this.txtStartDate.TabIndex = 1;
            this.txtStartDate.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtStartDate.TextBoxForeColor = System.Drawing.Color.White;
            this.txtStartDate.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtStartDate.TextMode = Gym.ucTextBox.InputMode.ReadOnly;
            this.txtStartDate.TextValue = "";
            this.txtStartDate.TxtOffsetX = 0;
            this.txtStartDate.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtStartDate.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtStartDate.UnderlineOnly = false;
            this.txtStartDate.UnderlineThickness = 2;
            this.txtStartDate.UsePasswordChar = false;
            // 
            // cbPlan
            // 
            this.cbPlan.AutoHeight = false;
            this.cbPlan.BackColor = System.Drawing.Color.Transparent;
            this.cbPlan.BorderColor = System.Drawing.Color.DarkGray;
            this.cbPlan.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.cbPlan.BorderRadius = 20;
            this.cbPlan.BorderThickness = 1;
            this.cbPlan.cbFont = new System.Drawing.Font("Segoe UI", 9F);
            this.cbPlan.cbForeColor = System.Drawing.SystemColors.Control;
            this.cbPlan.DataSource = null;
            this.cbPlan.DisplayMember = "";
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cbPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlan.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbPlan.HoverForeColor = System.Drawing.Color.DodgerBlue;
            this.cbPlan.Location = new System.Drawing.Point(428, 36);
            this.cbPlan.Margin = new System.Windows.Forms.Padding(5);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.PlaceholderColor = System.Drawing.Color.Gray;
            this.cbPlan.PlaceholderText = "";
            this.cbPlan.SelectedIndex = -1;
            this.cbPlan.SelectedItem = null;
            this.cbPlan.SelectedValue = null;
            this.cbPlan.Size = new System.Drawing.Size(209, 41);
            this.cbPlan.TabIndex = 0;
            this.cbPlan.ValueMember = "";
            this.cbPlan.VerticalPadding = 12;
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(12, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "MemberShip Details";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel3.BorderRadius = 15;
            this.roundedPanel3.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel3.BorderThickness = 1;
            this.roundedPanel3.Controls.Add(this.label3);
            this.roundedPanel3.Controls.Add(this.txtNotes);
            this.roundedPanel3.Controls.Add(this.txtAmount);
            this.roundedPanel3.CornerBottomLeft = true;
            this.roundedPanel3.CornerBottomRight = true;
            this.roundedPanel3.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.roundedPanel3.CornerTopLeft = true;
            this.roundedPanel3.CornerTopRight = true;
            this.roundedPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel3.ForceGlow = false;
            this.roundedPanel3.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel3.GlowEnabled = false;
            this.roundedPanel3.GlowSize = 5;
            this.roundedPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel3.Location = new System.Drawing.Point(17, 466);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(726, 188);
            this.roundedPanel3.TabIndex = 11;
            this.roundedPanel3.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel3.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel3.UnderlineOnly = false;
            this.roundedPanel3.UnderlineThickness = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(26, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Amount";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtNotes.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNotes.BorderRadius = 25;
            this.txtNotes.BorderThickness = 2;
            this.txtNotes.EnableEnterPress = false;
            this.txtNotes.EnableGroupSeparators = true;
            this.txtNotes.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtNotes.GlowEnabled = false;
            this.txtNotes.GlowSize = 5;
            this.txtNotes.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtNotes.LeftIconImage = null;
            this.txtNotes.LeftIconOffsetX = 0;
            this.txtNotes.LeftIconSize = 25;
            this.txtNotes.Location = new System.Drawing.Point(352, 20);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNotes.PlaceholderText = "Notes";
            this.txtNotes.RightAndLeftIconVisible = true;
            this.txtNotes.RightIconImage = null;
            this.txtNotes.RightIconOffsetX = 0;
            this.txtNotes.RightIconSize = 25;
            this.txtNotes.Size = new System.Drawing.Size(360, 149);
            this.txtNotes.TabIndex = 22;
            this.txtNotes.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtNotes.TextBoxForeColor = System.Drawing.Color.White;
            this.txtNotes.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNotes.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtNotes.TextValue = "";
            this.txtNotes.TxtOffsetX = 0;
            this.txtNotes.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtNotes.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNotes.UnderlineOnly = false;
            this.txtNotes.UnderlineThickness = 2;
            this.txtNotes.UsePasswordChar = false;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtAmount.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtAmount.BorderRadius = 25;
            this.txtAmount.BorderThickness = 2;
            this.txtAmount.EnableEnterPress = false;
            this.txtAmount.EnableGroupSeparators = true;
            this.txtAmount.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtAmount.GlowEnabled = false;
            this.txtAmount.GlowSize = 5;
            this.txtAmount.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtAmount.LeftIconImage = null;
            this.txtAmount.LeftIconOffsetX = 0;
            this.txtAmount.LeftIconSize = 25;
            this.txtAmount.Location = new System.Drawing.Point(14, 43);
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAmount.PlaceholderText = "Amount";
            this.txtAmount.RightAndLeftIconVisible = true;
            this.txtAmount.RightIconImage = null;
            this.txtAmount.RightIconOffsetX = 0;
            this.txtAmount.RightIconSize = 25;
            this.txtAmount.Size = new System.Drawing.Size(323, 58);
            this.txtAmount.TabIndex = 21;
            this.txtAmount.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtAmount.TextBoxForeColor = System.Drawing.Color.White;
            this.txtAmount.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAmount.TextMode = Gym.ucTextBox.InputMode.NumbersOnly;
            this.txtAmount.TextValue = "";
            this.txtAmount.TxtOffsetX = 0;
            this.txtAmount.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtAmount.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtAmount.UnderlineOnly = false;
            this.txtAmount.UnderlineThickness = 2;
            this.txtAmount.UsePasswordChar = false;
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
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
            this.btnClose.Location = new System.Drawing.Point(478, 665);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(122, 52);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(620, 665);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnSave.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnSave.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSave.Size = new System.Drawing.Size(122, 52);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(19, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Payment Details";
            // 
            // RenewMemberShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(777, 737);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RenewMemberShip";
            this.ShowIcon = false;
            this.Text = "Renew MemberShip";
            this.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.Load += new System.EventHandler(this.RenewMemberShip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.PanelAvatar.ResumeLayout(false);
            this.PanelAvatar.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustomControls.RoundedPanel roundedPanel2;
        private CustomControls.RoundedPanel PanelAvatar;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private ucTextBox txtEndDate;
        private ucTextBox txtStartDate;
        private CustomControls.ucComboBox cbPlan;
        private CustomControls.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label3;
        private ucTextBox txtNotes;
        private ucTextBox txtAmount;
        private CustomControls.RoundedButton btnClose;
        private CustomControls.RoundedButton btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private ucTextBox txtMemberShipID;
    }
}