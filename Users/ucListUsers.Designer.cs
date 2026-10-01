namespace Gym
{
    partial class ucListUsers
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
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRoleFilter = new Gym.CustomControls.ucComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new Gym.CustomControls.RoundedButton();
            this.cbStatusFilter = new Gym.CustomControls.ucComboBox();
            this.txtFilterValue = new Gym.ucTextBox();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            this.dgvUsers = new Gym.CustomDataGridView();
            this.btnAddNewUser = new Gym.CustomControls.RoundedButton();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(520, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Users";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.cbRoleFilter);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.btnClear);
            this.roundedPanel1.Controls.Add(this.cbStatusFilter);
            this.roundedPanel1.Controls.Add(this.txtFilterValue);
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
            this.roundedPanel1.Location = new System.Drawing.Point(12, 166);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1005, 87);
            this.roundedPanel1.TabIndex = 12;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(617, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Role";
            // 
            // cbRoleFilter
            // 
            this.cbRoleFilter.AutoHeight = false;
            this.cbRoleFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbRoleFilter.BorderColor = System.Drawing.Color.DarkGray;
            this.cbRoleFilter.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.cbRoleFilter.BorderRadius = 20;
            this.cbRoleFilter.BorderThickness = 1;
            this.cbRoleFilter.cbFont = new System.Drawing.Font("Segoe UI", 9F);
            this.cbRoleFilter.cbForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbRoleFilter.DataSource = null;
            this.cbRoleFilter.DisplayMember = "";
            this.cbRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoleFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cbRoleFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoleFilter.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbRoleFilter.HoverForeColor = System.Drawing.Color.DodgerBlue;
            this.cbRoleFilter.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Employee"});
            this.cbRoleFilter.Location = new System.Drawing.Point(604, 26);
            this.cbRoleFilter.Margin = new System.Windows.Forms.Padding(5);
            this.cbRoleFilter.Name = "cbRoleFilter";
            this.cbRoleFilter.PlaceholderColor = System.Drawing.Color.Gray;
            this.cbRoleFilter.PlaceholderText = "";
            this.cbRoleFilter.SelectedIndex = -1;
            this.cbRoleFilter.SelectedItem = null;
            this.cbRoleFilter.SelectedValue = null;
            this.cbRoleFilter.Size = new System.Drawing.Size(245, 50);
            this.cbRoleFilter.TabIndex = 14;
            this.cbRoleFilter.ValueMember = "";
            this.cbRoleFilter.VerticalPadding = 12;
            this.cbRoleFilter.SelectedIndexChanged += new System.EventHandler(this.cbRoleFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(375, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Status";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.BorderRadius = 15;
            this.btnClear.BorderThickness = 0;
            this.btnClear.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnClear.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnClear.DisabledForeColor = System.Drawing.Color.White;
            this.btnClear.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnClear.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnClear.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnClear.ImageColor = System.Drawing.Color.White;
            this.btnClear.ImageColorMode = false;
            this.btnClear.ImageSize = new System.Drawing.Size(0, 0);
            this.btnClear.IsSelected = false;
            this.btnClear.Location = new System.Drawing.Point(859, 26);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClear.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClear.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClear.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClear.Size = new System.Drawing.Size(136, 50);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Filters";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.AutoHeight = false;
            this.cbStatusFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbStatusFilter.BorderColor = System.Drawing.Color.DarkGray;
            this.cbStatusFilter.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.cbStatusFilter.BorderRadius = 20;
            this.cbStatusFilter.BorderThickness = 1;
            this.cbStatusFilter.cbFont = new System.Drawing.Font("Segoe UI", 9F);
            this.cbStatusFilter.cbForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbStatusFilter.DataSource = null;
            this.cbStatusFilter.DisplayMember = "";
            this.cbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusFilter.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.HoverForeColor = System.Drawing.Color.DodgerBlue;
            this.cbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Active",
            "InActive"});
            this.cbStatusFilter.Location = new System.Drawing.Point(354, 26);
            this.cbStatusFilter.Margin = new System.Windows.Forms.Padding(5);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.PlaceholderColor = System.Drawing.Color.Gray;
            this.cbStatusFilter.PlaceholderText = "";
            this.cbStatusFilter.SelectedIndex = -1;
            this.cbStatusFilter.SelectedItem = null;
            this.cbStatusFilter.SelectedValue = null;
            this.cbStatusFilter.Size = new System.Drawing.Size(245, 50);
            this.cbStatusFilter.TabIndex = 1;
            this.cbStatusFilter.ValueMember = "";
            this.cbStatusFilter.VerticalPadding = 12;
            this.cbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cbStatusFilter_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtFilterValue.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtFilterValue.BorderRadius = 25;
            this.txtFilterValue.BorderThickness = 2;
            this.txtFilterValue.EnableEnterPress = false;
            this.txtFilterValue.EnableGroupSeparators = true;
            this.txtFilterValue.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtFilterValue.GlowEnabled = false;
            this.txtFilterValue.GlowSize = 5;
            this.txtFilterValue.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtFilterValue.LeftIconImage = null;
            this.txtFilterValue.LeftIconOffsetX = 0;
            this.txtFilterValue.LeftIconSize = 25;
            this.txtFilterValue.Location = new System.Drawing.Point(10, 26);
            this.txtFilterValue.Multiline = false;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFilterValue.PlaceholderText = "Search By UserName or FullName";
            this.txtFilterValue.RightAndLeftIconVisible = true;
            this.txtFilterValue.RightIconImage = null;
            this.txtFilterValue.RightIconOffsetX = 0;
            this.txtFilterValue.RightIconSize = 25;
            this.txtFilterValue.Size = new System.Drawing.Size(339, 50);
            this.txtFilterValue.TabIndex = 0;
            this.txtFilterValue.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtFilterValue.TextBoxForeColor = System.Drawing.Color.White;
            this.txtFilterValue.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFilterValue.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtFilterValue.TextValue = "";
            this.txtFilterValue.TxtOffsetX = 0;
            this.txtFilterValue.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtFilterValue.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtFilterValue.UnderlineOnly = false;
            this.txtFilterValue.UnderlineThickness = 2;
            this.txtFilterValue.UsePasswordChar = false;
            this.txtFilterValue.TextValueChanged += new System.Action(this.txtFilterValue_TextValueChanged);
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
            this.btnClose.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.FillColor2 = System.Drawing.Color.SlateBlue;
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
            this.btnClose.Location = new System.Drawing.Point(1090, 731);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(143, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(12, 265);
            this.dgvUsers.MaxVisibleRows = 10;
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.RowTemplate.Height = 40;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1221, 323);
            this.dgvUsers.TabIndex = 10;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsers_CellFormatting);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewUser.BorderRadius = 15;
            this.btnAddNewUser.BorderThickness = 0;
            this.btnAddNewUser.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnAddNewUser.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnAddNewUser.DisabledForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewUser.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnAddNewUser.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnAddNewUser.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnAddNewUser.ImageColor = System.Drawing.Color.White;
            this.btnAddNewUser.ImageColorMode = false;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(0, 0);
            this.btnAddNewUser.IsSelected = false;
            this.btnAddNewUser.Location = new System.Drawing.Point(1023, 197);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnAddNewUser.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnAddNewUser.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddNewUser.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnAddNewUser.Size = new System.Drawing.Size(210, 50);
            this.btnAddNewUser.TabIndex = 9;
            this.btnAddNewUser.Text = "+   Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // ucListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.label1);
            this.Name = "ucListUsers";
            this.Size = new System.Drawing.Size(1265, 820);
            this.Load += new System.EventHandler(this.ucListUsers_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedButton btnAddNewUser;
        private CustomDataGridView dgvUsers;
        private CustomControls.RoundedButton btnClose;
        private ucTextBox txtFilterValue;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedButton btnClear;
        private CustomControls.ucComboBox cbStatusFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.ucComboBox cbRoleFilter;
    }
}