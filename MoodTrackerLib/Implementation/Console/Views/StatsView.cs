﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;
using static System.Console;

namespace MoodTrackerLib.Implementation.Console.Views
{
    public static class StatsView
    {
        private static readonly DataAccess Data = new DataAccess();

        public static void ShowStats()
        {
            Helpers.HighlightMessage("Stats");
            List<IDay> days = Data.GetDays();
            WriteLine($"Total day entries: {days.Count}");
            WriteLine($"Average day: {days.Average(x => x.Points)} (based on a 1 to 10 point system)");
            WriteLine($"Excellent days: {days.Count(x => x.Mood == Day.DayMood.Excellent)}");
            WriteLine($"Good days: {days.Count(x => x.Mood == Day.DayMood.Good)}");
            WriteLine($"Decent days: {days.Count(x => x.Mood == Day.DayMood.Decent)}");
            WriteLine($"Meh days: {days.Count(x => x.Mood == Day.DayMood.Meh)}");
            WriteLine($"Bad days: {days.Count(x => x.Mood == Day.DayMood.Bad)}");
            WriteLine();
            WriteLine("Enter '1' to return to main menu.");
        }

        public static ConsoleDisplay.View StatsSelection()
        {
            return UserInput.OptionSelection() == 1 ? ConsoleDisplay.View.Main : ConsoleDisplay.View.Stats;
        }
    }
}
