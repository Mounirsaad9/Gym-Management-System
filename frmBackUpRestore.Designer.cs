namespace Gym
{
    partial class frmBackupRestore
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
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.btnCreateBackup = new Gym.CustomControls.RoundedButton();
            this.btnBrowseBackup = new Gym.CustomControls.RoundedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBackupPath = new Gym.ucTextBox();
            this.roundedPanel2 = new Gym.CustomControls.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRestore = new Gym.CustomControls.RoundedButton();
            this.btnBrowseRestore = new Gym.CustomControls.RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRestorePath = new Gym.ucTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new Gym.CustomControls.RoundedButton();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataBase Backup / Restore";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.btnCreateBackup);
            this.roundedPanel1.Controls.Add(this.btnBrowseBackup);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.txtBackupPath);
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
            this.roundedPanel1.Location = new System.Drawing.Point(12, 114);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(534, 189);
            this.roundedPanel1.TabIndex = 1;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateBackup.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateBackup.BorderRadius = 15;
            this.btnCreateBackup.BorderThickness = 0;
            this.btnCreateBackup.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnCreateBackup.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnCreateBackup.DisabledForeColor = System.Drawing.Color.White;
            this.btnCreateBackup.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateBackup.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnCreateBackup.FlatAppearance.BorderSize = 0;
            this.btnCreateBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCreateBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCreateBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCreateBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBackup.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCreateBackup.ForeColor = System.Drawing.Color.White;
            this.btnCreateBackup.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnCreateBackup.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnCreateBackup.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnCreateBackup.ImageColor = System.Drawing.Color.White;
            this.btnCreateBackup.ImageColorMode = false;
            this.btnCreateBackup.ImageSize = new System.Drawing.Size(0, 0);
            this.btnCreateBackup.IsSelected = false;
            this.btnCreateBackup.Location = new System.Drawing.Point(319, 122);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnCreateBackup.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnCreateBackup.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateBackup.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnCreateBackup.Size = new System.Drawing.Size(126, 44);
            this.btnCreateBackup.TabIndex = 7;
            this.btnCreateBackup.Text = "Create";
            this.btnCreateBackup.UseVisualStyleBackColor = false;
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseBackup.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowseBackup.BorderRadius = 15;
            this.btnBrowseBackup.BorderThickness = 0;
            this.btnBrowseBackup.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnBrowseBackup.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnBrowseBackup.DisabledForeColor = System.Drawing.Color.White;
            this.btnBrowseBackup.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnBrowseBackup.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnBrowseBackup.FlatAppearance.BorderSize = 0;
            this.btnBrowseBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBrowseBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBrowseBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBrowseBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseBackup.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnBrowseBackup.ForeColor = System.Drawing.Color.White;
            this.btnBrowseBackup.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnBrowseBackup.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnBrowseBackup.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnBrowseBackup.ImageColor = System.Drawing.Color.White;
            this.btnBrowseBackup.ImageColorMode = false;
            this.btnBrowseBackup.ImageSize = new System.Drawing.Size(0, 0);
            this.btnBrowseBackup.IsSelected = false;
            this.btnBrowseBackup.Location = new System.Drawing.Point(319, 53);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnBrowseBackup.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnBrowseBackup.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBrowseBackup.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnBrowseBackup.Size = new System.Drawing.Size(126, 44);
            this.btnBrowseBackup.TabIndex = 6;
            this.btnBrowseBackup.Text = "Browse";
            this.btnBrowseBackup.UseVisualStyleBackColor = false;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Backup Directory";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtBackupPath.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtBackupPath.BorderRadius = 25;
            this.txtBackupPath.BorderThickness = 2;
            this.txtBackupPath.EnableEnterPress = false;
            this.txtBackupPath.EnableGroupSeparators = true;
            this.txtBackupPath.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtBackupPath.GlowEnabled = false;
            this.txtBackupPath.GlowSize = 5;
            this.txtBackupPath.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtBackupPath.LeftIconImage = null;
            this.txtBackupPath.LeftIconOffsetX = 0;
            this.txtBackupPath.LeftIconSize = 25;
            this.txtBackupPath.Location = new System.Drawing.Point(6, 53);
            this.txtBackupPath.Multiline = false;
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBackupPath.PlaceholderText = "";
            this.txtBackupPath.RightAndLeftIconVisible = true;
            this.txtBackupPath.RightIconImage = null;
            this.txtBackupPath.RightIconOffsetX = 0;
            this.txtBackupPath.RightIconSize = 25;
            this.txtBackupPath.Size = new System.Drawing.Size(248, 44);
            this.txtBackupPath.TabIndex = 0;
            this.txtBackupPath.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtBackupPath.TextBoxForeColor = System.Drawing.Color.White;
            this.txtBackupPath.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBackupPath.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtBackupPath.TextValue = "";
            this.txtBackupPath.TxtOffsetX = 0;
            this.txtBackupPath.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtBackupPath.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtBackupPath.UnderlineOnly = false;
            this.txtBackupPath.UnderlineThickness = 2;
            this.txtBackupPath.UsePasswordChar = false;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel2.BorderRadius = 15;
            this.roundedPanel2.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel2.BorderThickness = 1;
            this.roundedPanel2.Controls.Add(this.label6);
            this.roundedPanel2.Controls.Add(this.btnRestore);
            this.roundedPanel2.Controls.Add(this.btnBrowseRestore);
            this.roundedPanel2.Controls.Add(this.label5);
            this.roundedPanel2.Controls.Add(this.txtRestorePath);
            this.roundedPanel2.CornerBottomLeft = true;
            this.roundedPanel2.CornerBottomRight = true;
            this.roundedPanel2.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.roundedPanel2.CornerTopLeft = true;
            this.roundedPanel2.CornerTopRight = true;
            this.roundedPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel2.ForceGlow = false;
            this.roundedPanel2.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel2.GlowEnabled = false;
            this.roundedPanel2.GlowSize = 5;
            this.roundedPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel2.Location = new System.Drawing.Point(12, 335);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(534, 189);
            this.roundedPanel2.TabIndex = 2;
            this.roundedPanel2.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel2.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel2.UnderlineOnly = false;
            this.roundedPanel2.UnderlineThickness = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(17, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(418, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Warning: Restoring the database will overwrite all existing data!";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRestore.BorderRadius = 15;
            this.btnRestore.BorderThickness = 0;
            this.btnRestore.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnRestore.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnRestore.DisabledForeColor = System.Drawing.Color.White;
            this.btnRestore.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnRestore.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnRestore.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnRestore.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnRestore.ImageColor = System.Drawing.Color.White;
            this.btnRestore.ImageColorMode = false;
            this.btnRestore.ImageSize = new System.Drawing.Size(0, 0);
            this.btnRestore.IsSelected = false;
            this.btnRestore.Location = new System.Drawing.Point(319, 130);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnRestore.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnRestore.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRestore.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnRestore.Size = new System.Drawing.Size(126, 44);
            this.btnRestore.TabIndex = 11;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseRestore.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowseRestore.BorderRadius = 15;
            this.btnBrowseRestore.BorderThickness = 0;
            this.btnBrowseRestore.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnBrowseRestore.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnBrowseRestore.DisabledForeColor = System.Drawing.Color.White;
            this.btnBrowseRestore.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnBrowseRestore.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnBrowseRestore.FlatAppearance.BorderSize = 0;
            this.btnBrowseRestore.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBrowseRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBrowseRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBrowseRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseRestore.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnBrowseRestore.ForeColor = System.Drawing.Color.White;
            this.btnBrowseRestore.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnBrowseRestore.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnBrowseRestore.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnBrowseRestore.ImageColor = System.Drawing.Color.White;
            this.btnBrowseRestore.ImageColorMode = false;
            this.btnBrowseRestore.ImageSize = new System.Drawing.Size(0, 0);
            this.btnBrowseRestore.IsSelected = false;
            this.btnBrowseRestore.Location = new System.Drawing.Point(318, 48);
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnBrowseRestore.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnBrowseRestore.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBrowseRestore.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnBrowseRestore.Size = new System.Drawing.Size(126, 44);
            this.btnBrowseRestore.TabIndex = 10;
            this.btnBrowseRestore.Text = "Browse";
            this.btnBrowseRestore.UseVisualStyleBackColor = false;
            this.btnBrowseRestore.Click += new System.EventHandler(this.btnBrowseRestore_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(16, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Backup File(.bak)";
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtRestorePath.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtRestorePath.BorderRadius = 25;
            this.txtRestorePath.BorderThickness = 2;
            this.txtRestorePath.EnableEnterPress = false;
            this.txtRestorePath.EnableGroupSeparators = true;
            this.txtRestorePath.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtRestorePath.GlowEnabled = false;
            this.txtRestorePath.GlowSize = 5;
            this.txtRestorePath.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtRestorePath.LeftIconImage = null;
            this.txtRestorePath.LeftIconOffsetX = 0;
            this.txtRestorePath.LeftIconSize = 25;
            this.txtRestorePath.Location = new System.Drawing.Point(6, 49);
            this.txtRestorePath.Multiline = false;
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRestorePath.PlaceholderText = "";
            this.txtRestorePath.RightAndLeftIconVisible = true;
            this.txtRestorePath.RightIconImage = null;
            this.txtRestorePath.RightIconOffsetX = 0;
            this.txtRestorePath.RightIconSize = 25;
            this.txtRestorePath.Size = new System.Drawing.Size(248, 44);
            this.txtRestorePath.TabIndex = 8;
            this.txtRestorePath.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtRestorePath.TextBoxForeColor = System.Drawing.Color.White;
            this.txtRestorePath.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRestorePath.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtRestorePath.TextValue = "";
            this.txtRestorePath.TxtOffsetX = 0;
            this.txtRestorePath.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtRestorePath.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtRestorePath.UnderlineOnly = false;
            this.txtRestorePath.UnderlineThickness = 2;
            this.txtRestorePath.UsePasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Backup DataBase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Restore DataBase";
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
            this.btnCancel.Location = new System.Drawing.Point(456, 541);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnCancel.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnCancel.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Size = new System.Drawing.Size(90, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(618, 600);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmBackupRestore";
            this.ShowIcon = false;
            this.Text = "frmBackUp";
            this.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.Load += new System.EventHandler(this.frmBackupRestore_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RoundedButton btnCancel;
        private CustomControls.RoundedButton btnCreateBackup;
        private CustomControls.RoundedButton btnBrowseBackup;
        private System.Windows.Forms.Label label4;
        private ucTextBox txtBackupPath;
        private CustomControls.RoundedButton btnRestore;
        private CustomControls.RoundedButton btnBrowseRestore;
        private System.Windows.Forms.Label label5;
        private ucTextBox txtRestorePath;
        private System.Windows.Forms.Label label6;
    }
}