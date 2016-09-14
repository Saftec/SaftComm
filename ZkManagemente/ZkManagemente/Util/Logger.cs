using log4net;

namespace ZkManagement.Util
{
    class Logger
    {
        private static ILog error_logger=null;
        private static ILog info_logger=null;

        public static ILog GetErrorLogger()
        {
            if (error_logger == null)
            {
                error_logger = LogManager.GetLogger("FileAppender");
            }
            return error_logger;
        }

        public static ILog GetInfoLogger()
        {
            if (info_logger == null)
            {
                info_logger = LogManager.GetLogger("InfoAppender");
            }
            return info_logger;
        }
    }
}
