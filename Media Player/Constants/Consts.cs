using System.Windows.Forms;
using System.Windows.Input;

namespace Media_Player.Constants
{
    public class MusicExtensionFilterConsts
    {
        public static string WindowsMediaFormats = "Windows Media formats|*.asf;*.wma;*.wmv;*.wm";
        public static string AudioVisualInterleave = "Audio Visual Interleave|*.avi";
        public static string AudioWindows = "Audio for Windows|*.wav";
        public static string Mp4Audio = "MP4 Audio|*.m4a";
        public static string FreeLosslessAudioCodec = "Free Lossless Audio Codec|*.flac";
        public static string MovingPicturesExpertsGroup = "Moving Pictures Experts Group|*.mp2;*.mp3;*.mpa";
    }

    public class VideoExtensionFilterConsts
    {
        public static string QuickTimeMovie = "QuickTime Movie|*.mov";
        public static string Mp4Video = "MP4 Video|*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp";
        public static string MovingPicturesExpertsGroup = "Moving Pictures Experts Group|*.mpg;*.mpeg;*.m1v";
    }

    public static class MediaType
    {
        public static string Video = "Video";
        public static string Music = "Music";
    }

    public static class Status
    {
        public static string Active = "Active";
        public static string Deactive = "Deactive";
    }
}
