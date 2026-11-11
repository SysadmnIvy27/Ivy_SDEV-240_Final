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
        private void Button1_Click(object sender, EventArgs e) => lblPlayer.Text = CardGen.GenerateCard(); //Back Button



        private void BlackJackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MenuForm.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Tuple(int, string) currCard = CardGen.GenerateCard();
            lblPlayer.Text = currCard.Item2;
            playerScore += currCard.Item1;
            currCard = CardGen.GenerateCard();
            lblPlayer.Text += $", {currCard.Item2}";
            playerScore += currCard.Item1;
            currCard = CardGen.GenerateCard();
            lblDealer.Text = $"?, {CardGen.GenerateCard().Item2}";
            dealerScore += currCard.Item1;
            CardGen.ResetDeck();
        }
    }
}
