namespace UltimateBatchFileMaker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ExtractInfo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDefinitionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createResourceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createResourceFileAdvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Level_txtbx = new System.Windows.Forms.TextBox();
            this.Player_grpbx = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Money_txtbx = new System.Windows.Forms.TextBox();
            this.Map_none_rbtn = new System.Windows.Forms.RadioButton();
            this.Map_markers_rbtn = new System.Windows.Forms.RadioButton();
            this.Map_full_rbtn = new System.Windows.Forms.RadioButton();
            this.Perk_grpbx = new System.Windows.Forms.GroupBox();
            this.Perk_txtbx = new System.Windows.Forms.TextBox();
            this.Perk_remove_btn = new System.Windows.Forms.Button();
            this.Perk_add_btn = new System.Windows.Forms.Button();
            this.Perks_lstbx = new System.Windows.Forms.ListBox();
            this.Var_grpbx = new System.Windows.Forms.GroupBox();
            this.Var_txtbx = new System.Windows.Forms.TextBox();
            this.Variables_lstbx = new System.Windows.Forms.ListBox();
            this.Var_remove_btn = new System.Windows.Forms.Button();
            this.Var_add_btn = new System.Windows.Forms.Button();
            this.Map_grpbx = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.Player_grpbx.SuspendLayout();
            this.Perk_grpbx.SuspendLayout();
            this.Var_grpbx.SuspendLayout();
            this.Map_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 201);
            this.tabControl1.TabIndex = 13;
            // 
            // ExtractInfo
            // 
            this.ExtractInfo.Location = new System.Drawing.Point(365, 27);
            this.ExtractInfo.Name = "ExtractInfo";
            this.ExtractInfo.Size = new System.Drawing.Size(86, 145);
            this.ExtractInfo.TabIndex = 14;
            this.ExtractInfo.Text = "Create File";
            this.ExtractInfo.UseVisualStyleBackColor = true;
            this.ExtractInfo.Click += new System.EventHandler(this.ExtractInfo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCategoryToolStripMenuItem,
            this.loadFolderToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadCategoryToolStripMenuItem
            // 
            this.loadCategoryToolStripMenuItem.Name = "loadCategoryToolStripMenuItem";
            this.loadCategoryToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.loadCategoryToolStripMenuItem.Text = "Load Resource";
            this.loadCategoryToolStripMenuItem.Click += new System.EventHandler(this.LoadResourceFileToolStripMenuItem_Click);
            // 
            // loadFolderToolStripMenuItem
            // 
            this.loadFolderToolStripMenuItem.Name = "loadFolderToolStripMenuItem";
            this.loadFolderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.loadFolderToolStripMenuItem.Text = "Load Folder";
            this.loadFolderToolStripMenuItem.Click += new System.EventHandler(this.LoadResourceFolderToolStripMenuItem_click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDefinitionFileToolStripMenuItem,
            this.createResourceFileToolStripMenuItem,
            this.createResourceFileAdvToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // createDefinitionFileToolStripMenuItem
            // 
            this.createDefinitionFileToolStripMenuItem.Name = "createDefinitionFileToolStripMenuItem";
            this.createDefinitionFileToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.createDefinitionFileToolStripMenuItem.Text = "Create Definition File";
            this.createDefinitionFileToolStripMenuItem.Click += new System.EventHandler(this.CreateDefinitionFileToolStripMenuItem_Click);
            // 
            // createResourceFileToolStripMenuItem
            // 
            this.createResourceFileToolStripMenuItem.Name = "createResourceFileToolStripMenuItem";
            this.createResourceFileToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.createResourceFileToolStripMenuItem.Text = "Create Resource File (basic)";
            this.createResourceFileToolStripMenuItem.Click += new System.EventHandler(this.CreateResourceFileToolStripMenuItem_Click);
            // 
            // createResourceFileAdvToolStripMenuItem
            // 
            this.createResourceFileAdvToolStripMenuItem.Name = "createResourceFileAdvToolStripMenuItem";
            this.createResourceFileAdvToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.createResourceFileAdvToolStripMenuItem.Text = "Create Resource File (Adv)";
            this.createResourceFileAdvToolStripMenuItem.Click += new System.EventHandler(this.CreateResourceFileAdvToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Level:";
            // 
            // Level_txtbx
            // 
            this.Level_txtbx.Location = new System.Drawing.Point(69, 15);
            this.Level_txtbx.Name = "Level_txtbx";
            this.Level_txtbx.Size = new System.Drawing.Size(58, 20);
            this.Level_txtbx.TabIndex = 0;
            // 
            // Player_grpbx
            // 
            this.Player_grpbx.Controls.Add(this.label3);
            this.Player_grpbx.Controls.Add(this.label1);
            this.Player_grpbx.Controls.Add(this.Money_txtbx);
            this.Player_grpbx.Controls.Add(this.Level_txtbx);
            this.Player_grpbx.Location = new System.Drawing.Point(6, 27);
            this.Player_grpbx.Name = "Player_grpbx";
            this.Player_grpbx.Size = new System.Drawing.Size(133, 72);
            this.Player_grpbx.TabIndex = 9;
            this.Player_grpbx.TabStop = false;
            this.Player_grpbx.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Money:";
            // 
            // Money_txtbx
            // 
            this.Money_txtbx.Location = new System.Drawing.Point(69, 41);
            this.Money_txtbx.Name = "Money_txtbx";
            this.Money_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Money_txtbx.Size = new System.Drawing.Size(58, 20);
            this.Money_txtbx.TabIndex = 1;
            // 
            // Map_none_rbtn
            // 
            this.Map_none_rbtn.AutoSize = true;
            this.Map_none_rbtn.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Map_none_rbtn.Location = new System.Drawing.Point(6, 56);
            this.Map_none_rbtn.Name = "Map_none_rbtn";
            this.Map_none_rbtn.Size = new System.Drawing.Size(77, 17);
            this.Map_none_rbtn.TabIndex = 4;
            this.Map_none_rbtn.TabStop = true;
            this.Map_none_rbtn.Text = "Remove All";
            this.Map_none_rbtn.UseVisualStyleBackColor = true;
            this.Map_none_rbtn.CheckedChanged += new System.EventHandler(this.Map_none_rbtn_CheckedChanged);
            // 
            // Map_markers_rbtn
            // 
            this.Map_markers_rbtn.AutoSize = true;
            this.Map_markers_rbtn.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Map_markers_rbtn.Location = new System.Drawing.Point(6, 36);
            this.Map_markers_rbtn.Name = "Map_markers_rbtn";
            this.Map_markers_rbtn.Size = new System.Drawing.Size(93, 17);
            this.Map_markers_rbtn.TabIndex = 3;
            this.Map_markers_rbtn.TabStop = true;
            this.Map_markers_rbtn.Text = "Show Markers ";
            this.Map_markers_rbtn.UseVisualStyleBackColor = true;
            this.Map_markers_rbtn.CheckedChanged += new System.EventHandler(this.Map_markers_rbtn_CheckedChanged);
            // 
            // Map_full_rbtn
            // 
            this.Map_full_rbtn.AutoSize = true;
            this.Map_full_rbtn.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Map_full_rbtn.Location = new System.Drawing.Point(6, 16);
            this.Map_full_rbtn.Name = "Map_full_rbtn";
            this.Map_full_rbtn.Size = new System.Drawing.Size(114, 17);
            this.Map_full_rbtn.TabIndex = 2;
            this.Map_full_rbtn.TabStop = true;
            this.Map_full_rbtn.Text = "Complete Discover";
            this.Map_full_rbtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Map_full_rbtn.UseVisualStyleBackColor = true;
            this.Map_full_rbtn.CheckedChanged += new System.EventHandler(this.Map_full_rbtn_CheckedChanged);
            // 
            // Perk_grpbx
            // 
            this.Perk_grpbx.Controls.Add(this.Perk_txtbx);
            this.Perk_grpbx.Controls.Add(this.Perk_remove_btn);
            this.Perk_grpbx.Controls.Add(this.Perk_add_btn);
            this.Perk_grpbx.Controls.Add(this.Perks_lstbx);
            this.Perk_grpbx.Location = new System.Drawing.Point(145, 27);
            this.Perk_grpbx.Name = "Perk_grpbx";
            this.Perk_grpbx.Size = new System.Drawing.Size(102, 148);
            this.Perk_grpbx.TabIndex = 10;
            this.Perk_grpbx.TabStop = false;
            this.Perk_grpbx.Text = "Perks";
            // 
            // Perk_txtbx
            // 
            this.Perk_txtbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Perk_txtbx.Location = new System.Drawing.Point(3, 16);
            this.Perk_txtbx.Name = "Perk_txtbx";
            this.Perk_txtbx.Size = new System.Drawing.Size(96, 20);
            this.Perk_txtbx.TabIndex = 5;
            // 
            // Perk_remove_btn
            // 
            this.Perk_remove_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Perk_remove_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perk_remove_btn.Image = ((System.Drawing.Image)(resources.GetObject("Perk_remove_btn.Image")));
            this.Perk_remove_btn.Location = new System.Drawing.Point(65, 38);
            this.Perk_remove_btn.Name = "Perk_remove_btn";
            this.Perk_remove_btn.Size = new System.Drawing.Size(33, 22);
            this.Perk_remove_btn.TabIndex = 8;
            this.Perk_remove_btn.Text = "↑";
            this.Perk_remove_btn.UseVisualStyleBackColor = true;
            this.Perk_remove_btn.Click += new System.EventHandler(this.Perk_remove_btn_Click);
            // 
            // Perk_add_btn
            // 
            this.Perk_add_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Perk_add_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perk_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("Perk_add_btn.Image")));
            this.Perk_add_btn.Location = new System.Drawing.Point(6, 38);
            this.Perk_add_btn.Name = "Perk_add_btn";
            this.Perk_add_btn.Size = new System.Drawing.Size(33, 22);
            this.Perk_add_btn.TabIndex = 6;
            this.Perk_add_btn.Text = "↓";
            this.Perk_add_btn.UseVisualStyleBackColor = true;
            this.Perk_add_btn.Click += new System.EventHandler(this.Perk_add_btn_Click);
            // 
            // Perks_lstbx
            // 
            this.Perks_lstbx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Perks_lstbx.FormattingEnabled = true;
            this.Perks_lstbx.Location = new System.Drawing.Point(3, 63);
            this.Perks_lstbx.Name = "Perks_lstbx";
            this.Perks_lstbx.Size = new System.Drawing.Size(96, 82);
            this.Perks_lstbx.TabIndex = 7;
            // 
            // Var_grpbx
            // 
            this.Var_grpbx.Controls.Add(this.Var_txtbx);
            this.Var_grpbx.Controls.Add(this.Variables_lstbx);
            this.Var_grpbx.Controls.Add(this.Var_remove_btn);
            this.Var_grpbx.Controls.Add(this.Var_add_btn);
            this.Var_grpbx.Location = new System.Drawing.Point(253, 27);
            this.Var_grpbx.Name = "Var_grpbx";
            this.Var_grpbx.Size = new System.Drawing.Size(106, 148);
            this.Var_grpbx.TabIndex = 12;
            this.Var_grpbx.TabStop = false;
            this.Var_grpbx.Text = "Variables";
            // 
            // Var_txtbx
            // 
            this.Var_txtbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Var_txtbx.Location = new System.Drawing.Point(3, 16);
            this.Var_txtbx.Name = "Var_txtbx";
            this.Var_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Var_txtbx.TabIndex = 9;
            // 
            // Variables_lstbx
            // 
            this.Variables_lstbx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Variables_lstbx.FormattingEnabled = true;
            this.Variables_lstbx.Location = new System.Drawing.Point(3, 63);
            this.Variables_lstbx.Name = "Variables_lstbx";
            this.Variables_lstbx.Size = new System.Drawing.Size(100, 82);
            this.Variables_lstbx.TabIndex = 11;
            // 
            // Var_remove_btn
            // 
            this.Var_remove_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Var_remove_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Var_remove_btn.Image = ((System.Drawing.Image)(resources.GetObject("Var_remove_btn.Image")));
            this.Var_remove_btn.Location = new System.Drawing.Point(67, 38);
            this.Var_remove_btn.Name = "Var_remove_btn";
            this.Var_remove_btn.Size = new System.Drawing.Size(33, 22);
            this.Var_remove_btn.TabIndex = 12;
            this.Var_remove_btn.Text = "↑";
            this.Var_remove_btn.UseVisualStyleBackColor = true;
            this.Var_remove_btn.Click += new System.EventHandler(this.Var_remove_btn_Click);
            // 
            // Var_add_btn
            // 
            this.Var_add_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Var_add_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Var_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("Var_add_btn.Image")));
            this.Var_add_btn.Location = new System.Drawing.Point(3, 38);
            this.Var_add_btn.Name = "Var_add_btn";
            this.Var_add_btn.Size = new System.Drawing.Size(33, 22);
            this.Var_add_btn.TabIndex = 10;
            this.Var_add_btn.Text = "↓";
            this.Var_add_btn.UseVisualStyleBackColor = true;
            this.Var_add_btn.Click += new System.EventHandler(this.Var_add_btn_Click);
            // 
            // Map_grpbx
            // 
            this.Map_grpbx.Controls.Add(this.Map_none_rbtn);
            this.Map_grpbx.Controls.Add(this.Map_full_rbtn);
            this.Map_grpbx.Controls.Add(this.Map_markers_rbtn);
            this.Map_grpbx.Location = new System.Drawing.Point(7, 99);
            this.Map_grpbx.Name = "Map_grpbx";
            this.Map_grpbx.Size = new System.Drawing.Size(132, 76);
            this.Map_grpbx.TabIndex = 0;
            this.Map_grpbx.TabStop = false;
            this.Map_grpbx.Text = "Map";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 380);
            this.Controls.Add(this.Var_grpbx);
            this.Controls.Add(this.Map_grpbx);
            this.Controls.Add(this.Perk_grpbx);
            this.Controls.Add(this.Player_grpbx);
            this.Controls.Add(this.ExtractInfo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(478, 418);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Batch File Maker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Player_grpbx.ResumeLayout(false);
            this.Player_grpbx.PerformLayout();
            this.Perk_grpbx.ResumeLayout(false);
            this.Perk_grpbx.PerformLayout();
            this.Var_grpbx.ResumeLayout(false);
            this.Var_grpbx.PerformLayout();
            this.Map_grpbx.ResumeLayout(false);
            this.Map_grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button ExtractInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCategoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Level_txtbx;
        private System.Windows.Forms.GroupBox Player_grpbx;
        private System.Windows.Forms.RadioButton Map_none_rbtn;
        private System.Windows.Forms.RadioButton Map_markers_rbtn;
        private System.Windows.Forms.RadioButton Map_full_rbtn;
        private System.Windows.Forms.GroupBox Perk_grpbx;
        private System.Windows.Forms.ListBox Perks_lstbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Money_txtbx;
        private System.Windows.Forms.TextBox Perk_txtbx;
        private System.Windows.Forms.Button Perk_remove_btn;
        private System.Windows.Forms.GroupBox Var_grpbx;
        private System.Windows.Forms.TextBox Var_txtbx;
        private System.Windows.Forms.ListBox Variables_lstbx;
        private System.Windows.Forms.Button Var_remove_btn;
        private System.Windows.Forms.Button Var_add_btn;
        private System.Windows.Forms.GroupBox Map_grpbx;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDefinitionFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createResourceFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.Button Perk_add_btn;
        private System.Windows.Forms.ToolStripMenuItem createResourceFileAdvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFolderToolStripMenuItem;
    }
}