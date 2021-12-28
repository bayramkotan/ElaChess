namespace ElaChess
{
    partial class newGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboEngine1 = new System.Windows.Forms.ComboBox();
            this.comboEngine2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start the Game!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboEngine1
            // 
            this.comboEngine1.FormattingEnabled = true;
            this.comboEngine1.Items.AddRange(new object[] {
            "Human",
            "Stockfish",
            "Gnuchess",
            "Crafty",
            "Toga II",
            "Sjeng"});
            this.comboEngine1.Location = new System.Drawing.Point(43, 6);
            this.comboEngine1.Name = "comboEngine1";
            this.comboEngine1.Size = new System.Drawing.Size(146, 21);
            this.comboEngine1.TabIndex = 2;
            // 
            // comboEngine2
            // 
            this.comboEngine2.FormattingEnabled = true;
            this.comboEngine2.Items.AddRange(new object[] {
            "Human",
            "Stockfish",
            "Gnuchess",
            "Crafty",
            "Toga II",
            "Sjeng"});
            this.comboEngine2.Location = new System.Drawing.Point(43, 32);
            this.comboEngine2.Name = "comboEngine2";
            this.comboEngine2.Size = new System.Drawing.Size(146, 21);
            this.comboEngine2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "White";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Black";
            // 
            // newGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 102);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEngine2);
            this.Controls.Add(this.comboEngine1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "newGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.newGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboEngine1;
        private System.Windows.Forms.ComboBox comboEngine2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}