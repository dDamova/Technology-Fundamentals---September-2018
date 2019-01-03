using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            decimal pokePowerCopy = pokePower;
            int counter = 0;

            while (pokePowerCopy >= distanceBetweenTargets)
            {
                pokePowerCopy -= distanceBetweenTargets;
                counter++;
                if (pokePowerCopy == (decimal)(0.5 * pokePower) && pokePowerCopy!=0 && exhaustionFactor!=0)
                {
                    pokePowerCopy = (int)(pokePowerCopy / exhaustionFactor);
                }

            }
            Console.WriteLine(pokePowerCopy);
            Console.WriteLine(counter);
        }
    }
}
