using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Utils
{
    public static class CodeUtils
    {
        /// <summary>
        /// Hàm dùng để sinh ra mã code, dựa vào thời điểm đang thực thi
        /// </summary>
        /// <returns></returns>
        public static string GenCode()
        {
            return DateTime.UtcNow.ToString("yyyyMMddhhmmssffffff");
        }
    }
}
