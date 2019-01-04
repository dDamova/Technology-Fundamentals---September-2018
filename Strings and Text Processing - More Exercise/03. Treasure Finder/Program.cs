using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keySequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string message = Console.ReadLine();

            while (message != "find")
            {
                string decryptedMessage = DecryptMessage(keySequence, message);
                string type = GetType(decryptedMessage);
                string coordinates = GetCoordinates(decryptedMessage);

                Console.WriteLine($"Found {type} at {coordinates}");

                message = Console.ReadLine();
            }
        }

        private static string GetCoordinates(string decryptedMessage)
        {
            string coordinates = string.Empty;

            int startIndex = decryptedMessage.IndexOf('<') + 1;
            int length = decryptedMessage.IndexOf('>') - startIndex;
            coordinates = decryptedMessage.Substring(startIndex, length);

            return coordinates;
        }

        private static string GetType(string decryptedMessage)
        {
            string type = string.Empty;

            int startIndex = decryptedMessage.IndexOf('&') + 1;
            int length = decryptedMessage.LastIndexOf('&') - startIndex;
            type = decryptedMessage.Substring(startIndex, length);

            return type;
        }

        private static string DecryptMessage(int[] keySequence, string message)
        {
            string resultMessage = string.Empty;

            if (keySequence.Length >= message.Length)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    char symbol = message[i];
                    resultMessage += (char)(symbol - keySequence[i]);
                }
            }
            else
            {
                List<int> resultKeySequence = new List<int>();
                int times = message.Length / keySequence.Length;
                int remain = message.Length % keySequence.Length;

                for (int i = 0; i < times; i++)
                {
                    resultKeySequence.AddRange(keySequence);
                }
                for (int i = 0; i < remain; i++)
                {
                    resultKeySequence.Add(keySequence[i]);
                }

                for (int i = 0; i < message.Length; i++)
                {
                    char symbol = message[i];
                    resultMessage += (char)(symbol - resultKeySequence[i]);
                }
            }

            return resultMessage;
        }
    }
}
