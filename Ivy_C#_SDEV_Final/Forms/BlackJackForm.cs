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
        public BlackJackForm()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e) => lblPlayer.Text = CardGen.GenerateCard(); //Back Button
    }
}
