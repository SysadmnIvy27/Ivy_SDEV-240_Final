using page_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ivy_C__SDEV_Final.Program;

namespace Ivy_C__SDEV_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Add_Tabs();
            label1.Text = username;
            label2.Text = Convert.ToString(chips);
        }
        public void Add_Tabs()
        {
            Assembly assem = Assembly.GetExecutingAssembly();
            Type[] types = assem.GetTypes();

            Debug.WriteLine("Loading Pages: ");
            foreach (Type type in types)
            {
                if (Convert.ToString(type.Namespace) == "page_classes" && type.BaseType == typeof(TabPage))
                {
                    Debug.WriteLine($"{type.Name} loaded.");
                    object tab_obj = Activator.CreateInstance(type);
                    TabPage tab = tab_obj as TabPage;
                    tabControl1.Controls.Add(tab);
                    if (Convert.ToString(type.Name) == "Mainmenu")
                    {
                        Mainmenu Menu_obj = tab_obj as Mainmenu;
                        Menu_obj.InfoChanged += OnInfoChanged;
                    }
                }
            }
        }
        public void OnInfoChanged(object sender, EventArgs e)
        {
            label1.Text = username;
            label2.Text = Convert.ToString(chips);
        }

    }
}
