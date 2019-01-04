using System;
using System.Globalization;

namespace DayOfWeek_ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            DateTime currentDate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(currentDate.DayOfWeek);
        }
    }
}
