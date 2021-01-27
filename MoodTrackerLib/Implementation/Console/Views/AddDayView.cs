using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodTrackerLib.Models;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console.Views
{
    public static class AddDayView
    {
        public static void ShowAddDay()
        {
            Helpers.HighlightMessage("Add Day");
            WriteLine();
            Helpers.CreateOptions(Enum.GetNames(typeof(Day.DayMood)), "Add on a different date");

            // TODO: remove below message, when applicable.
            WriteLine("Add Day is still a work-in-progress");
        }

        public static void AddDaySelection(int numberOfOptions)
        {
            WriteLine("AddDaySelection() called");
            int[] options = new int[numberOfOptions];
            foreach (var option in options)
            {
                switch (options)
                {
                    
                }
            }
        }
    }
}
