using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Helpers
{
    public static class LogHelper
    {
        public static string DIR = System.Windows.Forms.Application.StartupPath + @"\LogFile\";
        public static string PathFileNameModel = "{0}/LogFile/{1}_{2}.txt";
        public static void WriteLog(this string message, bool IsError = true)
        {
            if (!Directory.Exists(DIR)) Directory.CreateDirectory(DIR);
            string FileName = string.Format(PathFileNameModel, DIR, IsError ? "error" : "info", DateTime.Now.ToString("yyyyMMdd"));
            try
            {
                FileStream fs = File.Open(FileName, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff") + " : " + message);
                sw.Write("\r\n");
                sw.Write("----------------------------------------------------------------------------------------");
                sw.Write("\r\n");
                sw.Dispose();
                fs.Close();
                fs.Dispose();
            }
            catch { }
        }
    }
}
