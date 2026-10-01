namespace Gym
{
    partial class frmLogin
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.roundedButtonLogin = new Gym.CustomControls.RoundedButton();
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucTextBoxUserName = new Gym.ucTextBox();
            this.ucTextBoxPassword = new Gym.ucTextBox();
            this.chkShowPassword = new Gym.CustomConstrols.CustomToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Gym.Properties.Resources.closeBlack32;
            this.btnClose.Location = new System.Drawing.Point(935, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(421, 339);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(19, 30);
            this.lblError.TabIndex = 8;
            this.lblError.Text = ".";
            // 
            // roundedButtonLogin
            // 
            this.roundedButtonLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.roundedButtonLogin.BorderColor = System.Drawing.Color.DodgerBlue;
            this.roundedButtonLogin.BorderRadius = 20;
            this.roundedButtonLogin.BorderThickness = 0;
            this.roundedButtonLogin.DisabledFillColor = System.Drawing.Color.LightGray;
            this.roundedButtonLogin.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.roundedButtonLogin.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.roundedButtonLogin.FillColor = System.Drawing.Color.CornflowerBlue;
            this.roundedButtonLogin.FillColor2 = System.Drawing.Color.SlateBlue;
            this.roundedButtonLogin.FlatAppearance.BorderSize = 0;
            this.roundedButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonLogin.ForeColor = System.Drawing.Color.White;
            this.roundedButtonLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedButtonLogin.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.roundedButtonLogin.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.roundedButtonLogin.ImageColor = System.Drawing.Color.White;
            this.roundedButtonLogin.ImageColorMode = false;
            this.roundedButtonLogin.ImageSize = new System.Drawing.Size(0, 0);
            this.roundedButtonLogin.IsSelected = false;
            this.roundedButtonLogin.Location = new System.Drawing.Point(899, 446);
            this.roundedButtonLogin.Name = "roundedButtonLogin";
            this.roundedButtonLogin.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.roundedButtonLogin.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.roundedButtonLogin.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButtonLogin.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.roundedButtonLogin.Size = new System.Drawing.Size(111, 55);
            this.roundedButtonLogin.TabIndex = 2;
            this.roundedButtonLogin.Text = "Login";
            this.roundedButtonLogin.UseVisualStyleBackColor = false;
            this.roundedButtonLogin.Click += new System.EventHandler(this.roundedButtonLogin_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.CornerBottomLeft = false;
            this.roundedPanel1.CornerBottomRight = true;
            this.roundedPanel1.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight)));
            this.roundedPanel1.CornerTopLeft = false;
            this.roundedPanel1.CornerTopRight = true;
            this.roundedPanel1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.roundedPanel1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.roundedPanel1.ForceGlow = false;
            this.roundedPanel1.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.GlowEnabled = false;
            this.roundedPanel1.GlowSize = 5;
            this.roundedPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(261, 530);
            this.roundedPanel1.TabIndex = 9;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(39, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "GYM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym.Properties.Resources.Gym_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(39, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "TO THE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(39, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "WELCOME ";
            // 
            // ucTextBoxUserName
            // 
            this.ucTextBoxUserName.BorderColor = System.Drawing.Color.Gainsboro;
            this.ucTextBoxUserName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.ucTextBoxUserName.BorderRadius = 25;
            this.ucTextBoxUserName.BorderThickness = 2;
            this.ucTextBoxUserName.EnableEnterPress = false;
            this.ucTextBoxUserName.EnableGroupSeparators = true;
            this.ucTextBoxUserName.GlowColor = System.Drawing.Color.DodgerBlue;
            this.ucTextBoxUserName.GlowEnabled = false;
            this.ucTextBoxUserName.GlowSize = 5;
            this.ucTextBoxUserName.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ucTextBoxUserName.LeftIconImage = null;
            this.ucTextBoxUserName.LeftIconOffsetX = 0;
            this.ucTextBoxUserName.LeftIconSize = 25;
            this.ucTextBoxUserName.Location = new System.Drawing.Point(380, 158);
            this.ucTextBoxUserName.Multiline = false;
            this.ucTextBoxUserName.Name = "ucTextBoxUserName";
            this.ucTextBoxUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ucTextBoxUserName.PlaceholderText = "User Name ";
            this.ucTextBoxUserName.RightAndLeftIconVisible = true;
            this.ucTextBoxUserName.RightIconImage = null;
            this.ucTextBoxUserName.RightIconOffsetX = 0;
            this.ucTextBoxUserName.RightIconSize = 25;
            this.ucTextBoxUserName.Size = new System.Drawing.Size(243, 36);
            this.ucTextBoxUserName.TabIndex = 0;
            this.ucTextBoxUserName.TextBoxBackColor = System.Drawing.Color.WhiteSmoke;
            this.ucTextBoxUserName.TextBoxForeColor = System.Drawing.Color.Black;
            this.ucTextBoxUserName.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTextBoxUserName.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.ucTextBoxUserName.TextValue = "";
            this.ucTextBoxUserName.TxtOffsetX = 0;
            this.ucTextBoxUserName.UnderlineColor = System.Drawing.Color.LightGray;
            this.ucTextBoxUserName.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.ucTextBoxUserName.UnderlineOnly = false;
            this.ucTextBoxUserName.UnderlineThickness = 2;
            this.ucTextBoxUserName.UsePasswordChar = false;
            this.ucTextBoxUserName.TextValueChanged += new System.Action(this.ucTextBoxUserName_TextValueChanged);
            // 
            // ucTextBoxPassword
            // 
            this.ucTextBoxPassword.BorderColor = System.Drawing.Color.Gainsboro;
            this.ucTextBoxPassword.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.ucTextBoxPassword.BorderRadius = 25;
            this.ucTextBoxPassword.BorderThickness = 2;
            this.ucTextBoxPassword.EnableEnterPress = false;
            this.ucTextBoxPassword.EnableGroupSeparators = true;
            this.ucTextBoxPassword.GlowColor = System.Drawing.Color.DodgerBlue;
            this.ucTextBoxPassword.GlowEnabled = false;
            this.ucTextBoxPassword.GlowSize = 5;
            this.ucTextBoxPassword.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ucTextBoxPassword.LeftIconImage = null;
            this.ucTextBoxPassword.LeftIconOffsetX = 0;
            this.ucTextBoxPassword.LeftIconSize = 25;
            this.ucTextBoxPassword.Location = new System.Drawing.Point(380, 211);
            this.ucTextBoxPassword.Multiline = false;
            this.ucTextBoxPassword.Name = "ucTextBoxPassword";
            this.ucTextBoxPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ucTextBoxPassword.PlaceholderText = "Password ";
            this.ucTextBoxPassword.RightAndLeftIconVisible = true;
            this.ucTextBoxPassword.RightIconImage = null;
            this.ucTextBoxPassword.RightIconOffsetX = 0;
            this.ucTextBoxPassword.RightIconSize = 25;
            this.ucTextBoxPassword.Size = new System.Drawing.Size(243, 36);
            this.ucTextBoxPassword.TabIndex = 1;
            this.ucTextBoxPassword.TextBoxBackColor = System.Drawing.Color.WhiteSmoke;
            this.ucTextBoxPassword.TextBoxForeColor = System.Drawing.Color.Black;
            this.ucTextBoxPassword.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTextBoxPassword.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.ucTextBoxPassword.TextValue = "";
            this.ucTextBoxPassword.TxtOffsetX = 0;
            this.ucTextBoxPassword.UnderlineColor = System.Drawing.Color.LightGray;
            this.ucTextBoxPassword.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.ucTextBoxPassword.UnderlineOnly = false;
            this.ucTextBoxPassword.UnderlineThickness = 2;
            this.ucTextBoxPassword.UsePasswordChar = true;
            this.ucTextBoxPassword.TextValueChanged += new System.Action(this.ucTextBoxUserName_TextValueChanged);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Location = new System.Drawing.Point(380, 269);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.chkShowPassword.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.chkShowPassword.Size = new System.Drawing.Size(60, 30);
            this.chkShowPassword.TabIndex = 10;
            this.chkShowPassword.ToggleColor = System.Drawing.Color.White;
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(471, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Show Password";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.roundedButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1036, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.ucTextBoxPassword);
            this.Controls.Add(this.ucTextBoxUserName);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedButtonLogin);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblError;
        private CustomControls.RoundedButton roundedButtonLogin;
        private CustomControls.RoundedPanel roundedPanel1;
        private ucTextBox ucTextBoxUserName;
        private ucTextBox ucTextBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomConstrols.CustomToggleSwitch chkShowPassword;
        private System.Windows.Forms.Label label4;
    }
}