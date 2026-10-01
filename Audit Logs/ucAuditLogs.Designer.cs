namespace Gym
{
    partial class ucAuditLogs
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Gym.ucTextBox();
            this.dtpToDate = new Gym.CustomDateTimePicker();
            this.dtpFromDate = new Gym.CustomDateTimePicker();
            this.btnReset = new Gym.CustomControls.RoundedButton();
            this.cbActionTypes = new Gym.CustomControls.ucComboBox();
            this.cbTables = new Gym.CustomControls.ucComboBox();
            this.cbUsers = new Gym.CustomControls.ucComboBox();
            this.dgvAuditLogs = new Gym.CustomDataGridView();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnPreviousPage = new Gym.CustomControls.RoundedButton();
            this.btnNextPage = new Gym.CustomControls.RoundedButton();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(506, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Audit Logs";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.BorderRadius = 15;
            this.btnClose.BorderThickness = 0;
            this.btnClose.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnClose.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnClose.DisabledForeColor = System.Drawing.Color.White;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
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
            this.btnClose.Location = new System.Drawing.Point(1082, 719);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(127, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.txtSearch);
            this.roundedPanel1.Controls.Add(this.dtpToDate);
            this.roundedPanel1.Controls.Add(this.dtpFromDate);
            this.roundedPanel1.Controls.Add(this.btnReset);
            this.roundedPanel1.Controls.Add(this.cbActionTypes);
            this.roundedPanel1.Controls.Add(this.cbTables);
            this.roundedPanel1.Controls.Add(this.cbUsers);
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
            this.roundedPanel1.Location = new System.Drawing.Point(24, 101);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1018, 181);
            this.roundedPanel1.TabIndex = 6;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(20, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "From Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(257, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "To Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(497, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(257, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Actions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(20, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Users";
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
            this.txtSearch.LeftIconImage = null;
            this.txtSearch.LeftIconOffsetX = 0;
            this.txtSearch.LeftIconSize = 25;
            this.txtSearch.Location = new System.Drawing.Point(484, 110);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.PlaceholderText = "Search by details or Record ID..... ";
            this.txtSearch.RightAndLeftIconVisible = true;
            this.txtSearch.RightIconImage = null;
            this.txtSearch.RightIconOffsetX = 0;
            this.txtSearch.RightIconSize = 25;
            this.txtSearch.Size = new System.Drawing.Size(286, 43);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
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
            // dtpToDate
            // 
            this.dtpToDate.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.dtpToDate.BorderRadius = 12;
            this.dtpToDate.BorderSize = 2;
            this.dtpToDate.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpToDate.IconColor = System.Drawing.Color.CornflowerBlue;
            this.dtpToDate.Location = new System.Drawing.Point(243, 116);
            this.dtpToDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.PlaceholderText = "Select Date...";
            this.dtpToDate.ShowPlaceholder = true;
            this.dtpToDate.Size = new System.Drawing.Size(200, 35);
            this.dtpToDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.dtpToDate.TabIndex = 10;
            this.dtpToDate.TextColor = System.Drawing.Color.White;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.dtpFromDate.BorderRadius = 12;
            this.dtpFromDate.BorderSize = 2;
            this.dtpFromDate.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFromDate.IconColor = System.Drawing.Color.CornflowerBlue;
            this.dtpFromDate.Location = new System.Drawing.Point(12, 116);
            this.dtpFromDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.PlaceholderText = "Select Date...";
            this.dtpFromDate.ShowPlaceholder = true;
            this.dtpFromDate.Size = new System.Drawing.Size(200, 35);
            this.dtpFromDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.dtpFromDate.TabIndex = 9;
            this.dtpFromDate.TextColor = System.Drawing.Color.White;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.BorderRadius = 15;
            this.btnReset.BorderThickness = 0;
            this.btnReset.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnReset.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnReset.DisabledForeColor = System.Drawing.Color.White;
            this.btnReset.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnReset.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnReset.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnReset.ImageColor = System.Drawing.Color.White;
            this.btnReset.ImageColorMode = false;
            this.btnReset.ImageSize = new System.Drawing.Size(0, 0);
            this.btnReset.IsSelected = false;
            this.btnReset.Location = new System.Drawing.Point(825, 100);
            this.btnReset.Name = "btnReset";
            this.btnReset.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnReset.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnReset.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnReset.Size = new System.Drawing.Size(149, 51);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Clear Filters";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbActionTypes
            // 
            this.cbActionTypes.AutoHeight = false;
            this.cbActionTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbActionTypes.BorderColor = System.Drawing.Color.DarkGray;
            this.cbActionTypes.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.cbActionTypes.BorderRadius = 20;
            this.cbActionTypes.BorderThickness = 1;
            this.cbActionTypes.cbFont = new System.Drawing.Font("Segoe UI", 9F);
            this.cbActionTypes.cbForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbActionTypes.DataSource = null;
            this.cbActionTypes.DisplayMember = "";
            this.cbActionTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActionTypes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cbActionTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActionTypes.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbActionTypes.HoverForeColor = System.Drawing.Color.DodgerBlue;
            this.cbActionTypes.Location = new System.Drawing.Point(242, 35);
            this.cbActionTypes.Margin = new System.Windows.Forms.Padding(5);
            this.cbActionTypes.Name = "cbActionTypes";
            this.cbActionTypes.PlaceholderColor = System.Drawing.Color.Gray;
            this.cbActionTypes.PlaceholderText = "";
            this.cbActionTypes.SelectedIndex = -1;
            this.cbActionTypes.SelectedItem = null;
            this.cbActionTypes.SelectedValue = null;
            this.cbActionTypes.Size = new System.Drawing.Size(209, 41);
            this.cbActionTypes.TabIndex = 4;
            this.cbActionTypes.ValueMember = "";
            this.cbActionTypes.VerticalPadding = 12;
            this.cbActionTypes.SelectedIndexChanged += new System.EventHandler(this.cbActionTypes_SelectedIndexChanged);
            // 
            // cbTables
            // 
            this.cbTables.AutoHeight = false;
            this.cbTables.BackColor = System.Drawing.Color.Transparent;
            this.cbTables.BorderColor = System.Drawing.Color.DarkGray;
            this.cbTables.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.cbTables.BorderRadius = 20;
            this.cbTables.BorderThickness = 1;
            this.cbTables.cbFont = new System.Drawing.Font("Segoe UI", 9F);
            this.cbTables.cbForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbTables.DataSource = null;
            this.cbTables.DisplayMember = "";
            this.cbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTables.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cbTables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTables.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbTables.HoverForeColor = System.Drawing.Color.DodgerBlue;
            this.cbTables.Location = new System.Drawing.Point(485, 35);
            this.cbTables.Margin = new System.Windows.Forms.Padding(5);
            this.cbTables.Name = "cbTables";
            this.cbTables.PlaceholderColor = System.Drawing.Color.Gray;
            this.cbTables.PlaceholderText = "";
            this.cbTables.SelectedIndex = -1;
            this.cbTables.SelectedItem = null;
            this.cbTables.SelectedValue = null;
            this.cbTables.Size = new System.Drawing.Size(209, 41);
            this.cbTables.TabIndex = 5;
            this.cbTables.ValueMember = "";
            this.cbTables.VerticalPadding = 12;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // cbUsers
            // 
            this.cbUsers.AutoHeight = false;
            this.cbUsers.BackColor = System.Drawing.Color.Transparent;
            this.cbUsers.BorderColor = System.Drawing.Color.DarkGray;
            this.cbUsers.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.cbUsers.BorderRadius = 20;
            this.cbUsers.BorderThickness = 1;
            this.cbUsers.cbFont = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUsers.cbForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbUsers.DataSource = null;
            this.cbUsers.DisplayMember = "";
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cbUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsers.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbUsers.HoverForeColor = System.Drawing.Color.DodgerBlue;
            this.cbUsers.Location = new System.Drawing.Point(12, 35);
            this.cbUsers.Margin = new System.Windows.Forms.Padding(5);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.PlaceholderColor = System.Drawing.Color.Gray;
            this.cbUsers.PlaceholderText = "";
            this.cbUsers.SelectedIndex = -1;
            this.cbUsers.SelectedItem = null;
            this.cbUsers.SelectedValue = null;
            this.cbUsers.Size = new System.Drawing.Size(209, 41);
            this.cbUsers.TabIndex = 3;
            this.cbUsers.ValueMember = "";
            this.cbUsers.VerticalPadding = 12;
            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);
            // 
            // dgvAuditLogs
            // 
            this.dgvAuditLogs.AllowUserToAddRows = false;
            this.dgvAuditLogs.AllowUserToDeleteRows = false;
            this.dgvAuditLogs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvAuditLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuditLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditLogs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dgvAuditLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.dgvAuditLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuditLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditLogs.EnableHeadersVisualStyles = false;
            this.dgvAuditLogs.Location = new System.Drawing.Point(24, 309);
            this.dgvAuditLogs.MaxVisibleRows = 8;
            this.dgvAuditLogs.MultiSelect = false;
            this.dgvAuditLogs.Name = "dgvAuditLogs";
            this.dgvAuditLogs.ReadOnly = true;
            this.dgvAuditLogs.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAuditLogs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuditLogs.RowTemplate.Height = 40;
            this.dgvAuditLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditLogs.Size = new System.Drawing.Size(1185, 383);
            this.dgvAuditLogs.TabIndex = 2;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPageInfo.Location = new System.Drawing.Point(53, 733);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(24, 21);
            this.lblPageInfo.TabIndex = 19;
            this.lblPageInfo.Text = "??";
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousPage.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPreviousPage.BorderRadius = 15;
            this.btnPreviousPage.BorderThickness = 0;
            this.btnPreviousPage.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnPreviousPage.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnPreviousPage.DisabledForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnPreviousPage.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPreviousPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPreviousPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnPreviousPage.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnPreviousPage.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnPreviousPage.ImageColor = System.Drawing.Color.White;
            this.btnPreviousPage.ImageColorMode = false;
            this.btnPreviousPage.ImageSize = new System.Drawing.Size(0, 0);
            this.btnPreviousPage.IsSelected = false;
            this.btnPreviousPage.Location = new System.Drawing.Point(24, 731);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnPreviousPage.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnPreviousPage.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPreviousPage.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnPreviousPage.Size = new System.Drawing.Size(21, 23);
            this.btnPreviousPage.TabIndex = 18;
            this.btnPreviousPage.Text = "-";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNextPage.BorderRadius = 15;
            this.btnNextPage.BorderThickness = 0;
            this.btnNextPage.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnNextPage.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnNextPage.DisabledForeColor = System.Drawing.Color.White;
            this.btnNextPage.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnNextPage.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnNextPage.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnNextPage.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnNextPage.ImageColor = System.Drawing.Color.White;
            this.btnNextPage.ImageColorMode = false;
            this.btnNextPage.ImageSize = new System.Drawing.Size(0, 0);
            this.btnNextPage.IsSelected = false;
            this.btnNextPage.Location = new System.Drawing.Point(227, 731);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnNextPage.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnNextPage.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNextPage.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnNextPage.Size = new System.Drawing.Size(21, 23);
            this.btnNextPage.TabIndex = 17;
            this.btnNextPage.Text = "+";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ucAuditLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.dgvAuditLogs);
            this.Controls.Add(this.label1);
            this.Name = "ucAuditLogs";
            this.Size = new System.Drawing.Size(1238, 780);
            this.Load += new System.EventHandler(this.ucAuditLogs_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomDataGridView dgvAuditLogs;
        private CustomControls.ucComboBox cbUsers;
        private CustomControls.ucComboBox cbActionTypes;
        private CustomControls.ucComboBox cbTables;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedButton btnReset;
        private ucTextBox txtSearch;
        private CustomDateTimePicker dtpToDate;
        private CustomDateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CustomControls.RoundedButton btnClose;
        private System.Windows.Forms.Label lblPageInfo;
        private CustomControls.RoundedButton btnPreviousPage;
        private CustomControls.RoundedButton btnNextPage;
    }
}
