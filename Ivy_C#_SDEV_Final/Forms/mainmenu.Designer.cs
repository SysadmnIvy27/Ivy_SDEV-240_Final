namespace Ivy_C__SDEV_Final.Forms
{
    partial class mainmenu
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserDNU = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblChipsDNU = new System.Windows.Forms.Label();
            this.lblChips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1177, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(1010, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Guest";
            // 
            // lblUserDNU
            // 
            this.lblUserDNU.AutoSize = true;
            this.lblUserDNU.Location = new System.Drawing.Point(981, 17);
            this.lblUserDNU.Name = "lblUserDNU";
            this.lblUserDNU.Size = new System.Drawing.Size(32, 13);
            this.lblUserDNU.TabIndex = 2;
            this.lblUserDNU.Text = "User:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1177, 646);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblChipsDNU
            // 
            this.lblChipsDNU.AutoSize = true;
            this.lblChipsDNU.Location = new System.Drawing.Point(1081, 17);
            this.lblChipsDNU.Name = "lblChipsDNU";
            this.lblChipsDNU.Size = new System.Drawing.Size(36, 13);
            this.lblChipsDNU.TabIndex = 4;
            this.lblChipsDNU.Text = "Chips:";
            // 
            // lblChips
            // 
            this.lblChips.AutoSize = true;
            this.lblChips.Location = new System.Drawing.Point(1114, 17);
            this.lblChips.Name = "lblChips";
            this.lblChips.Size = new System.Drawing.Size(13, 13);
            this.lblChips.TabIndex = 5;
            this.lblChips.Text = "0";
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblChips);
            this.Controls.Add(this.lblChipsDNU);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUserDNU);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Name = "mainmenu";
            this.Text = "mainmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserDNU;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblChipsDNU;
        private System.Windows.Forms.Label lblChips;
    }
}