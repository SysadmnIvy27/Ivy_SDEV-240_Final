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
    public partial class BlackJackForm : Form
    {
        Random rnd = new Random();
        List<String> spadeCards = new List<String>() {"A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "J", "Q", "K"};
        List<String> clubCards = new List<String>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "J", "Q", "K" };
        List<String> heartCards = new List<String>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "J", "Q", "K" };
        List<String> diamondCards = new List<String>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "J", "Q", "K" };
        public BlackJackForm()
        {
            InitializeComponent();
        }
        private void GenerateCard()
        {
            var v = 0;
            var value = "0";
            int suit = rnd.Next(4);
            if (suit == 0)
            {
                v = rnd.Next(spadeCards.Count);
                value = spadeCards[v];
                lblPlayer.Text = $"{lblPlayer.Text}, {value}♠";
            }
            if (suit == 1)
            {
                v = rnd.Next(clubCards.Count);
                value = clubCards[v];
                lblPlayer.Text = $"{lblPlayer.Text}, {value}♣";
            }
            if (suit == 2)
            {
                v = rnd.Next(heartCards.Count);
                value = heartCards[v];
                lblPlayer.Text = $"{lblPlayer.Text}, {value}♥";
            }
            if (suit == 3)
            {
                v = rnd.Next(diamondCards.Count);
                value = diamondCards[v];
                lblPlayer.Text = $"{lblPlayer.Text}, {value}♦";
            }
        }
        private void Button1_Click(object sender, EventArgs e) => GenerateCard(); //Back Button
    }
}
