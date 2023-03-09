using Hemligheter.Helpers;
using Serilog;
using Squirrel;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hemligheter.Helpers
{
    public class UpdateHelper
    {
        private static string DistributionUrl = ConfigurationManager.AppSettings.Get("DistributionUrl");

        public static void HandleUpdate()
        {
            using (var updateManager = new UpdateManager(DistributionUrl))
            {
                string appName = GetAppName();

                SquirrelAwareApp.HandleEvents(
                    onInitialInstall: v =>
                    {
                        Log.Information("Application installed, v. " + v.ToString());
                        updateManager.CreateShortcutForThisExe();
                        updateManager.CreateShortcutsForExecutable(appName, ShortcutLocation.Startup, false);
                        updateManager.CreateUninstallerRegistryEntry();
                    },
                    onAppUpdate: v =>
                    {
                        Log.Information("Application updated to v. " + v.ToString());
                        updateManager.CreateShortcutForThisExe();
                        updateManager.CreateShortcutsForExecutable(appName, ShortcutLocation.Startup, false);
                        updateManager.CreateUninstallerRegistryEntry();
                    },
                    onAppUninstall: v =>
                    {
                        Log.Information("Application uninstalled");
                        updateManager.RemoveShortcutForThisExe();
                        updateManager.RemoveShortcutsForExecutable(appName, ShortcutLocation.Startup);
                        updateManager.RemoveUninstallerRegistryEntry();
                    });
            }
            
            RestoreSettings();
        }

        public static async Task<bool> CheckForUpdates()
        {
            return false; // TODO: Update storage location and enable updates?

            Log.Information("Checking for updates...");

#if DEBUG
            Log.Information("DEBUG mode, skipping updates");
            return false;
#endif

            if (ConnectivityHelper.IsConnectedToInternet() == false)
            {
                Log.Warning("No internet connection, could not check for updates");
                return false;
            }

            using (var updateManager = new UpdateManager(DistributionUrl))
            {
                try
                {
                    var updates = await updateManager.CheckForUpdate();
                    if (updates.ReleasesToApply.Any() == false)
                    {
                        Log.Information("Found no new updates");
                        return false;
                    }
                    Log.Information("Found {UpdateCount} update(s):", updates.ReleasesToApply.Count);
                    Log.Information(string.Join(Environment.NewLine, updates.ReleasesToApply.Select(r => r.Version)));

                    Log.Information("Downloading and installing updates...");

                    await updateManager.DownloadReleases(updates.ReleasesToApply);
                    await updateManager.ApplyReleases(updates);
                    await updateManager.UpdateApp();
                    
                    BackupSettings();
                    
                    Log.Information("Updates have been installed");
                    
                    return true;
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "An error occured while updating application");
                    MessageBox.Show(null, "Kunde inte kontrollera uppdateringar:\n\n" + ex.ToString(), "Fel vid uppdatering!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return false;
        }

        public static void ApplyUpdate()
        {
            BackupSettings();
            UpdateManager.RestartApp();
        }

        private static string GetAppName()
        {
            var exePath = Assembly.GetEntryAssembly().Location;
            return Path.GetFileName(exePath);
        }

        public static void BackupSettings()
        {
            string settingsFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
            if(File.Exists(settingsFile) == false)
            {
                return;
            }
            
            string destination = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\..\\last.config";
            File.Copy(settingsFile, destination, true);
        }

        private static void RestoreSettings()
        {
            //Restore settings after application update            
            string destFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
            string sourceFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\..\\last.config";
            // Check if we have settings that we need to restore
            if (!File.Exists(sourceFile))
            {
                // Nothing we need to do
                return;
            }
            // Create directory as needed
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(destFile));
            }
            catch (Exception) { }

            // Copy our backup file in place 
            try
            {
                File.Copy(sourceFile, destFile, true);
            }
            catch (Exception) { }

            // Delete backup file
            try
            {
                File.Delete(sourceFile);
            }
            catch (Exception) { }
        }
    }
}
