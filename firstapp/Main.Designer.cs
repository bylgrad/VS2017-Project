namespace firstapp
{
    partial class Main
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("DRIVER");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("VEHICLE");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("MASTER", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("REQUEST");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("TRAVEL");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("TRANSACTION", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("MFC");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("RIS");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("MOROT");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("REPORTS", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionUID = new System.Windows.Forms.Label();
            this.sessionROLE = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // sessionUID
            // 
            this.sessionUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionUID.AutoSize = true;
            this.sessionUID.Location = new System.Drawing.Point(799, 14);
            this.sessionUID.Name = "sessionUID";
            this.sessionUID.Size = new System.Drawing.Size(61, 13);
            this.sessionUID.TabIndex = 3;
            this.sessionUID.Text = "sessionUID";
            // 
            // sessionROLE
            // 
            this.sessionROLE.AutoSize = true;
            this.sessionROLE.Location = new System.Drawing.Point(378, 14);
            this.sessionROLE.Name = "sessionROLE";
            this.sessionROLE.Size = new System.Drawing.Size(35, 13);
            this.sessionROLE.TabIndex = 4;
            this.sessionROLE.Text = "label1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(5, 29);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "Node4";
            treeNode11.Text = "DRIVER";
            treeNode12.Name = "Node5";
            treeNode12.Text = "VEHICLE";
            treeNode13.Name = "Node0";
            treeNode13.Text = "MASTER";
            treeNode14.Name = "Node6";
            treeNode14.Text = "REQUEST";
            treeNode15.Name = "Node7";
            treeNode15.Text = "TRAVEL";
            treeNode16.Name = "Node1";
            treeNode16.Text = "TRANSACTION";
            treeNode17.Name = "Node11";
            treeNode17.Text = "MFC";
            treeNode18.Name = "Node9";
            treeNode18.Text = "RIS";
            treeNode19.Name = "Node10";
            treeNode19.Text = "MOROT";
            treeNode20.Name = "Node8";
            treeNode20.Text = "REPORTS";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(207, 341);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(212, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 341);
            this.panel1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 375);
            this.Controls.Add(this.sessionROLE);
            this.Controls.Add(this.sessionUID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEO - Travel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label sessionUID;
        private System.Windows.Forms.Label sessionROLE;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
    }
}

