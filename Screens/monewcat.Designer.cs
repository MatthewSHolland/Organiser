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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monewcat));
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tbCateName = new System.Windows.Forms.TextBox();
            this.tbColorPrev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColour = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(10, 11);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(95, 16);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Category Name";
            // 
            // tbCateName
            // 
            this.tbCateName.Location = new System.Drawing.Point(111, 7);
            this.tbCateName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCateName.Name = "tbCateName";
            this.tbCateName.Size = new System.Drawing.Size(262, 21);
            this.tbCateName.TabIndex = 3;
            // 
            // tbColorPrev
            // 
            this.tbColorPrev.Location = new System.Drawing.Point(111, 39);
            this.tbColorPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbColorPrev.Name = "tbColorPrev";
            this.tbColorPrev.Size = new System.Drawing.Size(116, 21);
            this.tbColorPrev.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Colour";
            // 
            // btnColour
            // 
            this.btnColour.Image = global::Organiser.Properties.Resources.ColourPalette16;
            this.btnColour.Location = new System.Drawing.Point(233, 36);
            this.btnColour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(34, 28);
            this.btnColour.TabIndex = 4;
            this.btnColour.Text = "...";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::Organiser.Properties.Resources.Check2;
            this.btnOk.Location = new System.Drawing.Point(286, 75);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 39);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Organiser.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(13, 75);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 39);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // monewcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbColorPrev);
            this.Controls.Add(this.btnColour);
            this.Controls.Add(this.tbCateName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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