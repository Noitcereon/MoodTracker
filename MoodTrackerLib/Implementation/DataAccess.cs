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
using NLog;

namespace MoodTrackerLib.Implementation
{
    /// <summary>
    /// Retrieves, adds, (updates) and removes data.
    /// </summary>
    public class DataAccess
    {
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        private static List<IDay> _days = JsonData.LoadDaysFromJson();

        public List<IDay> GetDays()
        {
            return _days;
        }

        public bool AddDay(IDay day)
        {
            try
            {
                _logger.Debug("Attempting to add Day: {day}", day);
                RemoveOldEntryIfTheSameDay();

                bool success = false;
                int beforeAdd = _days.Count;
                _days.Add(day);

                JsonData.SaveDaysToJson(_days);
                if (beforeAdd < _days.Count) success = true;
                return success;
            }
            catch
            {
                _logger.Fatal("An error occurred while trying to Add Day. \n" +
                                         "Program will now crash... \n");
                                         
                // BUG: application crashes if moodStats.json has not been created. (should be fixed now, but leaving it here for now.)
                System.Console.WriteLine();
                Thread.Sleep(5000);
                throw;
            }
            finally
            {
                LogManager.Shutdown();
            }
        }

        public void RemoveLastDayEntry()
        {
            _logger.Debug("RemoveLastDayEntry() called.");
            _days.RemoveAt(_days.Count-1);
        }

        public bool RemoveOldEntryIfTheSameDay()
        {
            _logger.Debug("RemoveOldEntryIfTheSameDay() called");
            IDay oldDay = _days.Find(x => PIHelpers.IsToday(x.Date));
            return oldDay == null || _days.Remove(oldDay);
        }

        public bool ResetStats()
        {
            _logger.Debug("ResetStats() called. Awaiting confirmation from user");
            bool willReset = UserInput.Confirmation();
            if (willReset)
            {
                _logger.Debug("Resetting stats");
                JsonData.BackupOldData(_days);
                _days = new List<IDay>();
                JsonData.SaveDaysToJson(_days);
            }

            return willReset;
        }
    }
}
