using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Entity
{
    public class Library
    {
        /// <summary>
        /// Id: Primary key (khóa chính, không được NULL)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tên thư viện
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Mã code thư viện, dùng để dễ quản lý
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Trạng thái: Active/Inactive
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Hàm dùng để hiển thị chính xác tên của Library trên giao diện
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
