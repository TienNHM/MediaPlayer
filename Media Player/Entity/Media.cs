using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Entity
{
    public class Media
    {
        /// <summary>
        /// Khóa chính, đánh theo số thứ tự
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mã bài hát
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên video/bài hát
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Đường dẫn đến file
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Loại media: Video/Music
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Trạng thái: Active/Deactive
        /// </summary>
        public string Status {  get; set; }


        /// <summary>
        /// Hàm dùng để hiển thị chính xác thông tin (tên) bài hát lên giao diện
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// So sánh media1 và media2, không phân biệt chữ hoa/chữ thường
        /// </summary>
        /// <param name="media1"></param>
        /// <param name="media2"></param>
        /// <returns>
        /// value < 0 nếu media1.Name < media2.Name
        /// value = 0 nếu media1.Name = media2.Name
        /// value > 0 nếu media1.Name > media2.Name
        /// </returns>
        public static int SoSanh(Media media1, Media media2)
        {
            return String.Compare(media1.Name, media2.Name, ignoreCase: true);
        }
    }
}
