using System;

namespace Automation.Common.Helpers
{
    public static class Randomizer
    {
        private static readonly Random Random = new Random();

        public static int RandomId(int minRange = 0, int maxRange = 10000)
            => Random.Next(minRange, maxRange);

        public static int RandomInt(int minRange = 0, int maxRange = 10000)
            => Random.Next(minRange, maxRange);
    }
}