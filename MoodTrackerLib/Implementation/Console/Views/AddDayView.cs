using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console.Views
{
    public static class AddDayView
    {
        public static void ShowAddDay()
        {
            Helpers.HighlightMessage("Add Day");
            WriteLine();
            //Helpers.CreateOptions(Enum.GetNames(typeof(Day.DayType)));
            WriteLine("Add Day is a work-in-progress");
        }
    }
}
