using Media_Player.Constants;
using Media_Player.Data;
using Media_Player.Entity;
using Media_Player.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WMPLib;
using MusicConsts = Media_Player.Constants.MusicExtensionFilterConsts;
using VideoConsts = Media_Player.Constants.VideoExtensionFilterConsts;

namespace Media_Player.UI
{
    public partial class frmMusicPlayer : Form
    {
        private readonly string PLAYLIST = "Media Player";
        IWMPPlaylist playlist;
        private bool isLibraryExpanded = true;
        private bool isFavoriteExpanded = true;
        private bool isPlaying = true;
        private int selectedIndex = 0;
        private MediaDB _mediaDB = new MediaDB();
        private LibraryDB _libraryDB = new LibraryDB();
        private List<Media> listSongData = new List<Media>();
        private LinkedList<Library> AllLibraries = new LinkedList<Library>();

        // Các định dạng file được hỗ trợ
        private List<string> AvailableFileExtensions = new List<string>
        {
            // Music
            MusicConsts.MovingPicturesExpertsGroup,
            MusicConsts.WindowsMediaFormats,
            MusicConsts.AudioWindows,
            MusicConsts.AudioVisualInterleave,
            MusicConsts.Mp4Audio,
            MusicConsts.FreeLosslessAudioCodec,

            // Video
            VideoConsts.Mp4Video,
            VideoConsts.QuickTimeMovie,
            VideoConsts.MovingPicturesExpertsGroup,
        };

        private enum TabMedia
        {
            Music
        }

        public frmMusicPlayer()
        {
            InitializeComponent();
            Init();
            LoadData();
        }

        /// <summary>
        /// Khởi tạo
        /// </summary>
        private void Init()
        {
            this.axWindowsMediaPlayer.uiMode = "none";
            playlist = axWindowsMediaPlayer.playlistCollection.newPlaylist(PLAYLIST);
            this.listSongs.Focus();
        }

        private void LoadData()
        {
            this.LoadLibraries();
            this.LoadMedias();
            this.InitPlaylists();

            // Cập nhật giao diện
            this.UpdateListSongsView();

            // Cập nhật lại playlist đang phát cho axWindowsMediaPlayer
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                this.axWindowsMediaPlayer.currentPlaylist = this.playlist;
                this.listSongs.SelectedIndex = this.listSongData.Any() ? 0 : -1;
            }
        }

        /// <summary>
        /// Load tất cả các thư viện đang hiện có
        /// </summary>
        private void LoadLibraries()
        {
            // Call hàm để query database
            this.AllLibraries = _libraryDB.GetAll();

            // Thêm lib Tất cả vào đầu danh sách
            this.AllLibraries.AddFirst(new Library()
            {
                Code = null,
                Name = "Tất cả",
                Status = Status.Active
            });
            var libraies = this.AllLibraries.ToList();

            // Gán lại DataSource để hiển thị trên giao diện
            this.selectLibrary.DataSource = libraies;
        }

        /// <summary>
        /// Load tất cả các bài hát
        /// </summary>
        private void LoadMedias()
        {
            LinkedList<Media> allMedia = _mediaDB.GetAll();
            this.listSongData = allMedia.Where(x => x.Status == Status.Active).ToList();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            this.isFavoriteExpanded = !this.isFavoriteExpanded;
            this.btnCreateNewLibrary.Visible = this.isFavoriteExpanded;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                ChooseFiles();

                // Update playlist dang phat
                this.tabLibrary.SelectedIndex = (int)TabMedia.Music;
                this.axWindowsMediaPlayer.currentPlaylist = playlist;

                // Update giao diện hiển thị
                if (this.listSongs.Items.Count > 0)
                {
                    this.listSongs.SelectedIndex = 0;
                    this.selectedIndex = 0;
                    this.btnRemove.Enabled = true;
                }
            }

            // Update icon playing
            this.isPlaying = true;
            this.PlayingStateChange();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.playlist.count <= 0 || this.listSongs.Items.Count <= 0)
            {
                return;
            }

            if (tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                int selectedIndex = this.listSongs.SelectedIndex;
                Media selectedItem = this.listSongs.SelectedItem as Media;

                string message = $"Bạn có muốn xóa bỏ bài hát *{selectedItem.Name}* không?";
                var dialogResult = MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                this.listSongData.Remove(selectedItem);
                this.playlist.removeItem(this.playlist.Item[selectedIndex]);

                this._mediaDB.Delete(selectedItem);

                this.UpdateListSongsView();

                this.listSongs.SelectedIndex = Math.Min(selectedIndex, this.listSongData.Count - 1);
                if (this.listSongData.Count == 0)
                {
                    this.labeMediaName.Text = "";
                    this.btnRemove.Enabled = false;
                }
            }

            this.axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void btnFavVideos_Click(object sender, EventArgs e)
        {

        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            this.isLibraryExpanded = !this.isLibraryExpanded;

            this.btnAdd.Visible = this.isLibraryExpanded;
            this.btnRemove.Visible = this.isLibraryExpanded;
            this.btnSortAsc.Visible = this.isLibraryExpanded;
            this.btnSortDesc.Visible = this.isLibraryExpanded;
        }

        private void LoadMediaInPlayListForTabLayout()
        {
            this.txtSearch.Text = "";
            LinkedList<Media> listMedia = new LinkedList<Media>();

            int selectedTabIndex = this.tabLibrary.SelectedIndex;
            if (selectedTabIndex == 0)
            {
                listMedia = _mediaDB.GetAll();
                this.btnAdd.Visible = true;
                this.btnRemove.Visible = true;
                this.listSongs.SelectedIndex = 0;
            }
            else
            {
                var selectedTab = this.tabLibrary.SelectedTab;
                var libraryCode = selectedTab.Name.Split('_')[1];
                listMedia = _mediaDB.GetAllMediaInLibrary(libraryCode);
                var listBox = selectedTab.Controls[0] as System.Windows.Forms.ListBox;
                listBox.DataSource = listMedia.ToList();
                listBox.SelectedIndex = (listMedia.Count > 0) ? 0 : -1;
                this.btnAdd.Visible = false;
                this.btnRemove.Visible = false;
            }

            this.listSongData = listMedia.ToList();
            InitPlaylists();
            this.axWindowsMediaPlayer.currentPlaylist = this.playlist;
            this.selectedIndex = 0;
        }

        private void tabLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabLibrary.TabPages.Count > 0)
                LoadMediaInPlayListForTabLayout();
            this.selectedIndex = 0;
        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as System.Windows.Forms.ListBox;
            this.selectedIndex = listBox.SelectedIndex;

            if (this.selectedIndex >= 0 && this.selectedIndex < playlist.count)
            {
                this.axWindowsMediaPlayer.Ctlcontrols.playItem(playlist.Item[this.selectedIndex]);
            }
        }

        /// <summary>
        /// Hàm dùng để cập nhật hiển thị label tên bài hát đang phát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axWindowsMediaPlayer_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            this.labeMediaName.Text = this.axWindowsMediaPlayer.currentMedia.name;
        }

        /// <summary>
        /// Chuyển trạng thái phát/dừng của trình phát nhạc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            // switch trạng thái
            this.isPlaying = !this.isPlaying;
            this.PlayingStateChange();
        }

        /// <summary>
        /// Chuyển trạng thái và icon play
        /// </summary>
        private void PlayingStateChange()
        {
            if (this.isPlaying)
            {
                this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                this.axWindowsMediaPlayer.Ctlcontrols.play();
            }
            else
            {
                this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                this.axWindowsMediaPlayer.Ctlcontrols.pause();
            }
        }

        /// <summary>
        /// Xử lý việc bấm Next bài hát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Gọi hàm next() của trình phát để chuyển sang bài hát tiếp theo
            this.axWindowsMediaPlayer.Ctlcontrols.next();

            this.selectedIndex += 1;

            // Nếu là tab Music (Tất cả)
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                if (this.selectedIndex == this.listSongData.Count)
                {
                    this.selectedIndex = 0;
                }
                this.listSongs.SelectedIndex = this.selectedIndex;
            }
            // Ngược lại, nếu là các tab danh sách phát khác
            else
            {
                // lấy ra tab Library đang được chọn
                var selectedTab = this.tabLibrary.SelectedTab;
                // Lấy ra listBox (giao diện) chứa tên các bài hát
                var listBox = selectedTab.Controls[0] as System.Windows.Forms.ListBox;

                if (this.selectedIndex == this.listSongData.Count)
                {
                    this.selectedIndex = 0;
                }

                // Gán lại SelectedIndex
                listBox.SelectedIndex = this.selectedIndex;
            }
        }

        /// <summary>
        /// Xử lý việc bấm nút Back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer.Ctlcontrols.previous();

            this.selectedIndex -= 1;

            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                if (this.selectedIndex < 0)
                {
                    this.selectedIndex = this.listSongData.Count - 1;
                }
                this.listSongs.SelectedIndex = this.selectedIndex;
            }
            else
            {
                // lấy ra tab Library đang được chọn
                var selectedTab = this.tabLibrary.SelectedTab;
                // Lấy ra listBox (giao diện) chứa tên các bài hát
                var listBox = selectedTab.Controls[0] as System.Windows.Forms.ListBox;
                if (this.selectedIndex < 0)
                {
                    this.selectedIndex = this.listSongData.Count - 1;
                }
                listBox.SelectedIndex = this.selectedIndex;
            }
        }

        /// <summary>
        /// Hàm xử lý cho nút sắp xếp tăng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            // Sort data tăng dần
            SortUtils.SortMedia(this.listSongData, SortDirection.Asc);

            // Sort playlist tăng dần
            SortUtils.SortPlaylist(this.playlist, SortDirection.Asc);

            // Cập nhật giao diện
            this.UpdateListSongsView();

            // Cập nhật lại playlist đang phát cho axWindowsMediaPlayer
            this.axWindowsMediaPlayer.currentPlaylist = this.playlist;

            // Chuyển selectedIndex = 0 để chọn bài hát đầu danh sách
            // Nếu ở tab Tất cả
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                this.listSongs.SelectedIndex = 0;
            }
            // Ngược lại, cấn phải xác định listBox cụ thể cho tab Library
            else
            {
                // Lấy ra tab đang được chọn
                var selectedTab = this.tabLibrary.SelectedTab;
                // Lấy listBox (giao diện) chứa tên các bài hát
                var listBox = selectedTab.Controls[0] as System.Windows.Forms.ListBox;
                // Gán lại selectedIndex
                listBox.SelectedIndex = 0;
            }
            // Gán this.selectedIndex, dùng để theo dõi index nào đang được chọn theo playlist
            this.selectedIndex = 0;
        }

        /// <summary>
        /// Hàm xử lý cho nút sắp xếp giảm dần
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            // Sort data giảm dần
            SortUtils.SortMedia(this.listSongData, SortDirection.Desc);

            // Sort playlist giảm dần
            SortUtils.SortPlaylist(this.playlist, SortDirection.Desc);

            // Cập nhật giao diện
            this.UpdateListSongsView();

            // Cập nhật lại playlist đang phát cho axWindowsMediaPlayer
            this.axWindowsMediaPlayer.currentPlaylist = this.playlist;

            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                this.listSongs.SelectedIndex = 0;
            }
            else
            {
                var selectedTab = this.tabLibrary.SelectedTab;
                var listBox = selectedTab.Controls[0] as System.Windows.Forms.ListBox;
                listBox.SelectedIndex = 0;
            }
            this.selectedIndex = 0;
        }

        /// <summary>
        /// Hàm xử lý cho việc chọn thêm bài hát
        /// </summary>
        private void ChooseFiles()
        {
            // Tạo 1 hộp thoại để chọn file
            OpenFileDialog dialog = new OpenFileDialog();
            // Cho phép cho nhiều file cùng lúc
            dialog.Multiselect = true;
            dialog.Title = "Choose media";
            // Lọc ra những định dạng file cho phép
            dialog.Filter = string.Join("|", AvailableFileExtensions);

            // Nếu chọn file xong và nhấn OK
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy danh sách đường dẫn các file được chọn
                string[] files = dialog.FileNames;

                // Cập nhật playlist
                UpdatePlaylist("All", files.ToList());

                // Cập nhật lại giao diện hiển thị
                this.UpdateListSongsView();
            }
        }

        /// <summary>
        /// Khởi tạo playlist từ listSongData
        /// </summary>
        private void InitPlaylists()
        {
            // Xóa hết tất cả bài hát có trong playlist hiện tại
            this.playlist.clear();

            // Với mỗi bài hát trong listSongData
            foreach (Media media in this.listSongData)
            {
                // Tạo mới 1 đối tượng media
                var mediaItem = this.axWindowsMediaPlayer.newMedia(media.FilePath);
                // Thêm vào playlist
                this.playlist.appendItem(mediaItem);
            }
        }

        /// <summary>
        /// Cập nhật lại playlist (thêm mới file) dựa trên danh sách đường dẫn file
        /// </summary>
        /// <param name="playlistName"></param>
        /// <param name="listFilePaths"></param>
        private void UpdatePlaylist(string playlistName, List<string> listFilePaths)
        {
            if (playlistName == null)
            {
                return;
            }
            else if (playlistName == "All")
            {
                foreach (string filePath in listFilePaths)
                {
                    // Tạo mới bài hát vào thêm vào playlist
                    var mediaItem = this.axWindowsMediaPlayer.newMedia(filePath);
                    this.playlist.appendItem(mediaItem);

                    // Tạo mới media và thêm vào listSongData
                    Media media = new Media()
                    {
                        Code = CodeUtils.GenCode(),
                        FilePath = filePath,
                        Name = mediaItem.name,
                        Status = Status.Active,
                        Type = MediaType.Music
                    };
                    this.listSongData.Add(media);

                    // Gọi hàm để lưu vào database
                    _mediaDB.Create(media);
                }
            }
        }

        /// <summary>
        /// Hàm xử lý cho chức năng tìm kiếm tên bài hát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                // Gọi hàm tìm kiếm, để lấy ra danh sách các bài hát cho chứa từ query
                List<Media> mediaList = Search(this.listSongData, query);

                // Cập nhật lại DataSource để hiển thị danh sách các bài hát đã tìm thấy
                this.listSongs.DataSource = mediaList;
            }
            else
            {
                // Gọi hàm tìm kiếm, để lấy ra danh sách các bài hát cho chứa từ query
                List<Media> mediaList = Search(this.listSongData, query);

                // Cập nhật lại DataSource để hiển thị danh sách các bài hát đã tìm thấy
                var selectedTab = this.tabLibrary.SelectedTab;
                var listBox = selectedTab.Controls[0] as System.Windows.Forms.ListBox;
                listBox.DataSource = mediaList;
            }
        }

        private List<Media> Search(List<Media> medias, string query)
        {
            // Chuẩn hóa text dùng để tìm kiếm bằng tiếng Việt không dấu
            query = StringUtils.RemoveSign4VietnameseString(query.ToLower().Trim());

            List<Media> result = new List<Media>();
            for (int i = 0; i < medias.Count; i++)
            {
                // Chuẩn hóa Name: loại bỏ dấu cách thừa, chuyển sang chữ thường và tiếng Việt không dấu
                string name = medias[i].Name.ToLower().Trim();
                name = StringUtils.RemoveSign4VietnameseString(name);

                // Kiểm tra xem Name của media có chứa từ trong query không
                // Nếu có, thêm vào kết quả trả về
                if (name.Contains(query) == true)
                {
                    result.Add(medias[i]);
                }
            }

            return result;
        }

        /// <summary>
        /// Lấy ra thông tin bài hát đang được chọn
        /// </summary>
        /// <returns></returns>
        private Media GetSelectedMedia()
        {
            // Nếu là tab Tất cả
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                return this.listSongs.SelectedItem as Media;
            }
            // Ngược lại, là tab Library
            else
            {
                var selectedTab = this.tabLibrary.SelectedTab;
                var listBox = selectedTab.Controls[0] as System.Windows.Forms.ListBox;
                return listBox.SelectedItem as Media;
            }
        }

        /// <summary>
        /// Hàm xử lý cho nút Action, khi 1 bài hát được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMediaAction_Click(object sender, EventArgs e)
        {
            Media selectedMedia = GetSelectedMedia();

            // Đảm bảo là có 1 bài hát được chọn, nếu không sẽ văng lỗi
            if (selectedMedia is null)
            {
                return;
            }

            var libriries = this.AllLibraries;

            // Mở 1 form mới
            using (frmMediaActionMenu mediaActionMenu = new frmMediaActionMenu()
            {
                AllLibraries = libriries, // truyền dữ liệu sang form
                SelectedMedia = selectedMedia
            })
            {
                // Nếu là tab Tất cả, thì ẩn đi nút Remove bài hát khỏi danh sách phát
                if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
                {
                    mediaActionMenu.btnRemove.Visible = false;
                }

                // Hiển thị form
                DialogResult dialogResult = mediaActionMenu.ShowDialog();

                // Load lại danh sách phát
                LoadMediaInPlayListForTabLayout();
            }
        }

        /// <summary>
        /// Hàm xử lý khi bấm nút tạo mới 1 playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateNewLibrary_Click(object sender, EventArgs e)
        {
            // Tạo 1 form
            frmCreateLibrary createLibrary = new frmCreateLibrary();
            // Cho hiển thị form
            DialogResult dialogResult = createLibrary.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                // Lấy dữ liệu người dùng nhập từ form
                var libraryName = createLibrary.LibraryName;

                // Tạo mới 1 đối tự Library
                Library library = new Library()
                {
                    Name = libraryName,
                    Code = CodeUtils.GenCode(),
                    Status = Status.Active
                };
                // Lưu vào database
                _libraryDB.Create(library);

                // Cập nhật lại danh sách các library
                this.LoadLibraries();

                // Hiển thị thông báo thành công
                MessageBox.Show($"Đã tạo thành công thư viện {libraryName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Hàm xử lý khi người dùng chọn library từ danh sách dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu chọn danh sách phát tự tạo
            if (this.selectLibrary.SelectedIndex > 0)
            {
                // Lấy ra thông tin library đang được chọn
                Library library = this.selectLibrary.SelectedItem as Library;

                // Kiểm tra xem library này có đang mở hay không
                // Bằng cách tìm xem có TabPage nào chứa key tương tự như sau không
                // Lưu ý: key chính là Name của TabPage (được tạo theo cú pháp TabLibrary_{library.Code})
                int index = this.tabLibrary.TabPages.IndexOfKey($"TabLibrary_{library.Code}");

                // Nếu tồn tại, thì chuyển sang tab đang mở
                if (index >= 0)
                {
                    this.tabLibrary.SelectedIndex = index;
                    return;
                }

                // Lấy ra danh sách bài hát có trong library, bằng cách gọi hàm query database
                LinkedList<Media> data = _mediaDB.GetAllMediaInLibrary(library.Code);
                // Tạo mới 1 tabPage để hiển thị
                TabPage tabPage = this.CreateTabPage(library.Name, library.Code, data.ToList());
                // Thêm tabPage đó vào giao diện
                this.tabLibrary.TabPages.Add(tabPage);
                // Chuyển tab được chọn trên giao diện sang tab vừa tạo
                this.tabLibrary.SelectedIndex = this.tabLibrary.TabPages.Count - 1;
            }
            // Nếu chọn danh sách Tất cả
            else
            {
                this.tabLibrary.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Cập nhật lại danh sách bài hát trên giao diện
        /// </summary>
        private void UpdateListSongsView()
        {
            // Nếu ở tab Tất cả
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                // Xóa các tên bài hát đang hiển thị trên giao diện
                this.listSongs.Items.Clear();

                // Cập nhật lại danh sách tên các bài hát dựa vào listSongData
                this.listSongs.Items.AddRange(this.listSongData.ToArray());
            }
            // Ngược lại
            else
            {
                // Xác được tab nào đang chọn
                var selectedTab = this.tabLibrary.SelectedTab;
                var listBox = selectedTab.Controls[0] as System.Windows.Forms.ListBox;

                // Cập nhật lại danh sách tên các bài hát dựa vào listSongData
                listBox.DataSource = this.listSongData.ToList();
            }
        }

        /// <summary>
        /// Hàm xử lý cho nút Quản lý thư viện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLibManager_Click(object sender, EventArgs e)
        {
            // Tạo mới form
            frmLibraryManagement frmLibraryManagement = new frmLibraryManagement();
            // Cho form hiển thị
            frmLibraryManagement.ShowDialog();

            // Load lại danh sách thư viện
            LoadLibraries();

            // Lấy ra tab Tất cả (để tránh bị xóa mất)
            var tabPageSong = this.tabLibrary.TabPages[0];
            // Xóa hết tất cả các tab hiện có
            this.tabLibrary.TabPages.Clear();
            // Thêm lại tab tất cả
            this.tabLibrary.TabPages.Add(tabPageSong);
            this.tabLibrary.SelectedIndex = 0;
        }
    }
}
