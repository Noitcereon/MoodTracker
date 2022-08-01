using System;

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

        public static bool Confirmation()
        {
            try
            {
                System.Console.WriteLine("Press 'y' or 'n' to confirm or cancel.");
                string input = System.Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return false;
                if (input.Equals("y")) return true;
                if (input.Equals("n")) return false;

                System.Console.WriteLine("Press 'y' or 'n'...");
                Confirmation();
            }
            catch
            {
                System.Console.WriteLine("Something went wrong. Press any button to return to Main Menu.");
                System.Console.ReadKey();
            }

            throw new ArgumentException("Something went wrong in the Confirmation dialogue");
        }
    }
}
