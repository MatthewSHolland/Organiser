namespace Organiser.Screens
{
    partial class monewcat
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tbCateName = new System.Windows.Forms.TextBox();
            this.btnColour = new System.Windows.Forms.Button();
            this.tbColorPrev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 69);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 69);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(9, 9);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Category Name";
            // 
            // tbCateName
            // 
            this.tbCateName.Location = new System.Drawing.Point(95, 6);
            this.tbCateName.Name = "tbCateName";
            this.tbCateName.Size = new System.Drawing.Size(225, 20);
            this.tbCateName.TabIndex = 3;
            // 
            // btnColour
            // 
            this.btnColour.Location = new System.Drawing.Point(201, 31);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(29, 23);
            this.btnColour.TabIndex = 4;
            this.btnColour.Text = "...";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // tbColorPrev
            // 
            this.tbColorPrev.Location = new System.Drawing.Point(95, 32);
            this.tbColorPrev.Name = "tbColorPrev";
            this.tbColorPrev.Size = new System.Drawing.Size(100, 20);
            this.tbColorPrev.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Colour";
            // 
            // monewcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbColorPrev);
            this.Controls.Add(this.btnColour);
            this.Controls.Add(this.tbCateName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "monewcat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New/Update Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox tbCateName;
        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.TextBox tbColorPrev;
        private System.Windows.Forms.Label label1;
    }
}