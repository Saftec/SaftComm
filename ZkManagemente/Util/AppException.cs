using System;

namespace Util
{
    public class AppException:Exception
    {
        private Exception _ex;

        public Exception Ex
        {
            get { return _ex; }
        }
        public AppException (string message): base(message)
        {

        }

        public AppException()
        {

        }

        public AppException(string message, string level, Exception ex) : base(message, ex)
        {
            _ex = ex;
            ExType type = (ExType)Enum.Parse(typeof(ExType), level);
            switch (type)
            {
                case ExType.Error:
                    Logger.LogInfo("MESSAGE: " + ex.Message + "\n *-*-*-*-*- \nSTACK TRACE: " + ex.StackTrace);
                    break;
                case ExType.Fatal:
                    Logger.LogFatal("MESSAGE: " + ex.Message + "\n *-*-*-*-*- \nSTACK TRACE: " + ex.StackTrace);
                    break;
            }
        }

        public enum ExType
        {
            Error,
            Fatal
        }
    }
}
