using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodTrackerLib.Interfaces;

namespace MoodTrackerLib.Models
{
    public class Day : IDay
    {
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
        public Day() { }

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
    }
}
