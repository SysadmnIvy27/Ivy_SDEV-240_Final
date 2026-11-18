using Ivy_C__SDEV_Final.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivy_C__SDEV_Final
{
    public partial class formLogin : Form
    {
        public frmMainMenu MenuForm = null;
        public formLogin(frmMainMenu form)
        {
            InitializeComponent();
            MenuForm = form;
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.username == "Default")
            {
                Program.username = "Guest";
                Program.chips = 100;
                Program.milestone = 0;
            }
            MenuForm.Show();
            MenuForm.Login();
        }
    }
}
