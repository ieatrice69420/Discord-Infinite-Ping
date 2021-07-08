using System;
using System.IO;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace DiscordInfinitePing
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            /*             Application.SetHighDpiMode(HighDpiMode.SystemAware);
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1()); */

            // Change this path to change settings file location.
            string settingsPath = @"c:\DiscordInfinitePing\settings.json";
            Settings settings = new Settings(10, 20);

            if (File.Exists(settingsPath))
            {
                settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settingsPath));
            }
            else
            {
                if (!Directory.Exists(@"c:\DiscordInfinitePing\"))
                {
                    Directory.CreateDirectory(@"c:\DiscordInfinitePing\");
                }

                File.WriteAllText(settingsPath, JsonConvert.SerializeObject(settings));
            }

            await new MainLoop().PingLoop(settings);
        }
    }
}
