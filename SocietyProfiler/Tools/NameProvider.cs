using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocietyProfiler.Properties;

namespace SocietyProfiler.Tools
{
    public static class NameProvider
    {
        static string[] _boyNames;
        static string[] _girlNames;
        static string[] _lastNames;

        static Random _rand;

        static NameProvider()
        {
            _rand = new Random();

            LoadList(Resources.names_boys, out _boyNames);
            LoadList(Resources.names_girls, out _girlNames);
            LoadList(Resources.names_last, out _lastNames);
        }

        private static void LoadList(string list, out string[] output)
        {
            output = list.Split('\n');
        }

        public static string GetGirlsName()
        {
            return _girlNames[_rand.Next(_girlNames.Length)].Replace("\r","");
        }

        public static string GetBoysName()
        {
            return _boyNames[_rand.Next(_boyNames.Length)].Replace("\r", "");
        }

        public static string GetLastName()
        {
            return _lastNames[_rand.Next(_lastNames.Length)].Replace("\r", "");
        }
    }
}
