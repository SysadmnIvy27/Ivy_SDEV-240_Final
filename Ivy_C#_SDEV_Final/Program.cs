using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using page_classes;
using System.Reflection;
using System.Diagnostics;

namespace Ivy_C__SDEV_Final
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string username = "Default";
        public static int chips = 0;
        public static int milestone = 0;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
