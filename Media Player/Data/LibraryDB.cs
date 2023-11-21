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

        public LinkedList<Library> GetAll()
        {
            LinkedList<Library> rerult = new LinkedList<Library>();

            this.Database.Connection.Open();

            string sql = $"SELECT * FROM Library WHERE Status = '{Status.Active}';";
            SQLiteCommand command = new SQLiteCommand(sql, this.Database.Connection);
            
            SQLiteDataReader dataReader = command.ExecuteReader();

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

        public int Create(Library library)
        {
            string query = $@"
                INSERT INTO Library(Code, Name, Status) 
                VALUES ('{library.Code}', '{library.Name}','{library.Status}');";

            return this.Database.ExecuteNonQuery(query);
        }

        public int Delete(Library library)
        {
            string query = $@"DELETE FROM Library WHERE Code = '{library.Code}';";

            return this.Database.ExecuteNonQuery(query);
        }
    }
}
