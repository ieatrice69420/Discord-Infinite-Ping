using System;
using System.Threading.Tasks;
using System.Media;

namespace DiscordInfinitePing
{
    public class MainLoop
    {
        // Enter ping sound file location here
        SoundPlayer player = new SoundPlayer(@"d:\GitHub\Discord-Infinite-Ping\Discord-Infinite-Ping\Discord-Infinite-Ping\discord-notification.wav");

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