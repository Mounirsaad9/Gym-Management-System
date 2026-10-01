namespace Gym
{
    partial class frmAddUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new Gym.CustomControls.RoundedButton();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            this.txtUserName = new Gym.ucTextBox();
            this.txtPassword = new Gym.ucTextBox();
            this.txtConfirmPassword = new Gym.ucTextBox();
            this.txtFullName = new Gym.ucTextBox();
            this.cbRole = new Gym.CustomControls.ucComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(88, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 50);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Add User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnSave.Location = new System.Drawing.Point(193, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnSave.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnSave.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSave.Size = new System.Drawing.Size(109, 50);
            this.btnSave.TabIndex = 11;
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
            this.btnClose.Location = new System.Drawing.Point(38, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(109, 50);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtUserName.BorderRadius = 25;
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.EnableEnterPress = false;
            this.txtUserName.EnableGroupSeparators = true;
            this.txtUserName.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtUserName.GlowEnabled = false;
            this.txtUserName.GlowSize = 5;
            this.txtUserName.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtUserName.LeftIconImage = null;
            this.txtUserName.LeftIconOffsetX = 0;
            this.txtUserName.LeftIconSize = 25;
            this.txtUserName.Location = new System.Drawing.Point(36, 101);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.PlaceholderText = "UserName";
            this.txtUserName.RightAndLeftIconVisible = true;
            this.txtUserName.RightIconImage = null;
            this.txtUserName.RightIconOffsetX = 0;
            this.txtUserName.RightIconSize = 25;
            this.txtUserName.Size = new System.Drawing.Size(266, 53);
            this.txtUserName.TabIndex = 13;
            this.txtUserName.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtUserName.TextBoxForeColor = System.Drawing.Color.White;
            this.txtUserName.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserName.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtUserName.TextValue = "";
            this.txtUserName.TxtOffsetX = 0;
            this.txtUserName.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtUserName.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtUserName.UnderlineOnly = false;
            this.txtUserName.UnderlineThickness = 2;
            this.txtUserName.UsePasswordChar = false;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderRadius = 25;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.EnableEnterPress = false;
            this.txtPassword.EnableGroupSeparators = true;
            this.txtPassword.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.GlowEnabled = false;
            this.txtPassword.GlowSize = 5;
            this.txtPassword.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtPassword.LeftIconImage = null;
            this.txtPassword.LeftIconOffsetX = 0;
            this.txtPassword.LeftIconSize = 25;
            this.txtPassword.Location = new System.Drawing.Point(36, 172);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.RightAndLeftIconVisible = true;
            this.txtPassword.RightIconImage = null;
            this.txtPassword.RightIconOffsetX = 0;
            this.txtPassword.RightIconSize = 25;
            this.txtPassword.Size = new System.Drawing.Size(266, 53);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtPassword.TextBoxForeColor = System.Drawing.Color.White;
            this.txtPassword.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtPassword.TextValue = "";
            this.txtPassword.TxtOffsetX = 0;
            this.txtPassword.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtPassword.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.UnderlineOnly = false;
            this.txtPassword.UnderlineThickness = 2;
            this.txtPassword.UsePasswordChar = false;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtConfirmPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtConfirmPassword.BorderRadius = 25;
            this.txtConfirmPassword.BorderThickness = 2;
            this.txtConfirmPassword.EnableEnterPress = false;
            this.txtConfirmPassword.EnableGroupSeparators = true;
            this.txtConfirmPassword.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtConfirmPassword.GlowEnabled = false;
            this.txtConfirmPassword.GlowSize = 5;
            this.txtConfirmPassword.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtConfirmPassword.LeftIconImage = null;
            this.txtConfirmPassword.LeftIconOffsetX = 0;
            this.txtConfirmPassword.LeftIconSize = 25;
            this.txtConfirmPassword.Location = new System.Drawing.Point(36, 243);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.RightAndLeftIconVisible = true;
            this.txtConfirmPassword.RightIconImage = null;
            this.txtConfirmPassword.RightIconOffsetX = 0;
            this.txtConfirmPassword.RightIconSize = 25;
            this.txtConfirmPassword.Size = new System.Drawing.Size(266, 53);
            this.txtConfirmPassword.TabIndex = 15;
            this.txtConfirmPassword.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtConfirmPassword.TextBoxForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPassword.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtConfirmPassword.TextValue = "";
            this.txtConfirmPassword.TxtOffsetX = 0;
            this.txtConfirmPassword.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtConfirmPassword.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtConfirmPassword.UnderlineOnly = false;
            this.txtConfirmPassword.UnderlineThickness = 2;
            this.txtConfirmPassword.UsePasswordChar = false;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
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
            this.txtFullName.Location = new System.Drawing.Point(36, 314);
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullName.PlaceholderText = "Full Name";
            this.txtFullName.RightAndLeftIconVisible = true;
            this.txtFullName.RightIconImage = null;
            this.txtFullName.RightIconOffsetX = 0;
            this.txtFullName.RightIconSize = 25;
            this.txtFullName.Size = new System.Drawing.Size(266, 53);
            this.txtFullName.TabIndex = 16;
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
            this.cbRole.Location = new System.Drawing.Point(38, 387);
            this.cbRole.Margin = new System.Windows.Forms.Padding(5);
            this.cbRole.Name = "cbRole";
            this.cbRole.PlaceholderColor = System.Drawing.Color.WhiteSmoke;
            this.cbRole.PlaceholderText = "Role";
            this.cbRole.SelectedIndex = -1;
            this.cbRole.SelectedItem = null;
            this.cbRole.SelectedValue = null;
            this.cbRole.Size = new System.Drawing.Size(264, 41);
            this.cbRole.TabIndex = 17;
            this.cbRole.ValueMember = "";
            this.cbRole.VerticalPadding = 12;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(353, 543);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frmAddUser";
            this.ShowIcon = false;
            this.Text = "AddUser";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ucTextBox txtPassword;
        private ucTextBox txtUserName;
        private CustomControls.RoundedButton btnClose;
        private CustomControls.RoundedButton btnSave;
        private ucTextBox txtFullName;
        private ucTextBox txtConfirmPassword;
        private CustomControls.ucComboBox cbRole;
    }
}