using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
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
        List<string> lstMusicPaths, lstVideoPaths;
        private bool isLibraryExpanded = false;
        private bool isFavoriteExpanded = false;
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

        public frmMusicPlayer()
        {
            InitializeComponent();
            Init();
            LoadData();
        }

        private void Init()
        {
            playlistAllSongs = axWindowsMediaPlayer.playlistCollection.newPlaylist(PLAYLIST_ALL_SONGS);
            playlistAllVideos = axWindowsMediaPlayer.playlistCollection.newPlaylist(PLAYLIST_ALL_VIDEOS);
            playlistFavSongs = axWindowsMediaPlayer.playlistCollection.newPlaylist(PLAYLIST_FAV_SONGS);
            playlistFavVideos = axWindowsMediaPlayer.playlistCollection.newPlaylist(PLAYLIST_FAV_VIDEOS);
            this.listSongs.Focus();
        }

        private void LoadData()
        {
            lstMusicPaths = new List<string>();
            lstVideoPaths = new List<string>();
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
            axWindowsMediaPlayer.currentPlaylist = playlistAllSongs;
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            ChooseVideo();

            // Update playlist dang phat
            this.tabSongVideo.SelectedIndex = (int)TabMedia.Video;
            axWindowsMediaPlayer.currentPlaylist = playlistAllVideos;
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
            switch (tabSongVideo.SelectedIndex)
            {
                case (int)TabMedia.Music:
                    axWindowsMediaPlayer.currentPlaylist = playlistAllSongs;
                    break;
                case (int)TabMedia.Video:
                    axWindowsMediaPlayer.currentPlaylist = playlistAllVideos;
                    break;
            }
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = lstMusicPaths[listSongs.SelectedIndex];
        }

        private void listVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = lstVideoPaths[listVideos.SelectedIndex];
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
                // them danh sach cac file vua chon vao list paths
                lstMusicPaths.AddRange(files);
                // loc bo nhung file trùng
                lstMusicPaths = lstMusicPaths.Distinct().ToList();
                // xoa tat ca file dang hien thi tren giao dien
                listSongs.Items.Clear();
                // them cac file trong list paths vao giao dien listBox
                listSongs.Items.AddRange(lstMusicPaths.ToArray());
                // cap nhat danh sach bai hat vao playlist AllSongs
                axWindowsMediaPlayer.playlistCollection.remove(playlistAllSongs);
                lstMusicPaths.ForEach(path =>
                {
                    var mediaItem = axWindowsMediaPlayer.newMedia(path);
                    playlistAllSongs.appendItem(mediaItem);
                });
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
                // them danh sach cac file vua chon vao list paths
                lstVideoPaths.AddRange(files);
                // loc bo nhung file trùng
                lstVideoPaths = lstVideoPaths.Distinct().ToList();
                // xoa tat ca file dang hien thi tren giao dien
                listVideos.Items.Clear();
                // them cac file trong list paths vao giao dien listBox
                listVideos.Items.AddRange(lstVideoPaths.ToArray());
                // cap nhat danh sach bai hat vao playlist AllSongs
                axWindowsMediaPlayer.playlistCollection.remove(playlistAllVideos);
                lstVideoPaths.ForEach(path =>
                {
                    var mediaItem = axWindowsMediaPlayer.newMedia(path);
                    playlistAllVideos.appendItem(mediaItem);
                });
            }
        }
    }
}
