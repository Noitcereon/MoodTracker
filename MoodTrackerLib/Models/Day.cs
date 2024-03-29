﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodTrackerLib.Interfaces;
using NLog;

namespace MoodTrackerLib.Models
{
    public class Day : IDay
    {
        public enum DayMood { Excellent = 1, Good, Decent, Meh, Bad }
        
        private double _points;
        private static ILogger _logger = LogManager.GetCurrentClassLogger();

        [Required]
        public DateTimeOffset Date { get; set; }

        [Required]
        [Range(1.0, 10.0)]
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
                    _logger.Warn("Invalid value entered for Day._points: {value}. Value should be between 1-10.", value);
                    throw new ArgumentOutOfRangeException(paramName: $"_points");
                }
            }
        }

        public DayMood Mood => DetermineMood();


        public Day()
        {
        }

        public Day(double points)
        {
            Date = DateTimeOffset.Now.AddHours(-4);
            Points = points;
        }
        public Day(DateTimeOffset date, double points)
        {
            Date = date;
            Points = points;
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
