using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackerLib.Implementation
{
    /// <summary>
    /// PIHelpers = Platform Independent Helpers
    /// </summary>
    public static class PIHelpers
    {
        public static bool IsToday(DateTimeOffset date)
        {
            return date.ToString("d").Equals(DateTime.Today.ToShortDateString());
        }
    }
}
