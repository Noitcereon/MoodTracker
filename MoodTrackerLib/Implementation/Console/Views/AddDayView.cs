using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using MoodTrackerLib.Models;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console.Views
{
    public class AddDayView
    {
        private readonly DataAccess DataAccess = new DataAccess();

        public static void ShowAddDay()
        {
            Helpers.HighlightMessage("Add Day");
            WriteLine($"Current date: {DateTime.Now.Date.ToShortDateString()}");
            WriteLine();
            Helpers.CreateOptions(Enum.GetNames(typeof(Day.DayMood)), "Change Date", "Main Menu");

            // TODO: remove below message, when applicable.
            WriteLine("Add Day is still a work-in-progress");
            WriteLine();
        }

        public ConsoleDisplay.View AddDaySelection()
        {
            int userInput = UserInput.OptionSelection();

            switch (userInput)
            {
                case 1:
                    WriteLine("Case 1");
                    DataAccess.AddDay(new Day(10));
                    break;
                case 2:
                    DataAccess.AddDay(new Day(7.5));
                    break;
                case 3:
                    DataAccess.AddDay(new Day(5));
                    break;
                case 4:
                    DataAccess.AddDay(new Day(3.5));
                    break;
                case 5:
                    DataAccess.AddDay(new Day(1));
                    break;
                case 6:
                    // Change date option
                    throw new NotImplementedException();
                case 7:
                    return ConsoleDisplay.View.Main;
                default:
                    WriteLine("Try again.");
                    AddDaySelection();
                    break;
            }

            return ConsoleDisplay.View.AddDay;
        }
    }
}
