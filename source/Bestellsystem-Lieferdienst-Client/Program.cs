using Bestellsystem_Lieferdienst_Client;
using Bestellsystem_Lieferdienst_Client.Server;

namespace Bestellsystem_Lieferdienst_Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Form form = new MainForm();


        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Client.client = new Client("192.168.0.67", 5000);
            Client.client.ConnectToServer();

            Application.Run(form);
        }
    }
}