namespace Ivy_C__SDEV_Final.Forms
{
    partial class BlackJackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
            this.lblDealerStand = new System.Windows.Forms.Label();
            this.lblChips = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnInsurance = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDealerStand
            // 
            this.lblDealerStand.AutoSize = true;
            this.lblDealerStand.BackColor = System.Drawing.Color.Green;
            this.lblDealerStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerStand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDealerStand.Location = new System.Drawing.Point(438, 232);
            this.lblDealerStand.MinimumSize = new System.Drawing.Size(364, 38);
            this.lblDealerStand.Name = "lblDealerStand";
            this.lblDealerStand.Size = new System.Drawing.Size(364, 38);
            this.lblDealerStand.TabIndex = 0;
            this.lblDealerStand.Text = "Dealer stands on soft 17";
            // 
            // lblChips
            // 
            this.lblChips.AutoSize = true;
            this.lblChips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChips.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChips.Location = new System.Drawing.Point(1186, 9);
            this.lblChips.Name = "lblChips";
            this.lblChips.Size = new System.Drawing.Size(66, 20);
            this.lblChips.TabIndex = 1;
            this.lblChips.Text = "Chips: 0";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(567, 83);
            this.lblDealer.MinimumSize = new System.Drawing.Size(0, 52);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(146, 52);
            this.lblDealer.TabIndex = 2;
            this.lblDealer.Text = "?, A♠";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(543, 398);
            this.lblPlayer.MinimumSize = new System.Drawing.Size(0, 52);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 52);
            this.lblPlayer.TabIndex = 3;
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(480, 545);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(76, 23);
            this.btnHit.TabIndex = 4;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(562, 545);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(76, 23);
            this.btnStand.TabIndex = 5;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            // 
            // btnInsurance
            // 
            this.btnInsurance.Location = new System.Drawing.Point(602, 595);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Size = new System.Drawing.Size(76, 23);
            this.btnInsurance.TabIndex = 6;
            this.btnInsurance.Text = "Insurance";
            this.btnInsurance.UseVisualStyleBackColor = true;
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(644, 545);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(76, 23);
            this.btnDouble.TabIndex = 7;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(726, 545);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(76, 23);
            this.btnSplit.TabIndex = 8;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 75);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInsurance);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblChips);
            this.Controls.Add(this.lblDealerStand);
            this.Name = "BlackJackForm";
            this.Text = "BlackJackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDealerStand;
        private System.Windows.Forms.Label lblChips;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnBack;
    }
}