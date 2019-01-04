using System;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");

            string content = Console.ReadLine();

            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");

            string currentComment = Console.ReadLine();

            while (currentComment != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {currentComment}");
                Console.WriteLine("</div>");

                currentComment = Console.ReadLine();
            }
        }
    }
}
