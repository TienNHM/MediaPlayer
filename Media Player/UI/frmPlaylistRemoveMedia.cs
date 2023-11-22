using Media_Player.Data;
using Media_Player.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player.UI
{
    public partial class frmPlaylistRemoveMedia : Form
    {
        public Media Media { get; set; }
        private LibraryInfoDB _libraryInfoDB = new LibraryInfoDB();
        private LibraryDB _libraryDB = new LibraryDB();
        public frmPlaylistRemoveMedia()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lấy tất cả thư viện đang có
        /// </summary>
        public void LoadData()
        {
            var libraries = _libraryDB.GetAllLibrariesByMediaCode(this.Media.Code);
            this.listBoxLibrary.DataSource = libraries.ToList();
        }

        /// <summary>
        /// Hàm xử lý khi bấm nút Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Lấy thông tin library đang được chọn
            var library = this.listBoxLibrary.SelectedItem as Library;

            // Gọi hàm xử lý xóa bài hát khỏi danh sách
            _libraryInfoDB.RemoveMedia(library.Code, Media.Code);

            // Hiện thông báo
            MessageBox.Show($"Đã xóa bài hát {Media.Name} khỏi danh sách {library.Name} thành công",
                "Thông báo",
                MessageBoxButtons.OK);

            // Load lại danh sách
            LoadData();
        }
    }
}
