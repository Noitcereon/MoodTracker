using System;

namespace MoodTrackerConsole
{
    class Program
    {
        static void Main()
        {
            NLog.ILogger logger = NLog.LogManager.GetCurrentClassLogger();
            try
            {
                logger.Debug("NLog Initialized");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Worker worker = new ();
            worker.Start();
        }
    }
}
