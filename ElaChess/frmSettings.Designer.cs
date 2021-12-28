namespace ElaChess
{
    partial class frmSettings
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
            this.tabMenus = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAnimationSpeed = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbShowCoord = new System.Windows.Forms.CheckBox();
            this.cbAnimation = new System.Windows.Forms.CheckBox();
            this.tabMenus.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimationSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenus
            // 
            this.tabMenus.Controls.Add(this.tabPage1);
            this.tabMenus.Controls.Add(this.tabPage2);
            this.tabMenus.Controls.Add(this.tabPage3);
            this.tabMenus.Location = new System.Drawing.Point(12, 12);
            this.tabMenus.Name = "tabMenus";
            this.tabMenus.SelectedIndex = 0;
            this.tabMenus.Size = new System.Drawing.Size(429, 495);
            this.tabMenus.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbAnimation);
            this.tabPage1.Controls.Add(this.cbShowCoord);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAnimationSpeed);
            this.groupBox1.Location = new System.Drawing.Point(16, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animation Speed";
            // 
            // tbAnimationSpeed
            // 
            this.tbAnimationSpeed.Location = new System.Drawing.Point(8, 19);
            this.tbAnimationSpeed.Name = "tbAnimationSpeed";
            this.tbAnimationSpeed.Size = new System.Drawing.Size(189, 45);
            this.tbAnimationSpeed.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Engines";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(421, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Themes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbShowCoord
            // 
            this.cbShowCoord.AutoSize = true;
            this.cbShowCoord.Checked = true;
            this.cbShowCoord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowCoord.Location = new System.Drawing.Point(16, 154);
            this.cbShowCoord.Name = "cbShowCoord";
            this.cbShowCoord.Size = new System.Drawing.Size(199, 17);
            this.cbShowCoord.TabIndex = 1;
            this.cbShowCoord.Text = "Show Numbers and Letters on board";
            this.cbShowCoord.UseVisualStyleBackColor = true;
            this.cbShowCoord.CheckedChanged += new System.EventHandler(this.cbShowCoord_CheckedChanged);
            // 
            // cbAnimation
            // 
            this.cbAnimation.AutoSize = true;
            this.cbAnimation.Checked = true;
            this.cbAnimation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAnimation.Location = new System.Drawing.Point(16, 20);
            this.cbAnimation.Name = "cbAnimation";
            this.cbAnimation.Size = new System.Drawing.Size(108, 17);
            this.cbAnimation.TabIndex = 2;
            this.cbAnimation.Text = "Enable Animation";
            this.cbAnimation.UseVisualStyleBackColor = true;
            this.cbAnimation.CheckedChanged += new System.EventHandler(this.cbAnimation_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 519);
            this.Controls.Add(this.tabMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.tabMenus.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnimationSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenus;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbAnimationSpeed;
        private System.Windows.Forms.CheckBox cbShowCoord;
        private System.Windows.Forms.CheckBox cbAnimation;
    }
}