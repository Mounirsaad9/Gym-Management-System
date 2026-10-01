namespace Gym
{
    partial class frmChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFullName = new Gym.ucTextBox();
            this.txtCurrentPassword = new Gym.ucTextBox();
            this.txtNewPassword = new Gym.ucTextBox();
            this.txtConfirmPassword = new Gym.ucTextBox();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            this.btnSave = new Gym.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(62, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
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
            this.txtFullName.Location = new System.Drawing.Point(24, 110);
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullName.PlaceholderText = "Full Name";
            this.txtFullName.RightAndLeftIconVisible = true;
            this.txtFullName.RightIconImage = null;
            this.txtFullName.RightIconOffsetX = 0;
            this.txtFullName.RightIconSize = 25;
            this.txtFullName.Size = new System.Drawing.Size(309, 51);
            this.txtFullName.TabIndex = 11;
            this.txtFullName.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtFullName.TextBoxForeColor = System.Drawing.Color.White;
            this.txtFullName.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullName.TextMode = Gym.ucTextBox.InputMode.ReadOnly;
            this.txtFullName.TextValue = "";
            this.txtFullName.TxtOffsetX = 0;
            this.txtFullName.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtFullName.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtFullName.UnderlineOnly = false;
            this.txtFullName.UnderlineThickness = 2;
            this.txtFullName.UsePasswordChar = false;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCurrentPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCurrentPassword.BorderRadius = 25;
            this.txtCurrentPassword.BorderThickness = 2;
            this.txtCurrentPassword.EnableEnterPress = false;
            this.txtCurrentPassword.EnableGroupSeparators = true;
            this.txtCurrentPassword.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtCurrentPassword.GlowEnabled = false;
            this.txtCurrentPassword.GlowSize = 5;
            this.txtCurrentPassword.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtCurrentPassword.LeftIconImage = null;
            this.txtCurrentPassword.LeftIconOffsetX = 0;
            this.txtCurrentPassword.LeftIconSize = 25;
            this.txtCurrentPassword.Location = new System.Drawing.Point(24, 178);
            this.txtCurrentPassword.Multiline = false;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCurrentPassword.PlaceholderText = "Currnet Password";
            this.txtCurrentPassword.RightAndLeftIconVisible = true;
            this.txtCurrentPassword.RightIconImage = null;
            this.txtCurrentPassword.RightIconOffsetX = 0;
            this.txtCurrentPassword.RightIconSize = 25;
            this.txtCurrentPassword.Size = new System.Drawing.Size(309, 51);
            this.txtCurrentPassword.TabIndex = 12;
            this.txtCurrentPassword.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtCurrentPassword.TextBoxForeColor = System.Drawing.Color.White;
            this.txtCurrentPassword.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCurrentPassword.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtCurrentPassword.TextValue = "";
            this.txtCurrentPassword.TxtOffsetX = 0;
            this.txtCurrentPassword.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtCurrentPassword.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCurrentPassword.UnderlineOnly = false;
            this.txtCurrentPassword.UnderlineThickness = 2;
            this.txtCurrentPassword.UsePasswordChar = false;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtNewPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNewPassword.BorderRadius = 25;
            this.txtNewPassword.BorderThickness = 2;
            this.txtNewPassword.EnableEnterPress = false;
            this.txtNewPassword.EnableGroupSeparators = true;
            this.txtNewPassword.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtNewPassword.GlowEnabled = false;
            this.txtNewPassword.GlowSize = 5;
            this.txtNewPassword.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtNewPassword.LeftIconImage = null;
            this.txtNewPassword.LeftIconOffsetX = 0;
            this.txtNewPassword.LeftIconSize = 25;
            this.txtNewPassword.Location = new System.Drawing.Point(24, 246);
            this.txtNewPassword.Multiline = false;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.PlaceholderText = "New Password";
            this.txtNewPassword.RightAndLeftIconVisible = true;
            this.txtNewPassword.RightIconImage = null;
            this.txtNewPassword.RightIconOffsetX = 0;
            this.txtNewPassword.RightIconSize = 25;
            this.txtNewPassword.Size = new System.Drawing.Size(309, 51);
            this.txtNewPassword.TabIndex = 13;
            this.txtNewPassword.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtNewPassword.TextBoxForeColor = System.Drawing.Color.White;
            this.txtNewPassword.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewPassword.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtNewPassword.TextValue = "";
            this.txtNewPassword.TxtOffsetX = 0;
            this.txtNewPassword.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtNewPassword.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNewPassword.UnderlineOnly = false;
            this.txtNewPassword.UnderlineThickness = 2;
            this.txtNewPassword.UsePasswordChar = false;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
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
            this.txtConfirmPassword.Location = new System.Drawing.Point(24, 314);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.RightAndLeftIconVisible = true;
            this.txtConfirmPassword.RightIconImage = null;
            this.txtConfirmPassword.RightIconOffsetX = 0;
            this.txtConfirmPassword.RightIconSize = 25;
            this.txtConfirmPassword.Size = new System.Drawing.Size(309, 51);
            this.txtConfirmPassword.TabIndex = 14;
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
            this.btnClose.Location = new System.Drawing.Point(77, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(109, 50);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(224, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnSave.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnSave.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSave.Size = new System.Drawing.Size(109, 50);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(379, 496);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frmChangePassword";
            this.ShowIcon = false;
            this.Text = "ChangePassword";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ucTextBox txtConfirmPassword;
        private ucTextBox txtNewPassword;
        private ucTextBox txtCurrentPassword;
        private ucTextBox txtFullName;
        private CustomControls.RoundedButton btnClose;
        private CustomControls.RoundedButton btnSave;
    }
}