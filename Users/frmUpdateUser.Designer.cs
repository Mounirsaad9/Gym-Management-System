namespace Gym
{
    partial class frmUpdateUser
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFullName = new Gym.ucTextBox();
            this.cbRole = new Gym.CustomControls.ucComboBox();
            this.chkIsActive = new Gym.CustomConstrols.CustomToggleSwitch();
            this.lblActive = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.PanelAvatar = new Gym.CustomControls.RoundedPanel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.btnSave = new Gym.CustomControls.RoundedButton();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.PanelAvatar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(90, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update User";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserName.Location = new System.Drawing.Point(116, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(24, 21);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "??";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(121, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "User ID  :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserID.Location = new System.Drawing.Point(198, 75);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(24, 21);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.Text = "??";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtFullName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtFullName.BorderRadius = 25;
            this.txtFullName.BorderThickness = 2;
            this.txtFullName.EnableEnterPress = false;
            this.txtFullName.EnableGroupSeparators = true;
            this.txtFullName.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtFullName.GlowEnabled = false;
            this.txtFullName.GlowSize = 5;
            this.txtFullName.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtFullName.LeftIconImage = null;
            this.txtFullName.LeftIconOffsetX = 0;
            this.txtFullName.LeftIconSize = 25;
            this.txtFullName.Location = new System.Drawing.Point(12, 219);
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullName.PlaceholderText = "Full Name";
            this.txtFullName.RightAndLeftIconVisible = true;
            this.txtFullName.RightIconImage = null;
            this.txtFullName.RightIconOffsetX = 0;
            this.txtFullName.RightIconSize = 25;
            this.txtFullName.Size = new System.Drawing.Size(293, 62);
            this.txtFullName.TabIndex = 9;
            this.txtFullName.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtFullName.TextBoxForeColor = System.Drawing.Color.White;
            this.txtFullName.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullName.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtFullName.TextValue = "";
            this.txtFullName.TxtOffsetX = 0;
            this.txtFullName.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtFullName.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtFullName.UnderlineOnly = false;
            this.txtFullName.UnderlineThickness = 2;
            this.txtFullName.UsePasswordChar = false;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFullName_Validating);
            // 
            // cbRole
            // 
            this.cbRole.AutoHeight = false;
            this.cbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbRole.BorderColor = System.Drawing.Color.DarkGray;
            this.cbRole.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.cbRole.BorderRadius = 20;
            this.cbRole.BorderThickness = 1;
            this.cbRole.cbFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.cbForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbRole.DataSource = null;
            this.cbRole.DisplayMember = "";
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbRole.HoverForeColor = System.Drawing.Color.DodgerBlue;
            this.cbRole.Location = new System.Drawing.Point(14, 302);
            this.cbRole.Margin = new System.Windows.Forms.Padding(5);
            this.cbRole.Name = "cbRole";
            this.cbRole.PlaceholderColor = System.Drawing.Color.WhiteSmoke;
            this.cbRole.PlaceholderText = "Role";
            this.cbRole.SelectedIndex = -1;
            this.cbRole.SelectedItem = null;
            this.cbRole.SelectedValue = null;
            this.cbRole.Size = new System.Drawing.Size(291, 41);
            this.cbRole.TabIndex = 10;
            this.cbRole.ValueMember = "";
            this.cbRole.VerticalPadding = 12;
            // 
            // chkIsActive
            // 
            this.chkIsActive.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.chkIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIsActive.Location = new System.Drawing.Point(17, 361);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.chkIsActive.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.chkIsActive.Size = new System.Drawing.Size(77, 44);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.ToggleColor = System.Drawing.Color.White;
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActive.Location = new System.Drawing.Point(135, 384);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(52, 21);
            this.lblActive.TabIndex = 12;
            this.lblActive.Text = "Active";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.PanelAvatar);
            this.roundedPanel1.Controls.Add(this.lblUserName);
            this.roundedPanel1.Controls.Add(this.lblUserID);
            this.roundedPanel1.Controls.Add(this.label6);
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
            this.roundedPanel1.Location = new System.Drawing.Point(14, 89);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(291, 107);
            this.roundedPanel1.TabIndex = 13;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
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
            this.PanelAvatar.Location = new System.Drawing.Point(10, 11);
            this.PanelAvatar.Name = "PanelAvatar";
            this.PanelAvatar.Size = new System.Drawing.Size(100, 62);
            this.PanelAvatar.TabIndex = 11;
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.BorderRadius = 15;
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
            this.btnSave.Location = new System.Drawing.Point(183, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnSave.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnSave.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSave.Size = new System.Drawing.Size(135, 59);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(19, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(135, 59);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(361, 523);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmUpdateUser";
            this.ShowIcon = false;
            this.Text = "Update User";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.PanelAvatar.ResumeLayout(false);
            this.PanelAvatar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustomControls.ucComboBox cbRole;
        private ucTextBox txtFullName;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label lblActive;
        private CustomConstrols.CustomToggleSwitch chkIsActive;
        private CustomControls.RoundedPanel PanelAvatar;
        private System.Windows.Forms.Label lblAvatar;
        private CustomControls.RoundedButton btnClose;
        private CustomControls.RoundedButton btnSave;
    }
}