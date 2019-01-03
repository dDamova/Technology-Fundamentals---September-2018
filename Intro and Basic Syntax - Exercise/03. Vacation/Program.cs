using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double singlePrice = 0;
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    singlePrice = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    singlePrice = 9.8;
                }
                else if (dayOfWeek == "Sunday")
                {
                    singlePrice = 10.46;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    singlePrice = 10.9;
                }
                else if (dayOfWeek == "Saturday")
                {
                    singlePrice = 15.6;
                }
                else if (dayOfWeek == "Sunday")
                {
                    singlePrice = 16;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    singlePrice = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    singlePrice = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    singlePrice = 22.5;
                }
            }

            totalPrice = singlePrice * groupSize;

            if (typeOfGroup == "Students" && groupSize >= 30)
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (typeOfGroup == "Business" && groupSize >= 100)
            {
                totalPrice = singlePrice * (groupSize - 10);
            }
            else if (typeOfGroup == "Regular" && (groupSize >= 10 && groupSize <= 20))
            {
                totalPrice = totalPrice - 0.05 * totalPrice;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
