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
        private readonly DataAccess _dataAccess = new DataAccess();

        public static void ShowAddDay()
        {
            Helpers.HighlightMessage("Add Day");
            WriteLine($"Current date: {DateTime.Now.Date.ToShortDateString()}");
            WriteLine();
            Helpers.CreateOptions(Enum.GetNames(typeof(Day.DayMood)), "Change Date", "Main Menu");
            WriteLine();
        }

        public ConsoleDisplay.View AddDaySelection()
        {
            int userInput = UserInput.OptionSelection();

            switch (userInput)
            {
                case 1:
                    _dataAccess.AddDay(new Day(10));
                    DayAddedMsg(Day.DayMood.Excellent);
                    break;
                case 2:
                    _dataAccess.AddDay(new Day(7.5));
                    DayAddedMsg(Day.DayMood.Good);
                    break;
                case 3:
                    _dataAccess.AddDay(new Day(5));
                    DayAddedMsg(Day.DayMood.Decent);
                    break;
                case 4:
                    _dataAccess.AddDay(new Day(3.5));
                    DayAddedMsg(Day.DayMood.Meh);
                    break;
                case 5:
                    _dataAccess.AddDay(new Day(1));
                    DayAddedMsg(Day.DayMood.Bad);
                    break;
                case 6:
                    // Change date option
                    _dataAccess.RemoveLastDayEntry(); // temporary, can remove.
                    break;
                    //throw new NotImplementedException();
                case 7:
                    return ConsoleDisplay.View.Main;
                default:
                    WriteLine("Invalid input for AddDay, try again.");
                    AddDaySelection();
                    break;
            }

            return ConsoleDisplay.View.Main;
        }

        private void DayAddedMsg(Day.DayMood mood)
        {
            WriteLine($"{mood} day added. Press any key redirect to continue (redirect to main menu.)");
            ReadKey();
        }
    }
}
