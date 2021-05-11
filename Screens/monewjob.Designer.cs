namespace Organiser.Screens
{
    partial class monewjob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monewjob));
            this.lblJobId = new System.Windows.Forms.Label();
            this.tbJobID = new System.Windows.Forms.TextBox();
            this.lblJobName = new System.Windows.Forms.Label();
            this.tbJobName = new System.Windows.Forms.TextBox();
            this.lblJobDesc = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblJobType = new System.Windows.Forms.Label();
            this.cbJobType = new System.Windows.Forms.ComboBox();
            this.lblAttach = new System.Windows.Forms.Label();
            this.tbAttach = new System.Windows.Forms.TextBox();
            this.tbOkay = new System.Windows.Forms.Button();
            this.tbCancel = new System.Windows.Forms.Button();
            this.tbBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Location = new System.Drawing.Point(35, 16);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(42, 16);
            this.lblJobId.TabIndex = 0;
            this.lblJobId.Text = "Job ID";
            // 
            // tbJobID
            // 
            this.tbJobID.Location = new System.Drawing.Point(86, 12);
            this.tbJobID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbJobID.Name = "tbJobID";
            this.tbJobID.Size = new System.Drawing.Size(209, 21);
            this.tbJobID.TabIndex = 1;
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(15, 59);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(64, 16);
            this.lblJobName.TabIndex = 2;
            this.lblJobName.Text = "Job Name";
            // 
            // tbJobName
            // 
            this.tbJobName.Location = new System.Drawing.Point(86, 57);
            this.tbJobName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbJobName.Name = "tbJobName";
            this.tbJobName.Size = new System.Drawing.Size(209, 21);
            this.tbJobName.TabIndex = 3;
            // 
            // lblJobDesc
            // 
            this.lblJobDesc.AutoSize = true;
            this.lblJobDesc.Location = new System.Drawing.Point(15, 103);
            this.lblJobDesc.Name = "lblJobDesc";
            this.lblJobDesc.Size = new System.Drawing.Size(90, 16);
            this.lblJobDesc.TabIndex = 4;
            this.lblJobDesc.Text = "Job Description";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(15, 124);
            this.rtbDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(280, 189);
            this.rtbDesc.TabIndex = 5;
            this.rtbDesc.Text = "";
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(320, 15);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(59, 16);
            this.lblCate.TabIndex = 6;
            this.lblCate.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(386, 11);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(142, 24);
            this.cbCategory.TabIndex = 7;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Location = new System.Drawing.Point(317, 52);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(57, 16);
            this.lblJobType.TabIndex = 8;
            this.lblJobType.Text = "Job Type";
            // 
            // cbJobType
            // 
            this.cbJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobType.FormattingEnabled = true;
            this.cbJobType.Location = new System.Drawing.Point(386, 48);
            this.cbJobType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbJobType.Name = "cbJobType";
            this.cbJobType.Size = new System.Drawing.Size(142, 24);
            this.cbJobType.TabIndex = 9;
            // 
            // lblAttach
            // 
            this.lblAttach.AutoSize = true;
            this.lblAttach.Location = new System.Drawing.Point(306, 207);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(108, 16);
            this.lblAttach.TabIndex = 16;
            this.lblAttach.Text = "Attachment Folder";
            // 
            // tbAttach
            // 
            this.tbAttach.Location = new System.Drawing.Point(309, 228);
            this.tbAttach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAttach.Name = "tbAttach";
            this.tbAttach.Size = new System.Drawing.Size(181, 21);
            this.tbAttach.TabIndex = 17;
            // 
            // tbOkay
            // 
            this.tbOkay.Image = global::Organiser.Properties.Resources.Check2;
            this.tbOkay.Location = new System.Drawing.Point(441, 275);
            this.tbOkay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOkay.Name = "tbOkay";
            this.tbOkay.Size = new System.Drawing.Size(87, 39);
            this.tbOkay.TabIndex = 19;
            this.tbOkay.Text = "Ok";
            this.tbOkay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbOkay.UseVisualStyleBackColor = true;
            this.tbOkay.Click += new System.EventHandler(this.tbOkay_Click);
            // 
            // tbCancel
            // 
            this.tbCancel.Image = global::Organiser.Properties.Resources.Close;
            this.tbCancel.Location = new System.Drawing.Point(309, 275);
            this.tbCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCancel.Name = "tbCancel";
            this.tbCancel.Size = new System.Drawing.Size(87, 39);
            this.tbCancel.TabIndex = 20;
            this.tbCancel.Text = "Cancel";
            this.tbCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbCancel.UseVisualStyleBackColor = true;
            this.tbCancel.Click += new System.EventHandler(this.tbCancel_Click);
            // 
            // tbBrowse
            // 
            this.tbBrowse.Image = global::Organiser.Properties.Resources.ellipsis;
            this.tbBrowse.Location = new System.Drawing.Point(498, 225);
            this.tbBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBrowse.Name = "tbBrowse";
            this.tbBrowse.Size = new System.Drawing.Size(30, 28);
            this.tbBrowse.TabIndex = 18;
            this.tbBrowse.UseVisualStyleBackColor = true;
            // 
            // monewjob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 329);
            this.Controls.Add(this.tbCancel);
            this.Controls.Add(this.tbOkay);
            this.Controls.Add(this.tbBrowse);
            this.Controls.Add(this.tbAttach);
            this.Controls.Add(this.lblAttach);
            this.Controls.Add(this.cbJobType);
            this.Controls.Add(this.lblJobType);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCate);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.lblJobDesc);
            this.Controls.Add(this.tbJobName);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.tbJobID);
            this.Controls.Add(this.lblJobId);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "monewjob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New/Update Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.TextBox tbJobID;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.TextBox tbJobName;
        private System.Windows.Forms.Label lblJobDesc;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.ComboBox cbJobType;
        private System.Windows.Forms.Label lblAttach;
        private System.Windows.Forms.TextBox tbAttach;
        private System.Windows.Forms.Button tbBrowse;
        private System.Windows.Forms.Button tbOkay;
        private System.Windows.Forms.Button tbCancel;
    }
}