using System;

namespace MoodTrackerLib.Implementation.Console
{
    public static class ViewHandler
    {
        public static void ShowMainMenu()
        {
            System.Console.WriteLine($"{Environment.NewLine} " +
                              $"Choose what to do: ");
            System.Console.WriteLine("1. Main");
            System.Console.WriteLine("2. Stats");
            System.Console.WriteLine("3. Add Day");
            System.Console.WriteLine("4. Options");
            System.Console.WriteLine();
        }
        public static void ShowOptions()
        {
            throw new NotImplementedException();
        }

        public static void ShowAddDay()
        {
            throw new NotImplementedException();
        }

        public static void ShowStats()
        {
            throw new NotImplementedException();
        }
    }
}
