using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackerLib.Implementation.Console
{
    public class Helpers
    {
        public static void HighlightMessage(string message)
        {
            System.Console.WriteLine($"--- {message} ---");
        }


        /// <summary>
        /// Creates a string with spaces placed between each capitalized letter after the first of the string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>The modified input as a string</returns>
        public static string SpaceSeperatePascalName(string input)
        {
            StringBuilder builder = new StringBuilder();
            string output = input;
            foreach (char letter in output)
            {
                if (char.IsUpper(letter) && builder.Length > 0) builder.Append(' ');
                builder.Append(letter);
            }
            output = builder.ToString();

            return output;
        }

        public static void CreateOptions(string [] enumNames)
        {
            int i = 1;
            foreach (var name in enumNames)
            {
                System.Console.WriteLine($"{i}: {SpaceSeperatePascalName(name)}");
                i++;
            }
        }
    }
}
