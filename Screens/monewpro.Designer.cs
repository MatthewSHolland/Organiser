namespace Organiser.Screens
{
    partial class monewpro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monewpro));
            this.lblProjectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.tbProjectDir = new System.Windows.Forms.TextBox();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(15, 23);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(81, 16);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Directory";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(131, 23);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(284, 21);
            this.tbProjectName.TabIndex = 2;
            // 
            // tbProjectDir
            // 
            this.tbProjectDir.Enabled = false;
            this.tbProjectDir.Location = new System.Drawing.Point(131, 55);
            this.tbProjectDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProjectDir.Name = "tbProjectDir";
            this.tbProjectDir.Size = new System.Drawing.Size(230, 21);
            this.tbProjectDir.TabIndex = 3;
            // 
            // btnSelDir
            // 
            this.btnSelDir.AutoSize = true;
            this.btnSelDir.Image = global::Organiser.Properties.Resources.ellipsis;
            this.btnSelDir.Location = new System.Drawing.Point(370, 52);
            this.btnSelDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(45, 28);
            this.btnSelDir.TabIndex = 4;
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Organiser.Properties.Resources.Check2;
            this.btnNext.Location = new System.Drawing.Point(328, 104);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 39);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Organiser.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(18, 104);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // monewpro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 156);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSelDir);
            this.Controls.Add(this.tbProjectDir);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProjectName);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "monewpro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbProjectDir;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
    }
}