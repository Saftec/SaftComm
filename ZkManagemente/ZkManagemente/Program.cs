using log4net;
using System;
using System.Windows.Forms;

namespace ZkManagement
{
    static class Program
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);    //("Local");

     /*   static void Log4Net_Log()
        {
            FileInfo fi = new FileInfo("log4net.xml");
            log4net.Config.XmlConfigurator.Configure(fi);
            GlobalContext.Properties["host"] = Environment.MachineName;

        } */

        [STAThread]
        static void Main()
        {
          //  Log4Net_Log();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interfaz.Login());
        }
    }
}
