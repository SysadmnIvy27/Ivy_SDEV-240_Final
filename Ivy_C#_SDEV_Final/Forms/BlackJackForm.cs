using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            lblPlayer.Text = $"{CardGen.GenerateCard()}, {CardGen.GenerateCard()}";
            lblDealer.Text = $"?, {CardGen.GenerateCard()}";
            CardGen.ResetDeck();
        }
    }
}
