using Hemligheter.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hemligheter.Services
{
    public class Settings
    {
        public string[] Authorities { get; set; }
        public string Resource { get; set; }
        public string SelectedKeyVault { get; set; }
        public bool UseClipboard { get; set; }
        public bool UseSearchForm { get; set; }
    }

    public class SettingsService
    {
        public Settings GetSettings()
        {
            var settings = new Settings
            {
                Authorities = Properties.Settings.Default.Authorities.Cast<string>().ToArray(),
                Resource = Properties.Settings.Default.Resource,
                SelectedKeyVault = Properties.Settings.Default.SelectedKeyVault,
                UseClipboard = Properties.Settings.Default.UseClipboard,
                UseSearchForm = Properties.Settings.Default.UseSearchForm
            };

            return CleanupSettings(settings);
        }

        private static Settings CleanupSettings(Settings settings)
        {
            var authorities = settings.Authorities.TrimAndRemoveEmptyStrings();
            if (!authorities.Any())
            {
                MessageBox.Show($"Inga giltiga hemlighetskällor hittades i inställningarna.{Environment.NewLine}{Environment.NewLine}Vänligen ange minst ett giltigt Azure directory i inställningarna enligt formatet nedan.{Environment.NewLine}{Environment.NewLine}https://login.windows.net/<mytenant>.onmicrosoft.com", "Inga giltiga hemlighetskällor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                authorities = new[] { "" };
            }
            var resource = settings.Resource?.Trim();
            if (string.IsNullOrWhiteSpace(resource))
                resource = "https://management.core.windows.net/";

            settings.Authorities = authorities;
            settings.Resource = resource;

            return settings;
        }

        public void SaveSettings(Settings settings)
        {
            settings = CleanupSettings(settings);

            Properties.Settings.Default.Authorities.Clear();
            Properties.Settings.Default.Authorities.AddRange(settings.Authorities);
            Properties.Settings.Default.Resource = settings.Resource;
            Properties.Settings.Default.SelectedKeyVault = settings.SelectedKeyVault;
            Properties.Settings.Default.UseClipboard = settings.UseClipboard;
            Properties.Settings.Default.UseSearchForm = settings.UseSearchForm;

            Properties.Settings.Default.Save();
            UpdateHelper.BackupSettings();
        }
    }

    internal static class StringExtensions
    {
        public static string[] TrimAndRemoveEmptyStrings(this string[] values)
        {
            if (values == null)
                return new string[0];
            return values
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Select(s => s.Trim())
                .Distinct()
                .ToArray();
        }
    }
}
