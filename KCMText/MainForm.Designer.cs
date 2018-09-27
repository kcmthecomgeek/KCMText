namespace KCMText
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.springLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lineCharStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSeparator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.numLockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.capsLockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.scrollLockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainEditor = new KCMText.Editor.EditorControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.springLabel,
            this.lineCharStatusLabel,
            this.statusSeparator1,
            this.numLockLabel,
            this.capsLockLabel,
            this.scrollLockLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Overall Status";
            // 
            // springLabel
            // 
            this.springLabel.Name = "springLabel";
            this.springLabel.Size = new System.Drawing.Size(611, 17);
            this.springLabel.Spring = true;
            // 
            // lineCharStatusLabel
            // 
            this.lineCharStatusLabel.Name = "lineCharStatusLabel";
            this.lineCharStatusLabel.Size = new System.Drawing.Size(66, 17);
            this.lineCharStatusLabel.Text = "LN: 1 CH: 1";
            // 
            // statusSeparator1
            // 
            this.statusSeparator1.AutoSize = false;
            this.statusSeparator1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusSeparator1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusSeparator1.Name = "statusSeparator1";
            this.statusSeparator1.Size = new System.Drawing.Size(3, 17);
            // 
            // numLockLabel
            // 
            this.numLockLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLockLabel.Name = "numLockLabel";
            this.numLockLabel.Size = new System.Drawing.Size(35, 17);
            this.numLockLabel.Text = "NUM";
            // 
            // capsLockLabel
            // 
            this.capsLockLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.capsLockLabel.Enabled = false;
            this.capsLockLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capsLockLabel.Name = "capsLockLabel";
            this.capsLockLabel.Size = new System.Drawing.Size(36, 17);
            this.capsLockLabel.Text = "CAPS";
            // 
            // scrollLockLabel
            // 
            this.scrollLockLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.scrollLockLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.scrollLockLabel.Enabled = false;
            this.scrollLockLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollLockLabel.Name = "scrollLockLabel";
            this.scrollLockLabel.Size = new System.Drawing.Size(34, 17);
            this.scrollLockLabel.Text = "SCRL";
            // 
            // mainEditor
            // 
            this.mainEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainEditor.Location = new System.Drawing.Point(0, 24);
            this.mainEditor.Name = "mainEditor";
            this.mainEditor.Size = new System.Drawing.Size(800, 404);
            this.mainEditor.TabIndex = 1;
            this.mainEditor.WordWrap = false;
            this.mainEditor.CursorPositionChanged += new System.EventHandler(this.mainEditor_CursorPositionChanged);
            this.mainEditor.ModifierKeyPressed += new System.Windows.Forms.KeyEventHandler(this.mainEditor_ModifierKeyPressed);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainEditor);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KCM Text";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel springLabel;
        private System.Windows.Forms.ToolStripStatusLabel lineCharStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel numLockLabel;
        private System.Windows.Forms.ToolStripStatusLabel capsLockLabel;
        private System.Windows.Forms.ToolStripStatusLabel scrollLockLabel;
        private Editor.EditorControl mainEditor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

