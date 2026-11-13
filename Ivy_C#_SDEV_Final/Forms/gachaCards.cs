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
    public partial class gachaCards : Form
    {
        string jsonCardsPath = "JsonFilePathHere"; // May not need this. May hard bake the cards into program and just use json for individual user data. 
        private int userChips = 10000; // Example value, replace with actual user chips value later on
        private string userName_standin = "Mr. Guy";
        public int UserChips
        {
            get { return userChips; }
            set
            {
                userChips = value;
                lblUserMoney.Text = $"Chips: {userChips}";
            }
        }

        public gachaCards()
        {
            InitializeComponent();
            lblUserMoney.Text = $"Chips: {UserChips}";
            lblUserName.Text = $"{userName_standin}";

        }

        // Right now, buttons just subtract price, but else if doesn't do anything at the moment.

        private void btnBuyCopper_Click(object sender, EventArgs e)
        {
            if (UserChips >= 250)
            {
                UserChips -= 250;
                lblUserMoney.Text = $"Chips: {UserChips}";
            }
            else if (UserChips < 250)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnBuyIron_Click(object sender, EventArgs e)
        {
            if (UserChips >= 500)
            {
                UserChips -= 500;
                lblUserMoney.Text = $"Chips: {UserChips}";
            }
            else if (UserChips < 500)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnBuyBronze_Click(object sender, EventArgs e)
        {
            if (UserChips >= 1000)
            {
                userChips -= 1000;
                lblUserMoney.Text = $"Chips: {userChips}";
            }
            else if (UserChips < 1000)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnBuySilver_Click(object sender, EventArgs e)
        {
            if (UserChips >= 2000)
            {
                userChips -= 2000;
                lblUserMoney.Text = $"Chips: {userChips}";
            }
            else if(UserChips < 2000)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnBuyGold_Click(object sender, EventArgs e)
        {
            if (UserChips >= 4000)
            {
                userChips -= 4000;
                lblUserMoney.Text = $"Chips: {userChips}";
            }
            else if (UserChips < 4000)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnViewBinder_Click(object sender, EventArgs e)
        {
            gachaCardsBinder binderForm = new gachaCardsBinder();
            binderForm.Owner = this; // Set the owner of the binder form to the current gachaCards form
            binderForm.Show();
            this.Hide();
        }

    }
}