using System;
using System.Windows.Forms;
using System.ServiceProcess;

namespace E_videoteka
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGlavna());
        }
    }
}
