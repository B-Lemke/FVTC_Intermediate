namespace BJL.Notepad.UI
{
    partial class frmParent
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
            this.newDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCloseall = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeForms = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocumentToolStripMenuItem,
            this.mnuMakeForms});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newDocumentToolStripMenuItem
            // 
            this.newDocumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.toolStripMenuItem1,
            this.mnuTileHorizontal,
            this.mnuTileVertical,
            this.toolStripMenuItem2,
            this.mnuCloseall,
            this.mnuCascade,
            this.mnuArrangeIcons});
            this.newDocumentToolStripMenuItem.Name = "newDocumentToolStripMenuItem";
            this.newDocumentToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.newDocumentToolStripMenuItem.Text = "&Form";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(200, 22);
            this.mnuNew.Text = "&New Document";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 6);
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Name = "mnuTileHorizontal";
            this.mnuTileHorizontal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuTileHorizontal.Size = new System.Drawing.Size(200, 22);
            this.mnuTileHorizontal.Text = "Tile &Horizontal";
            this.mnuTileHorizontal.Click += new System.EventHandler(this.mnuTileHorizontal_Click);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Name = "mnuTileVertical";
            this.mnuTileVertical.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuTileVertical.Size = new System.Drawing.Size(200, 22);
            this.mnuTileVertical.Text = "Tile &Vertical";
            this.mnuTileVertical.Click += new System.EventHandler(this.mnuTileVertical_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 6);
            // 
            // mnuCloseall
            // 
            this.mnuCloseall.Name = "mnuCloseall";
            this.mnuCloseall.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.mnuCloseall.Size = new System.Drawing.Size(200, 22);
            this.mnuCloseall.Text = "Close All";
            this.mnuCloseall.Click += new System.EventHandler(this.mnuCloseall_Click);
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(200, 22);
            this.mnuCascade.Text = "Cascade";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
            // 
            // mnuArrangeIcons
            // 
            this.mnuArrangeIcons.Name = "mnuArrangeIcons";
            this.mnuArrangeIcons.Size = new System.Drawing.Size(200, 22);
            this.mnuArrangeIcons.Text = "Arange Icons";
            this.mnuArrangeIcons.Click += new System.EventHandler(this.mnuArrangeIcons_Click);
            // 
            // mnuMakeForms
            // 
            this.mnuMakeForms.Name = "mnuMakeForms";
            this.mnuMakeForms.Size = new System.Drawing.Size(84, 20);
            this.mnuMakeForms.Text = "Make Forms";
            this.mnuMakeForms.Click += new System.EventHandler(this.mnuMakeForms_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 652);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 674);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmParent";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseall;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeForms;
    }
}

