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
            this.cHANGEBOOLToolStripMenuItem});
            this.msStrip.Location = new System.Drawing.Point(0, 0);
            this.msStrip.Name = "msStrip";
            this.msStrip.Size = new System.Drawing.Size(800, 24);
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
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catagoriesToolStripMenuItem,
            this.jobTypesToolStripMenuItem});
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(39, 20);
            this.tsmEdit.Text = "Edit";
            // 
            // catagoriesToolStripMenuItem
            // 
            this.catagoriesToolStripMenuItem.Name = "catagoriesToolStripMenuItem";
            this.catagoriesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.catagoriesToolStripMenuItem.Text = "Catagories";
            this.catagoriesToolStripMenuItem.Click += new System.EventHandler(this.catagoriesToolStripMenuItem_Click);
            // 
            // jobTypesToolStripMenuItem
            // 
            this.jobTypesToolStripMenuItem.Name = "jobTypesToolStripMenuItem";
            this.jobTypesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.jobTypesToolStripMenuItem.Text = "Job Types";
            this.jobTypesToolStripMenuItem.Click += new System.EventHandler(this.jobTypesToolStripMenuItem_Click);
            // 
            // tsmSec
            // 
            this.tsmSec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.securityLevelsToolStripMenuItem});
            this.tsmSec.Name = "tsmSec";
            this.tsmSec.Size = new System.Drawing.Size(61, 20);
            this.tsmSec.Text = "Security";
            this.tsmSec.Click += new System.EventHandler(this.sercurityToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // securityLevelsToolStripMenuItem
            // 
            this.securityLevelsToolStripMenuItem.Name = "securityLevelsToolStripMenuItem";
            this.securityLevelsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.securityLevelsToolStripMenuItem.Text = "Security Levels";
            this.securityLevelsToolStripMenuItem.Click += new System.EventHandler(this.securityLevelsToolStripMenuItem_Click);
            // 
            // cHANGEBOOLToolStripMenuItem
            // 
            this.cHANGEBOOLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRUEToolStripMenuItem,
            this.fALSEToolStripMenuItem});
            this.cHANGEBOOLToolStripMenuItem.Name = "cHANGEBOOLToolStripMenuItem";
            this.cHANGEBOOLToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.cHANGEBOOLToolStripMenuItem.Text = "CHANGEBOOL";
            // 
            // tRUEToolStripMenuItem
            // 
            this.tRUEToolStripMenuItem.Name = "tRUEToolStripMenuItem";
            this.tRUEToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.tRUEToolStripMenuItem.Text = "TRUE";
            this.tRUEToolStripMenuItem.Click += new System.EventHandler(this.tRUEToolStripMenuItem_Click);
            // 
            // fALSEToolStripMenuItem
            // 
            this.fALSEToolStripMenuItem.Name = "fALSEToolStripMenuItem";
            this.fALSEToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.fALSEToolStripMenuItem.Text = "FALSE";
            this.fALSEToolStripMenuItem.Click += new System.EventHandler(this.fALSEToolStripMenuItem_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(13, 28);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(75, 23);
            this.btnAddJob.TabIndex = 1;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Visible = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // momaiscn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.msStrip);
            this.MainMenuStrip = this.msStrip;
            this.Name = "momaiscn";
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
    }
}

