using System;
using System.Windows.Forms;

namespace Gara_Manage
{
    static class Gara
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MAIN());
        }
    }
}
