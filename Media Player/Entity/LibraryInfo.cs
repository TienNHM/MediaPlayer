using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Entity
{
    public class LibraryInfo
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mã code của Library
        /// </summary>
        public string LibraryCode { get; set; }

        /// <summary>
        /// Mã code của bài hát
        /// </summary>
        public string MediaCode { get; set; }
        public string Status {  get; set; }

        /// <summary>
        /// Hàm dùng để hiển thị chính xác thông tin LibraryInfo trên giao diện
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.LibraryCode}_{this.MediaCode}";
        }
    }
}
