using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodTrackerLib.Implementation.Console.ConsoleDisplay;
using static MoodTrackerLib.Implementation.Console.Views.MainMenuView;
using static MoodTrackerLib.Implementation.Console.Views.StatsView;
using static MoodTrackerLib.Implementation.Console.Views.OptionsView;
using static MoodTrackerLib.Implementation.Console.Views.AddDayView;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console.ViewModels
{
    public class MainMenuViewModel
    {
        public static View MainMenuSelection(int viewEnumIndex)
        {
            View selectedView = (View)viewEnumIndex;
            switch (selectedView)
            {
                case View.Main:
                    ShowMainMenu();
                    break;
                case View.Stats:
                    ShowStats();
                    break;
                case View.AddDay:
                    ShowAddDay();
                    break;
                case View.Options:
                    ShowOptions();
                    break;
                default:
                    WriteLine("That number is not assigned to a command. Try again.\n");
                    MainMenuSelection(UserInput.OptionSelection());
                    break;
            }
            return selectedView;
        }
    }
}
