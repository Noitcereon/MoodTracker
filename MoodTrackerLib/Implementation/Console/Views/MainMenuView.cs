using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static MoodTrackerLib.Implementation.Console.ConsoleDisplay;

namespace MoodTrackerLib.Implementation.Console.Views
{
    public static class MainMenuView
    {
        public static void ShowMainMenu()
        {
            Helpers.HighlightMessage("Main Menu");
            WriteLine($"{Environment.NewLine} " +
                      "Enter a number to select command. ");

            Helpers.CreateOptions(Enum.GetNames(typeof(View)));

            WriteLine();
        }
        public static View MainMenuSelection(int viewEnumIndex)
        {
            View selectedView = (View)viewEnumIndex;
            switch (selectedView)
            {
                case View.Main:
                    ShowMainMenu();
                    break;
                case View.Stats:
                    StatsView.ShowStats();
                    break;
                case View.AddDay:
                    AddDayView.ShowAddDay();
                    break;
                case View.Options:
                    OptionsView.ShowOptions();
                    break;
                case View.Exit:
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("That number is not assigned to a command. Try again.\n");
                    selectedView = MainMenuSelection(UserInput.OptionSelection());
                    break;
            }
            return selectedView;
        }
    }
}
