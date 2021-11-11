using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace DiscordInfinitePing
{
    static class Program
    {
        // Change this path to change settings file location.
        public static string settingsPath = @"c:\Discord-Infinite-Ping\settings.json";
        public static Settings CurrentSettings = new Settings(10, 20, false);


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (File.Exists(settingsPath))
            {
                CurrentSettings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settingsPath));
            }
            else
            {
                if (!Directory.Exists(@"c:\Discord-Infinite-Ping\"))
                {
                    Directory.CreateDirectory(@"c:\Discord-Infinite-Ping\");
                }

                File.WriteAllText(settingsPath, JsonConvert.SerializeObject(CurrentSettings));
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartPing().GetAwaiter().GetResult();
        }

        public static void StopPing()
        {
            CurrentSettings = new Settings(CurrentSettings.MinDelayBetweenPings, CurrentSettings.MaxDelayBetweenPings, false);
        }

        public static async Task StartPing()
        {
            CurrentSettings = new Settings(/*CurrentSettings.MinDelayBetweenPings*/10, /*CurrentSettings.MaxDelayBetweenPings*/ 20, true);

            await new PingPlayer().PingLoop();
        }
    }
}
