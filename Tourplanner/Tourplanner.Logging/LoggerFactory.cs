using System.IO;

namespace Tourplanner.Logging
{
//TODO: Factory pattern anschauen
    public class LoggerFactory
    {
        public static ILogItem GetDefaultLogger()
        {
            return new Log4NetLogger(new FileInfo("./log4net.config"));
        }
    }
}
