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
    public partial class frmLibraryManagement : Form
    {
        private LibraryDB LibraryDB = new LibraryDB();
        public frmLibraryManagement()
        {
            InitializeComponent();
            LoadData();
        }

        /// <summary>
        /// Lấy tất cả các thư viện đang có
        /// </summary>
        private void LoadData()
        {
            var data = LibraryDB.GetAll();
            this.listBoxLibrary.DataSource = data.ToList();
        }

        /// <summary>
        /// Hàm xử lý cho nút Xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Lấy ra thông tin library nào đang được chọn
            var selectedLibrary = this.listBoxLibrary.SelectedItem as Library;

            if (selectedLibrary is null)
            {
                return;
            }

            var dialog = MessageBox.Show($"Bạn có muốn xóa bỏ playlist {selectedLibrary.Name} và tất cả bài hát có trong playlist này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                // Gọi hàm xóa dữ liệu trong database
                var re = LibraryDB.Delete(selectedLibrary);
                if (re > 0)
                {
                    MessageBox.Show($"Đã xóa thành công playlist {selectedLibrary.Name} và tất cả bài hát có trong playlist này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            // Cập nhật lại giao diện sau khi xóa 1 library
            LoadData();
        }
    }
}
