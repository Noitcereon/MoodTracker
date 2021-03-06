﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackerLib.Implementation.Console
{
    public class Helpers
    {
        /// <summary>
        /// Encapsulates a message with --- on both sides. Like so: --- {message} ---
        /// </summary>
        /// <param name="message"></param>
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

        public static int CreateOptions(string [] options)
        {
            int noOfOptions = 1;
            foreach (string name in options)
            {
                System.Console.WriteLine($"{noOfOptions}: {SpaceSeperatePascalName(name)}");
                noOfOptions++;
            }

            return noOfOptions;
        }

        public static int CreateOptions(string[] options, params string[] additionalOptions)
        {
            int noOfOptions = CreateOptions(options);

            foreach (string name in additionalOptions)
            {
                System.Console.WriteLine($"{noOfOptions}: {SpaceSeperatePascalName(name)}");
                noOfOptions++;
            }

            return noOfOptions;
        }
    }
}
