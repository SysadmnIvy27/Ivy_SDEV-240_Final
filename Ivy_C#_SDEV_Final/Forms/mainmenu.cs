using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivy_C__SDEV_Final.Forms
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit application?",MessageBoxButtons.YesNo);
            try
            {
                if(dialogResult == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
            }
            catch
            {

            }
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            formLogin LoginForm = new formLogin(this);
            btnLogin.Enabled = false;
            LoginForm.Show();
        }

        private void btnBlackjack_Click(object sender, EventArgs e)
        {
            BlackJackForm Blackjack = new BlackJackForm(/*this*/);
            //this.Hide();
            Blackjack.Show();
        }

        private void btnGachaCards_Click(object sender, EventArgs e)
        {
            gachaCards Gacha = new gachaCards(/*this*/);
            //this.Hide();
            Gacha.Show();
        }

        private void btnRoulette_Click(object sender, EventArgs e)
        {
            roulette Roulette = new roulette(/*this*/);
            //this.Hide();
            Roulette.Show();
        }

        private void btnSlots_Click(object sender, EventArgs e)
        {
            Slots Slots = new Slots(/*this*/);
            //this.Hide();
            Slots.Show();
        }

        private void btnTexasHoldEm_Click(object sender, EventArgs e)
        {
            texas_Holdem Texas = new texas_Holdem(/*this*/);
            //this.Hide();
            Texas.Show();
        }

        private void frmMainMenu_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Login()
        {
            btnLogin.Enabled = true;
            RefreshValues();
        }

        public void RefreshValues()
        {
            lblChips.Text = Convert.ToString(Program.chips);
            lblUsername.Text = Convert.ToString(Program.username);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin LoginForm = new formLogin(this);
            btnLogin.Enabled = false;
            LoginForm.Show();
        }
    }
}
