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

        public static void LogInfo(string message)
        {
            Log.Info(message);
        }
        public static void LogError(string message)
        {
            Log.Error(message);
        }

        public static void LogFatal(string message)
        {
            Log.Fatal(message);
        }
    }
}
