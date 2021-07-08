using System;

namespace DiscordInfinitePing
{
    public struct Settings
    {
        public int MinDelayBetweenPings;
        public int MaxDelayBetweenPings;

        public Settings(int minDelayBetweenPings, int maxDelayBetweenPings)
        {
            MinDelayBetweenPings = minDelayBetweenPings;
            MaxDelayBetweenPings = maxDelayBetweenPings;
        }
    }
}
