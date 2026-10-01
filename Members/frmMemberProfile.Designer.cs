namespace Gym
{
    partial class frmMemberProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            this.customDataGridView1 = new Gym.CustomDataGridView();
            this.roundedPanel3 = new Gym.CustomControls.RoundedPanel();
            this.btnPayments = new Gym.CustomControls.RoundedButton();
            this.btnMemberShip = new Gym.CustomControls.RoundedButton();
            this.roundedPanel2 = new Gym.CustomControls.RoundedPanel();
            this.PanelAvatar = new Gym.CustomControls.RoundedPanel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMemberSince = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.PanelAvatar.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(295, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Profile";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.BorderRadius = 15;
            this.btnClose.BorderThickness = 0;
            this.btnClose.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnClose.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnClose.DisabledForeColor = System.Drawing.Color.White;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
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
            this.btnClose.Location = new System.Drawing.Point(586, 761);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(179, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.AllowUserToAddRows = false;
            this.customDataGridView1.AllowUserToDeleteRows = false;
            this.customDataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.customDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.customDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.customDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGridView1.EnableHeadersVisualStyles = false;
            this.customDataGridView1.Location = new System.Drawing.Point(22, 521);
            this.customDataGridView1.MaxVisibleRows = 5;
            this.customDataGridView1.MultiSelect = false;
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.ReadOnly = true;
            this.customDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.customDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.customDataGridView1.RowTemplate.Height = 40;
            this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView1.Size = new System.Drawing.Size(778, 186);
            this.customDataGridView1.TabIndex = 9;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel3.BorderRadius = 15;
            this.roundedPanel3.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel3.BorderThickness = 1;
            this.roundedPanel3.Controls.Add(this.btnPayments);
            this.roundedPanel3.Controls.Add(this.btnMemberShip);
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
            this.roundedPanel3.Location = new System.Drawing.Point(171, 421);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(382, 76);
            this.roundedPanel3.TabIndex = 8;
            this.roundedPanel3.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel3.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel3.UnderlineOnly = false;
            this.roundedPanel3.UnderlineThickness = 2;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnPayments.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPayments.BorderRadius = 15;
            this.btnPayments.BorderThickness = 0;
            this.btnPayments.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnPayments.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnPayments.DisabledForeColor = System.Drawing.Color.White;
            this.btnPayments.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnPayments.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnPayments.HoverFillColor = System.Drawing.Color.MediumTurquoise;
            this.btnPayments.HoverFillColor2 = System.Drawing.Color.SteelBlue;
            this.btnPayments.ImageColor = System.Drawing.Color.White;
            this.btnPayments.ImageColorMode = false;
            this.btnPayments.ImageSize = new System.Drawing.Size(0, 0);
            this.btnPayments.IsSelected = false;
            this.btnPayments.Location = new System.Drawing.Point(8, 13);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnPayments.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnPayments.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPayments.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnPayments.Size = new System.Drawing.Size(179, 49);
            this.btnPayments.TabIndex = 1;
            this.btnPayments.Text = "Payments History";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnMemberShip
            // 
            this.btnMemberShip.BackColor = System.Drawing.Color.Transparent;
            this.btnMemberShip.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMemberShip.BorderRadius = 15;
            this.btnMemberShip.BorderThickness = 0;
            this.btnMemberShip.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnMemberShip.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnMemberShip.DisabledForeColor = System.Drawing.Color.White;
            this.btnMemberShip.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnMemberShip.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnMemberShip.FlatAppearance.BorderSize = 0;
            this.btnMemberShip.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMemberShip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMemberShip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMemberShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberShip.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnMemberShip.ForeColor = System.Drawing.Color.White;
            this.btnMemberShip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnMemberShip.HoverFillColor = System.Drawing.Color.MediumTurquoise;
            this.btnMemberShip.HoverFillColor2 = System.Drawing.Color.SteelBlue;
            this.btnMemberShip.ImageColor = System.Drawing.Color.White;
            this.btnMemberShip.ImageColorMode = false;
            this.btnMemberShip.ImageSize = new System.Drawing.Size(0, 0);
            this.btnMemberShip.IsSelected = false;
            this.btnMemberShip.Location = new System.Drawing.Point(195, 13);
            this.btnMemberShip.Name = "btnMemberShip";
            this.btnMemberShip.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnMemberShip.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnMemberShip.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMemberShip.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnMemberShip.Size = new System.Drawing.Size(179, 49);
            this.btnMemberShip.TabIndex = 0;
            this.btnMemberShip.Text = "MemberShips History";
            this.btnMemberShip.UseVisualStyleBackColor = false;
            this.btnMemberShip.Click += new System.EventHandler(this.btnMemberShip_Click);
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
            this.roundedPanel2.Controls.Add(this.lblStatus);
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
            this.roundedPanel2.Location = new System.Drawing.Point(22, 53);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(369, 108);
            this.roundedPanel2.TabIndex = 7;
            this.roundedPanel2.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel2.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel2.UnderlineOnly = false;
            this.roundedPanel2.UnderlineThickness = 2;
            // 
            // PanelAvatar
            // 
            this.PanelAvatar.BorderColor = System.Drawing.Color.Gainsboro;
            this.PanelAvatar.BorderRadius = 15;
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
            this.lblAvatar.Location = new System.Drawing.Point(24, 33);
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
            this.lblMemberID.Size = new System.Drawing.Size(44, 25);
            this.lblMemberID.TabIndex = 11;
            this.lblMemberID.Text = "????";
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(291, 33);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Active";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.lblGender);
            this.roundedPanel1.Controls.Add(this.lblPhone);
            this.roundedPanel1.Controls.Add(this.lblMemberSince);
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.lblDOB);
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
            this.roundedPanel1.Location = new System.Drawing.Point(22, 177);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(743, 226);
            this.roundedPanel1.TabIndex = 6;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGender.Location = new System.Drawing.Point(341, 65);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(44, 25);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "????";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPhone.Location = new System.Drawing.Point(28, 65);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 25);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "????";
            // 
            // lblMemberSince
            // 
            this.lblMemberSince.AutoSize = true;
            this.lblMemberSince.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberSince.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMemberSince.Location = new System.Drawing.Point(341, 161);
            this.lblMemberSince.Name = "lblMemberSince";
            this.lblMemberSince.Size = new System.Drawing.Size(44, 25);
            this.lblMemberSince.TabIndex = 7;
            this.lblMemberSince.Text = "????";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(341, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "DateOfBirth ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(28, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(319, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Member Since ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDOB.Location = new System.Drawing.Point(28, 161);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(44, 25);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "????";
            // 
            // frmMemberProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(835, 830);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.customDataGridView1);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "frmMemberProfile";
            this.ShowIcon = false;
            this.Text = "Member Profile";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmMemberProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.PanelAvatar.ResumeLayout(false);
            this.PanelAvatar.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMemberSince;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label label10;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedPanel roundedPanel2;
        private CustomControls.RoundedPanel roundedPanel3;
        private CustomControls.RoundedButton btnPayments;
        private CustomControls.RoundedButton btnMemberShip;
        private CustomDataGridView customDataGridView1;
        private CustomControls.RoundedButton btnClose;
        private CustomControls.RoundedPanel PanelAvatar;
        private System.Windows.Forms.Label lblAvatar;
    }
}