using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console.Views
{
    public class AddDayView
    {
        private static readonly DataAccess DataAccess = new DataAccess();

        public static void ShowAddDay()
        {
            List<IDay> days = DataAccess.GetDays();
            Helpers.HighlightMessage("Add Day");
            WriteLine($"Current date: { DateTime.Now.Date:d}");
            if (days.Count > 0) WriteLine($"Last day added on: {days.Last().Date:d}");
            WriteLine();
            Helpers.CreateOptions(Enum.GetNames(typeof(Day.DayMood)), "Main Menu", "Add on different date");
            WriteLine();
        }

        public static ConsoleDisplay.View AddDaySelection()
        {
            int userInput = UserInput.OptionSelection();
            bool success = false;
            switch (userInput)
            {
                case 1:
                    success = DataAccess.AddDay(new Day(10));
                    DayAddedMsg(Day.DayMood.Excellent, success);
                    break;
                case 2:
                    success = DataAccess.AddDay(new Day(7.5));
                    DayAddedMsg(Day.DayMood.Good, success);
                    break;
                case 3:
                    success = DataAccess.AddDay(new Day(5));
                    DayAddedMsg(Day.DayMood.Decent, success);
                    break;
                case 4:
                    success = DataAccess.AddDay(new Day(3.5));
                    DayAddedMsg(Day.DayMood.Meh, success);
                    break;
                case 5:
                    success = DataAccess.AddDay(new Day(1));
                    DayAddedMsg(Day.DayMood.Bad, success);
                    break;
                case 6:
                    return ConsoleDisplay.View.Main;
                case 7:
                    AddOnDifferentDate();
                    break;
                default:
                    WriteLine("Invalid input for AddDay, try again.");
                    AddDaySelection();
                    break;
            }

            return ConsoleDisplay.View.Main;
        }

        private static void DayAddedMsg(Day.DayMood mood, bool dayWasAdded)
        {
            if (dayWasAdded)
            {
                WriteLine($"{mood} day added.");
            }
            WriteLine($"Press any key redirect to continue (redirect to main menu.)");
            ReadKey();
        }

        private static void AddOnDifferentDate()
        {
            // TODO: This method really ought to have some testing, so it should be public. Therefore it should be in another file, but which? :thinking:
            // Maybe some kind of ViewModel for the AddDayView? Or AddDayViewHelpers?
            try
            {
                WriteLine();
                WriteLine("Enter a date in this format: dd-mm");
                WriteLine($"Example: 12-12 = 12th of December {DateTime.Now.Year}");
                WriteLine("Enter '1' to cancel");

                string userInput = ReadLine();

                if (userInput.Equals("1")) return;

                string[] dateArray = userInput.Split("-");
                DateTimeOffset date = new DateTimeOffset(DateTime.Today.Year, Convert.ToInt16(dateArray[1]),
                    Convert.ToInt16(dateArray[0]), 0, 0, 0, TimeSpan.Zero);
                if (date.Date >= DateTime.Today.AddDays(1))
                {
                    throw new Exception("Attempted to add on a future date.");
                }
                
                WriteLine("How good was the day between 1 and 10?");
                IDay day = new Day(date, Convert.ToDouble(ReadLine()));
                bool success = DataAccess.AddDay(day);
                DayAddedMsg(day.Mood, success);
            }
            catch (Exception e)
            {
                WriteLine($"Invalid input: {e.Message}");
                WriteLine("Press any key to continue...");
                ReadKey();
                Clear();
                AddOnDifferentDate();
            }
        }
    }
}
