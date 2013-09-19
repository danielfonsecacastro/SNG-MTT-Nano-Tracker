using SNGMTTNanoTracker.Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

using System.Windows.Forms;

namespace Poker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + " - " + ex.StackTrace);
            //}
        }
    }
}
