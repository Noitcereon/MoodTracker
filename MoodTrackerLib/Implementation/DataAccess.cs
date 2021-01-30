using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodTrackerLib.Implementation.Console;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;

namespace MoodTrackerLib.Implementation
{
    public class DataAccess
    {
        private static List<IDay> _days = Concurrency.LoadDaysFromJson();
        // this class should take data and make stats out of it, so it can be used in the application.

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
            catch (Exception e)
            {
                System.Console.WriteLine(e);
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
