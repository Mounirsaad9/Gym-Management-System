namespace Gym
{
    partial class frmSetLockerMaintenance
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
            this.lblLockerNumber = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnSetMaintenance = new Gym.CustomControls.RoundedButton();
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
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
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
            this.btnCancel.Location = new System.Drawing.Point(152, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnCancel.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnCancel.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Size = new System.Drawing.Size(115, 38);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLockerNumber
            // 
            this.lblLockerNumber.AutoSize = true;
            this.lblLockerNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockerNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLockerNumber.Location = new System.Drawing.Point(12, 21);
            this.lblLockerNumber.Name = "lblLockerNumber";
            this.lblLockerNumber.Size = new System.Drawing.Size(28, 25);
            this.lblLockerNumber.TabIndex = 10;
            this.lblLockerNumber.Text = "??";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentStatus.Location = new System.Drawing.Point(12, 66);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(28, 25);
            this.lblCurrentStatus.TabIndex = 11;
            this.lblCurrentStatus.Text = "??";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(12, 110);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(28, 25);
            this.lblWarning.TabIndex = 12;
            this.lblWarning.Text = "??";
            // 
            // btnSetMaintenance
            // 
            this.btnSetMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnSetMaintenance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSetMaintenance.BorderRadius = 15;
            this.btnSetMaintenance.BorderThickness = 0;
            this.btnSetMaintenance.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnSetMaintenance.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnSetMaintenance.DisabledForeColor = System.Drawing.Color.White;
            this.btnSetMaintenance.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSetMaintenance.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnSetMaintenance.FlatAppearance.BorderSize = 0;
            this.btnSetMaintenance.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSetMaintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetMaintenance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSetMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnSetMaintenance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnSetMaintenance.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnSetMaintenance.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnSetMaintenance.ImageColor = System.Drawing.Color.White;
            this.btnSetMaintenance.ImageColorMode = false;
            this.btnSetMaintenance.ImageSize = new System.Drawing.Size(0, 0);
            this.btnSetMaintenance.IsSelected = false;
            this.btnSetMaintenance.Location = new System.Drawing.Point(17, 169);
            this.btnSetMaintenance.Name = "btnSetMaintenance";
            this.btnSetMaintenance.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnSetMaintenance.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnSetMaintenance.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetMaintenance.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSetMaintenance.Size = new System.Drawing.Size(115, 38);
            this.btnSetMaintenance.TabIndex = 13;
            this.btnSetMaintenance.Text = "Maintenance";
            this.btnSetMaintenance.UseVisualStyleBackColor = false;
            this.btnSetMaintenance.Click += new System.EventHandler(this.btnSetMaintenance_Click);
            // 
            // frmSetLockerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(290, 228);
            this.Controls.Add(this.btnSetMaintenance);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblLockerNumber);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.Name = "frmSetLockerMaintenance";
            this.ShowIcon = false;
            this.Text = "Set Locker Maintenance";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmSetLockerMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedButton btnCancel;
        private System.Windows.Forms.Label lblLockerNumber;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblWarning;
        private CustomControls.RoundedButton btnSetMaintenance;
    }
}