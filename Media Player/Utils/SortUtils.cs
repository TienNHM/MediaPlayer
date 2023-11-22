using Media_Player.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Media_Player.Utils
{
    public static class SortUtils
    {
        #region Sort Media
        /// <summary>
        /// Sort danh sách media theo thứ tự tăng dần/giảm dần, bằng thuật toán Bubble sort (sắp xếp nổi bọt).
        /// </summary>
        /// <param name="medias">Danh sách media cần sắp xếp.</param>
        /// <param name="sortDirection">Hướng sắp xếp: Tăng dần (Asc) / Giảm dần (Desc).</param>
        public static void SortMedia(List<Media> medias, SortDirection sortDirection = SortDirection.Asc)
        {
            if (sortDirection == SortDirection.Asc)
            {
                SortMediaAsc(medias);
            }
            else
            {
                SortMediaDesc(medias);
            }
        }

        /// <summary>
        /// Sắp xếp tăng dần các bài hát, dùng thuật toán Bubble Sort
        /// </summary>
        /// <param name="medias"></param>
        private static void SortMediaAsc(List<Media> medias)
        {
            for (int i = 0; i < medias.Count - 1; i++)
            {
                for (int j = i + 1;  j < medias.Count; j++)
                {
                    // Nếu media[i] > media[j]
                    if (Media.SoSanh(medias[i], medias[j]) > 0)
                    {
                        // Đổi chỗ vị trí media[i] và media[j]
                        Media temp = medias[i];
                        medias[i] = medias[j];
                        medias[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Sắp xếp giảm dần các bài hát, dùng thuật toán Bubble sort
        /// </summary>
        /// <param name="medias"></param>
        private static void SortMediaDesc(List<Media> medias)
        {
            for (int i = 0; i < medias.Count - 1; i++)
            {
                for (int j = i + 1; j < medias.Count; j++)
                {
                    // Nếu media[i] < media[j]
                    if (Media.SoSanh(medias[i], medias[j]) < 0)
                    {
                        // Đổi chỗ vị trí media[i] và media[j]
                        Media temp = medias[i];
                        medias[i] = medias[j];
                        medias[j] = temp;
                    }
                }
            }
        }
        #endregion Sort Media

        #region Sort MediaItem in Playlist
        /// <summary>
        /// Sắp xếp các bài hát trong playlist theo thứ tự tăng dần/giảm dần
        /// </summary>
        /// <param name="playlist">playlist cần sắp xếp lại
        /// <param name="sortDirection">chiều sắp xếp: Asc (tăng dần) / Desc (giảm dần)</param>
        public static void SortPlaylist(IWMPPlaylist playlist, SortDirection sortDirection)
        {
            // Lấy ra danh sách các IWMPMedia có trong playlist
            List<IWMPMedia> listMedias = new List<IWMPMedia>();
            for (int i = 0; i < playlist.count; i++)
            {
                listMedias.Add(playlist.Item[i]);
            }

            // Sắp xếp các IWMPMedia trong danh sách theo thứ tự sortDirection
            if (sortDirection == SortDirection.Asc)
            {
                SortPlaylistAsc(listMedias);
            }
            else
            {
                SortPlaylistDesc(listMedias);
            }

            // Xóa tất cả IWMPMedia trong danh sách hiện tại
            playlist.clear();

            // Thêm các IWMPMedia đã sắp xếp theo thứ tự vào lại playlist 
            foreach (IWMPMedia media in listMedias)
            {
                playlist.appendItem(media);
            }
        }

        private static void SortPlaylistAsc(List<IWMPMedia> medias)
        {
            for (int i = 0; i < medias.Count - 1; i++)
            {
                for (int j = i + 1; j < medias.Count; j++)
                {
                    // Nếu media[i] > media[j]
                    if (SoSanhPlaylistItem(medias[i], medias[j]) > 0)
                    {
                        // Đổi chỗ vị trí media[i] và media[j]
                        IWMPMedia temp = medias[i];
                        medias[i] = medias[j];
                        medias[j] = temp;
                    }
                }
            }
        }

        private static void SortPlaylistDesc(List<IWMPMedia> medias)
        {
            for (int i = 0; i < medias.Count - 1; i++)
            {
                for (int j = i + 1; j < medias.Count; j++)
                {
                    // Nếu media[i] < media[j]
                    if (SoSanhPlaylistItem(medias[i], medias[j]) < 0)
                    {
                        // Đổi chỗ vị trí media[i] và media[j]
                        IWMPMedia temp = medias[i];
                        medias[i] = medias[j];
                        medias[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// So sánh media1 và media2, không phân biệt chữ hoa/chữ thường
        /// </summary>
        /// <param name="media1"></param>
        /// <param name="media2"></param>
        /// <returns>
        /// value < 0 nếu media1.name < media2.name
        /// value = 0 nếu media1.name = media2.name
        /// value > 0 nếu media1.name > media2.name
        /// </returns>
        private static int SoSanhPlaylistItem(IWMPMedia media1, IWMPMedia media2)
        {
            return String.Compare(media1.name, media2.name, ignoreCase: true);
        }
        #endregion Sort MediaItem in Playlist
    }

    public enum SortDirection
    {
        Asc,
        Desc,
    }
}
