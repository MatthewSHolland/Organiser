namespace Organiser
{
    partial class momaiscn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(momaiscn));
            this.msStrip = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.catagoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSec = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHANGEBOOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fALSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.msStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // msStrip
            // 
            this.msStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmEdit,
            this.tsmSec,
            this.cHANGEBOOLToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.msStrip.Location = new System.Drawing.Point(0, 0);
            this.msStrip.Name = "msStrip";
            this.msStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msStrip.Size = new System.Drawing.Size(842, 25);
            this.msStrip.TabIndex = 0;
            this.msStrip.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.tsmFile.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(40, 21);
            this.tsmFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catagoriesToolStripMenuItem,
            this.jobTypesToolStripMenuItem});
            this.tsmEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(42, 21);
            this.tsmEdit.Text = "Edit";
            // 
            // catagoriesToolStripMenuItem
            // 
            this.catagoriesToolStripMenuItem.Name = "catagoriesToolStripMenuItem";
            this.catagoriesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.catagoriesToolStripMenuItem.Text = "Catagories";
            this.catagoriesToolStripMenuItem.Click += new System.EventHandler(this.catagoriesToolStripMenuItem_Click);
            // 
            // jobTypesToolStripMenuItem
            // 
            this.jobTypesToolStripMenuItem.Name = "jobTypesToolStripMenuItem";
            this.jobTypesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.jobTypesToolStripMenuItem.Text = "Job Types";
            this.jobTypesToolStripMenuItem.Click += new System.EventHandler(this.jobTypesToolStripMenuItem_Click);
            // 
            // tsmSec
            // 
            this.tsmSec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.securityLevelsToolStripMenuItem});
            this.tsmSec.Enabled = false;
            this.tsmSec.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSec.Name = "tsmSec";
            this.tsmSec.Size = new System.Drawing.Size(68, 21);
            this.tsmSec.Text = "Security";
            this.tsmSec.Visible = false;
            this.tsmSec.Click += new System.EventHandler(this.sercurityToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // securityLevelsToolStripMenuItem
            // 
            this.securityLevelsToolStripMenuItem.Name = "securityLevelsToolStripMenuItem";
            this.securityLevelsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.securityLevelsToolStripMenuItem.Text = "Security Levels";
            this.securityLevelsToolStripMenuItem.Click += new System.EventHandler(this.securityLevelsToolStripMenuItem_Click);
            // 
            // cHANGEBOOLToolStripMenuItem
            // 
            this.cHANGEBOOLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRUEToolStripMenuItem,
            this.fALSEToolStripMenuItem});
            this.cHANGEBOOLToolStripMenuItem.Enabled = false;
            this.cHANGEBOOLToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHANGEBOOLToolStripMenuItem.Name = "cHANGEBOOLToolStripMenuItem";
            this.cHANGEBOOLToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.cHANGEBOOLToolStripMenuItem.Text = "CHANGEBOOL";
            this.cHANGEBOOLToolStripMenuItem.Visible = false;
            // 
            // tRUEToolStripMenuItem
            // 
            this.tRUEToolStripMenuItem.Name = "tRUEToolStripMenuItem";
            this.tRUEToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.tRUEToolStripMenuItem.Text = "TRUE";
            this.tRUEToolStripMenuItem.Click += new System.EventHandler(this.tRUEToolStripMenuItem_Click);
            // 
            // fALSEToolStripMenuItem
            // 
            this.fALSEToolStripMenuItem.Name = "fALSEToolStripMenuItem";
            this.fALSEToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.fALSEToolStripMenuItem.Text = "FALSE";
            this.fALSEToolStripMenuItem.Click += new System.EventHandler(this.fALSEToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // btnAddJob
            // 
            this.btnAddJob.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJob.Image = global::Organiser.Properties.Resources.NewJob;
            this.btnAddJob.Location = new System.Drawing.Point(15, 34);
            this.btnAddJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(68, 57);
            this.btnAddJob.TabIndex = 1;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Visible = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // momaiscn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 783);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.msStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "momaiscn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.momaiscn_FormClosing);
            this.msStrip.ResumeLayout(false);
            this.msStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem catagoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSec;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityLevelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHANGEBOOLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRUEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fALSEToolStripMenuItem;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    }
}

