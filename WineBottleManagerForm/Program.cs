using WineCellarManager;


namespace WineBottleManagerForm
{
    internal static class Program
    {
        // Main entry point for the application.
        [STAThread]
        static void Main()
        {
            // Customize application configuration such as set high DPI settings or default font at: https://aka.ms/applicationconfiguration.

            // Connection string to the database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=M:\\desktop\\junk_cartelle\\Documents\\WineBottlesDb.mdf;Integrated Security=True;Connect Timeout=30";

            // Creating WineManager object with the connection string
            WineManager wineManager = new WineManager(connectionString);

            // Initializing the application
            ApplicationConfiguration.Initialize();

            // Starting the main form and passing the WineManager object
            Application.Run(new MainMenuForm(wineManager));
        }
    }
}
