using Media_Player.Constants;
using Media_Player.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Data
{
    public class LibraryInfoDB
    {
        public Database Database { get; set; }

        public LibraryInfoDB()
        {
            this.Database = new Database();
        }

        /// <summary>
        /// Lấy danh sách tất cả LibraryInfo
        /// </summary>
        /// <returns></returns>
        public LinkedList<LibraryInfo> GetAll()
        {
            LinkedList<LibraryInfo> rerult = new LinkedList<LibraryInfo>();

            this.Database.Connection.Open();

            string sql = $"SELECT * FROM Library WHERE Status = '{Status.Active}';";
            SQLiteCommand command = new SQLiteCommand(sql, this.Database.Connection);

            SQLiteDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (!dataReader.IsDBNull(1))
                {
                    LibraryInfo library = new LibraryInfo()
                    {
                        Id = dataReader.GetInt32(0),
                        LibraryCode = dataReader.GetString(1),
                        MediaCode = dataReader.GetString(2),
                        Status = dataReader.GetString(3),
                    };
                    rerult.AddLast(library);
                }
            }
            dataReader.Close();

            this.Database.Connection.Close();

            return rerult;
        }

        /// <summary>
        /// Tạo mới 1 record
        /// </summary>
        /// <param name="libraryInfo"></param>
        /// <returns></returns>
        public int Create(LibraryInfo libraryInfo)
        {
            string query = $@"
                INSERT INTO LibraryInfo(LibraryCode, MediaCode, Status) 
                VALUES ('{libraryInfo.LibraryCode}', '{libraryInfo.MediaCode}','{libraryInfo.Status}');";

            return this.Database.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Xóa bỏ record
        /// </summary>
        /// <param name="libraryInfo"></param>
        /// <returns></returns>
        public int Delete(LibraryInfo libraryInfo)
        {
            string query = $@"DELETE FROM LibraryInfo WHERE Id = '{libraryInfo.Id}';";

            return this.Database.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Loại bỏ bài hát khỏi danh sách phát
        /// </summary>
        /// <param name="libraryCode">Mã code của library có liên quan</param>
        /// <param name="mediaCode">Mã code của bài hát cần xóa</param>
        /// <returns></returns>
        public int RemoveMedia(string libraryCode, string mediaCode)
        {
            string query = $@"DELETE FROM LibraryInfo WHERE LibraryCode = '{libraryCode}' AND MediaCode = '{mediaCode}';";

            return this.Database.ExecuteNonQuery(query);
        }
    }
}
