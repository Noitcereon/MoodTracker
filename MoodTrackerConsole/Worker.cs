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
        
        // Needs research.
        // Is it possible to make a method that works as a switch statement with userInput and changing options?
        public void ProgramLoop(string userInput, params string[] options)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
