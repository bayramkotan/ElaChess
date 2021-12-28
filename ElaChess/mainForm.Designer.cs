namespace ElaChess
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listBoxMoves = new System.Windows.Forms.ListBox();
            this.pbBoard = new System.Windows.Forms.PictureBox();
            this.menuNew = new System.Windows.Forms.ToolStripButton();
            this.menuOpen = new System.Windows.Forms.ToolStripButton();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
            this.menuFirst = new System.Windows.Forms.ToolStripButton();
            this.menuPrevious = new System.Windows.Forms.ToolStripButton();
            this.menuNext = new System.Windows.Forms.ToolStripButton();
            this.menuLast = new System.Windows.Forms.ToolStripButton();
            this.menuSettings = new System.Windows.Forms.ToolStripButton();
            this.menuAbout = new System.Windows.Forms.ToolStripButton();
            this.menuExit = new System.Windows.Forms.ToolStripButton();
            this.pbNumberSide = new System.Windows.Forms.PictureBox();
            this.pbLetterSide = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetterSide)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.toolStripSeparator2,
            this.menuFirst,
            this.menuPrevious,
            this.menuNext,
            this.menuLast,
            this.toolStripSeparator1,
            this.menuSettings,
            this.menuAbout,
            this.menuExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // listBoxMoves
            // 
            this.listBoxMoves.FormattingEnabled = true;
            this.listBoxMoves.Location = new System.Drawing.Point(678, 32);
            this.listBoxMoves.Name = "listBoxMoves";
            this.listBoxMoves.Size = new System.Drawing.Size(326, 667);
            this.listBoxMoves.TabIndex = 2;
            // 
            // pbBoard
            // 
            this.pbBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBoard.Image = global::ElaChess.Properties.Resources.board;
            this.pbBoard.Location = new System.Drawing.Point(30, 31);
            this.pbBoard.Name = "pbBoard";
            this.pbBoard.Size = new System.Drawing.Size(642, 642);
            this.pbBoard.TabIndex = 1;
            this.pbBoard.TabStop = false;
            this.pbBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // menuNew
            // 
            this.menuNew.Image = global::ElaChess.Properties.Resources.NewDocumentHS;
            this.menuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(48, 22);
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Image = global::ElaChess.Properties.Resources.openHS;
            this.menuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(53, 22);
            this.menuOpen.Text = "Open";
            // 
            // menuSave
            // 
            this.menuSave.Image = global::ElaChess.Properties.Resources.saveHS;
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(51, 22);
            this.menuSave.Text = "Save";
            // 
            // menuFirst
            // 
            this.menuFirst.Image = ((System.Drawing.Image)(resources.GetObject("menuFirst.Image")));
            this.menuFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFirst.Name = "menuFirst";
            this.menuFirst.Size = new System.Drawing.Size(48, 22);
            this.menuFirst.Text = "First";
            // 
            // menuPrevious
            // 
            this.menuPrevious.Image = global::ElaChess.Properties.Resources.GoToPrevious;
            this.menuPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrevious.Name = "menuPrevious";
            this.menuPrevious.Size = new System.Drawing.Size(68, 22);
            this.menuPrevious.Text = "Previous";
            // 
            // menuNext
            // 
            this.menuNext.Image = global::ElaChess.Properties.Resources.GoToNextHS;
            this.menuNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNext.Name = "menuNext";
            this.menuNext.Size = new System.Drawing.Size(50, 22);
            this.menuNext.Text = "Next";
            this.menuNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // menuLast
            // 
            this.menuLast.Image = ((System.Drawing.Image)(resources.GetObject("menuLast.Image")));
            this.menuLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuLast.Name = "menuLast";
            this.menuLast.Size = new System.Drawing.Size(47, 22);
            this.menuLast.Text = "Last";
            // 
            // menuSettings
            // 
            this.menuSettings.Image = ((System.Drawing.Image)(resources.GetObject("menuSettings.Image")));
            this.menuSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(66, 22);
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Image = global::ElaChess.Properties.Resources.Help;
            this.menuAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(56, 22);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Image = global::ElaChess.Properties.Resources.DeleteHS;
            this.menuExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(45, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // pbNumberSide
            // 
            this.pbNumberSide.BackgroundImage = global::ElaChess.Properties.Resources.numberSide;
            this.pbNumberSide.Location = new System.Drawing.Point(3, 32);
            this.pbNumberSide.Name = "pbNumberSide";
            this.pbNumberSide.Size = new System.Drawing.Size(24, 641);
            this.pbNumberSide.TabIndex = 3;
            this.pbNumberSide.TabStop = false;
            // 
            // pbLetterSide
            // 
            this.pbLetterSide.BackgroundImage = global::ElaChess.Properties.Resources.letterSide;
            this.pbLetterSide.Location = new System.Drawing.Point(30, 677);
            this.pbLetterSide.Name = "pbLetterSide";
            this.pbLetterSide.Size = new System.Drawing.Size(642, 29);
            this.pbLetterSide.TabIndex = 4;
            this.pbLetterSide.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 711);
            this.Controls.Add(this.pbLetterSide);
            this.Controls.Add(this.pbNumberSide);
            this.Controls.Add(this.listBoxMoves);
            this.Controls.Add(this.pbBoard);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ela Chess";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetterSide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuNew;
        private System.Windows.Forms.ToolStripButton menuOpen;
        private System.Windows.Forms.ToolStripButton menuSave;
        private System.Windows.Forms.ToolStripButton menuPrevious;
        private System.Windows.Forms.ToolStripButton menuNext;
        private System.Windows.Forms.ToolStripButton menuAbout;
        private System.Windows.Forms.ToolStripButton menuExit;
        private System.Windows.Forms.PictureBox pbBoard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton menuSettings;
        private System.Windows.Forms.ListBox listBoxMoves;
        private System.Windows.Forms.ToolStripButton menuFirst;
        private System.Windows.Forms.ToolStripButton menuLast;
        private System.Windows.Forms.PictureBox pbNumberSide;
        private System.Windows.Forms.PictureBox pbLetterSide;
    }
}

