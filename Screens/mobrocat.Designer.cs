namespace Organiser.Screens
{
    partial class mobrocat
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
            this.dgvCateView = new System.Windows.Forms.DataGridView();
            this.btnNewCate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCateView
            // 
            this.dgvCateView.AllowUserToAddRows = false;
            this.dgvCateView.AllowUserToDeleteRows = false;
            this.dgvCateView.AllowUserToResizeColumns = false;
            this.dgvCateView.AllowUserToResizeRows = false;
            this.dgvCateView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCateView.Location = new System.Drawing.Point(13, 13);
            this.dgvCateView.MultiSelect = false;
            this.dgvCateView.Name = "dgvCateView";
            this.dgvCateView.ReadOnly = true;
            this.dgvCateView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCateView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCateView.Size = new System.Drawing.Size(331, 439);
            this.dgvCateView.TabIndex = 0;
            this.dgvCateView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNewCate
            // 
            this.btnNewCate.Location = new System.Drawing.Point(361, 12);
            this.btnNewCate.Name = "btnNewCate";
            this.btnNewCate.Size = new System.Drawing.Size(75, 23);
            this.btnNewCate.TabIndex = 1;
            this.btnNewCate.Text = "New";
            this.btnNewCate.UseVisualStyleBackColor = true;
            this.btnNewCate.Click += new System.EventHandler(this.btnNewCate_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(361, 429);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(361, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(361, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mobrocat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 464);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnNewCate);
            this.Controls.Add(this.dgvCateView);
            this.Name = "mobrocat";
            this.Text = "View/Add Categories";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCateView;
        private System.Windows.Forms.Button btnNewCate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}