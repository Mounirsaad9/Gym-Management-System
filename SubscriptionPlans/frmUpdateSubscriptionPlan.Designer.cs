namespace Gym
{
    partial class frmUpdateSubscriptionPlan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPlanID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new Gym.ucTextBox();
            this.txtDurationDays = new Gym.ucTextBox();
            this.txtPlanName = new Gym.ucTextBox();
            this.btnSave = new Gym.CustomControls.RoundedButton();
            this.btnCanncel = new Gym.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(181, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Plan";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.lblPlanID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtDurationDays);
            this.panel2.Controls.Add(this.txtPlanName);
            this.panel2.Location = new System.Drawing.Point(2, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 327);
            this.panel2.TabIndex = 1;
            // 
            // lblPlanID
            // 
            this.lblPlanID.AutoSize = true;
            this.lblPlanID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlanID.Location = new System.Drawing.Point(151, 14);
            this.lblPlanID.Name = "lblPlanID";
            this.lblPlanID.Size = new System.Drawing.Size(40, 30);
            this.lblPlanID.TabIndex = 3;
            this.lblPlanID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "PlanID :";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPrice.BorderRadius = 25;
            this.txtPrice.BorderThickness = 2;
            this.txtPrice.EnableEnterPress = false;
            this.txtPrice.EnableGroupSeparators = true;
            this.txtPrice.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtPrice.GlowEnabled = false;
            this.txtPrice.GlowSize = 5;
            this.txtPrice.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtPrice.LeftIconImage = null;
            this.txtPrice.LeftIconOffsetX = 0;
            this.txtPrice.LeftIconSize = 25;
            this.txtPrice.Location = new System.Drawing.Point(12, 227);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPrice.PlaceholderText = "Enter Price";
            this.txtPrice.RightAndLeftIconVisible = true;
            this.txtPrice.RightIconImage = null;
            this.txtPrice.RightIconOffsetX = 0;
            this.txtPrice.RightIconSize = 25;
            this.txtPrice.Size = new System.Drawing.Size(360, 70);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextBoxBackColor = System.Drawing.Color.Transparent;
            this.txtPrice.TextBoxForeColor = System.Drawing.Color.White;
            this.txtPrice.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrice.TextMode = Gym.ucTextBox.InputMode.NumbersOnly;
            this.txtPrice.TextValue = "";
            this.txtPrice.TxtOffsetX = 0;
            this.txtPrice.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtPrice.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPrice.UnderlineOnly = false;
            this.txtPrice.UnderlineThickness = 2;
            this.txtPrice.UsePasswordChar = false;
            // 
            // txtDurationDays
            // 
            this.txtDurationDays.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDurationDays.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDurationDays.BorderRadius = 25;
            this.txtDurationDays.BorderThickness = 2;
            this.txtDurationDays.EnableEnterPress = false;
            this.txtDurationDays.EnableGroupSeparators = true;
            this.txtDurationDays.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtDurationDays.GlowEnabled = false;
            this.txtDurationDays.GlowSize = 5;
            this.txtDurationDays.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtDurationDays.LeftIconImage = null;
            this.txtDurationDays.LeftIconOffsetX = 0;
            this.txtDurationDays.LeftIconSize = 25;
            this.txtDurationDays.Location = new System.Drawing.Point(12, 147);
            this.txtDurationDays.Multiline = false;
            this.txtDurationDays.Name = "txtDurationDays";
            this.txtDurationDays.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDurationDays.PlaceholderText = "Enter Duration Days";
            this.txtDurationDays.RightAndLeftIconVisible = true;
            this.txtDurationDays.RightIconImage = null;
            this.txtDurationDays.RightIconOffsetX = 0;
            this.txtDurationDays.RightIconSize = 25;
            this.txtDurationDays.Size = new System.Drawing.Size(360, 70);
            this.txtDurationDays.TabIndex = 1;
            this.txtDurationDays.TextBoxBackColor = System.Drawing.Color.Transparent;
            this.txtDurationDays.TextBoxForeColor = System.Drawing.Color.White;
            this.txtDurationDays.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDurationDays.TextMode = Gym.ucTextBox.InputMode.NumbersOnly;
            this.txtDurationDays.TextValue = "";
            this.txtDurationDays.TxtOffsetX = 0;
            this.txtDurationDays.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtDurationDays.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDurationDays.UnderlineOnly = false;
            this.txtDurationDays.UnderlineThickness = 2;
            this.txtDurationDays.UsePasswordChar = false;
            // 
            // txtPlanName
            // 
            this.txtPlanName.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPlanName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPlanName.BorderRadius = 25;
            this.txtPlanName.BorderThickness = 2;
            this.txtPlanName.EnableEnterPress = false;
            this.txtPlanName.EnableGroupSeparators = true;
            this.txtPlanName.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtPlanName.GlowEnabled = false;
            this.txtPlanName.GlowSize = 5;
            this.txtPlanName.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtPlanName.LeftIconImage = null;
            this.txtPlanName.LeftIconOffsetX = 0;
            this.txtPlanName.LeftIconSize = 25;
            this.txtPlanName.Location = new System.Drawing.Point(12, 67);
            this.txtPlanName.Multiline = false;
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPlanName.PlaceholderText = "Enter Plan Name";
            this.txtPlanName.RightAndLeftIconVisible = true;
            this.txtPlanName.RightIconImage = null;
            this.txtPlanName.RightIconOffsetX = 0;
            this.txtPlanName.RightIconSize = 25;
            this.txtPlanName.Size = new System.Drawing.Size(360, 70);
            this.txtPlanName.TabIndex = 0;
            this.txtPlanName.TextBoxBackColor = System.Drawing.Color.Transparent;
            this.txtPlanName.TextBoxForeColor = System.Drawing.Color.White;
            this.txtPlanName.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPlanName.TextMode = Gym.ucTextBox.InputMode.LettersOnly;
            this.txtPlanName.TextValue = "";
            this.txtPlanName.TxtOffsetX = 0;
            this.txtPlanName.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtPlanName.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPlanName.UnderlineOnly = false;
            this.txtPlanName.UnderlineThickness = 2;
            this.txtPlanName.UsePasswordChar = false;
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
            this.btnSave.Location = new System.Drawing.Point(421, 459);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnSave.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnSave.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSave.Size = new System.Drawing.Size(128, 53);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCanncel
            // 
            this.btnCanncel.BackColor = System.Drawing.Color.Transparent;
            this.btnCanncel.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCanncel.BorderRadius = 20;
            this.btnCanncel.BorderThickness = 0;
            this.btnCanncel.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnCanncel.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnCanncel.DisabledForeColor = System.Drawing.Color.White;
            this.btnCanncel.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnCanncel.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnCanncel.FlatAppearance.BorderSize = 0;
            this.btnCanncel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCanncel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCanncel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCanncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanncel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCanncel.ForeColor = System.Drawing.Color.White;
            this.btnCanncel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnCanncel.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnCanncel.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnCanncel.ImageColor = System.Drawing.Color.White;
            this.btnCanncel.ImageColorMode = false;
            this.btnCanncel.ImageSize = new System.Drawing.Size(0, 0);
            this.btnCanncel.IsSelected = false;
            this.btnCanncel.Location = new System.Drawing.Point(267, 459);
            this.btnCanncel.Name = "btnCanncel";
            this.btnCanncel.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnCanncel.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnCanncel.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCanncel.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnCanncel.Size = new System.Drawing.Size(128, 53);
            this.btnCanncel.TabIndex = 4;
            this.btnCanncel.Text = "Cancel";
            this.btnCanncel.UseVisualStyleBackColor = false;
            this.btnCanncel.Click += new System.EventHandler(this.btnCanncel_Click);
            // 
            // frmUpdateSubscriptionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(561, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCanncel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "frmUpdateSubscriptionPlan";
            this.ShowIcon = false;
            this.Text = "frmUpdateSubscriptionPlan";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmUpdateSubscriptionPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RoundedButton btnCanncel;
        private ucTextBox txtPrice;
        private ucTextBox txtDurationDays;
        private ucTextBox txtPlanName;
        private CustomControls.RoundedButton btnSave;
        private System.Windows.Forms.Label lblPlanID;
        private System.Windows.Forms.Label label2;
    }
}