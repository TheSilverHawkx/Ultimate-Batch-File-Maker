namespace UltimateBatchFileMaker
{
    partial class CreateResFormBasic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateResFormBasic));
            this.label1 = new System.Windows.Forms.Label();
            this.Category_txtbx = new System.Windows.Forms.TextBox();
            this.Name_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Resource_add_btn = new System.Windows.Forms.Button();
            this.Resource_remove_btn = new System.Windows.Forms.Button();
            this.Code_txtbx = new System.Windows.Forms.TextBox();
            this.Create_btn = new System.Windows.Forms.Button();
            this.Resource_lstv = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.Game_txtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game name:";
            // 
            // Category_txtbx
            // 
            this.Category_txtbx.Location = new System.Drawing.Point(131, 36);
            this.Category_txtbx.Name = "Category_txtbx";
            this.Category_txtbx.Size = new System.Drawing.Size(80, 20);
            this.Category_txtbx.TabIndex = 1;
            // 
            // Name_txtbx
            // 
            this.Name_txtbx.Location = new System.Drawing.Point(12, 89);
            this.Name_txtbx.Name = "Name_txtbx";
            this.Name_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Name_txtbx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "code";
            // 
            // Resource_add_btn
            // 
            this.Resource_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("Resource_add_btn.Image")));
            this.Resource_add_btn.Location = new System.Drawing.Point(41, 115);
            this.Resource_add_btn.Name = "Resource_add_btn";
            this.Resource_add_btn.Size = new System.Drawing.Size(32, 23);
            this.Resource_add_btn.TabIndex = 6;
            this.Resource_add_btn.Text = "↓";
            this.Resource_add_btn.UseVisualStyleBackColor = true;
            this.Resource_add_btn.Click += new System.EventHandler(this.Resource_add_btn_Click);
            // 
            // Resource_remove_btn
            // 
            this.Resource_remove_btn.Image = ((System.Drawing.Image)(resources.GetObject("Resource_remove_btn.Image")));
            this.Resource_remove_btn.Location = new System.Drawing.Point(150, 115);
            this.Resource_remove_btn.Name = "Resource_remove_btn";
            this.Resource_remove_btn.Size = new System.Drawing.Size(32, 23);
            this.Resource_remove_btn.TabIndex = 7;
            this.Resource_remove_btn.Text = "↑";
            this.Resource_remove_btn.UseVisualStyleBackColor = true;
            this.Resource_remove_btn.Click += new System.EventHandler(this.Resource_remove_btn_Click);
            // 
            // Code_txtbx
            // 
            this.Code_txtbx.Location = new System.Drawing.Point(118, 89);
            this.Code_txtbx.Name = "Code_txtbx";
            this.Code_txtbx.Size = new System.Drawing.Size(93, 20);
            this.Code_txtbx.TabIndex = 2;
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(12, 255);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(199, 23);
            this.Create_btn.TabIndex = 8;
            this.Create_btn.Text = "Create Resource File";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Resource_lstv
            // 
            this.Resource_lstv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.Resource_lstv.FullRowSelect = true;
            this.Resource_lstv.GridLines = true;
            this.Resource_lstv.Location = new System.Drawing.Point(12, 144);
            this.Resource_lstv.Name = "Resource_lstv";
            this.Resource_lstv.Size = new System.Drawing.Size(199, 105);
            this.Resource_lstv.TabIndex = 9;
            this.Resource_lstv.UseCompatibleStateImageBehavior = false;
            this.Resource_lstv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Code";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Resource name:";
            // 
            // Game_txtbx
            // 
            this.Game_txtbx.Location = new System.Drawing.Point(131, 12);
            this.Game_txtbx.Name = "Game_txtbx";
            this.Game_txtbx.Size = new System.Drawing.Size(80, 20);
            this.Game_txtbx.TabIndex = 1;
            // 
            // CreateResFormBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 284);
            this.Controls.Add(this.Resource_lstv);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.Resource_remove_btn);
            this.Controls.Add(this.Resource_add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Code_txtbx);
            this.Controls.Add(this.Name_txtbx);
            this.Controls.Add(this.Game_txtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Category_txtbx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateResFormBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Resource File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Category_txtbx;
        private System.Windows.Forms.TextBox Name_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Resource_add_btn;
        private System.Windows.Forms.Button Resource_remove_btn;
        private System.Windows.Forms.TextBox Code_txtbx;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.ListView Resource_lstv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Game_txtbx;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}