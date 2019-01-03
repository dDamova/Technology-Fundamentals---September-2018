using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyAvailable = decimal.Parse(Console.ReadLine());
            byte studentsCount = byte.Parse(Console.ReadLine());
            decimal lightsabrePrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            short lightsabersCount = (short)Math.Ceiling(studentsCount * 1.1);
            byte beltsCount = (byte)(studentsCount - Math.Floor(studentsCount / 6.0));
            byte robesCount = studentsCount;
            decimal moneyNeeded = lightsabersCount * lightsabrePrice + robesCount * robePrice + beltsCount * beltPrice;

            if (moneyNeeded <= moneyAvailable)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                decimal diff = moneyNeeded - moneyAvailable;

                Console.WriteLine($"Ivan Cho will need {diff:F2}lv more.");
            }
        }
    }
}
