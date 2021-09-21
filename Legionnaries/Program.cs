using System;
using System.Collections.Generic;
using System.Linq;

namespace Legionnaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Total Count is {CountOccurence(2660)}");
            Console.ReadKey();
        }

        public static int CountOccurence(int limit)
        {
            var countList = new List<string>();
            for(int i = 1; i <= limit; i++)
            {
                countList.Add(IntToRoman(i));
            }

            int count = 0;
            foreach (var c in string.Join(", ", countList).AsSpan())
            {
                if (c == 'X')
                    count++;
            }

            return count;
        }

        public static string IntToRoman(int num)
        {
            var result = string.Empty;
            var map = new Dictionary<string, int>
            {
                {"M", 1000 },
                {"CM", 900},
                {"D", 500},
                {"CD", 400},
                {"C", 100},
                {"XC", 90},
                {"L", 50},
                {"XL", 40},
                {"X", 10},
                {"IX", 9},
                {"V", 5},
                {"IV", 4},
                {"I", 1}
            };
            foreach (var pair in map)
            {
                result += string.Join(string.Empty, Enumerable.Repeat(pair.Key, num / pair.Value));
                num %= pair.Value;
            }
            return result.ToUpper();
        }
    }
}
