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
            System.Console.WriteLine("----- Mood Tracker by Noitcereon -----");

            ViewHandler.ShowMainMenu();

            SwitchView(UserInput.ViewSelection());
        }

        public void SwitchView(View selectedView)
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
                    throw new ArgumentOutOfRangeException(nameof(selectedView), selectedView, null);
            }
        }
    }
}
