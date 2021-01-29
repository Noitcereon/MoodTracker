using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackerLib.Implementation
{
    // PIHelpers = Platform Independent Helpers
    public static class PIHelpers
    {
        public static bool IsToday(DateTimeOffset date)
        {
            return date.ToString("d").Equals(DateTime.Today.ToShortDateString());
        }
    }
}
