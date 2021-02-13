using System;
using MoodTrackerLib.Implementation.Console.Views;
using MoodTrackerLib.Interfaces;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console
{
    public class ConsoleDisplay : IDisplay
    {
        public enum View { Main = 1, Stats, AddDay, Options, Exit }

        private static View _currentView;

        public void StartUp()
        {
            Title = $"Mood Tracker {ApplicationInfo.Version} by Noitcereon ";
            MainMenuView.ShowMainMenu();
            _currentView = MainMenuView.MainMenuSelection(UserInput.OptionSelection());

            AppLoop();
        }

        public void Shutdown()
        {
            // Save stats to json file and other stuff?
            Environment.Exit(0);
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
                        _currentView = AddDayView.AddDaySelection();
                        break;
                    case View.Options:
                        OptionsView.ShowOptions();
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
