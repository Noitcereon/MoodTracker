using System;
using System.Collections.Generic;
using System.Text;
using MoodTrackerLib.Implementation.Console;
using MoodTrackerLib.Models;

namespace MoodTrackerConsole
{
    public class Worker
    {
        private static readonly ConsoleDisplay Display = new ConsoleDisplay();

        public void Start()
        {
            Display.StartUp();
        }
    }
}
