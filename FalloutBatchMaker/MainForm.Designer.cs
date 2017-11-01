namespace FalloutBatchMaker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ExtractInfo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Level_txtbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Perks_lstbx = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Money_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Perk_txtbx = new System.Windows.Forms.TextBox();
            this.PerkAdd_btn = new System.Windows.Forms.Button();
            this.PerkRem_btn = new System.Windows.Forms.Button();
            this.Variables_lstbx = new System.Windows.Forms.ListBox();
            this.VarAdd_btn = new System.Windows.Forms.Button();
            this.VarRem_btn = new System.Windows.Forms.Button();
            this.Var_txtbx = new System.Windows.Forms.TextBox();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDefinitionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createResourceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 178);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 201);
            this.tabControl1.TabIndex = 4;
            // 
            // ExtractInfo
            // 
            this.ExtractInfo.Location = new System.Drawing.Point(365, 69);
            this.ExtractInfo.Name = "ExtractInfo";
            this.ExtractInfo.Size = new System.Drawing.Size(86, 103);
            this.ExtractInfo.TabIndex = 5;
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
            this.clearAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadCategoryToolStripMenuItem
            // 
            this.loadCategoryToolStripMenuItem.Name = "loadCategoryToolStripMenuItem";
            this.loadCategoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadCategoryToolStripMenuItem.Text = "Load File";
            this.loadCategoryToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
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
            this.Level_txtbx.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Money_txtbx);
            this.groupBox1.Controls.Add(this.Level_txtbx);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 72);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton3.Location = new System.Drawing.Point(6, 56);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Remove All";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton2.Location = new System.Drawing.Point(6, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Show Markers ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton1.Location = new System.Drawing.Point(6, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Complete Discover";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Perk_txtbx);
            this.groupBox2.Controls.Add(this.PerkRem_btn);
            this.groupBox2.Controls.Add(this.PerkAdd_btn);
            this.groupBox2.Controls.Add(this.Perks_lstbx);
            this.groupBox2.Location = new System.Drawing.Point(145, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 148);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perks";
            // 
            // Perks_lstbx
            // 
            this.Perks_lstbx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Perks_lstbx.FormattingEnabled = true;
            this.Perks_lstbx.Location = new System.Drawing.Point(3, 63);
            this.Perks_lstbx.Name = "Perks_lstbx";
            this.Perks_lstbx.Size = new System.Drawing.Size(96, 82);
            this.Perks_lstbx.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Preview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Money_txtbx
            // 
            this.Money_txtbx.Location = new System.Drawing.Point(69, 41);
            this.Money_txtbx.Name = "Money_txtbx";
            this.Money_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Money_txtbx.Size = new System.Drawing.Size(58, 20);
            this.Money_txtbx.TabIndex = 8;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Var_txtbx);
            this.groupBox3.Controls.Add(this.Variables_lstbx);
            this.groupBox3.Controls.Add(this.VarRem_btn);
            this.groupBox3.Controls.Add(this.VarAdd_btn);
            this.groupBox3.Location = new System.Drawing.Point(253, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 148);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Variables";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Location = new System.Drawing.Point(7, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 76);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Map";
            // 
            // Perk_txtbx
            // 
            this.Perk_txtbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Perk_txtbx.Location = new System.Drawing.Point(3, 16);
            this.Perk_txtbx.Name = "Perk_txtbx";
            this.Perk_txtbx.Size = new System.Drawing.Size(96, 20);
            this.Perk_txtbx.TabIndex = 1;
            // 
            // PerkAdd_btn
            // 
            this.PerkAdd_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PerkAdd_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PerkAdd_btn.Location = new System.Drawing.Point(6, 38);
            this.PerkAdd_btn.Name = "PerkAdd_btn";
            this.PerkAdd_btn.Size = new System.Drawing.Size(33, 22);
            this.PerkAdd_btn.TabIndex = 13;
            this.PerkAdd_btn.Text = "↓";
            this.PerkAdd_btn.UseVisualStyleBackColor = true;
            this.PerkAdd_btn.Click += new System.EventHandler(this.PerkAdd_btn_Click);
            // 
            // PerkRem_btn
            // 
            this.PerkRem_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PerkRem_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PerkRem_btn.Location = new System.Drawing.Point(65, 38);
            this.PerkRem_btn.Name = "PerkRem_btn";
            this.PerkRem_btn.Size = new System.Drawing.Size(33, 22);
            this.PerkRem_btn.TabIndex = 13;
            this.PerkRem_btn.Text = "↑";
            this.PerkRem_btn.UseVisualStyleBackColor = true;
            this.PerkRem_btn.Click += new System.EventHandler(this.PerkRem_btn_Click);
            // 
            // Variables_lstbx
            // 
            this.Variables_lstbx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Variables_lstbx.FormattingEnabled = true;
            this.Variables_lstbx.Location = new System.Drawing.Point(3, 63);
            this.Variables_lstbx.Name = "Variables_lstbx";
            this.Variables_lstbx.Size = new System.Drawing.Size(100, 82);
            this.Variables_lstbx.TabIndex = 14;
            // 
            // VarAdd_btn
            // 
            this.VarAdd_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarAdd_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.VarAdd_btn.Location = new System.Drawing.Point(3, 38);
            this.VarAdd_btn.Name = "VarAdd_btn";
            this.VarAdd_btn.Size = new System.Drawing.Size(33, 22);
            this.VarAdd_btn.TabIndex = 13;
            this.VarAdd_btn.Text = "↓";
            this.VarAdd_btn.UseVisualStyleBackColor = true;
            this.VarAdd_btn.Click += new System.EventHandler(this.VarAdd_btn_Click);
            // 
            // VarRem_btn
            // 
            this.VarRem_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarRem_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.VarRem_btn.Location = new System.Drawing.Point(67, 38);
            this.VarRem_btn.Name = "VarRem_btn";
            this.VarRem_btn.Size = new System.Drawing.Size(33, 22);
            this.VarRem_btn.TabIndex = 13;
            this.VarRem_btn.Text = "↑";
            this.VarRem_btn.UseVisualStyleBackColor = true;
            this.VarRem_btn.Click += new System.EventHandler(this.VarRem_btn_Click);
            // 
            // Var_txtbx
            // 
            this.Var_txtbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Var_txtbx.Location = new System.Drawing.Point(3, 16);
            this.Var_txtbx.Name = "Var_txtbx";
            this.Var_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Var_txtbx.TabIndex = 14;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDefinitionFileToolStripMenuItem,
            this.createResourceFileToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
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
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            // 
            // createDefinitionFileToolStripMenuItem
            // 
            this.createDefinitionFileToolStripMenuItem.Name = "createDefinitionFileToolStripMenuItem";
            this.createDefinitionFileToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createDefinitionFileToolStripMenuItem.Text = "Create Definition File";
            // 
            // createResourceFileToolStripMenuItem
            // 
            this.createResourceFileToolStripMenuItem.Name = "createResourceFileToolStripMenuItem";
            this.createResourceFileToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createResourceFileToolStripMenuItem.Text = "Create Resource File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 379);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExtractInfo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ultimate Batch File Maker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Perks_lstbx;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Money_txtbx;
        private System.Windows.Forms.TextBox Perk_txtbx;
        private System.Windows.Forms.Button PerkRem_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Var_txtbx;
        private System.Windows.Forms.ListBox Variables_lstbx;
        private System.Windows.Forms.Button VarRem_btn;
        private System.Windows.Forms.Button VarAdd_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDefinitionFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createResourceFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.Button PerkAdd_btn;
    }
}