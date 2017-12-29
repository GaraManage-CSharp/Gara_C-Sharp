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
                MAIN main = new MAIN();
                Application.Run(main);
        }
    }
}
