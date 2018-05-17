using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Helpers
{
    public class SystemHelper
    {
        public const int INTERNET_OPTION_END_BROWSER_SESSION = 42;

        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookieEx(string lpszUrlName, string lpszCookieName, string lpszCookieData, uint dwFlags, IntPtr dwReserved);
    }
}
