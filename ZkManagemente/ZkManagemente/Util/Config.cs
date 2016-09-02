using System.Configuration;
using System.Runtime.InteropServices;
using System.Text;


namespace ZkManagement.Util
{
    class Config
    {
        private static Config _config;
        private string filePath = ConfigurationManager.AppSettings["Path"].ToString() + @"\exportar.ini";

        public static Config Instance()  // PATRON SINGLETON!
        {
            if (_config == null)
                _config = new Config();

            return _config;
        }             
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
        string key,
        string val,
        string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
        string key,
        string def,
        StringBuilder retVal,
        int size,
        string filePath);

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value.ToLower(), filePath);            
        }

        public string Read(string section, string key)
        {
            StringBuilder SB = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", SB, 255, filePath);
            return SB.ToString();
        }


    }
}
