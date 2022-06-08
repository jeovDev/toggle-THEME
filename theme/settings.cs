using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace theme
{
    class settings
    {
        public string iniPath = Application.StartupPath + @"\config.ini";
        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(String secionName, String keyName, string Default, StringBuilder returnedString, int size, string filename);
        [DllImport("Kernel32")]
        private static extern long WritePrivateProfileString(String section, string keyname, string value, string path);

        public StringBuilder sbtheme;
        public string theme{ get; set; }

        public void readIni() {

            int resultSize;
            sbtheme = new StringBuilder(10);
            resultSize = GetPrivateProfileString("SECTION", "key","",sbtheme,sbtheme.Capacity,iniPath);
            this.theme = sbtheme.ToString();
        }
        public void writeIni(string section,string key,string value) {
            WritePrivateProfileString(section,key,value,iniPath);
        }
    }
}
