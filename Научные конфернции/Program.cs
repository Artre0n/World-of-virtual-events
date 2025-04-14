using Microsoft.VisualBasic.ApplicationServices;
using Научные_конфернции;
namespace Научные_конфернции
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            Application.Run(new MainForm());
            
            
        }

    }
}