using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morse = new Dictionary<string, char> {
              { ".-"   ,'A'},
                                       { "-..." ,'B'},
                                       { "-.-." ,'C'},
                                       { "-.."  ,'D'},
                                       { "."    ,'E'},
                                       { "..-." ,'F'},
                                       { "--."  ,'G'},
                                       { "...." ,'H'},
                                       { ".."   ,'I'},
                                       { ".---" ,'J'},
                                       { "-.-"  ,'K'},
                                       { ".-.." ,'L'},
                                       { "--"   ,'M'},
                                       { "-."   ,'N'},
                                       { "---"  ,'O'},
                                       { ".--." ,'P'},
                                       { "--.-" ,'Q'},
                                       { ".-."  ,'R'},
                                       { "..."  ,'S'},
                                       { "-"    ,'T'},
                                       { "..-"  ,'U'},
                                       { "...-" ,'V'},
                                       { ".--"  ,'W'},
                                       { "-..-" ,'X'},
                                       { "-.--" ,'Y'},
                                       { "--.." ,'Z'},
                                       { "-----",'0'},
                                       { ".----",'1'},
                                       { "..---",'2'},
                                       { "...--",'3'},
                                       { "....-",'4'},
                                       { ".....",'5'},
                                       { "-....",'6'},
                                       { "--...",'7'},
                                       { "---..",'8'},
                                       { "----.",'9'}
            };
            List<string> words = new List<string>();
            string[] textInMorse = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            foreach (string symbol in textInMorse)
            {
                if (symbol == "|")
                {
                    result.Append(" ");
                }
                else
                {
                    result.Append(morse[symbol].ToString());
                }
            }

            Console.WriteLine(result);
        }
    }
}
