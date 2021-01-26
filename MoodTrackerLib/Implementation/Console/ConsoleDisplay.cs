using System;

namespace MoodTrackerLib.Implementation.Console
{
    public class ConsoleDisplay : BaseDisplay
    {
        public enum View
        {
            Main = 1, Stats, AddDay, Options
        }

        public override void StartUp()
        {
            Helpers.HighlightMessage("Mood Tracker by Noitcereon");

            ViewHandler.ShowMainMenu();

            while (true)
            {
                SwitchView(UserInput.ViewSelection());
            }
        }

        public static void SwitchView(View selectedView)
        {
            switch (selectedView)
            {
                case View.Main:
                    System.Console.Clear();
                    ViewHandler.ShowMainMenu();
                    return;
                case View.Stats:
                    System.Console.Clear();
                    ViewHandler.ShowStats();
                    return;
                case View.AddDay:
                    System.Console.Clear();
                    ViewHandler.ShowAddDay();
                    return;
                case View.Options:
                    System.Console.Clear();
                    ViewHandler.ShowOptions();
                    return;
                default:
                    System.Console.WriteLine("That number is not assigned to a command. Try again.\n");
                    SwitchView(UserInput.ViewSelection());
                    break;
            }
        }
    }
}
