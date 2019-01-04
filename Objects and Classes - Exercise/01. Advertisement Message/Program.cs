using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int advCount = int.Parse(Console.ReadLine());

            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            for (int i = 0; i < phrases.Length; i++)
            {
                int ri = random.Next(0, phrases.Length);

                string temp = phrases[i];
                phrases[i] = phrases[ri];
                phrases[ri] = temp;
            }

            for (int i = 0; i < authors.Length; i++)
            {
                int ri = random.Next(0, authors.Length);

                string temp = authors[i];
                authors[i] = authors[ri];
                authors[ri] = temp;
            }
            for (int i = 0; i < events.Length; i++)
            {
                int ri = random.Next(0, events.Length);

                string temp = events[i];
                events[i] = events[ri];
                events[ri] = temp;
            }
            for (int i = 0; i < cities.Length; i++)
            {
                int ri = random.Next(0, cities.Length);

                string temp = cities[i];
                cities[i] = cities[ri];
                cities[ri] = temp;
            }

            for (int i = 0; i < advCount; i++)
            {
                Console.WriteLine($"{phrases[i]} {events[i]} {authors[i]} – {cities[i]}");
            }
        }
    }
}
