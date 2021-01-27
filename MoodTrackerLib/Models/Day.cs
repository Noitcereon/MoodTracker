﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodTrackerLib.Interfaces;

namespace MoodTrackerLib.Models
{
    public class Day : IDay
    {
        public enum DayMood { Excellent = 1, Good, Decent, Meh, Bad }

        private double _points;

        public DateTimeOffset Date { get; set; }

        public double Points
        {
            get => _points;
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _points = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(paramName: $"_points");
                }
            }
        }

        public DayMood Mood { get; }

        public Day() { }

        public Day(double points)
        {
            Date = DateTimeOffset.Now.AddHours(-4);
            Points = points;
            Mood = DetermineMood();

        }
        public Day(DateTimeOffset date, double points)
        {
            Date = date;
            Points = points;
            Mood = DetermineMood();
        }

        public override string ToString()
        {
            return $"{Date.Date}: {Points}";
        }

        private DayMood DetermineMood()
        {
            if (Points >= 8) return DayMood.Excellent;
            if (Points >= 7) return DayMood.Good;
            if (Points >= 4.5) return DayMood.Decent;
            if (Points >= 3) return DayMood.Meh;
            if (Points < 3) return DayMood.Bad;
            
            return DayMood.Decent;
        }
    }
}
