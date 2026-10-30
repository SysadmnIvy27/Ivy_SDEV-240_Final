namespace Ivy_C__SDEV_Final.Forms
{
    partial class frmMainMenu
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
            this.tctrlMenu = new System.Windows.Forms.TabControl();
            this.tpgGames = new System.Windows.Forms.TabPage();
            this.tpgMilestones = new System.Windows.Forms.TabPage();
            this.tpgUserInfo = new System.Windows.Forms.TabPage();
            this.btnBlackjack = new System.Windows.Forms.Button();
            this.btnGachaCards = new System.Windows.Forms.Button();
            this.btnRoulette = new System.Windows.Forms.Button();
            this.btnSlots = new System.Windows.Forms.Button();
            this.btnTexasHoldEm = new System.Windows.Forms.Button();
            this.tctrlMenu.SuspendLayout();
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
            this.lblUsername.Location = new System.Drawing.Point(52, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Guest";
            // 
            // lblUserDNU
            // 
            this.lblUserDNU.AutoSize = true;
            this.lblUserDNU.Location = new System.Drawing.Point(23, 17);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChipsDNU
            // 
            this.lblChipsDNU.AutoSize = true;
            this.lblChipsDNU.Location = new System.Drawing.Point(296, 17);
            this.lblChipsDNU.Name = "lblChipsDNU";
            this.lblChipsDNU.Size = new System.Drawing.Size(36, 13);
            this.lblChipsDNU.TabIndex = 4;
            this.lblChipsDNU.Text = "Chips:";
            // 
            // lblChips
            // 
            this.lblChips.AutoSize = true;
            this.lblChips.Location = new System.Drawing.Point(329, 17);
            this.lblChips.Name = "lblChips";
            this.lblChips.Size = new System.Drawing.Size(13, 13);
            this.lblChips.TabIndex = 5;
            this.lblChips.Text = "0";
            // 
            // tctrlMenu
            // 
            this.tctrlMenu.Controls.Add(this.tpgGames);
            this.tctrlMenu.Controls.Add(this.tpgMilestones);
            this.tctrlMenu.Controls.Add(this.tpgUserInfo);
            this.tctrlMenu.Location = new System.Drawing.Point(13, 52);
            this.tctrlMenu.Name = "tctrlMenu";
            this.tctrlMenu.SelectedIndex = 0;
            this.tctrlMenu.Size = new System.Drawing.Size(563, 603);
            this.tctrlMenu.TabIndex = 6;
            // 
            // tpgGames
            // 
            this.tpgGames.Location = new System.Drawing.Point(4, 22);
            this.tpgGames.Name = "tpgGames";
            this.tpgGames.Padding = new System.Windows.Forms.Padding(3);
            this.tpgGames.Size = new System.Drawing.Size(555, 577);
            this.tpgGames.TabIndex = 0;
            this.tpgGames.Text = "Games";
            this.tpgGames.UseVisualStyleBackColor = true;
            // 
            // tpgMilestones
            // 
            this.tpgMilestones.Location = new System.Drawing.Point(4, 22);
            this.tpgMilestones.Name = "tpgMilestones";
            this.tpgMilestones.Padding = new System.Windows.Forms.Padding(3);
            this.tpgMilestones.Size = new System.Drawing.Size(555, 577);
            this.tpgMilestones.TabIndex = 1;
            this.tpgMilestones.Text = "Milestones";
            this.tpgMilestones.UseVisualStyleBackColor = true;
            // 
            // tpgUserInfo
            // 
            this.tpgUserInfo.Location = new System.Drawing.Point(4, 22);
            this.tpgUserInfo.Name = "tpgUserInfo";
            this.tpgUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpgUserInfo.Size = new System.Drawing.Size(555, 577);
            this.tpgUserInfo.TabIndex = 2;
            this.tpgUserInfo.Text = "User Info";
            this.tpgUserInfo.UseVisualStyleBackColor = true;
            // 
            // btnBlackjack
            // 
            this.btnBlackjack.Location = new System.Drawing.Point(679, 74);
            this.btnBlackjack.Name = "btnBlackjack";
            this.btnBlackjack.Size = new System.Drawing.Size(90, 23);
            this.btnBlackjack.TabIndex = 7;
            this.btnBlackjack.Text = "Blackjack";
            this.btnBlackjack.UseVisualStyleBackColor = true;
            this.btnBlackjack.Click += new System.EventHandler(this.btnBlackjack_Click);
            // 
            // btnGachaCards
            // 
            this.btnGachaCards.Location = new System.Drawing.Point(679, 103);
            this.btnGachaCards.Name = "btnGachaCards";
            this.btnGachaCards.Size = new System.Drawing.Size(90, 23);
            this.btnGachaCards.TabIndex = 8;
            this.btnGachaCards.Text = "Gacha Cards";
            this.btnGachaCards.UseVisualStyleBackColor = true;
            this.btnGachaCards.Click += new System.EventHandler(this.btnGachaCards_Click);
            // 
            // btnRoulette
            // 
            this.btnRoulette.Location = new System.Drawing.Point(679, 132);
            this.btnRoulette.Name = "btnRoulette";
            this.btnRoulette.Size = new System.Drawing.Size(90, 23);
            this.btnRoulette.TabIndex = 9;
            this.btnRoulette.Text = "Roulette";
            this.btnRoulette.UseVisualStyleBackColor = true;
            this.btnRoulette.Click += new System.EventHandler(this.btnRoulette_Click);
            // 
            // btnSlots
            // 
            this.btnSlots.Location = new System.Drawing.Point(679, 161);
            this.btnSlots.Name = "btnSlots";
            this.btnSlots.Size = new System.Drawing.Size(90, 23);
            this.btnSlots.TabIndex = 10;
            this.btnSlots.Text = "Slots";
            this.btnSlots.UseVisualStyleBackColor = true;
            this.btnSlots.Click += new System.EventHandler(this.btnSlots_Click);
            // 
            // btnTexasHoldEm
            // 
            this.btnTexasHoldEm.Location = new System.Drawing.Point(679, 190);
            this.btnTexasHoldEm.Name = "btnTexasHoldEm";
            this.btnTexasHoldEm.Size = new System.Drawing.Size(90, 23);
            this.btnTexasHoldEm.TabIndex = 11;
            this.btnTexasHoldEm.Text = "Texas Hold Em\'";
            this.btnTexasHoldEm.UseVisualStyleBackColor = true;
            this.btnTexasHoldEm.Click += new System.EventHandler(this.btnTexasHoldEm_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnTexasHoldEm);
            this.Controls.Add(this.btnSlots);
            this.Controls.Add(this.btnRoulette);
            this.Controls.Add(this.btnGachaCards);
            this.Controls.Add(this.btnBlackjack);
            this.Controls.Add(this.tctrlMenu);
            this.Controls.Add(this.lblChips);
            this.Controls.Add(this.lblChipsDNU);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUserDNU);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmMainMenu";
            this.Text = "mainmenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.tctrlMenu.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tctrlMenu;
        private System.Windows.Forms.TabPage tpgGames;
        private System.Windows.Forms.TabPage tpgMilestones;
        private System.Windows.Forms.TabPage tpgUserInfo;
        private System.Windows.Forms.Button btnBlackjack;
        private System.Windows.Forms.Button btnGachaCards;
        private System.Windows.Forms.Button btnRoulette;
        private System.Windows.Forms.Button btnSlots;
        private System.Windows.Forms.Button btnTexasHoldEm;
    }
}