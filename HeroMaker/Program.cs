using System;
using System.Windows.Forms;
using HeroMaker.Enums;

namespace HeroMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool running = true;
            FormControl.GS = GameState.Init;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (running)
            {
                if (FormControl.GS != GameState.Final)
                {
                    Application.Run(FormControl.RunForm());
                }

                if (FormControl.GS == GameState.Final)
                {
                    running = false;
                }
            }
        }
    }
}
