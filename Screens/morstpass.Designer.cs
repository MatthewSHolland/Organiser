namespace Organiser.Screens
{
    partial class morstpass
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
            this.lblCurrent = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lblRePass = new System.Windows.Forms.Label();
            this.tbRePass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(12, 16);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(90, 13);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current Password";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(110, 13);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(165, 20);
            this.tbCurrent.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(24, 42);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "New Password";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(110, 42);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(165, 20);
            this.tbNewPass.TabIndex = 3;
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.Location = new System.Drawing.Point(12, 66);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.Size = new System.Drawing.Size(75, 26);
            this.lblRePass.TabIndex = 4;
            this.lblRePass.Text = "Re-enter \r\nnew password";
            // 
            // tbRePass
            // 
            this.tbRePass.Location = new System.Drawing.Point(110, 71);
            this.tbRePass.Name = "tbRePass";
            this.tbRePass.Size = new System.Drawing.Size(165, 20);
            this.tbRePass.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // morstpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 157);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbRePass);
            this.Controls.Add(this.lblRePass);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.lblCurrent);
            this.Name = "morstpass";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lblRePass;
        private System.Windows.Forms.TextBox tbRePass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}