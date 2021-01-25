using System;
using static MoodTrackerLib.Implementation.Console.ConsoleDisplay;

namespace MoodTrackerLib.Implementation.Console
{
    public static class UserInput
    {
        public static View ViewSelection()
        {
            View userInput = (View)Convert.ToInt16(System.Console.ReadKey());
            return userInput;
        }
    }
}
