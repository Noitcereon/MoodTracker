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
        private static readonly Concurrency Concurrency = new Concurrency();
        private static readonly List<IDay> Days = Concurrency.LoadDaysFromJson();
        // this class should take data and make stats out of it, so it can be used in the application.

        public List<IDay> GetDays()
        {
            return Days;
        }

        public bool AddDay(IDay day)
        {
            try
            {
                RemoveOldEntryIfTheSameDay();
                bool success = false;
                int beforeAdd = Days.Count;
                Days.Add(day);

                // TODO: Save to file
                Concurrency.SaveDaysToJson(Days);
                if (beforeAdd < Days.Count) success = true;
                return success;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }
        }

        public void RemoveLastDayEntry()
        {
            Days.RemoveAt(Days.Count-1);
        }

        public bool RemoveOldEntryIfTheSameDay()
        {
            IDay oldDay = Days.Find(x => PIHelpers.IsToday(x.Date));
            return oldDay == null || Days.Remove(oldDay);
        }

        
    }
}
