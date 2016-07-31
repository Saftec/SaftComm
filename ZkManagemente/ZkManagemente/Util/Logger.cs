using log4net;
using System;
using System.Diagnostics;

namespace ZkManagement.Util
{
    public static class Logger
    {
            #region Fields

            private static readonly ILog mLog = LogManager.GetLogger(typeof(Logger));

            #endregion Fields

            #region Constructor

            static Logger()
            {
                Debug.WriteLine("Server Logger initializing...");

                log4net.Config.XmlConfigurator.Configure();

                if (mLog != null)
                {
                    Debug.WriteLine("Server Logger initialized");
                    Debug.WriteLine(string.Format("Debug: {0}, Error: {1}, Info: {2}, Warning {3}", mLog.IsDebugEnabled, mLog.IsErrorEnabled, mLog.IsInfoEnabled, mLog.IsWarnEnabled));
                }
                else
                {
                    Debug.WriteLine("Failed initializing Server Logger");
                }
            }

            #endregion Constructor

            #region Public Methods

            public static void PublishException(Exception exception)
            {
                if (mLog != null)
                    mLog.Error("Exception", exception);
            }

            public static void WriteVerbose(string category, string message)
            {
                if (mLog != null)
                    mLog.Debug(FormatMessage(category, message));
            }

            public static void WriteInfo(string category, string message)
            {
                if (mLog != null)
                    mLog.Info(FormatMessage(category, message));
            }

            public static void WriteWarning(string category, string message)
            {
                if (mLog != null)
                    mLog.Warn(FormatMessage(category, message));
            }

            public static void TraceError(string category, string message)
            {
                if (mLog != null)
                    mLog.Error(FormatMessage(category, message));
            }

            public static void Write(TraceLevel level, string category, string message)
            {
                switch (level)
                {
                    case TraceLevel.Verbose:
                        WriteVerbose(category, message);
                        break;
                    case TraceLevel.Info:
                        WriteInfo(category, message);
                        break;
                    case TraceLevel.Warning:
                        WriteWarning(category, message);
                        break;
                    case TraceLevel.Error:
                        TraceError(category, message);
                        break;
                }
            }

            #endregion Public Methods

            #region Private Methods

            private const string MessageFormat = "{0} | {1}";
            private const int MaxCategoryNameLength = 25;

            private static string FormatMessage(string category, string message)
            {
                string output = string.Format(MessageFormat, FormatName(category,
    MaxCategoryNameLength), message);
                return output;
            }

            private static string FormatName(string name, int minLength)
            {
                string result;
                string trimName = name != null ? name.Trim() : string.Empty;
                if (trimName.Length >= minLength)
                    result = trimName;
                else
                    result = trimName.PadRight(minLength);
                return result;
            }
            #endregion Private Methods
        }
    }

