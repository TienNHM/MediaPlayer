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

        public int Create(LibraryInfo libraryInfo)
        {
            string query = $@"
                INSERT INTO LibraryInfo(LibraryCode, MediaCode, Status) 
                VALUES ('{libraryInfo.LibraryCode}', '{libraryInfo.MediaCode}','{libraryInfo.Status}');";

            return this.Database.ExecuteNonQuery(query);
        }

        public int Delete(LibraryInfo libraryInfo)
        {
            string query = $@"DELETE FROM LibraryInfo WHERE Id = '{libraryInfo.Id}';";

            return this.Database.ExecuteNonQuery(query);
        }
    }
}
