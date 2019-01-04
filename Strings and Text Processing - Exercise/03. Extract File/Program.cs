using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int lastIndexOfSlash = path.LastIndexOf('\\');
            int indexofDot = path.LastIndexOf('.');
            int lengthOfFileName = indexofDot - 1 - lastIndexOfSlash;

            string fileName = path.Substring(lastIndexOfSlash + 1, lengthOfFileName);
            string extention = path.Substring(indexofDot + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
