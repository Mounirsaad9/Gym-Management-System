namespace Gym
{
    partial class frmBulkAddLockers
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Gym.CustomControls.RoundedButton();
            this.btnSave = new Gym.CustomControls.RoundedButton();
            this.lblHighestLocker = new System.Windows.Forms.Label();
            this.txtPrefix = new Gym.ucTextBox();
            this.txtStartNumber = new Gym.ucTextBox();
            this.txtCount = new Gym.ucTextBox();
            this.lblPreviewStatus = new System.Windows.Forms.Label();
            this.pnlPreview = new Gym.CustomControls.RoundedPanel();
            this.btnSuggest = new Gym.CustomControls.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(157, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulk Generate Lockers";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.BorderRadius = 15;
            this.btnClose.BorderThickness = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnClose.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnClose.DisabledForeColor = System.Drawing.Color.White;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
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
            this.btnClose.Location = new System.Drawing.Point(389, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnClose.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnClose.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnClose.Size = new System.Drawing.Size(105, 41);
            this.btnClose.TabIndex = 1;
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
            this.btnSave.Location = new System.Drawing.Point(266, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnSave.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnSave.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSave.Size = new System.Drawing.Size(105, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHighestLocker
            // 
            this.lblHighestLocker.AutoSize = true;
            this.lblHighestLocker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestLocker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHighestLocker.Location = new System.Drawing.Point(167, 77);
            this.lblHighestLocker.Name = "lblHighestLocker";
            this.lblHighestLocker.Size = new System.Drawing.Size(28, 25);
            this.lblHighestLocker.TabIndex = 3;
            this.lblHighestLocker.Text = "??";
            // 
            // txtPrefix
            // 
            this.txtPrefix.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtPrefix.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPrefix.BorderRadius = 25;
            this.txtPrefix.BorderThickness = 2;
            this.txtPrefix.EnableEnterPress = false;
            this.txtPrefix.EnableGroupSeparators = true;
            this.txtPrefix.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtPrefix.GlowEnabled = false;
            this.txtPrefix.GlowSize = 5;
            this.txtPrefix.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtPrefix.LeftIconImage = null;
            this.txtPrefix.LeftIconOffsetX = 0;
            this.txtPrefix.LeftIconSize = 25;
            this.txtPrefix.Location = new System.Drawing.Point(12, 141);
            this.txtPrefix.Multiline = false;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrefix.PlaceholderText = "";
            this.txtPrefix.RightAndLeftIconVisible = true;
            this.txtPrefix.RightIconImage = null;
            this.txtPrefix.RightIconOffsetX = 0;
            this.txtPrefix.RightIconSize = 25;
            this.txtPrefix.Size = new System.Drawing.Size(301, 57);
            this.txtPrefix.TabIndex = 4;
            this.txtPrefix.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtPrefix.TextBoxForeColor = System.Drawing.Color.White;
            this.txtPrefix.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrefix.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtPrefix.TextValue = "";
            this.txtPrefix.TxtOffsetX = 0;
            this.txtPrefix.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtPrefix.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPrefix.UnderlineOnly = false;
            this.txtPrefix.UnderlineThickness = 2;
            this.txtPrefix.UsePasswordChar = false;
            this.txtPrefix.TextValueChanged += new System.Action(this.txtInput_TextValueChanged);
            // 
            // txtStartNumber
            // 
            this.txtStartNumber.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtStartNumber.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtStartNumber.BorderRadius = 25;
            this.txtStartNumber.BorderThickness = 2;
            this.txtStartNumber.EnableEnterPress = false;
            this.txtStartNumber.EnableGroupSeparators = true;
            this.txtStartNumber.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtStartNumber.GlowEnabled = false;
            this.txtStartNumber.GlowSize = 5;
            this.txtStartNumber.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtStartNumber.LeftIconImage = null;
            this.txtStartNumber.LeftIconOffsetX = 0;
            this.txtStartNumber.LeftIconSize = 25;
            this.txtStartNumber.Location = new System.Drawing.Point(17, 235);
            this.txtStartNumber.Multiline = false;
            this.txtStartNumber.Name = "txtStartNumber";
            this.txtStartNumber.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartNumber.PlaceholderText = "";
            this.txtStartNumber.RightAndLeftIconVisible = true;
            this.txtStartNumber.RightIconImage = null;
            this.txtStartNumber.RightIconOffsetX = 0;
            this.txtStartNumber.RightIconSize = 25;
            this.txtStartNumber.Size = new System.Drawing.Size(301, 57);
            this.txtStartNumber.TabIndex = 5;
            this.txtStartNumber.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtStartNumber.TextBoxForeColor = System.Drawing.Color.White;
            this.txtStartNumber.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtStartNumber.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtStartNumber.TextValue = "";
            this.txtStartNumber.TxtOffsetX = 0;
            this.txtStartNumber.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtStartNumber.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtStartNumber.UnderlineOnly = false;
            this.txtStartNumber.UnderlineThickness = 2;
            this.txtStartNumber.UsePasswordChar = false;
            this.txtStartNumber.TextValueChanged += new System.Action(this.txtInput_TextValueChanged);
            // 
            // txtCount
            // 
            this.txtCount.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCount.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCount.BorderRadius = 25;
            this.txtCount.BorderThickness = 2;
            this.txtCount.EnableEnterPress = false;
            this.txtCount.EnableGroupSeparators = true;
            this.txtCount.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtCount.GlowEnabled = false;
            this.txtCount.GlowSize = 5;
            this.txtCount.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtCount.LeftIconImage = null;
            this.txtCount.LeftIconOffsetX = 0;
            this.txtCount.LeftIconSize = 25;
            this.txtCount.Location = new System.Drawing.Point(17, 315);
            this.txtCount.Multiline = false;
            this.txtCount.Name = "txtCount";
            this.txtCount.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCount.PlaceholderText = "";
            this.txtCount.RightAndLeftIconVisible = true;
            this.txtCount.RightIconImage = null;
            this.txtCount.RightIconOffsetX = 0;
            this.txtCount.RightIconSize = 25;
            this.txtCount.Size = new System.Drawing.Size(301, 57);
            this.txtCount.TabIndex = 6;
            this.txtCount.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtCount.TextBoxForeColor = System.Drawing.Color.White;
            this.txtCount.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCount.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtCount.TextValue = "";
            this.txtCount.TxtOffsetX = 0;
            this.txtCount.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtCount.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCount.UnderlineOnly = false;
            this.txtCount.UnderlineThickness = 2;
            this.txtCount.UsePasswordChar = false;
            this.txtCount.TextValueChanged += new System.Action(this.txtInput_TextValueChanged);
            // 
            // lblPreviewStatus
            // 
            this.lblPreviewStatus.AutoSize = true;
            this.lblPreviewStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPreviewStatus.Location = new System.Drawing.Point(10, 14);
            this.lblPreviewStatus.Name = "lblPreviewStatus";
            this.lblPreviewStatus.Size = new System.Drawing.Size(131, 25);
            this.lblPreviewStatus.TabIndex = 7;
            this.lblPreviewStatus.Text = "Preview Status";
            // 
            // pnlPreview
            // 
            this.pnlPreview.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlPreview.BorderRadius = 15;
            this.pnlPreview.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.pnlPreview.BorderThickness = 1;
            this.pnlPreview.Controls.Add(this.lblPreviewStatus);
            this.pnlPreview.CornerBottomLeft = true;
            this.pnlPreview.CornerBottomRight = true;
            this.pnlPreview.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.pnlPreview.CornerTopLeft = true;
            this.pnlPreview.CornerTopRight = true;
            this.pnlPreview.FillColor = System.Drawing.Color.Transparent;
            this.pnlPreview.FillColor2 = System.Drawing.Color.Transparent;
            this.pnlPreview.ForceGlow = false;
            this.pnlPreview.GlowColor = System.Drawing.Color.DodgerBlue;
            this.pnlPreview.GlowEnabled = false;
            this.pnlPreview.GlowSize = 5;
            this.pnlPreview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlPreview.Location = new System.Drawing.Point(17, 388);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(477, 85);
            this.pnlPreview.TabIndex = 8;
            this.pnlPreview.UnderlineColor = System.Drawing.Color.LightGray;
            this.pnlPreview.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.pnlPreview.UnderlineOnly = false;
            this.pnlPreview.UnderlineThickness = 2;
            // 
            // btnSuggest
            // 
            this.btnSuggest.BackColor = System.Drawing.Color.Transparent;
            this.btnSuggest.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSuggest.BorderRadius = 15;
            this.btnSuggest.BorderThickness = 0;
            this.btnSuggest.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnSuggest.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnSuggest.DisabledForeColor = System.Drawing.Color.White;
            this.btnSuggest.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuggest.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnSuggest.FlatAppearance.BorderSize = 0;
            this.btnSuggest.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSuggest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSuggest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSuggest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuggest.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSuggest.ForeColor = System.Drawing.Color.White;
            this.btnSuggest.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnSuggest.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnSuggest.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnSuggest.ImageColor = System.Drawing.Color.White;
            this.btnSuggest.ImageColorMode = false;
            this.btnSuggest.ImageSize = new System.Drawing.Size(0, 0);
            this.btnSuggest.IsSelected = false;
            this.btnSuggest.Location = new System.Drawing.Point(351, 237);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnSuggest.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnSuggest.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSuggest.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSuggest.Size = new System.Drawing.Size(105, 41);
            this.btnSuggest.TabIndex = 9;
            this.btnSuggest.Text = "Suggest";
            this.btnSuggest.UseVisualStyleBackColor = false;
            this.btnSuggest.Click += new System.EventHandler(this.btnSuggest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Highest Locker :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prefix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(23, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(23, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Count";
            // 
            // frmBulkAddLockers
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(540, 543);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtStartNumber);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.lblHighestLocker);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmBulkAddLockers";
            this.ShowIcon = false;
            this.Text = "Bulk Add Lockers";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmBulkAddLockers_Load);
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedButton btnClose;
        private CustomControls.RoundedButton btnSave;
        private System.Windows.Forms.Label lblHighestLocker;
        private ucTextBox txtPrefix;
        private ucTextBox txtStartNumber;
        private ucTextBox txtCount;
        private System.Windows.Forms.Label lblPreviewStatus;
        private CustomControls.RoundedPanel pnlPreview;
        private CustomControls.RoundedButton btnSuggest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}