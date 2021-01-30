using System;
using MoodTrackerLib.Implementation.Console.Views;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console
{
    public class ConsoleDisplay : BaseDisplay
    {
        public enum View { Main = 1, Stats, AddDay, Options }

        private static View _currentView;
        private readonly AddDayView _addDayView = new AddDayView();

        public override void StartUp()
        {
            Title = "Mood Tracker by Noitcereon";
            MainMenuView.ShowMainMenu();
            _currentView = MainMenuView.MainMenuSelection(UserInput.OptionSelection());

            AppLoop();
        }

        public override void Shutdown()
        {
            // Save stats to json file and other stuff?
        }

        private void AppLoop()
        {
            while (true)
            {
                Clear();
                switch (_currentView)
                {
                    case View.Main:
                        MainMenuView.ShowMainMenu();
                        _currentView = MainMenuView.MainMenuSelection(UserInput.OptionSelection());
                        break;
                    case View.Stats:
                        StatsView.ShowStats();
                        _currentView = StatsView.StatsSelection();
                        break;
                    case View.AddDay:
                        AddDayView.ShowAddDay();
                        _currentView = _addDayView.AddDaySelection();
                        break;
                    case View.Options:
                        OptionsView.ShowOptions();;
                        _currentView = OptionsView.OptionsSelection();
                        break;
                    default:
                        WriteLine("Invalid input.");
                        MainMenuView.MainMenuSelection(UserInput.OptionSelection());
                        break;
                }
            }
        }

        
    }
}
