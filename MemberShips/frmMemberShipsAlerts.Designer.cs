namespace Gym
{
    partial class frmMemberShipsAlerts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.lblExpiredCount = new System.Windows.Forms.Label();
            this.roundedPanel2 = new Gym.CustomControls.RoundedPanel();
            this.lblExpiringSoonCount = new System.Windows.Forms.Label();
            this.roundedPanel3 = new Gym.CustomControls.RoundedPanel();
            this.lblTotalAlertsCount = new System.Windows.Forms.Label();
            this.dgvMembershipAlerts = new Gym.CustomDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerach = new Gym.ucTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipAlerts)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.lblExpiredCount);
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
            this.roundedPanel1.Location = new System.Drawing.Point(12, 148);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(179, 59);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            // 
            // lblExpiredCount
            // 
            this.lblExpiredCount.AutoSize = true;
            this.lblExpiredCount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiredCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExpiredCount.Location = new System.Drawing.Point(77, 19);
            this.lblExpiredCount.Name = "lblExpiredCount";
            this.lblExpiredCount.Size = new System.Drawing.Size(19, 21);
            this.lblExpiredCount.TabIndex = 0;
            this.lblExpiredCount.Text = "0";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel2.BorderRadius = 15;
            this.roundedPanel2.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel2.BorderThickness = 1;
            this.roundedPanel2.Controls.Add(this.lblExpiringSoonCount);
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
            this.roundedPanel2.Location = new System.Drawing.Point(197, 148);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(179, 59);
            this.roundedPanel2.TabIndex = 1;
            this.roundedPanel2.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel2.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel2.UnderlineOnly = false;
            this.roundedPanel2.UnderlineThickness = 2;
            // 
            // lblExpiringSoonCount
            // 
            this.lblExpiringSoonCount.AutoSize = true;
            this.lblExpiringSoonCount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiringSoonCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExpiringSoonCount.Location = new System.Drawing.Point(73, 19);
            this.lblExpiringSoonCount.Name = "lblExpiringSoonCount";
            this.lblExpiringSoonCount.Size = new System.Drawing.Size(19, 21);
            this.lblExpiringSoonCount.TabIndex = 1;
            this.lblExpiringSoonCount.Text = "0";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel3.BorderRadius = 15;
            this.roundedPanel3.BorderSides = ((Gym.CustomControls.RoundedPanel.enBorderSides)((((Gym.CustomControls.RoundedPanel.enBorderSides.Top | Gym.CustomControls.RoundedPanel.enBorderSides.Bottom) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Left) 
            | Gym.CustomControls.RoundedPanel.enBorderSides.Right)));
            this.roundedPanel3.BorderThickness = 1;
            this.roundedPanel3.Controls.Add(this.lblTotalAlertsCount);
            this.roundedPanel3.CornerBottomLeft = true;
            this.roundedPanel3.CornerBottomRight = true;
            this.roundedPanel3.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.roundedPanel3.CornerTopLeft = true;
            this.roundedPanel3.CornerTopRight = true;
            this.roundedPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.roundedPanel3.ForceGlow = false;
            this.roundedPanel3.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel3.GlowEnabled = false;
            this.roundedPanel3.GlowSize = 5;
            this.roundedPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel3.Location = new System.Drawing.Point(384, 148);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(179, 59);
            this.roundedPanel3.TabIndex = 1;
            this.roundedPanel3.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel3.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel3.UnderlineOnly = false;
            this.roundedPanel3.UnderlineThickness = 2;
            // 
            // lblTotalAlertsCount
            // 
            this.lblTotalAlertsCount.AutoSize = true;
            this.lblTotalAlertsCount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAlertsCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalAlertsCount.Location = new System.Drawing.Point(79, 19);
            this.lblTotalAlertsCount.Name = "lblTotalAlertsCount";
            this.lblTotalAlertsCount.Size = new System.Drawing.Size(19, 21);
            this.lblTotalAlertsCount.TabIndex = 2;
            this.lblTotalAlertsCount.Text = "0";
            // 
            // dgvMembershipAlerts
            // 
            this.dgvMembershipAlerts.AllowUserToAddRows = false;
            this.dgvMembershipAlerts.AllowUserToDeleteRows = false;
            this.dgvMembershipAlerts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvMembershipAlerts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembershipAlerts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembershipAlerts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dgvMembershipAlerts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.dgvMembershipAlerts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembershipAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembershipAlerts.EnableHeadersVisualStyles = false;
            this.dgvMembershipAlerts.Location = new System.Drawing.Point(12, 228);
            this.dgvMembershipAlerts.MaxVisibleRows = 8;
            this.dgvMembershipAlerts.MultiSelect = false;
            this.dgvMembershipAlerts.Name = "dgvMembershipAlerts";
            this.dgvMembershipAlerts.ReadOnly = true;
            this.dgvMembershipAlerts.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMembershipAlerts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembershipAlerts.RowTemplate.Height = 40;
            this.dgvMembershipAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembershipAlerts.Size = new System.Drawing.Size(1086, 345);
            this.dgvMembershipAlerts.TabIndex = 2;
            this.dgvMembershipAlerts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembershipAlerts_CellClick);
            this.dgvMembershipAlerts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembershipAlerts_CellDoubleClick);
            this.dgvMembershipAlerts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMembershipAlerts_CellFormatting);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(479, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "MemberShips Alert";
            // 
            // txtSerach
            // 
            this.txtSerach.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSerach.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSerach.BorderRadius = 25;
            this.txtSerach.BorderThickness = 2;
            this.txtSerach.EnableEnterPress = false;
            this.txtSerach.EnableGroupSeparators = true;
            this.txtSerach.GlowColor = System.Drawing.Color.DodgerBlue;
            this.txtSerach.GlowEnabled = false;
            this.txtSerach.GlowSize = 5;
            this.txtSerach.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtSerach.LeftIconImage = null;
            this.txtSerach.LeftIconOffsetX = 0;
            this.txtSerach.LeftIconSize = 25;
            this.txtSerach.Location = new System.Drawing.Point(572, 148);
            this.txtSerach.Multiline = false;
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSerach.PlaceholderText = "Search By Name, Phone or ID";
            this.txtSerach.RightAndLeftIconVisible = true;
            this.txtSerach.RightIconImage = null;
            this.txtSerach.RightIconOffsetX = 0;
            this.txtSerach.RightIconSize = 25;
            this.txtSerach.Size = new System.Drawing.Size(270, 59);
            this.txtSerach.TabIndex = 4;
            this.txtSerach.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtSerach.TextBoxForeColor = System.Drawing.Color.White;
            this.txtSerach.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSerach.TextMode = Gym.ucTextBox.InputMode.Normal;
            this.txtSerach.TextValue = "";
            this.txtSerach.TxtOffsetX = 0;
            this.txtSerach.UnderlineColor = System.Drawing.Color.LightGray;
            this.txtSerach.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtSerach.UnderlineOnly = false;
            this.txtSerach.UnderlineThickness = 2;
            this.txtSerach.UsePasswordChar = false;
            this.txtSerach.TextValueChanged += new System.Action(this.txtSerach_TextValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(15, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expired";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(200, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Expiring Soon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(387, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Alerts";
            // 
            // frmMemberShipsAlerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1165, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMembershipAlerts);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.MaximizeBox = false;
            this.Name = "frmMemberShipsAlerts";
            this.Opacity = 1D;
            this.ShowIcon = false;
            this.Text = "MemberShips Alerts";
            this.TitleBarColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmMemberShipsAlerts_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipAlerts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label lblExpiredCount;
        private CustomControls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label lblExpiringSoonCount;
        private CustomControls.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label lblTotalAlertsCount;
        private CustomDataGridView dgvMembershipAlerts;
        private System.Windows.Forms.Label label4;
        private ucTextBox txtSerach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}