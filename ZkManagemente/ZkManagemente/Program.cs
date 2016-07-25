using log4net;
using System;
using System.IO;
using System.Windows.Forms;

namespace ZkManagement
{
    static class Program
    {
        static public ILog log = LogManager.GetLogger("Local");

        static void Log4Net_Log()
        {
            FileInfo fi = new FileInfo("log4net.xml");
            log4net.Config.XmlConfigurator.Configure(fi);
            GlobalContext.Properties["host"] = Environment.MachineName;

        }

        [STAThread]
        static void Main()
        {
            Log4Net_Log();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interfaz.Login());
        }
    }
}
