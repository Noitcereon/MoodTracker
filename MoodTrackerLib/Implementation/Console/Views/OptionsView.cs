using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console.Views
{
    public static class OptionsView
    {
        private static readonly DataAccess Data = new DataAccess();
        public static void ShowOptions()
        {
            string[] options = {"Reset stats", "Go to Main Menu"};
            Helpers.CreateOptions(options);
        }

        public static ConsoleDisplay.View OptionsSelection()
        {
            int userInput = UserInput.OptionSelection();
            switch (userInput)
            {
                case 1:
                    if (Data.ResetStats())
                    {
                        Helpers.HighlightMessage("Stats have been reset");
                    }
                    else
                    {
                        WriteLine("Cancelled reset");
                    }
                    WriteLine("Press any key to continue to main menu.");
                    ReadKey();
                    break;
                case 2:
                    return ConsoleDisplay.View.Main;
                default:
                    WriteLine("Number not assinged to command.");
                    break;
            }
            return ConsoleDisplay.View.Main;
        }
    }
}
