using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivy_C__SDEV_Final.Forms
{
    public partial class frmMainMenu : Form
    {
        public formLogin LoginForm = new formLogin();
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
            btnLogin.Enabled = false;
            LoginForm.Show(); 
            lblChips.Text = Convert.ToString(Program.chips);
            lblUsername.Text = Convert.ToString(Program.username);
        }

        private void btnBlackjack_Click(object sender, EventArgs e)
        {
            Form Blackjack = new BlackJackForm();
            Blackjack.Show();
        }

        private void btnGachaCards_Click(object sender, EventArgs e)
        {
            Form Gacha = new gachaCards();
            Gacha.Show();
        }

        private void btnRoulette_Click(object sender, EventArgs e)
        {
            Form Roulette = new roulette();
            Roulette.Show();
        }

        private void btnSlots_Click(object sender, EventArgs e)
        {
            Form Slots = new Slots();
            Slots.Show();
        }

        private void btnTexasHoldEm_Click(object sender, EventArgs e)
        {
            Form Texas = new texas_Holdem();
            Texas.Show();
        }
    }
}
