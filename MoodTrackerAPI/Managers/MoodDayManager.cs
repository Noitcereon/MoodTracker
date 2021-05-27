using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoodTrackerLib.Implementation;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;

namespace MoodTrackerAPI.Managers
{
    public class MoodDayManager
    {
        private readonly DataAccess _db = new DataAccess();

        public ICollection<IDay> GetAll()
        {
            return _db.GetDays();
        }

        public bool AddDay(IDay day)
        {
            return _db.AddDay(day);
        }

        public void RemoveLastEntry()
        {
            _db.RemoveLastDayEntry();
        }
    }
}
