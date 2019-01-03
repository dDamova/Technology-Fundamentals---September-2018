using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int month = int.Parse(Console.ReadLine());
            string monthInWords = string.Empty;

            switch (month)
            {
                case 1:
                    monthInWords = "January";
                    break;
                    break;
                case 2:
                    monthInWords = "February";
                    break;
                case 3:
                    monthInWords = "March";
                    break;
                case 4:
                    monthInWords = "April";
                    break;
                case 5:
                    monthInWords = "May";
                    break;
                case 6:
                    monthInWords = "June";
                    break;
                case 7:
                    monthInWords = "July";
                    break;
                case 8:
                    monthInWords = "August";
                    break;
                case 9:
                    monthInWords = "September";
                    break;
                case 10:
                    monthInWords = "October";
                    break;
                case 11:
                    monthInWords = "November";
                    break;
                case 12:
                    monthInWords = "December";
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            if (month >= 1 && month <= 12)
            {
                Console.WriteLine(monthInWords);
            }
        }
    }
}
