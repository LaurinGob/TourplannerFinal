using log4net;
using System.IO;

namespace Tourplanner.Logging
{
    public class Log4NetLogger : ILogItem
    {
        private static ILog logitem => LogManager.GetLogger("Tourplanner");

        public Log4NetLogger(FileInfo configFile)
        {
            if (!File.Exists(configFile.FullName)) throw new FileNotFoundException($"No config file found at {configFile.FullName}");

            log4net.Config.XmlConfigurator.Configure(configFile);
        }

        public void Info(string message)
        {
            logitem.Info(message);
        }

        public void Warn(string message)
        {
            logitem.Warn(message);
        }

        public void Error(string message)
        {
            logitem.Error(message);
        }
    }
}
