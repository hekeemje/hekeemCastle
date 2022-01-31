using System;
using NLog;

namespace logging_homework
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Info("info message");
        }
    }
}
