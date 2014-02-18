using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocietyProfiler.Tools
{
    public static class StaticRandom
    {
        static Random _rand;

        static StaticRandom()
        {
            _rand = new Random();
        }

        public static void SetSeed(int seed)
        {
            _rand = new Random(seed);
        }

        public static int Next()
        {
            return _rand.Next();
        }

        public static int Next(int maxValue)
        {
            return _rand.Next(maxValue);
        }

        public static int Next(int minValue, int maxValue)
        {
            return _rand.Next(minValue, maxValue);
        }

        /// <summary>
        /// The chance to return true, from 0 to 100
        /// </summary>
        /// <param name="chance">The chance for the event</param>
        /// <returns>True of false, depending on chance</returns>
        public static bool Chance(float chance)
        {
            float randVal = (float)_rand.NextDouble() * 100F;

            return (randVal < chance);
        }
    }
}
