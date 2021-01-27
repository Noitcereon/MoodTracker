using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console.Views
{
    public static class MainMenuView
    {
        public static void ShowMainMenu()
        {
            Helpers.HighlightMessage("Main Menu");
            WriteLine($"{Environment.NewLine} " +
                      "Enter a number to select command. ");

            Helpers.CreateOptions(Enum.GetNames(typeof(ConsoleDisplay.View)));

            WriteLine();
        }
    }
}
