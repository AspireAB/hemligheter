using Hemligheter.Helpers;
using Serilog;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Hemligheter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureLogging();
            Log.Information("Starting application...");
            
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();

            //UpdateHelper.HandleUpdate(); // TODO: Move update storage location and enable updates?

            var form = MainForm.InitApplication();
            if (form is null) return;
            Application.Run(form);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Log.Error(e.Exception, "Applikationen avslutades oväntat");
            MessageBox.Show(null, "Applikationen stötte på ett oväntat fel:\n\n" + e.Exception.ToString(), "Oväntat fel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private static void ConfigureLogging()
        {
            Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .WriteTo.File("logs\\Hemligheter.txt", rollingInterval: RollingInterval.Month)
                            .CreateLogger();
        }
    }
}
