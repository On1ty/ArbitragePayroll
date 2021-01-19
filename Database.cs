using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace UI_payroll
{
    class Database
    {
        public string ConnectionString { get; set; }


        string connection;
        private readonly string dbName = "Payroll.db";

        //Access Database

        public void GetConnection()
        {
            connection = @"Data Source=" + dbName + "; Version=3";
            ConnectionString = connection; 
        }

        //Creating a new Database
        public Database()
        {
            //Check if Database exist and if not, create a new one
            if (!File.Exists("./" + dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                GetConnection();

                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    using(SQLiteCommand command = new SQLiteCommand())
                    {
                        string query = @"CREATE TABLE ADMIN_LOGIN (" +
                                    "id INTEGER NOT NULL UNIQUE," +
                                    "adminname Text(50) NOT NULL UNIQUE," +
                                    "password Text(50) NOT NULL," +
                                    "PRIMARY KEY(id AUTOINCREMENT))";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.ExecuteNonQuery();
                        
                        query = @"INSERT INTO ADMIN_LOGIN (adminname, password) VALUES ('admin', 'admin')";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            else return;
        }
    }
}
