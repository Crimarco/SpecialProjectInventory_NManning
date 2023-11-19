﻿using System;
using System.Windows.Forms;

namespace SpecialProjectInventory
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
            Application.Run(new WelcomeForm());  // LoginForm was change to MainFrom
            //Application.Run(new AlertsForm());
        }
    }
}
