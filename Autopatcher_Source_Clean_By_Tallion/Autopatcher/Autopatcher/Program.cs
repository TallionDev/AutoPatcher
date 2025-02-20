/*******************************************************************************************
 * Sistem creat de Tallion, 2025
 * 
 * Website oficial: https://devm2code.com/
 * Discord: talion0127
 * Canal Discord: https://discord.gg/VZgzwacwFD
 * 
 * © Tallion 2025. Toate drepturile rezervate.
 *******************************************************************************************/
namespace Metin2Autopatcher
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
            Application.Run(new AutoPatcher());
        }
    }
}