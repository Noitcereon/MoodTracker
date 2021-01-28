using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;

namespace MoodTrackerLib.Implementation
{
    public class DataAccess
    {
        private static readonly List<IDay> Days = LoadDays();
        // this class should take data and make stats out of it, so it can be used in the application.

        private static List<IDay> LoadDays()
        {
            // TODO: Load stats from json file.
            List<IDay> output = new List<IDay>();
            return output;
        }

        public List<IDay> GetDays()
        {
            return Days;
        }

        public bool AddDay(IDay day)
        {
            bool success = false;
            int beforeAdd = Days.Count;
            Days.Add(day);
            if (beforeAdd < Days.Count) success = true;
            return success;
        }

        public void RemoveLastDayEntry()
        {
            Days.RemoveAt(Days.Count-1);
        }
    }
}
