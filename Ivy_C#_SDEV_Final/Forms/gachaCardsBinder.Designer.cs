namespace Ivy_C__SDEV_Final.Forms
{
    partial class gachaCardsBinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gachaCardsBinder));
            this.cardDisplayPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackToGacha = new System.Windows.Forms.Button();
            this.lblBackToGacha = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cardDisplayPanel
            // 
            this.cardDisplayPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardDisplayPanel.AutoScroll = true;
            this.cardDisplayPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.cardDisplayPanel.ColumnCount = 2;
            this.cardDisplayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cardDisplayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cardDisplayPanel.Location = new System.Drawing.Point(31, 117);
            this.cardDisplayPanel.Name = "cardDisplayPanel";
            this.cardDisplayPanel.RowCount = 2;
            this.cardDisplayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cardDisplayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cardDisplayPanel.Size = new System.Drawing.Size(1200, 550);
            this.cardDisplayPanel.TabIndex = 0;
            // 
            // btnBackToGacha
            // 
            this.btnBackToGacha.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToGacha.FlatAppearance.BorderSize = 0;
            this.btnBackToGacha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToGacha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackToGacha.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToGacha.Image")));
            this.btnBackToGacha.Location = new System.Drawing.Point(31, 8);
            this.btnBackToGacha.Name = "btnBackToGacha";
            this.btnBackToGacha.Size = new System.Drawing.Size(89, 81);
            this.btnBackToGacha.TabIndex = 15;
            this.btnBackToGacha.UseVisualStyleBackColor = false;
            this.btnBackToGacha.Click += new System.EventHandler(this.btnBackToGacha_Click);
            // 
            // lblBackToGacha
            // 
            this.lblBackToGacha.AutoSize = true;
            this.lblBackToGacha.Location = new System.Drawing.Point(38, 92);
            this.lblBackToGacha.Name = "lblBackToGacha";
            this.lblBackToGacha.Size = new System.Drawing.Size(69, 13);
            this.lblBackToGacha.TabIndex = 16;
            this.lblBackToGacha.Text = "MAIN MENU";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(1028, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 13);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "Username: Mr. Bruh";
            // 
            // lblUserMoney
            // 
            this.lblUserMoney.AutoSize = true;
            this.lblUserMoney.Location = new System.Drawing.Point(1144, 23);
            this.lblUserMoney.Name = "lblUserMoney";
            this.lblUserMoney.Size = new System.Drawing.Size(80, 13);
            this.lblUserMoney.TabIndex = 18;
            this.lblUserMoney.Text = "Chips: $ Money";
            // 
            // gachaCardsBinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblUserMoney);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblBackToGacha);
            this.Controls.Add(this.btnBackToGacha);
            this.Controls.Add(this.cardDisplayPanel);
            this.DoubleBuffered = true;
            this.Name = "gachaCardsBinder";
            this.Text = "gachaCardsBinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel cardDisplayPanel;
        private System.Windows.Forms.Button btnBackToGacha;
        private System.Windows.Forms.Label lblBackToGacha;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserMoney;
    }
}