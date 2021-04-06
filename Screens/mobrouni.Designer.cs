namespace Organiser.Screens
{
    partial class mobrouni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mobrouni));
            this.dgvUnitView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNewUnit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnitView
            // 
            this.dgvUnitView.AllowUserToAddRows = false;
            this.dgvUnitView.AllowUserToDeleteRows = false;
            this.dgvUnitView.AllowUserToResizeColumns = false;
            this.dgvUnitView.AllowUserToResizeRows = false;
            this.dgvUnitView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnitView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitView.Location = new System.Drawing.Point(15, 16);
            this.dgvUnitView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUnitView.MultiSelect = false;
            this.dgvUnitView.Name = "dgvUnitView";
            this.dgvUnitView.ReadOnly = true;
            this.dgvUnitView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUnitView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnitView.Size = new System.Drawing.Size(386, 540);
            this.dgvUnitView.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Organiser.Properties.Resources.update32;
            this.btnUpdate.Location = new System.Drawing.Point(423, 63);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Organiser.Properties.Resources.DeleteJob;
            this.btnDelete.Location = new System.Drawing.Point(423, 110);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Organiser.Properties.Resources.Check2;
            this.btnNext.Location = new System.Drawing.Point(423, 518);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 39);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNewUnit
            // 
            this.btnNewUnit.Image = global::Organiser.Properties.Resources.NewJob;
            this.btnNewUnit.Location = new System.Drawing.Point(423, 16);
            this.btnNewUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewUnit.Name = "btnNewUnit";
            this.btnNewUnit.Size = new System.Drawing.Size(87, 39);
            this.btnNewUnit.TabIndex = 5;
            this.btnNewUnit.Text = "New";
            this.btnNewUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewUnit.UseVisualStyleBackColor = true;
            this.btnNewUnit.Click += new System.EventHandler(this.btnNewUnit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Organiser.Properties.Resources.Close;
            this.btnExit.Location = new System.Drawing.Point(423, 157);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 39);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mobrouni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 571);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnNewUnit);
            this.Controls.Add(this.dgvUnitView);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mobrouni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View/Add Units";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnitView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNewUnit;
        private System.Windows.Forms.Button btnExit;
    }
}