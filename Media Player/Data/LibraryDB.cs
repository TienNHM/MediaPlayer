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
    public class LibraryDB
    {
        public Database Database { get; set; }

        public LibraryDB()
        {
            this.Database = new Database();
        }

        /// <summary>
        /// Lấy tất cả các Library hiện có
        /// </summary>
        /// <returns></returns>
        public LinkedList<Library> GetAll()
        {
            LinkedList<Library> rerult = new LinkedList<Library>();

            // Mở connection đến database
            this.Database.Connection.Open();

            string sql = $"SELECT * FROM Library WHERE Status = '{Status.Active}';";
            SQLiteCommand command = new SQLiteCommand(sql, this.Database.Connection);
            
            // Thực thi sql để lấy dữ liệu
            SQLiteDataReader dataReader = command.ExecuteReader();

            // Đọc dữ liệu từ database
            while (dataReader.Read())
            {
                // Nếu mã code không NULL
                if (!dataReader.IsDBNull(1))
                {
                    Library library = new Library()
                    {
                        Id = dataReader.GetInt32(0),
                        Code = dataReader.GetString(1),
                        Name = dataReader.GetString(2),
                        Status = dataReader.GetString(3),
                    };
                    rerult.AddLast(library);
                }
            }
            dataReader.Close();

            // Đóng connection đến database
            this.Database.Connection.Close();

            return rerult;
        }

        /// <summary>
        /// Lấy danh sách các Library có chứa bài hát (dựa vào mediaCode)
        /// </summary>
        /// <param name="mediaCode"></param>
        /// <returns></returns>
        public LinkedList<Library> GetAllLibrariesByMediaCode(string mediaCode)
        {
            LinkedList<Library> rerult = new LinkedList<Library>();

            this.Database.Connection.Open();

            string sql = $@"
                SELECT DISTINCT Library.* 
                FROM Library INNER JOIN LibraryInfo ON LibraryInfo.LibraryCode = Library.Code
                WHERE LibraryInfo.MediaCode = '{mediaCode}' AND Library.Status = '{Status.Active}';";

            SQLiteCommand command = new SQLiteCommand(sql, this.Database.Connection);

            SQLiteDataReader dataReader = command.ExecuteReader();

            // Đọc dữ liệu từ database
            while (dataReader.Read())
            {
                if (!dataReader.IsDBNull(1))
                {
                    Library library = new Library()
                    {
                        Id = dataReader.GetInt32(0),
                        Code = dataReader.GetString(1),
                        Name = dataReader.GetString(2),
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
        /// Tạo mới 1 library và lưu vào database
        /// </summary>
        /// <param name="library"></param>
        /// <returns></returns>
        public int Create(Library library)
        {
            string query = $@"
                INSERT INTO Library(Code, Name, Status) 
                VALUES ('{library.Code}', '{library.Name}','{library.Status}');";

            return this.Database.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Xóa library khỏi database: Bắt buộc phải xóa tất cả bài hát khỏi library, trước khi có thể xóa được library
        /// </summary>
        /// <param name="library"></param>
        /// <returns></returns>
        public int Delete(Library library)
        {
            // Xóa tất cả bài hát thuộc library
            string queryLibraryInfo = $@"DELETE FROM LibraryInfo WHERE LibraryCode = '{library.Code}';";
            var re1 = this.Database.ExecuteNonQuery(queryLibraryInfo);

            // Xóa library
            string query = $@"DELETE FROM Library WHERE Code = '{library.Code}';";
            var re2 = this.Database.ExecuteNonQuery(query);

            return re1 * re2;
        }
    }
}
