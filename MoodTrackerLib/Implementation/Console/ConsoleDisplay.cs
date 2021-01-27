using System;
using System.Net.Mime;
using MoodTrackerLib.Implementation.Console.ViewModels;
using MoodTrackerLib.Implementation.Console.Views;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console
{
    public class ConsoleDisplay : BaseDisplay
    {
        public enum View { Main = 1, Stats, AddDay, Options }

        private static View _currentView;

        public override void StartUp()
        {
            Title = "Mood Tracker";
            Helpers.HighlightMessage("Mood Tracker by Noitcereon");

            MainMenuView.ShowMainMenu();
            _currentView = MainMenuViewModel.MainMenuSelection(UserInput.OptionSelection());

            AppLoop();
        }

        public override void Shutdown()
        {
            // Save days stats to json file and other stuff?
        }

        public static void AppLoop()
        {
            while (true)
            {
                Clear();
                switch (_currentView)
                {
                    case View.Main:
                        MainMenuView.ShowMainMenu();
                        _currentView = MainMenuViewModel.MainMenuSelection(UserInput.OptionSelection());
                        break;
                    case View.Stats:
                        StatsView.ShowStats();
                        StatsViewModel.StatsSelection();
                        break;
                    case View.AddDay:
                        AddDayView.ShowAddDay();
                        AddDayViewModel.AddDaySelection();
                        break;
                    case View.Options:
                        OptionsView.ShowOptions();;
                        //OptionsVM.OptionsSelection();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        
    }
}
