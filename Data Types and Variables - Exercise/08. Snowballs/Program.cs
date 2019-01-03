using System;
using System.Collections.Generic;
using System.Numerics;

namespace Snawballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte snowballsCount = byte.Parse(Console.ReadLine());
            List<Snowball> snowballs = new List<Snowball>();

            for (int i = 0; i < snowballsCount; i++)
            {
                Snowball currentSnowball = new Snowball()
                {
                    SnowballSnow = int.Parse(Console.ReadLine()),
                    SnowballTime = int.Parse(Console.ReadLine()),
                    SnowballQuality = int.Parse(Console.ReadLine())
                };
                snowballs.Add(currentSnowball);

            }
            BigInteger maxValue = 0;

            for (int i = 0; i < snowballs.Count; i++)
            {
                if (snowballs[i].SnowballValue > maxValue)
                {
                    maxValue = snowballs[i].SnowballValue;
                }
            }
            foreach (var sn in snowballs)
            {
                if (sn.SnowballValue == maxValue)
                {
                    Console.WriteLine($"{sn.SnowballSnow} : {sn.SnowballTime} = {sn.SnowballValue} ({sn.SnowballQuality})");
                }
            }

        }
    }
    class Snowball
    {
        public int SnowballSnow { get; set; }
        public int SnowballTime { get; set; }
        public int SnowballQuality { get; set; }
        public BigInteger SnowballValue { get { return BigInteger.Pow((SnowballSnow / SnowballTime), SnowballQuality); } }
    }
}
