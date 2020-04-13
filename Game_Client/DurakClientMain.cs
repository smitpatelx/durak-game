/*
 Authors: Smit Patel, Arjun Chopra, Duc Lee, Junaid Khairi
 Date: 28-03-2020
 Description: GameClientMain, main entry point for the application
 */

using System;
using System.Windows.Forms;

namespace GameClient
{
    class GameClientMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameClientForm());
        }
    }
}
