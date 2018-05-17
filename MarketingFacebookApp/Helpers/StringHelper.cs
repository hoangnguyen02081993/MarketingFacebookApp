using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Helpers
{
    public static class StringHelper
    {
        public static string StringEndcoder(this string input)
        {
            string result = string.Empty;

            result += "ps";

            for (int i = 0; i < input.Length; i++)
            {
                char tmp = input.Substring(i, 1).ToCharArray()[0];
                result += (char)((tmp * 3 - 50) / 2 + 128);
                result += (char)((tmp * 4 - 50) / 2 + 64);
                result += (char)((tmp >= 128) ? tmp - 128 : tmp + 128);
            }
            return result;
        }
        public static string StringDecoder(this string input)
        {
            string result = string.Empty;

            for (int i = 0; i < (input.Length - 2) / 3; i++)
            {
                char tmp = input.Substring(2 + i * 3, 3).ToCharArray()[2];
                result += (char)((tmp >= 128) ? tmp - 128 : tmp + 128);
            }
            return result;
        }
    }
}
