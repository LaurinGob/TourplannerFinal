namespace Tourplanner.Logging
{
    // provides log class for single log message
    public class Log
    {
        private static ILogItem item;

        static Log()
        {
            item = LoggerFactory.GetDefaultLogger(); // gets logger via factory patterned logger
        }

        public static void Info(string message)
        {
            item.Info(message);
        }

        public static void Warn(string message)
        {
            item.Warn(message);
        }

        public static void Error(string message)
        {
            item.Error(message);
        }
    }
}
