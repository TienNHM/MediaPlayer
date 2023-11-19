using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Utils
{
    public static class CodeUtils
    {
        public static string GenCode()
        {
            return DateTime.UtcNow.ToString("yyyyMMddhhmmssffffff");
        }
    }
}
