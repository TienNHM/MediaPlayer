using Media_Player.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private bool isLibraryExpanded = false;
        private bool isFavoriteExpanded = false;
        private bool isPlaying = false;
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

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            ChooseMusic();

            // Update playlist dang phat
            this.tabSongVideo.SelectedIndex = (int)TabMedia.Music;
            this.axWindowsMediaPlayer.currentPlaylist = playlistAllSongs;
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            ChooseVideo();

            // Update playlist dang phat
            this.tabSongVideo.SelectedIndex = (int)TabMedia.Video;
            this.axWindowsMediaPlayer.currentPlaylist = playlistAllVideos;
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

            this.btnAddVideo.Visible = this.isLibraryExpanded;
            this.btnAddMusic.Visible = this.isLibraryExpanded;
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

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listSongs.SelectedIndex;

            if (index >= 0 && index < playlistAllSongs.count)
            {
                this.axWindowsMediaPlayer.Ctlcontrols.playItem(playlistAllSongs.Item[index]);
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer.Ctlcontrols.previous();
        }

        private void listVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listVideos.SelectedIndex;
            if (index >= 0 && index < playlistAllVideos.count)
            {
                this.axWindowsMediaPlayer.Ctlcontrols.playItem(playlistAllVideos.Item[index]);
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
                this.axWindowsMediaPlayer.playlistCollection.remove(playlistAllSongs);

                foreach (string file in files)
                {
                    Media media = new Media()
                    {
                        FilePath = file,
                        Name = System.IO.Path.GetFileNameWithoutExtension(file),
                    };
                    this.listSongData.Add(media);

                    // Thêm bài hát vào danh sách phát
                    var mediaItem = this.axWindowsMediaPlayer.newMedia(file);
                    this.playlistAllSongs.appendItem(mediaItem);
                }

                // Xóa các tên bài hát đang hiển thị trên giao diện
                this.listSongs.Items.Clear();

                // Cập nhật lại danh sách tên các bài hát
                this.listSongs.Items.AddRange(this.listSongData.ToArray());
            }
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
                this.axWindowsMediaPlayer.playlistCollection.remove(playlistAllVideos);

                foreach (string filePath in files)
                {
                    Media media = new Media()
                    {
                        FilePath = filePath,
                        Name = System.IO.Path.GetFileNameWithoutExtension(filePath),
                    };
                    this.listVideoData.Add(media);

                    var mediaItem = axWindowsMediaPlayer.newMedia(filePath);
                    this.playlistAllVideos.appendItem(mediaItem);
                }

                // xoa tat ca filePath dang hien thi tren giao dien
                this.listVideos.Items.Clear();

                // them cac filePath trong list paths vao giao dien listBox
                this.listVideos.Items.AddRange(this.listVideoData.ToArray());
            }
        }
    }
}
