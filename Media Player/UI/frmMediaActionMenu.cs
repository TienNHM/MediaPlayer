using Media_Player.Constants;
using Media_Player.Data;
using Media_Player.Entity;
using Media_Player.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class frmMediaActionMenu : Form
    {
        private LinkedList<Library> libraries;
        public LinkedList<Library> AllLibraries
        {
            get => this.libraries;
            set {
                this.libraries = value;
                this.selectLibrary.DataSource = value.ToList();
            }
        }

        /// <summary>
        /// Thông tin bài hát đang được chọn
        /// </summary>
        public Media SelectedMedia { get; set; }

        private bool isShowSelectLibrary = false;
        private LibraryInfoDB _libraryInfoDB { get; set; }
        private LibraryDB _libraryDB { get; set; }

        public MediaAction SelectedAction { get; set; }
        public frmMediaActionMenu()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            this._libraryInfoDB = new LibraryInfoDB();
            this._libraryDB = new LibraryDB();
        }

        private void btnAddFav_Click(object sender, EventArgs e)
        {
            this.isShowSelectLibrary = !this.isShowSelectLibrary;
            this.panelSelectLibrary.Visible = this.isShowSelectLibrary;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Hàm xử lý cho nút OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Lấy ra thông tin library đang được chọn
            var library = this.selectLibrary.SelectedItem as Library;

            // Tạo mới 1 thông tin libraryInfo: cho biết thư viện library nào đang chứa bài hát được chọn
            LibraryInfo libraryInfo = new LibraryInfo()
            {
                LibraryCode = library.Code,
                MediaCode = SelectedMedia.Code,
                Status = Status.Active
            };
            
            _libraryInfoDB.Create(libraryInfo);

            // Hiển thị thông báo
            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Hàm xử lý khi bấm nút xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Lấy danh sách tất cả libraries đang có
            var libraries = _libraryDB.GetAllLibrariesByMediaCode(this.SelectedMedia.Code);

            // Tạo mới form, truyền data ngay khi khởi tạo
            frmPlaylistRemoveMedia frmPlaylistRemoveMedia = new frmPlaylistRemoveMedia()
            {
                Media = SelectedMedia
            };
            // gán thông tin DataSource cho giao diện, để hiển thị ngay khi form vừa mở lên
            frmPlaylistRemoveMedia.listBoxLibrary.DataSource = libraries.ToList();
            
            frmPlaylistRemoveMedia.ShowDialog();
        }
    }

    public enum MediaAction
    {
        AddToFavorite,
        RemoveMedia
    }
}
