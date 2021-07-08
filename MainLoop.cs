using System;
using System.Threading.Tasks;
using System.Media;

namespace DiscordInfinitePing
{
    public class MainLoop
    {
        // Enter ping sound file location here
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"d:\GitHub\discordInfinitePing\discord-notification.wav");

        public async Task PingLoop(Settings settings)
        {
            Random rnd = new Random();

            while (true)
            {
                // Play ping sound.
                player.Play();
                await Task.Delay(1000 * rnd.Next(settings.MinDelayBetweenPings, settings.MaxDelayBetweenPings));
            }
        }
    }
}