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
    public partial class gachaCardsBinder : Form
    {
        public gachaCardsBinder()
        {
            InitializeComponent();
        }

        private void btnBackToGacha_Click(object sender, EventArgs e)
        { 
            this.Owner.Show();
            this.Close();
        }
    }
}
