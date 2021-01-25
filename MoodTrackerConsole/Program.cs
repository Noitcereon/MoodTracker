using System;

namespace MoodTrackerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Application!");
            Worker worker = new ();
            worker.Start();

        }
    }
}
