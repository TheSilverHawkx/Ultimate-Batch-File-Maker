namespace UltimateBatchFileMaker
{
    partial class CreateDefPopup
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
            this.label2 = new System.Windows.Forms.Label();
            this.Game_txtbx = new System.Windows.Forms.TextBox();
            this.def_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.def_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Game Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fill commands definitions";
            // 
            // Game_txtbx
            // 
            this.Game_txtbx.Location = new System.Drawing.Point(142, 8);
            this.Game_txtbx.Name = "Game_txtbx";
            this.Game_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Game_txtbx.TabIndex = 2;
            // 
            // def_dgv
            // 
            this.def_dgv.AllowUserToAddRows = false;
            this.def_dgv.AllowUserToDeleteRows = false;
            this.def_dgv.AllowUserToOrderColumns = true;
            this.def_dgv.AllowUserToResizeRows = false;
            this.def_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.def_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.def_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.def_dgv.Location = new System.Drawing.Point(16, 53);
            this.def_dgv.MultiSelect = false;
            this.def_dgv.Name = "def_dgv";
            this.def_dgv.Size = new System.Drawing.Size(226, 162);
            this.def_dgv.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Definition File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateDefPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.def_dgv);
            this.Controls.Add(this.Game_txtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateDefPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Definition File";
            ((System.ComponentModel.ISupportInitialize)(this.def_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Game_txtbx;
        private System.Windows.Forms.DataGridView def_dgv;
        private System.Windows.Forms.Button button1;
    }
}