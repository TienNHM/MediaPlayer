using Media_Player.Constants;
using Media_Player.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Data
{
    public class MediaDB
    {
        public Database Database { get; set; }

        public readonly List<string> AvailableMediaType = new List<string>()
        {
            MediaType.Video,
            MediaType.Music
        };

        public MediaDB()
        {
            this.Database = new Database();
        }

        /// <summary>
        /// Lấy tất cả bài hát hiện có
        /// </summary>
        /// <param name="mediaType"></param>
        /// <returns></returns>
        public LinkedList<Media> GetAll(string mediaType = null)
        {
            string query = string.Empty;
            if (AvailableMediaType.Contains(mediaType))
            {
                query = $"SELECT * FROM Media WHERE Type = {mediaType};";
            }
            else
            {
                query = "SELECT * FROM Media;";
            }

            LinkedList<Media> result = new LinkedList<Media>();

            this.Database.Connection.Open();

            SQLiteCommand command = new SQLiteCommand(query, this.Database.Connection);
            
            SQLiteDataReader dataReader = command.ExecuteReader();
            
            while (dataReader.Read())
            {
                if (!dataReader.IsDBNull(1))
                {
                    Media media = new Media()
                    {
                        Id = dataReader.GetInt32(0),
                        Code = dataReader.GetString(1),
                        Name = dataReader.GetString(2),
                        FilePath = dataReader.GetString(3),
                        Type = dataReader.GetString(4),
                        Status = dataReader.GetString(5)
                    };
                    result.AddLast(media);
                }
            }
            dataReader.Close();

            this.Database.Connection.Close();

            return result;
        }

        /// <summary>
        /// Lấy danh sách bài hát theo từng library cụ thể (dựa vào libraryCode)
        /// </summary>
        /// <param name="libraryCode">Mã code của library có liên quan</param>
        /// <returns></returns>
        public LinkedList<Media> GetAllMediaInLibrary(string libraryCode)
        {
            string query = $@"
                SELECT Media.*
                FROM LibraryInfo INNER JOIN Media ON LibraryInfo.MediaCode = Media.Code
                WHERE LibraryInfo.LibraryCode = '{libraryCode}' AND Media.Status = '{Status.Active}';";

            LinkedList<Media> result = new LinkedList<Media>();

            this.Database.Connection.Open();

            SQLiteCommand command = new SQLiteCommand(query, this.Database.Connection);

            SQLiteDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (!dataReader.IsDBNull(1))
                {
                    Media media = new Media()
                    {
                        Id = dataReader.GetInt32(0),
                        Code = dataReader.GetString(1),
                        Name = dataReader.GetString(2),
                        FilePath = dataReader.GetString(3),
                        Type = dataReader.GetString(4),
                        Status = dataReader.GetString(5)
                    };
                    result.AddLast(media);
                }
            }
            dataReader.Close();

            this.Database.Connection.Close();

            return result;
        }

        /// <summary>
        /// Tạo mới 1 record
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        public int Create(Media media)
        {
            string query = $@"
                INSERT INTO Media(Code, FilePath, Name, Type, Status) 
                VALUES ('{media.Code}', '{media.FilePath}','{media.Name}', '{media.Type}', '{media.Status}');";

            return this.Database.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Xóa bỏ
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        public int Delete(Media media)
        {
            string query = $@"DELETE FROM Media WHERE Code = '{media.Code}';";
            
            return this.Database.ExecuteNonQuery(query);
        }
    }
}
