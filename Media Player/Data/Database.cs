
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Data
{
    /// <summary>
    /// Class dùng để kết nối đến SQLite
    /// </summary>
    public class Database
    {
        /// <summary>
        /// ConnectionString đến file database
        /// </summary>
        public SQLiteConnection Connection { get; set; }
        public SQLiteDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Hàm khởi tạo (hàm dựng) mặc định
        /// </summary>
        public Database()
        {
            this.Connection = new SQLiteConnection(@"data source=Resources/database.db");
        }

        public Database(SQLiteConnection connection)
        {
            this.Connection = connection;
        }

        public Database(string connectionString)
        {
            this.Connection = new SQLiteConnection(connectionString);
        }

        /// <summary>
        /// Thực thi các câu lệnh Cập nhật, thêm, xóa, sửa
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            this.Connection.Open();

            SQLiteCommand command = new SQLiteCommand(sql, this.Connection);
            
            // execute non query
            int result = command.ExecuteNonQuery();

            this.Connection.Close();

            return result;
        }
    }
}
