using System;

namespace DiscordInfinitePing
{
    public struct Settings
    {
        public int MinDelayBetweenPings;
        public int MaxDelayBetweenPings;
        public bool IsRunning;

        public Settings(int minDelayBetweenPings, int maxDelayBetweenPings, bool isRunning)
        {
            MinDelayBetweenPings = minDelayBetweenPings;
            MaxDelayBetweenPings = maxDelayBetweenPings;
            IsRunning = isRunning;
        }
    }
}
