using System;
using static MoodTrackerLib.Implementation.Console.ConsoleDisplay;

namespace MoodTrackerLib.Implementation.Console
{
    public static class UserInput
    {
        public static View ViewSelection()
        {
            string userInput = System.Console.ReadLine();

            if (int.TryParse(userInput, out int selection))
            {
                View selectedView = (View)selection;
                return selectedView;
            }

            return View.Main;
        }
    }
}
