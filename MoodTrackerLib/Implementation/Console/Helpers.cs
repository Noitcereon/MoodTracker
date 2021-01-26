using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackerLib.Implementation.Console
{
    public class Helpers
    {
        public static void HighlightMessage(string message)
        {
            System.Console.WriteLine($"--- {message} ---");
        }
    }
}
