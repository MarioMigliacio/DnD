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
            FormControl.Gs = GameState.Init;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (running)
            {
                if (FormControl.Gs != GameState.Final)
                {
                    Application.Run(FormControl.RunForm());
                }

                if (FormControl.Gs == GameState.Final)
                {
                    running = false;
                }
            }
        }
    }
}
