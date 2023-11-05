namespace PaintApp.Forms
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSetColor = new System.Windows.Forms.ToolStripButton();
            this.btnPenIncrease = new System.Windows.Forms.ToolStripButton();
            this.btnPenDecrease = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnClear = new System.Windows.Forms.ToolStripButton();
            this.pbBoard = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuSave,
            this.openToolStripMenuOpen});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuSave
            // 
            this.saveToolStripMenuSave.Name = "saveToolStripMenuSave";
            this.saveToolStripMenuSave.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuSave.Text = "Save";
            this.saveToolStripMenuSave.Click += new System.EventHandler(this.saveToolStripMenuSave_Click);
            // 
            // openToolStripMenuOpen
            // 
            this.openToolStripMenuOpen.Name = "openToolStripMenuOpen";
            this.openToolStripMenuOpen.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuOpen.Text = "Open";
            this.openToolStripMenuOpen.Click += new System.EventHandler(this.openToolStripMenuOpen_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetColor,
            this.btnPenIncrease,
            this.btnPenDecrease,
            this.toolStripBtnClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSetColor
            // 
            this.btnSetColor.AutoSize = false;
            this.btnSetColor.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSetColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetColor.ForeColor = System.Drawing.Color.White;
            this.btnSetColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(50, 22);
            this.btnSetColor.Text = "Color";
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // btnPenIncrease
            // 
            this.btnPenIncrease.AutoSize = false;
            this.btnPenIncrease.BackColor = System.Drawing.Color.Plum;
            this.btnPenIncrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPenIncrease.ForeColor = System.Drawing.Color.White;
            this.btnPenIncrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPenIncrease.Name = "btnPenIncrease";
            this.btnPenIncrease.Size = new System.Drawing.Size(50, 22);
            this.btnPenIncrease.Text = "P+";
            this.btnPenIncrease.Click += new System.EventHandler(this.btnPenIncrease_Click);
            // 
            // btnPenDecrease
            // 
            this.btnPenDecrease.AutoSize = false;
            this.btnPenDecrease.BackColor = System.Drawing.Color.Plum;
            this.btnPenDecrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPenDecrease.ForeColor = System.Drawing.Color.White;
            this.btnPenDecrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPenDecrease.Name = "btnPenDecrease";
            this.btnPenDecrease.Size = new System.Drawing.Size(50, 22);
            this.btnPenDecrease.Text = "P-";
            this.btnPenDecrease.Click += new System.EventHandler(this.btnPenDecrease_Click);
            // 
            // toolStripBtnClear
            // 
            this.toolStripBtnClear.AutoSize = false;
            this.toolStripBtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnClear.Name = "toolStripBtnClear";
            this.toolStripBtnClear.Size = new System.Drawing.Size(50, 22);
            this.toolStripBtnClear.Text = "Clear";
            this.toolStripBtnClear.Click += new System.EventHandler(this.toolStripBtnClear_Click);
            // 
            // pbBoard
            // 
            this.pbBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBoard.Location = new System.Drawing.Point(0, 49);
            this.pbBoard.Name = "pbBoard";
            this.pbBoard.Size = new System.Drawing.Size(800, 401);
            this.pbBoard.TabIndex = 2;
            this.pbBoard.TabStop = false;
            this.pbBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBoard_MouseDownAndUp);
            this.pbBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbBoard_MouseMove);
            this.pbBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbBoard_MouseDownAndUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbBoard);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Paint App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuOpen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPenDecrease;
        private System.Windows.Forms.PictureBox pbBoard;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripBtnClear;
        private System.Windows.Forms.ToolStripButton btnSetColor;
        private System.Windows.Forms.ToolStripButton btnPenIncrease;
    }
}