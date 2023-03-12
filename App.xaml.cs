using Hemligheter.Services;
using Microsoft.Identity.Client;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using System.Diagnostics;
using Application = Microsoft.Maui.Controls.Application;
using WindowsConfiguration = Microsoft.Maui.Controls.PlatformConfiguration.Windows;

namespace Hemligheter
{
    public partial class App : Application
    {
        public const string Title = "Hemligheter";


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            SetupAppActions();
            SetupTrayIcon();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        private void SetupAppActions()
        {
            try
            {
                //AppActions.IconDirectory = Application.Current.On<WindowsConfiguration>().GetImageDirectory();
                //AppActions.SetAsync(
                //    new AppAction("current_info", "Check Current Weather", icon: "current_info"),
                //    new AppAction("add_location", "Add a Location", icon: "add_location")
                //);
                // TODO: Tray icon stuff
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine("App Actions not supported", ex);
            }
        }

        private void SetupTrayIcon()
        {
            var trayService = ServiceProvider.GetService<ITrayService>();

            if (trayService != null)
            {
                // TODO: Tray icon stuff
                //trayService.Initialize();
                //trayService.ClickHandler = () =>
                //    ServiceProvider.GetService<INotificationService>()
                //        ?.ShowNotification("Hello Build! 😻 From .NET MAUI", "How's your weather?  It's sunny where we are 🌞");
            }
        }
    }
}
