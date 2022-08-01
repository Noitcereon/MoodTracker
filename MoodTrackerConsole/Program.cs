using NLog;
using NLog.Targets;
using System;

namespace MoodTrackerConsole
{
    class Program
    {
        static void Main()
        {
            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var fullLogFile = new FileTarget("fullFileLog") { FileName = "fullLog.log" };
            var errorLog = new FileTarget("errorFileLog") { FileName = "error.log" };
            var logconsole = new ConsoleTarget("logconsole");

            // Rules for mapping loggers to targets
            config.AddRule(LogLevel.Error, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, fullLogFile);
            config.AddRule(LogLevel.Warn, LogLevel.Fatal, errorLog);

            // Apply config           
            LogManager.Configuration = config;

            ILogger logger = LogManager.GetCurrentClassLogger();

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
