namespace FalloutBatchMaker
{
    partial class AssociationPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.categories_cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_txtbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Could not regocnize resource category.\r\nPlease specify association category:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categories_cmbx
            // 
            this.categories_cmbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categories_cmbx.FormattingEnabled = true;
            this.categories_cmbx.Items.AddRange(new object[] {
            "Item",
            "NPC"});
            this.categories_cmbx.Location = new System.Drawing.Point(32, 38);
            this.categories_cmbx.Name = "categories_cmbx";
            this.categories_cmbx.Size = new System.Drawing.Size(154, 21);
            this.categories_cmbx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "or enter commnad:";
            // 
            // cmd_txtbx
            // 
            this.cmd_txtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_txtbx.Location = new System.Drawing.Point(32, 78);
            this.cmd_txtbx.Name = "cmd_txtbx";
            this.cmd_txtbx.Size = new System.Drawing.Size(154, 20);
            this.cmd_txtbx.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssociationPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd_txtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categories_cmbx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssociationPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Association";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categories_cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmd_txtbx;
        private System.Windows.Forms.Button button1;
    }
}