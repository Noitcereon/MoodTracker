using System;
using static MoodTrackerLib.Implementation.Console.ConsoleDisplay;

namespace MoodTrackerLib.Implementation.Console
{
    public static class UserInput
    {
        public static int OptionSelection()
        {
            try
            {
                string userInput = System.Console.ReadLine();
                if (int.TryParse(userInput, out int selection))
                {
                    return selection;
                }
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine($"Invalid input for {ex.ParamName}");
            }

            return -1;
        }
    }
}
