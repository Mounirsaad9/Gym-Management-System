namespace Gym
{
    partial class frmRentLocker
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
            this.btnRent = new Gym.CustomControls.RoundedButton();
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.lblEnd = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMemberShipStatus = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblMemberPhone = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchMember = new Gym.ucTextBox();
            this.roundedPanel2 = new Gym.CustomControls.RoundedPanel();
            this.txtDays = new Gym.ucTextBox();
            this.txtMonths = new Gym.ucTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.chkType = new Gym.CustomConstrols.CustomToggleSwitch();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStartDate = new Gym.CustomDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLockerNumber = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(552, 537);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnCancel.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnCancel.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Size = new System.Drawing.Size(106, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.Transparent;
            this.btnRent.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRent.BorderRadius = 15;
            this.btnRent.BorderThickness = 0;
            this.btnRent.DisabledFillColor = System.Drawing.Color.LightGray;
            this.btnRent.DisabledFillColor2 = System.Drawing.Color.Gray;
            this.btnRent.DisabledForeColor = System.Drawing.Color.White;
            this.btnRent.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnRent.FillColor2 = System.Drawing.Color.SlateBlue;
            this.btnRent.FlatAppearance.BorderSize = 0;
            this.btnRent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnRent.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnRent.HoverFillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnRent.ImageColor = System.Drawing.Color.White;
            this.btnRent.ImageColorMode = false;
            this.btnRent.ImageSize = new System.Drawing.Size(0, 0);
            this.btnRent.IsSelected = false;
            this.btnRent.Location = new System.Drawing.Point(416, 537);
            this.btnRent.Name = "btnRent";
            this.btnRent.PressedFillColor = System.Drawing.Color.SlateBlue;
            this.btnRent.PressedFillColor2 = System.Drawing.Color.MediumBlue;
            this.btnRent.SelectedFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRent.SelectedFillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnRent.Size = new System.Drawing.Size(106, 40);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.lblEnd);
            this.roundedPanel1.Controls.Add(this.label12);
            this.roundedPanel1.Controls.Add(this.lblMemberShipStatus);
            this.roundedPanel1.Controls.Add(this.lblMemberName);
            this.roundedPanel1.Controls.Add(this.lblMemberPhone);
            this.roundedPanel1.Controls.Add(this.lblMemberID);
            this.roundedPanel1.Controls.Add(this.label7);
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.txtSearchMember);
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
            this.roundedPanel1.Location = new System.Drawing.Point(12, 95);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(646, 160);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEnd.Location = new System.Drawing.Point(518, 70);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(14, 17);
            this.lblEnd.TabIndex = 17;
            this.lblEnd.Text = "?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(440, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "End Date :";
            // 
            // lblMemberShipStatus
            // 
            this.lblMemberShipStatus.AutoSize = true;
            this.lblMemberShipStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberShipStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMemberShipStatus.Location = new System.Drawing.Point(328, 111);
            this.lblMemberShipStatus.Name = "lblMemberShipStatus";
            this.lblMemberShipStatus.Size = new System.Drawing.Size(14, 17);
            this.lblMemberShipStatus.TabIndex = 15;
            this.lblMemberShipStatus.Text = "?";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMemberName.Location = new System.Drawing.Point(328, 70);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(14, 17);
            this.lblMemberName.TabIndex = 14;
            this.lblMemberName.Text = "?";
            // 
            // lblMemberPhone
            // 
            this.lblMemberPhone.AutoSize = true;
            this.lblMemberPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMemberPhone.Location = new System.Drawing.Point(73, 111);
            this.lblMemberPhone.Name = "lblMemberPhone";
            this.lblMemberPhone.Size = new System.Drawing.Size(14, 17);
            this.lblMemberPhone.TabIndex = 13;
            this.lblMemberPhone.Text = "?";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMemberID.Location = new System.Drawing.Point(73, 70);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(14, 17);
            this.lblMemberID.TabIndex = 12;
            this.lblMemberID.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(12, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(262, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(262, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID :";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSearchMember.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchMember.BorderRadius = 25;
            this.txtSearchMember.BorderThickness = 2;
            this.txtSearchMember.EnableEnterPress = false;
            this.txtSearchMember.EnableGroupSeparators = true;
            this.txtSearchMember.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchMember.GlowEnabled = false;
            this.txtSearchMember.GlowSize = 5;
            this.txtSearchMember.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtSearchMember.LeftIconImage = null;
            this.txtSearchMember.LeftIconOffsetX = 0;
            this.txtSearchMember.LeftIconSize = 25;
            this.txtSearchMember.Location = new System.Drawing.Point(10, 11);
            this.txtSearchMember.Multiline = false;
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchMember.PlaceholderText = "Search by Name,Phone or ID";
            this.txtSearchMember.RightAndLeftIconVisible = true;
            this.txtSearchMember.RightIconImage = null;
            this.txtSearchMember.RightIconOffsetX = 0;
            this.txtSearchMember.RightIconSize = 25;
            this.txtSearchMember.Size = new System.Drawing.Size(245, 44);
            this.txtSearchMember.TabIndex = 0;
            this.txtSearchMember.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtSearchMember.TextBoxForeColor = System.Drawing.Color.White;
            this.txtSearchMember.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearchMember.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtSearchMember.TextValue = "";
            this.txtSearchMember.TxtOffsetX = 0;
            this.txtSearchMember.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtSearchMember.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchMember.UnderlineOnly = false;
            this.txtSearchMember.UnderlineThickness = 2;
            this.txtSearchMember.UsePasswordChar = false;
            this.txtSearchMember.TextValueChanged += new System.Action(this.txtSearchMember_TextValueChanged);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel2.BorderRadius = 15;
            this.roundedPanel2.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel2.BorderThickness = 1;
            this.roundedPanel2.Controls.Add(this.txtDays);
            this.roundedPanel2.Controls.Add(this.txtMonths);
            this.roundedPanel2.Controls.Add(this.label13);
            this.roundedPanel2.Controls.Add(this.lblTotalFees);
            this.roundedPanel2.Controls.Add(this.lblEndDate);
            this.roundedPanel2.Controls.Add(this.label10);
            this.roundedPanel2.Controls.Add(this.lblType);
            this.roundedPanel2.Controls.Add(this.chkType);
            this.roundedPanel2.Controls.Add(this.label9);
            this.roundedPanel2.Controls.Add(this.dtpStartDate);
            this.roundedPanel2.Controls.Add(this.label3);
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
            this.roundedPanel2.Location = new System.Drawing.Point(12, 297);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(646, 200);
            this.roundedPanel2.TabIndex = 3;
            this.roundedPanel2.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel2.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel2.UnderlineOnly = false;
            this.roundedPanel2.UnderlineThickness = 2;
            // 
            // txtDays
            // 
            this.txtDays.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtDays.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDays.BorderRadius = 25;
            this.txtDays.BorderThickness = 2;
            this.txtDays.EnableEnterPress = false;
            this.txtDays.EnableGroupSeparators = true;
            this.txtDays.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtDays.GlowEnabled = false;
            this.txtDays.GlowSize = 5;
            this.txtDays.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtDays.LeftIconImage = null;
            this.txtDays.LeftIconOffsetX = 0;
            this.txtDays.LeftIconSize = 25;
            this.txtDays.Location = new System.Drawing.Point(265, 67);
            this.txtDays.Multiline = false;
            this.txtDays.Name = "txtDays";
            this.txtDays.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDays.PlaceholderText = "Days";
            this.txtDays.RightAndLeftIconVisible = true;
            this.txtDays.RightIconImage = null;
            this.txtDays.RightIconOffsetX = 0;
            this.txtDays.RightIconSize = 25;
            this.txtDays.Size = new System.Drawing.Size(168, 37);
            this.txtDays.TabIndex = 22;
            this.txtDays.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtDays.TextBoxForeColor = System.Drawing.Color.White;
            this.txtDays.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDays.TextMode = Gym.ucTextBox.InputMode.NumbersOnly;
            this.txtDays.TextValue = "";
            this.txtDays.TxtOffsetX = 0;
            this.txtDays.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtDays.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDays.UnderlineOnly = false;
            this.txtDays.UnderlineThickness = 2;
            this.txtDays.UsePasswordChar = false;
            this.txtDays.TextValueChanged += new System.Action(this.txtDays_TextValueChanged);
            // 
            // txtMonths
            // 
            this.txtMonths.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMonths.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMonths.BorderRadius = 25;
            this.txtMonths.BorderThickness = 2;
            this.txtMonths.EnableEnterPress = false;
            this.txtMonths.EnableGroupSeparators = true;
            this.txtMonths.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtMonths.GlowEnabled = false;
            this.txtMonths.GlowSize = 5;
            this.txtMonths.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtMonths.LeftIconImage = null;
            this.txtMonths.LeftIconOffsetX = 0;
            this.txtMonths.LeftIconSize = 25;
            this.txtMonths.Location = new System.Drawing.Point(265, 67);
            this.txtMonths.Multiline = false;
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMonths.PlaceholderText = "Months";
            this.txtMonths.RightAndLeftIconVisible = true;
            this.txtMonths.RightIconImage = null;
            this.txtMonths.RightIconOffsetX = 0;
            this.txtMonths.RightIconSize = 25;
            this.txtMonths.Size = new System.Drawing.Size(168, 37);
            this.txtMonths.TabIndex = 16;
            this.txtMonths.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtMonths.TextBoxForeColor = System.Drawing.Color.White;
            this.txtMonths.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMonths.TextMode = Gym.ucTextBox.InputMode.NumbersOnly;
            this.txtMonths.TextValue = "";
            this.txtMonths.TxtOffsetX = 0;
            this.txtMonths.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtMonths.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMonths.UnderlineOnly = false;
            this.txtMonths.UnderlineThickness = 2;
            this.txtMonths.UsePasswordChar = false;
            this.txtMonths.TextValueChanged += new System.Action(this.txtMonths_TextValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(13, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Total Fees :";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalFees.Location = new System.Drawing.Point(116, 155);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(14, 17);
            this.lblTotalFees.TabIndex = 20;
            this.lblTotalFees.Text = "?";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndDate.Location = new System.Drawing.Point(117, 121);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(14, 17);
            this.lblEndDate.TabIndex = 16;
            this.lblEndDate.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(13, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Expiration Date :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblType.Location = new System.Drawing.Point(184, 83);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 17);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "Daily";
            // 
            // chkType
            // 
            this.chkType.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.chkType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkType.Location = new System.Drawing.Point(116, 78);
            this.chkType.Name = "chkType";
            this.chkType.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.chkType.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.chkType.Size = new System.Drawing.Size(47, 26);
            this.chkType.TabIndex = 17;
            this.chkType.ToggleColor = System.Drawing.Color.White;
            this.chkType.UseVisualStyleBackColor = true;
            this.chkType.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(13, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Period Type :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.dtpStartDate.BorderRadius = 12;
            this.dtpStartDate.BorderSize = 2;
            this.dtpStartDate.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.IconColor = System.Drawing.Color.CornflowerBlue;
            this.dtpStartDate.Location = new System.Drawing.Point(15, 32);
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.PlaceholderText = "Select Date...";
            this.dtpStartDate.ShowPlaceholder = true;
            this.dtpStartDate.Size = new System.Drawing.Size(200, 35);
            this.dtpStartDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.dtpStartDate.TabIndex = 7;
            this.dtpStartDate.TextColor = System.Drawing.Color.White;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Member Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rental Details ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(17, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Rent Locker  _";
            // 
            // lblLockerNumber
            // 
            this.lblLockerNumber.AutoSize = true;
            this.lblLockerNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockerNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLockerNumber.Location = new System.Drawing.Point(147, 18);
            this.lblLockerNumber.Name = "lblLockerNumber";
            this.lblLockerNumber.Size = new System.Drawing.Size(28, 25);
            this.lblLockerNumber.TabIndex = 7;
            this.lblLockerNumber.Text = "??";
            // 
            // frmRentLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(670, 602);
            this.Controls.Add(this.lblLockerNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.Name = "frmRentLocker";
            this.ShowIcon = false;
            this.Text = "Rent Locker";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmRentLocker_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedButton btnCancel;
        private CustomControls.RoundedButton btnRent;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedPanel roundedPanel2;
        private CustomDateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMemberShipStatus;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblMemberPhone;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ucTextBox txtSearchMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLockerNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblType;
        private CustomConstrols.CustomToggleSwitch chkType;
        private ucTextBox txtDays;
        private ucTextBox txtMonths;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label label12;
    }
}