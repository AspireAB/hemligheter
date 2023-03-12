using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Hemligheter.Data;
using Hemligheter.Services;
using Azure.Identity;
using Azure.Core;

namespace Hemligheter
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            var services = builder.Services;

#if WINDOWS
            services.AddSingleton<ITrayService, WinUI.TrayService>();
            services.AddSingleton<INotificationService, WinUI.NotificationService>();
#elif MACCATALYST
            services.AddSingleton<ITrayService, MacCatalyst.TrayService>();
            services.AddSingleton<INotificationService, MacCatalyst.NotificationService>();
#endif

#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif

            services.AddMauiBlazorWebView();
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<KeyVaultService>();
            services.AddSingleton<UserService>();

            return builder.Build();
        }
    }
}