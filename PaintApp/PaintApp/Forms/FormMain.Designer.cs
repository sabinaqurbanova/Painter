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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnGold = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnPenSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbBoard = new System.Windows.Forms.PictureBox();
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
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnBlack,
            this.toolStripBtnRed,
            this.toolStripBtnGold,
            this.toolStripBtnPenSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnBlack
            // 
            this.toolStripBtnBlack.AutoSize = false;
            this.toolStripBtnBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripBtnBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnBlack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripBtnBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBlack.Name = "toolStripBtnBlack";
            this.toolStripBtnBlack.Size = new System.Drawing.Size(50, 22);
            this.toolStripBtnBlack.Text = "Black";
            // 
            // toolStripBtnRed
            // 
            this.toolStripBtnRed.AutoSize = false;
            this.toolStripBtnRed.BackColor = System.Drawing.Color.Red;
            this.toolStripBtnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnRed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripBtnRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRed.Name = "toolStripBtnRed";
            this.toolStripBtnRed.Size = new System.Drawing.Size(50, 22);
            this.toolStripBtnRed.Text = "Red";
            // 
            // toolStripBtnGold
            // 
            this.toolStripBtnGold.AutoSize = false;
            this.toolStripBtnGold.BackColor = System.Drawing.Color.Yellow;
            this.toolStripBtnGold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnGold.ForeColor = System.Drawing.Color.Black;
            this.toolStripBtnGold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGold.Name = "toolStripBtnGold";
            this.toolStripBtnGold.Size = new System.Drawing.Size(50, 22);
            this.toolStripBtnGold.Text = "Gold";
            // 
            // toolStripBtnPenSize
            // 
            this.toolStripBtnPenSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnPenSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripBtnPenSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripBtnPenSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPenSize.Name = "toolStripBtnPenSize";
            this.toolStripBtnPenSize.Size = new System.Drawing.Size(60, 22);
            this.toolStripBtnPenSize.Text = "PenSize";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "5";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "10";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "15";
            // 
            // pbBoard
            // 
            this.pbBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBoard.Location = new System.Drawing.Point(0, 52);
            this.pbBoard.Name = "pbBoard";
            this.pbBoard.Size = new System.Drawing.Size(800, 398);
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
            this.Load += new System.EventHandler(this.FormMain_Load);
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
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnBlack;
        private System.Windows.Forms.ToolStripButton toolStripBtnRed;
        private System.Windows.Forms.ToolStripButton toolStripBtnGold;
        private System.Windows.Forms.ToolStripDropDownButton toolStripBtnPenSize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.PictureBox pbBoard;
    }
}