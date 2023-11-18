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
using MusicConsts = Media_Player.MusicExtensionFilterConsts;
using VideoConsts = Media_Player.VideoExtensionFilterConsts;

namespace Media_Player
{
    public partial class frmMusicPlayer : Form
    {
        private readonly string PLAYLIST_ALL_SONGS = "All songs";
        private readonly string PLAYLIST_ALL_VIDEOS = "All videos";
        private readonly string PLAYLIST_FAV_SONGS = "Favorite songs";
        private readonly string PLAYLIST_FAV_VIDEOS = "Favorite videos";
        IWMPPlaylist playlistAllSongs, playlistAllVideos, playlistFavSongs, playlistFavVideos;
        private bool isLibraryExpanded = true;
        private bool isFavoriteExpanded = true;
        private bool isPlaying = false;
        private int selectedIndex = -1;
        private List<string> MusicFileExtensions = new List<string>
        {
            MusicConsts.MovingPicturesExpertsGroup,
            MusicConsts.WindowsMediaFormats,
            MusicConsts.AudioWindows,
            MusicConsts.AudioVisualInterleave,
            MusicConsts.Mp4Audio,
            MusicConsts.FreeLosslessAudioCodec,
        };
        private List<string> VideoFileExtensions = new List<string>
        {
            VideoConsts.Mp4Video,
            VideoConsts.QuickTimeMovie,
            VideoConsts.MovingPicturesExpertsGroup,
        };
        private enum TabMedia
        {
            Music,
            Video
        }
        private List<Media> listSongData = new List<Media>();
        private List<Media> listVideoData = new List<Media>();
        public frmMusicPlayer()
        {
            InitializeComponent();
            Init();
            LoadData();
        }

        private void Init()
        {
            this.axWindowsMediaPlayer.uiMode = "none";
            playlistAllSongs = axWindowsMediaPlayer.playlistCollection.newPlaylist(PLAYLIST_ALL_SONGS);
            playlistAllVideos = axWindowsMediaPlayer.playlistCollection.newPlaylist(PLAYLIST_ALL_VIDEOS);
            playlistFavSongs = axWindowsMediaPlayer.playlistCollection.newPlaylist(PLAYLIST_FAV_SONGS);
            playlistFavVideos = axWindowsMediaPlayer.playlistCollection.newPlaylist(PLAYLIST_FAV_VIDEOS);
            this.listSongs.Focus();
        }

        private void LoadData()
        {
            this.listSongData = new List<Media>();
            this.listVideoData = new List<Media>();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            this.isFavoriteExpanded = !this.isFavoriteExpanded;

            this.btnFavVideos.Visible = this.isFavoriteExpanded;
            this.btnFavSongs.Visible = this.isFavoriteExpanded;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabSongVideo.SelectedIndex == (int)TabMedia.Video)
            {
                ChooseVideo();

                // Update playlist dang phat
                this.tabSongVideo.SelectedIndex = (int)TabMedia.Video;
                this.axWindowsMediaPlayer.currentPlaylist = playlistAllVideos;

                // Update giao diện hiển thị
                if (this.listVideos.Items.Count > 0)
                {
                    this.listVideos.SelectedIndex = 0;
                    this.selectedIndex = 0;
                }
            }
            else
            {
                ChooseMusic();

                // Update playlist dang phat
                this.tabSongVideo.SelectedIndex = (int)TabMedia.Music;
                this.axWindowsMediaPlayer.currentPlaylist = playlistAllSongs;

                // Update giao diện hiển thị
                if (this.listSongs.Items.Count > 0)
                {
                    this.listSongs.SelectedIndex = 0;
                    this.selectedIndex = 0;
                }
            }

            // Update icon playing
            this.isPlaying = true;
            this.PlayingStateChange();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tabSongVideo.SelectedIndex == (int)TabMedia.Video)
            {
                int selectedIndex = this.listVideos.SelectedIndex;
                Media selectedItem = this.listVideos.SelectedItem as Media;
                
                this.listVideoData.Remove(selectedItem);
                this.playlistAllVideos.removeItem(this.playlistAllVideos.Item[selectedIndex]);
                
                this.UpdateListVideosView();
            }
            else
            {
                int selectedIndex = this.listSongs.SelectedIndex;
                Media selectedItem = this.listSongs.SelectedItem as Media;
                
                this.listSongData.Remove(selectedItem);
                this.playlistAllSongs.removeItem(this.playlistAllSongs.Item[selectedIndex]);

                this.UpdateListSongsView();
            }
        }

        private void btnFavSongs_Click(object sender, EventArgs e)
        {

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

        private void tabSongVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabSongVideo.SelectedIndex)
            {
                case (int)TabMedia.Music:
                    this.axWindowsMediaPlayer.currentPlaylist = playlistAllSongs;
                    break;
                case (int)TabMedia.Video:
                    this.axWindowsMediaPlayer.currentPlaylist = playlistAllVideos;
                    break;
            }
        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.listSongs.SelectedIndex;
            Media selectedItem = this.listSongs.SelectedItem as Media;

            if (selectedIndex >= 0 && selectedIndex < playlistAllSongs.count)
            {
                this.axWindowsMediaPlayer.Ctlcontrols.playItem(playlistAllSongs.Item[selectedIndex]);
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
            if (this.tabSongVideo.SelectedIndex == (int)TabMedia.Video)
            {
                if (this.selectedIndex == this.listVideoData.Count)
                {
                    this.selectedIndex = 0;
                }
                this.listVideos.SelectedIndex = this.selectedIndex;
            }
            else
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
           
            if (this.tabSongVideo.SelectedIndex == (int)TabMedia.Video)
            {
                if (this.selectedIndex < 0)
                {
                    this.selectedIndex = this.listVideoData.Count - 1;
                }
                this.listVideos.SelectedIndex = this.selectedIndex;

            }
            else
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
            SortUtils.SortMedia(this.listVideoData, SortDirection.Asc);

            // Sort playlist tăng dần
            SortUtils.SortPlaylist(this.playlistAllSongs, SortDirection.Asc);
            SortUtils.SortPlaylist(this.playlistAllVideos, SortDirection.Asc);

            // Cập nhật giao diện
            this.UpdateListSongsView();
            this.UpdateListVideosView();

            // Cập nhật lại playlist đang phát cho axWindowsMediaPlayer
            if (this.tabSongVideo.SelectedIndex == (int)TabMedia.Video)
            {
                this.axWindowsMediaPlayer.currentPlaylist = this.playlistAllVideos;
            }
            else
            {
                this.axWindowsMediaPlayer.currentPlaylist = this.playlistAllSongs;
            }
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            // Sort data giảm dần
            SortUtils.SortMedia(this.listSongData, SortDirection.Desc);
            SortUtils.SortMedia(this.listVideoData, SortDirection.Desc);

            // Sort playlist giảm dần
            SortUtils.SortPlaylist(this.playlistAllSongs, SortDirection.Desc);
            SortUtils.SortPlaylist(this.playlistAllVideos, SortDirection.Desc);

            // Cập nhật giao diện
            this.UpdateListSongsView();
            this.UpdateListVideosView();

            // Cập nhật lại playlist đang phát cho axWindowsMediaPlayer
            if (this.tabSongVideo.SelectedIndex == (int)TabMedia.Video)
            {
                this.axWindowsMediaPlayer.currentPlaylist = this.playlistAllVideos;
            }
            else
            {
                this.axWindowsMediaPlayer.currentPlaylist = this.playlistAllSongs;
            }
        }

        private void listVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.listVideos.SelectedIndex;
            Media selectedItem = this.listVideos.SelectedItem as Media;

            if (selectedIndex >= 0 && selectedIndex < playlistAllVideos.count)
            {
                this.axWindowsMediaPlayer.Ctlcontrols.playItem(playlistAllVideos.Item[selectedIndex]);
                //this.axWindowsMediaPlayer.URL = listVideoData[index].FilePath;
            }
        }

        private void ChooseMusic()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "Choose music";
            dialog.Filter = string.Join("|", MusicFileExtensions);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected files
                string[] files = dialog.FileNames;

                // Xóa danh sách phát hiện tại
                this.playlistAllSongs.clear();

                foreach (string file in files)
                {
                    // Thêm bài hát vào danh sách phát
                    var mediaItem = this.axWindowsMediaPlayer.newMedia(file);
                    this.playlistAllSongs.appendItem(mediaItem);

                    Media media = new Media()
                    {
                        FilePath = file,
                        Name = mediaItem.name,
                    };
                    this.listSongData.Add(media);
                }

                this.UpdateListSongsView();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            if (this.tabSongVideo.SelectedIndex == (int)TabMedia.Video)
            {
                List<Media> mediaList = Search(this.listVideoData, query);
                this.listVideos.DataSource = mediaList;
            }
            else
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

        private void ChooseVideo()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "Choose video";
            dialog.Filter = string.Join("|", VideoFileExtensions);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected files
                string[] files = dialog.FileNames;

                // Xóa tất cả video có trong playlist hiện tại
                this.playlistAllVideos.clear();

                foreach (string filePath in files)
                {
                    var mediaItem = axWindowsMediaPlayer.newMedia(filePath);
                    this.playlistAllVideos.appendItem(mediaItem);

                    Media media = new Media()
                    {
                        FilePath = filePath,
                        Name = mediaItem.name,
                    };
                    this.listVideoData.Add(media);
                }

                this.UpdateListVideosView();
            }
        }

        /// <summary>
        /// Cập nhật lại danh sách video trên giao diện
        /// </summary>
        private void UpdateListVideosView()
        {
            // Xóa tất cả tên các video hiện có trên giao diện
            this.listVideos.Items.Clear();

            // Cập nhật lại tên các video dựa vào listVideoData
            this.listVideos.Items.AddRange(this.listVideoData.ToArray());
        }
    }
}
