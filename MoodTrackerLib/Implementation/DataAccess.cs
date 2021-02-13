using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MoodTrackerLib.Implementation.Console;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;

namespace MoodTrackerLib.Implementation
{
    /// <summary>
    /// Retrieves, adds, (updates) and removes data.
    /// </summary>
    public class DataAccess
    {
        private static List<IDay> _days = Concurrency.LoadDaysFromJson();

        public List<IDay> GetDays()
        {
            return _days;
        }

        public bool AddDay(IDay day)
        {
            try
            {
                RemoveOldEntryIfTheSameDay();

                bool success = false;
                int beforeAdd = _days.Count;
                _days.Add(day);

                Concurrency.SaveDaysToJson(_days);
                if (beforeAdd < _days.Count) success = true;
                return success;
            }
            catch
            {
                System.Console.WriteLine("An error occurred while trying to Add Day. \n" +
                                         "Program will now crash... \n");
                                         
                // BUG: application crashes if moodStats.json has not been created. (should be fixed now, but leaving it here for now.)
                System.Console.WriteLine();
                Thread.Sleep(5000);
                throw;
            }
        }

        public void RemoveLastDayEntry()
        {
            _days.RemoveAt(_days.Count-1);
        }

        public bool RemoveOldEntryIfTheSameDay()
        {
            IDay oldDay = _days.Find(x => PIHelpers.IsToday(x.Date));
            return oldDay == null || _days.Remove(oldDay);
        }

        public bool ResetStats()
        {
            bool willReset = UserInput.Confirmation();
            if (willReset)
            {
                Concurrency.BackupOldData(_days);
                _days = new List<IDay>();
                Concurrency.SaveDaysToJson(_days);
            }

            return willReset;
        }
    }
}
