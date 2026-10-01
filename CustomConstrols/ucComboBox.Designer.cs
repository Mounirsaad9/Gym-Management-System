namespace Gym.CustomControls
{
    partial class ucComboBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel = new Gym.CustomControls.RoundedPanel();
            this.cb = new System.Windows.Forms.ComboBox();
            this.roundedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel
            // 
            this.roundedPanel.BackColor = System.Drawing.Color.White;
            this.roundedPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel.BorderRadius = 20;
            this.roundedPanel.BorderThickness = 1;
            this.roundedPanel.Controls.Add(this.cb);
            this.roundedPanel.CornerBottomLeft = true;
            this.roundedPanel.CornerBottomRight = true;
            this.roundedPanel.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.roundedPanel.CornerTopLeft = true;
            this.roundedPanel.CornerTopRight = true;
            this.roundedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel.FillColor = System.Drawing.Color.White;
            this.roundedPanel.FillColor2 = System.Drawing.Color.White;
            this.roundedPanel.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel.GlowEnabled = false;
            this.roundedPanel.GlowSize = 5;
            this.roundedPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel.Margin = new System.Windows.Forms.Padding(5);
            this.roundedPanel.Name = "roundedPanel";
            this.roundedPanel.Size = new System.Drawing.Size(209, 41);
            this.roundedPanel.TabIndex = 0;
            this.roundedPanel.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel.UnderlineOnly = false;
            this.roundedPanel.UnderlineThickness = 2;
            // 
            // cb
            // 
            this.cb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb.BackColor = System.Drawing.Color.White;
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(5, 5);
            this.cb.Margin = new System.Windows.Forms.Padding(5);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(199, 29);
            this.cb.TabIndex = 0;
            // 
            // ucComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucComboBox";
            this.Size = new System.Drawing.Size(209, 41);
            this.roundedPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel;
        private System.Windows.Forms.ComboBox cb;
    }
}
