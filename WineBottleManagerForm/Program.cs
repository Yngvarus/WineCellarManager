using WineCellarManager;

namespace WineBottleManagerForm
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

            //creazione oggetto wineManager
            WineManager wineManager = new WineManager();
            //inizializzazione form application
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuForm(wineManager));
        }
    }
}