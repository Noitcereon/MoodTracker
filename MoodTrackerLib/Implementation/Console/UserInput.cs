using System;
using static MoodTrackerLib.Implementation.Console.ConsoleDisplay;

namespace MoodTrackerLib.Implementation.Console
{
    public static class UserInput
    {
        public static int OptionSelection()
        {
            string userInput = System.Console.ReadLine();

            if (int.TryParse(userInput, out int selection))
            {
                return selection;
            }

            return -1;
        }
    }
}
