using System;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace DiscordInfinitePing
{
    public class PingPlayer
    {
        // Enter ping sound file location here
        SoundPlayer player = new SoundPlayer(@"c:\OS\discord-notification\discord-notification.wav\discord-notification.wav");

        public async Task PingLoop()
        {
            Random rnd = new Random();

            while (true)
            {
                //MessageBox.Show(settings.IsRunning.ToString());

                if (!Program.CurrentSettings.IsRunning)
                {
                    return;
                }

                //MessageBox.Show(settings.IsRunning.ToString());

                // Play ping sound.
                player.Play();

                await Task.Delay(1000 * rnd.Next(Program.CurrentSettings.MinDelayBetweenPings, Program.CurrentSettings.MaxDelayBetweenPings));
            }
        }
    }
}