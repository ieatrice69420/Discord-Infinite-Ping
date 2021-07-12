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
        public static Settings settings = new Settings(10, 20, true);


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new discordInfinitePingWindow());

            // Call when pressing start.
            await StartPing();
        }

        public static async Task StartPing()
        {
            if (File.Exists(settingsPath))
            {
                settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settingsPath));
            }
            else
            {
                if (!Directory.Exists(@"c:\Discord-Infinite-Ping\"))
                {
                    Directory.CreateDirectory(@"c:\Discord-Infinite-Ping\");
                }

                File.WriteAllText(settingsPath, JsonConvert.SerializeObject(settings));
            }

            settings.IsRunning = true;

            await new SoundPlayer().PingLoop(settings);
        }
    }
}
