namespace Gym
{
    partial class frmTransferLocker
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
            this.btnCancel = new Gym.CustomControls.RoundedButton();
            this.btnTransfer = new Gym.CustomControls.RoundedButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.lblCurrentLockerInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAvailableLockers = new Gym.CustomControls.ucComboBox();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderThickness = 0;
            this.btnCancel.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnCancel.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnCancel.DisabledForeColor = System.Drawing.Color.White;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnCancel.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnCancel.ImageColor = System.Drawing.Color.White;
            this.btnCancel.ImageColorMode = false;
            this.btnCancel.ImageSize = new System.Drawing.Size(0, 0);
            this.btnCancel.IsSelected = false;
            this.btnCancel.Location = new System.Drawing.Point(227, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnCancel.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnCancel.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Size = new System.Drawing.Size(125, 39);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTransfer.BorderRadius = 15;
            this.btnTransfer.BorderThickness = 0;
            this.btnTransfer.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnTransfer.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnTransfer.DisabledForeColor = System.Drawing.Color.White;
            this.btnTransfer.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnTransfer.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnTransfer.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnTransfer.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnTransfer.ImageColor = System.Drawing.Color.White;
            this.btnTransfer.ImageColorMode = false;
            this.btnTransfer.ImageSize = new System.Drawing.Size(0, 0);
            this.btnTransfer.IsSelected = false;
            this.btnTransfer.Location = new System.Drawing.Point(81, 303);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnTransfer.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnTransfer.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTransfer.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnTransfer.Size = new System.Drawing.Size(125, 39);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(35, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(28, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "??";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.lblCurrentLockerInfo);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.cbAvailableLockers);
            this.roundedPanel1.CornerBottomLeft = true;
            this.roundedPanel1.CornerBottomRight = true;
            this.roundedPanel1.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.roundedPanel1.CornerTopLeft = true;
            this.roundedPanel1.CornerTopRight = true;
            this.roundedPanel1.FillColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.roundedPanel1.ForceGlow = false;
            this.roundedPanel1.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.GlowEnabled = false;
            this.roundedPanel1.GlowSize = 5;
            this.roundedPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel1.Location = new System.Drawing.Point(17, 93);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(335, 154);
            this.roundedPanel1.TabIndex = 4;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // lblCurrentLockerInfo
            // 
            this.lblCurrentLockerInfo.AutoSize = true;
            this.lblCurrentLockerInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLockerInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentLockerInfo.Location = new System.Drawing.Point(18, 20);
            this.lblCurrentLockerInfo.Name = "lblCurrentLockerInfo";
            this.lblCurrentLockerInfo.Size = new System.Drawing.Size(28, 25);
            this.lblCurrentLockerInfo.TabIndex = 6;
            this.lblCurrentLockerInfo.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Available Lockers";
            // 
            // cbAvailableLockers
            // 
            this.cbAvailableLockers.AutoHeight = false;
            this.cbAvailableLockers.BackColor = System.Drawing.Color.Transparent;
            this.cbAvailableLockers.BorderColor = System.Drawing.Color.DarkGray;
            this.cbAvailableLockers.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.cbAvailableLockers.BorderRadius = 20;
            this.cbAvailableLockers.BorderThickness = 1;
            this.cbAvailableLockers.cbFont = new System.Drawing.Font("Segoe UI", 9F);
            this.cbAvailableLockers.cbForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbAvailableLockers.DataSource = null;
            this.cbAvailableLockers.DisplayMember = "";
            this.cbAvailableLockers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvailableLockers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cbAvailableLockers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAvailableLockers.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cbAvailableLockers.HoverForeColor = System.Drawing.Color.DodgerBlue;
            this.cbAvailableLockers.Location = new System.Drawing.Point(9, 106);
            this.cbAvailableLockers.Margin = new System.Windows.Forms.Padding(5);
            this.cbAvailableLockers.Name = "cbAvailableLockers";
            this.cbAvailableLockers.PlaceholderColor = System.Drawing.Color.Gray;
            this.cbAvailableLockers.PlaceholderText = "";
            this.cbAvailableLockers.SelectedIndex = -1;
            this.cbAvailableLockers.SelectedItem = null;
            this.cbAvailableLockers.SelectedValue = null;
            this.cbAvailableLockers.Size = new System.Drawing.Size(209, 41);
            this.cbAvailableLockers.TabIndex = 0;
            this.cbAvailableLockers.ValueMember = "";
            this.cbAvailableLockers.VerticalPadding = 12;
            // 
            // frmTransferLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(391, 370);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.Name = "frmTransferLocker";
            this.ShowIcon = false;
            this.Text = "Transfer Locker";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmTransferLocker_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedButton btnCancel;
        private CustomControls.RoundedButton btnTransfer;
        private System.Windows.Forms.Label lblTitle;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private CustomControls.ucComboBox cbAvailableLockers;
        private System.Windows.Forms.Label lblCurrentLockerInfo;
    }
}