using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivy_C__SDEV_Final.Classes;

namespace Ivy_C__SDEV_Final.Forms
{
    public partial class BlackJackForm : Form
    {
        public GenerateCards CardGen = new GenerateCards();
        public Form MenuForm = null;
        public int playerScore = 0;
        public int dealerScore = 0;
        private object currCard;

        public BlackJackForm(/*Form form*/)
        {
            InitializeComponent();
            //MenuForm = form;
        }
        private void Button1_Click(object sender, EventArgs e) => CardGen.ResetDeck(); //Back Button



        private void BlackJackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MenuForm.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            dealerScore = 0;
            CardGen.ResetDeck();
            Tuple <int, string> currCard = CardGen.GenerateCard();
            playerScore += currCard.Item1;
            lblPlayer.Text = currCard.Item2;
            currCard = CardGen.GenerateCard();
            playerScore += currCard.Item1;
            lblPlayer.Text += $", {currCard.Item2}";
            currCard = CardGen.GenerateCard();
            dealerScore += currCard.Item1;
            lblDealer.Text = $"?, {currCard.Item2}";
        }
        private void end_game()
        {
            if (playerScore <= 21)
            {
                int win = (int)txtBet.Value * 2;
                if (playerScore > dealerScore)
                {
                    if (playerScore == 21)
                    {
                        win = (int)txtBet.Value * 3;
                    }
                    lblWinnings.Text = $"You won {win} chip(s)!";
                }
                else if (playerScore == dealerScore)
                {
                    lblWinnings.Text = "Tie! Bet amount returned.";
                }
                else 
                {
                    if (dealerScore <= 21)
                    {
                        lblWinnings.Text = $"You lost {txtBet.Value} chip(s)!";
                    }
                    else
                    {
                        lblWinnings.Text = $"You won {win} chip(s)!";
                    }
                }
            }
            else
            {
                lblWinnings.Text = $"You lost {txtBet.Value} chip(s)!";
            }
        }
        private void stand()
        {
            if (playerScore <= 21)
            {
                Tuple<int, string> currCard = CardGen.GenerateCard();
                dealerScore += currCard.Item1;
                lblDealer.Text = lblDealer.Text.Replace("?", currCard.Item2);
                while (dealerScore < 17)
                {
                    currCard = CardGen.GenerateCard();
                    dealerScore += currCard.Item1;
                    lblDealer.Text += $", {currCard.Item2}";
                }
            }
            else
            {
                dealerScore = 21;
            }
            end_game();
        }
        private void btnStand_Click(object sender, EventArgs e) => stand();

        private void btnHit_Click(object sender, EventArgs e)
        {
            Tuple<int, string> currCard = CardGen.GenerateCard();
            playerScore += currCard.Item1;
            lblPlayer.Text += $", {currCard.Item2}";
            if (playerScore >= 21)
            {
                stand();
            }
        }
    }
}
