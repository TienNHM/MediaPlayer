
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player.Data
{
    public class Database
    {
        public SQLiteConnection Connection { get; set; }
        public SQLiteDataAdapter DataAdapter { get; set; }

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
