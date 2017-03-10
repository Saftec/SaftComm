using log4net;

namespace Util
{
    public class Logger
    {
        private static ILog _logger;

        private static ILog Log
        {
            get
            {
                if (_logger == null)
                {
                    _logger = LogManager.GetLogger("root");
                }
                return _logger;
            }
        }

        /*public static ILog GetLogger()
        {
            if (_logger == null)
            {
                _logger = LogManager.GetLogger("root");
            }
            return _logger;
        }

        public static ILog GetLogger(string log)
        {
            if (_logger == null)
            {
                _logger = LogManager.GetLogger(log);
            }
            return _logger;
        }*/

        public static void LogInfo(string message)
        {
            Log.Info(message);
        }

        public static void LogFatal(string message)
        {
            Log.Fatal(message);
        }
        /*public static ILog GetInfoLogger()
        {
            if (info_logger == null)
            {
                info_logger = LogManager.GetLogger("info");
            }
            return info_logger;
        }*/
    }
}
