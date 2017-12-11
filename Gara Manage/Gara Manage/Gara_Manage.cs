﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gara_Manage
{
    static class Gara_Manage
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MAIN main = new MAIN();
                Application.Run(main);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace,ex.Message);
            }
        }
    }
}