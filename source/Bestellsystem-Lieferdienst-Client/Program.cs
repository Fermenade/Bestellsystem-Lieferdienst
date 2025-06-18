using Bestellsystem_Lieferdienst_Client.Server;
using System.Diagnostics;

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
            Client.client = new Client("127.0.0.1", 5000);
            Client.client.ConnectToServer();

            Application.Run(form);
        }
    }
}