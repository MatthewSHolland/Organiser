namespace Organiser.Screens
{
    partial class monewuni
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
            this.lblTypeName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(13, 13);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(82, 13);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "Job Type Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(101, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(219, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(11, 48);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(84, 13);
            this.lblCate.TabIndex = 2;
            this.lblCate.Text = "Linked Category";
            // 
            // cbCate
            // 
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(101, 48);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(219, 21);
            this.cbCate.TabIndex = 3;
            this.cbCate.SelectedIndexChanged += new System.EventHandler(this.cbCate_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(16, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(245, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Ok";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // monewuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 127);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbCate);
            this.Controls.Add(this.lblCate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblTypeName);
            this.Name = "monewuni";
            this.Text = "New/Update Job Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}