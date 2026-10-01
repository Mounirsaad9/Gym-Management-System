namespace Gym

{
    partial class ucTextBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTextBox));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.roundedPanel1 = new Gym.CustomControls.RoundedPanel();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.BorderRadius = 25;
            this.roundedPanel1.BorderThickness = 2;
            this.roundedPanel1.Controls.Add(this.pbLeft);
            this.roundedPanel1.Controls.Add(this.txt);
            this.roundedPanel1.Controls.Add(this.pbRight);
            this.roundedPanel1.CornerBottomLeft = true;
            this.roundedPanel1.CornerBottomRight = true;
            this.roundedPanel1.Corners = ((Gym.CustomControls.RoundedPanel.RoundedCorners)((((Gym.CustomControls.RoundedPanel.RoundedCorners.TopLeft | Gym.CustomControls.RoundedPanel.RoundedCorners.TopRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomRight) 
            | Gym.CustomControls.RoundedPanel.RoundedCorners.BottomLeft)));
            this.roundedPanel1.CornerTopLeft = true;
            this.roundedPanel1.CornerTopRight = true;
            resources.ApplyResources(this.roundedPanel1, "roundedPanel1");
            this.roundedPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.roundedPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.GlowColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.GlowEnabled = false;
            this.roundedPanel1.GlowSize = 5;
            this.roundedPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.UnderlineColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.UnderlineFocusColor = System.Drawing.Color.DodgerBlue;
            this.roundedPanel1.UnderlineOnly = false;
            this.roundedPanel1.UnderlineThickness = 2;
            
            // 
            // pbLeft
            // 
            resources.ApplyResources(this.pbLeft, "pbLeft");
            this.pbLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.TabStop = false;
            // 
            // txt
            // 
            resources.ApplyResources(this.txt, "txt");
            this.txt.BackColor = System.Drawing.SystemColors.ControlText;
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt.ForeColor = System.Drawing.SystemColors.Control;
            this.txt.Name = "txt";
            this.txt.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txt.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txt.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDown);
            this.txt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseMove);
            // 
            // pbRight
            // 
            resources.ApplyResources(this.pbRight, "pbRight");
            this.pbRight.BackColor = System.Drawing.Color.Transparent;
            this.pbRight.Name = "pbRight";
            this.pbRight.TabStop = false;
            // 
            // ucTextBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "ucTextBox";
            this.Load += new System.EventHandler(this.ucTextBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.PictureBox pbLeft;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt;
    }
}
