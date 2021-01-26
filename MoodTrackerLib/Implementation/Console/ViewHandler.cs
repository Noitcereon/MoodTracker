using System;

namespace MoodTrackerLib.Implementation.Console
{
    public static class ViewHandler
    {
        public static void ShowMainMenu()
        {
            Helpers.HighlightMessage("Main Menu");
            System.Console.WriteLine($"{Environment.NewLine} " +
                              $"Enter a number to select command. ");
            System.Console.WriteLine("1. Main");
            System.Console.WriteLine("2. Stats");
            System.Console.WriteLine("3. Add Day");
            System.Console.WriteLine("4. Options");
            System.Console.WriteLine();
        }
        public static void ShowOptions()
        {
            System.Console.WriteLine("Options is not implemented yet.");
            ShowMainMenu();
        }

        public static void ShowAddDay()
        {
            System.Console.WriteLine("Add Day is not implemented yet.");
            ShowMainMenu();
        }

        public static void ShowStats()
        {
            System.Console.WriteLine("Stats are not implemented yet.");
            ShowMainMenu();
        }
    }
}
