using FontAwesome.Sharp;
using Media_Player.Constants;
using Media_Player.Data;
using Media_Player.Entity;
using Media_Player.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Shapes;
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
        private bool isPlaying = false;
        private int selectedIndex = 0;
        private MediaDB _mediaDB = new MediaDB();
        private LibraryDB _libraryDB = new LibraryDB();
        private List<Media> listSongData = new List<Media>();
        private LinkedList<Library> AllLibraries = new LinkedList<Library>();   
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

        private void LoadLibraries()
        {
            this.AllLibraries = _libraryDB.GetAll();
            this.AllLibraries.AddFirst(new Library()
            {
                Code = null,
                Name = "Tất cả",
                Status = Status.Active
            });
            var libraies = this.AllLibraries.ToList();
            
            this.selectLibrary.DataSource = libraies;
        }

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

        private void tabLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            LinkedList<Media> listMedia = new LinkedList<Media>();

            int selectedIndex = this.tabLibrary.SelectedIndex;
            if (selectedIndex == 0)
            {
                listMedia = _mediaDB.GetAll();
            }
            else
            {
                var library = this.selectLibrary.SelectedItem as Library;
                listMedia = _mediaDB.GetAllMediaInLibrary(library.Code);
            }

            this.listSongData = listMedia.ToList();
            InitPlaylists();
            this.axWindowsMediaPlayer.currentPlaylist = this.playlist;
        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as System.Windows.Forms.ListBox;
            int selectedIndex = listBox.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < playlist.count)
            {
                this.axWindowsMediaPlayer.Ctlcontrols.playItem(playlist.Item[selectedIndex]);
                //this.axWindowsMediaPlayer.URL = listSongData[index].FilePath;
            }
        }

        private void axWindowsMediaPlayer_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            this.labeMediaName.Text = this.axWindowsMediaPlayer.currentMedia.name;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.isPlaying = !this.isPlaying;
            this.PlayingStateChange();
        }

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer.Ctlcontrols.next();
            
            this.selectedIndex += 1;
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                if (this.selectedIndex == this.listSongData.Count)
                {
                    this.selectedIndex = 0;
                }
                this.listSongs.SelectedIndex = this.selectedIndex;
            }
        }

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
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            // Sort data tăng dần
            SortUtils.SortMedia(this.listSongData, SortDirection.Asc);

            // Sort playlist tăng dần
            SortUtils.SortPlaylist(this.playlist, SortDirection.Asc);

            // Cập nhật giao diện
            this.UpdateListSongsView();

            // Cập nhật lại playlist đang phát cho axWindowsMediaPlayer
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                this.axWindowsMediaPlayer.currentPlaylist = this.playlist;
                this.listSongs.SelectedIndex = 0;
            }
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            // Sort data giảm dần
            SortUtils.SortMedia(this.listSongData, SortDirection.Desc);

            // Sort playlist giảm dần
            SortUtils.SortPlaylist(this.playlist, SortDirection.Desc);

            // Cập nhật giao diện
            this.UpdateListSongsView();

            // Cập nhật lại playlist đang phát cho axWindowsMediaPlayer
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                this.axWindowsMediaPlayer.currentPlaylist = this.playlist;
                this.listSongs.SelectedIndex = 0;
            }
        }

        private void ChooseFiles()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "Choose media";
            dialog.Filter = string.Join("|", AvailableFileExtensions);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected files
                string[] files = dialog.FileNames;

                // Xóa danh sách phát hiện tại
                this.playlist.clear();
                
                // Cập nhật playlist
                UpdatePlaylist("All", files.ToList());

                this.UpdateListSongsView();
            }
        }

        private void InitPlaylists()
        {
            this.playlist.clear();
            foreach (Media media in this.listSongData)
            {
                var mediaItem = this.axWindowsMediaPlayer.newMedia(media.FilePath);
                this.playlist.appendItem(mediaItem);
            }
        }

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
                    var mediaItem = this.axWindowsMediaPlayer.newMedia(filePath);
                    this.playlist.appendItem(mediaItem);

                    Media media = new Media()
                    {
                        Code = CodeUtils.GenCode(),
                        FilePath = filePath,
                        Name = mediaItem.name,
                        Status = Status.Active,
                        Type = MediaType.Music
                    };
                    this.listSongData.Add(media);
                    _mediaDB.Create(media);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                List<Media> mediaList = Search(this.listSongData, query);
                this.listSongs.DataSource = mediaList;
            }
        }

        private List<Media> Search(List<Media> medias, string query)
        {
            // Chuẩn hóa text dùng để tìm kiếm
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

        private Media GetSelectedMedia()
        {
            if (this.tabLibrary.SelectedIndex == (int)TabMedia.Music)
            {
                return this.listSongs.SelectedItem as Media;
            }
            return null;
        }
        private void btnMediaAction_Click(object sender, EventArgs e)
        {
            Media selectedMedia = GetSelectedMedia();

            if (selectedMedia is null)
            {
                return;
            }

            using (frmMediaActionMenu mediaActionMenu = new frmMediaActionMenu()
            {
                AllLibraries = this.AllLibraries,
                SelectedMedia = selectedMedia
            })
            {
                DialogResult dialogResult = mediaActionMenu.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MediaAction mediaAction = mediaActionMenu.SelectedAction;
                }
            }
        }

        private void btnCreateNewLibrary_Click(object sender, EventArgs e)
        {
            frmCreateLibrary createLibrary = new frmCreateLibrary();
            
            DialogResult dialogResult = createLibrary.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                var libraryName = createLibrary.LibraryName;
                Library library = new Library()
                {
                    Name = libraryName,
                    Code = CodeUtils.GenCode(),
                    Status = Status.Active
                };
                _libraryDB.Create(library);

                this.LoadLibraries();
                
                MessageBox.Show($"Đã tạo thành công thư viện {libraryName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void selectLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.selectLibrary.SelectedIndex > 0)
            {
                Library library = this.selectLibrary.SelectedItem as Library;

                int index = this.tabLibrary.TabPages.IndexOfKey($"TabLibrary_{library.Code}");

                if (index >= 0)
                {
                    this.tabLibrary.SelectedIndex = index;
                    return;
                }

                LinkedList<Media> data = _mediaDB.GetAllMediaInLibrary(library.Code);

                TabPage tabPage = this.CreateTabPage(library.Name, library.Code, data.ToList());
                this.tabLibrary.TabPages.Add(tabPage);
                this.tabLibrary.SelectedIndex = this.tabLibrary.TabPages.Count - 1;
            }
            else
            {
                this.tabLibrary.SelectedIndex = 0;
            }
        }

        private void tabLibrary_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show($"tabLibrary_MouseDoubleClick: {tabLibrary.SelectedTab.Text}");
        }

        /// <summary>
        /// Cập nhật lại danh sách bài hát tren giao diện
        /// </summary>
        private void UpdateListSongsView()
        {
            // Xóa các tên bài hát đang hiển thị trên giao diện
            this.listSongs.Items.Clear();

            // Cập nhật lại danh sách tên các bài hát dựa vào listSongData
            this.listSongs.Items.AddRange(this.listSongData.ToArray());
        }
    }
}
